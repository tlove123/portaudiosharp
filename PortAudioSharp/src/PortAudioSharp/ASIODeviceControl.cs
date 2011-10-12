 /*
  * PortAudioSharp - PortAudio bindings for .NET
  * Copyright 2006-2011 Riccardo Gerosa and individual contributors as indicated
  * by the @authors tag. See the copyright.txt in the distribution for a
  * full listing of individual contributors.
  *
  * Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
  * and associated documentation files (the "Software"), to deal in the Software without restriction, 
  * including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
  * and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, 
  * subject to the following conditions:
  *
  * The above copyright notice and this permission notice shall be included in all copies or substantial 
  * portions of the Software.
  *
  * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT 
  * NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
  * IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
  * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE 
  * SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
  */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PortAudioSharp
{
	/// <summary>
	/// Description of UserControl1.
	/// </summary>
	public partial class ASIODeviceControl : UserControl, IDeviceControl
	{
		private PortAudio.PaHostApiInfo paHostApiInfo;
		private IUpdatableControl updatableControl;
		
		public bool Valid { get { return true; } }
		public int BufferSize { get { return (int) bufferSizeComboBox.SelectedItem; } }
		
		public ASIODeviceControl(PortAudio.PaHostApiInfo paHostApiInfo, IUpdatableControl updatableControl)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.paHostApiInfo = paHostApiInfo;
			this.updatableControl = updatableControl;
		}
		
		void ASIODeviceControlLoad(object sender, EventArgs e)
		{
			int deviceCount = PortAudio.Pa_GetDeviceCount();
			Console.WriteLine("Device count: " + paHostApiInfo.deviceCount + " default input device: " + paHostApiInfo.defaultInputDevice);
			
			deviceComboBox.Items.Clear();
			for (int i = 0; i < deviceCount; i++) {
				PortAudio.PaDeviceInfo paDeviceInfo = PortAudio.Pa_GetDeviceInfo(i);
				PortAudio.PaHostApiInfo paHostApi = PortAudio.Pa_GetHostApiInfo(paDeviceInfo.hostApi);
				if (paHostApi.type == PortAudio.PaHostApiTypeId.paASIO) {
					Console.WriteLine("\n#" + i + "\n" + paDeviceInfo);
					if (paDeviceInfo.maxOutputChannels > 0) {
						deviceComboBox.Items.Add(new DeviceItem(i, paDeviceInfo));
						if (i == paHostApiInfo.defaultOutputDevice) { 
							deviceComboBox.SelectedIndex = deviceComboBox.Items.Count - 1;
						}
					}
				}
			}
			
			bufferSizeComboBox.Items.Clear();
			int bufferSize = 256;
			while (bufferSize < 44100 / 2) {
				bufferSizeComboBox.Items.Add(bufferSize);
				bufferSize *= 2;
			}
			bufferSizeComboBox.SelectedIndex = 2;
		}
		
		void DeviceSettingsButtonClick(object sender, EventArgs e)
		{
			DeviceItem deviceItem = (DeviceItem) deviceComboBox.Items[deviceComboBox.SelectedIndex];
			PortAudio.PaAsio_ShowControlPanel(deviceItem.DeviceIndex, new IntPtr(this.Handle.ToInt64()));
		}
		
		void BufferSizeComboBoxSelectionChangeCommitted(object sender, EventArgs e)
		{
			updatableControl.update();
		}
	}
}
