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
	/// Description of AudioSettingsControl.
	/// </summary>
	public partial class AudioSettingsControl : UserControl, IDeviceControl, IUpdatableControl
	{
		private IUpdatableControl updatableControl;
		private IDeviceControl deviceControl;
		
		public bool Valid { 
			get {
				IDeviceControl deviceControl = this.deviceControl;
				if (deviceControl != null) {
					return deviceControl.Valid;
				} else {
					return false;
				}
			} 
		}
		public int BufferSize { 
			get {
				IDeviceControl deviceControl = this.deviceControl;
				if (deviceControl != null) {
					return deviceControl.BufferSize;
				} else {
					return 0;
				}
			} 
		}
		
		public AudioSettingsControl(IUpdatableControl updatableControl)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.updatableControl = updatableControl;
			this.deviceControl = null;
		}
		
		void AudioSettingsControlLoad(object sender, EventArgs e)
		{
			driverTypeComboBox.Items.Clear();
			int hostApiCount = PortAudio.Pa_GetHostApiCount();
			for (int i = 0; i < hostApiCount; i++) {
				PortAudio.PaHostApiInfo hostApiInfo = PortAudio.Pa_GetHostApiInfo(i);
				if (hostApiInfo.type != PortAudio.PaHostApiTypeId.paInDevelopment) {
					driverTypeComboBox.Items.Add(new HostApiItem(hostApiInfo, this));
				}
			}
			driverTypeComboBox.SelectedIndex = PortAudio.Pa_GetDefaultHostApi();
			
			sampleRateComboBox.Items.Clear();
			sampleRateComboBox.Items.Add(192000);
			sampleRateComboBox.Items.Add(176400);
			sampleRateComboBox.Items.Add(96000);
			sampleRateComboBox.Items.Add(88200);
			sampleRateComboBox.Items.Add(48000);
			sampleRateComboBox.Items.Add(44100);
			sampleRateComboBox.Items.Add(38400);
			sampleRateComboBox.Items.Add(37800);
			sampleRateComboBox.Items.Add(32000);
			sampleRateComboBox.Items.Add(24000);
			sampleRateComboBox.Items.Add(22050);
			sampleRateComboBox.Items.Add(19200);
			sampleRateComboBox.Items.Add(18900);
			sampleRateComboBox.Items.Add(16000);
			sampleRateComboBox.Items.Add(12000);
			sampleRateComboBox.Items.Add(11025);
			sampleRateComboBox.Items.Add(9600);
			sampleRateComboBox.Items.Add(8000);
			sampleRateComboBox.SelectedIndex = 5;
			
			update();
		}
		
		void DriverTypeComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			HostApiItem selectedItem = (HostApiItem) driverTypeComboBox.SelectedItem;
			audioSettingsPanel.Controls.Clear();
			this.deviceControl = (IDeviceControl) selectedItem.HostApiDeviceControl;
			audioSettingsPanel.Controls.Add(selectedItem.HostApiDeviceControl);
			update();
		}
		
		public void update() {
			object sampleRateComboBoxItem = sampleRateComboBox.SelectedItem;
			if (sampleRateComboBoxItem != null && deviceControl != null) {
				int bufferSize = deviceControl.BufferSize;
				int sampleRate = (int) sampleRateComboBoxItem;
				this.latencyLabel.Text = "Latency: " + (bufferSize * 1000 / sampleRate) + " ms";
			}
			updatableControl.update();
		}

		
		void SampleRateComboBoxSelectionChangeCommitted(object sender, EventArgs e)
		{
			update();
		}
	}
}
