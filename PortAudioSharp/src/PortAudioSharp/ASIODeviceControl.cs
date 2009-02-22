 /*
  * PortAudioSharp - PortAudio bindings for .NET
  * Copyright 2006, 2007, 2008 Riccardo Gerosa and individual contributors as indicated
  * by the @authors tag. See the copyright.txt in the distribution for a
  * full listing of individual contributors.
  *
  * This is free software; you can redistribute it and/or modify it
  * under the terms of the GNU Lesser General Public License as
  * published by the Free Software Foundation; either version 2.1 of
  * the License, or (at your option) any later version.
  *
  * This software is distributed in the hope that it will be useful,
  * but WITHOUT ANY WARRANTY; without even the implied warranty of
  * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
  * Lesser General Public License for more details.
  *
  * You should have received a copy of the GNU Lesser General Public
  * License along with this software; if not, write to the Free
  * Software Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA
  * 02110-1301 USA, or see the FSF site: http://www.fsf.org.
  */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PortAudioSharp.PortAudioSharp
{
	/// <summary>
	/// Description of UserControl1.
	/// </summary>
	public partial class ASIODeviceControl : UserControl
	{
		private PortAudio.PaHostApiInfo paHostApiInfo;
		
		public ASIODeviceControl(PortAudio.PaHostApiInfo paHostApiInfo)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.paHostApiInfo = paHostApiInfo;
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
	}
}
