/*
 * Creato da SharpDevelop.
 * Utente: Riccardo
 * Data: 27/01/2008
 * Ora: 14.55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
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
						deviceComboBox.Items.Add(new DeviceItem(paDeviceInfo));
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
			bufferSizeComboBox.SelectedIndex =2;
		}
	}
}
