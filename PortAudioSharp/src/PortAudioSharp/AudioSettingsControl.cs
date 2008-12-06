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
