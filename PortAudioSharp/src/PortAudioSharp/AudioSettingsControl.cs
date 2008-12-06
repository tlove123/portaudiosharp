/*
 * Creato da SharpDevelop.
 * Utente: Riccardo
 * Data: 27/01/2008
 * Ora: 16.30
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
	/// Description of AudioSettingsControl.
	/// </summary>
	public partial class AudioSettingsControl : UserControl
	{
		public AudioSettingsControl()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void AudioSettingsControlLoad(object sender, EventArgs e)
		{
			driverTypeComboBox.Items.Clear();
			
			int hostApiCount = PortAudio.Pa_GetHostApiCount();
			for (int i = 0; i < hostApiCount; i++) {
				PortAudio.PaHostApiInfo hostApiInfo = PortAudio.Pa_GetHostApiInfo(i);
				if (hostApiInfo.type != PortAudio.PaHostApiTypeId.paInDevelopment) {
					driverTypeComboBox.Items.Add(new HostApiItem(hostApiInfo));
				}
			}
			
			driverTypeComboBox.SelectedIndex = PortAudio.Pa_GetDefaultHostApi();
		}
		
		void DriverTypeComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			HostApiItem selectedItem = (HostApiItem) driverTypeComboBox.SelectedItem;
			Console.Out.WriteLine(selectedItem.HostApiInfo.name);
			audioSettingsPanel.Controls.Clear();
			audioSettingsPanel.Controls.Add(selectedItem.HostApiDeviceControl);
		}
	
	}
}
