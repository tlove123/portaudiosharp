/*
 * Creato da SharpDevelop.
 * Utente: Riccardo
 * Data: 27/01/2008
 * Ora: 15.24
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
	/// Description of DirectSoundDeviceControl.
	/// </summary>
	public partial class DirectSoundDeviceControl : UserControl
	{
		private PortAudio.PaHostApiInfo paHostApiInfo;
		
		public DirectSoundDeviceControl(PortAudio.PaHostApiInfo paHostApiInfo)
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
		
	
		
		void DirectSoundDeviceControlLoad(object sender, EventArgs e)
		{
			int deviceCount = PortAudio.Pa_GetDeviceCount();
			Console.WriteLine("Device count: " + paHostApiInfo.deviceCount + " default input device: " + paHostApiInfo.defaultInputDevice);
			
			inputDeviceComboBox.Items.Clear();
			outputDeviceComboBox.Items.Clear();
			for (int i = 0; i < deviceCount; i++) {
				PortAudio.PaDeviceInfo paDeviceInfo = PortAudio.Pa_GetDeviceInfo(i);
				PortAudio.PaHostApiInfo paHostApi = PortAudio.Pa_GetHostApiInfo(paDeviceInfo.hostApi);
				if (paHostApi.type == PortAudio.PaHostApiTypeId.paDirectSound) {
					Console.WriteLine("\n#" + i + "\n" + paDeviceInfo);
					if (paDeviceInfo.maxInputChannels > 0) {
						inputDeviceComboBox.Items.Add(new DeviceItem(paDeviceInfo));
						if (i == paHostApiInfo.defaultInputDevice) { 
							inputDeviceComboBox.SelectedIndex = inputDeviceComboBox.Items.Count - 1;
						}
					}
					if (paDeviceInfo.maxOutputChannels > 0) {
						outputDeviceComboBox.Items.Add(new DeviceItem(paDeviceInfo));
						if (i == paHostApiInfo.defaultOutputDevice) { 
							outputDeviceComboBox.SelectedIndex = outputDeviceComboBox.Items.Count - 1;
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
			bufferSizeComboBox.SelectedIndex =3;
		}
	}
}
