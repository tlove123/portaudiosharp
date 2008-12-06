/*
 * Creato da SharpDevelop.
 * Utente: Riccardo
 * Data: 06/12/2008
 * Ora: 20.28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace PortAudioSharp.PortAudioSharp
{

	public class HostApiItem 
		{
			private PortAudio.PaHostApiInfo hostApiInfo;
			private UserControl hostApiDeviceControl;
			
			public PortAudio.PaHostApiInfo HostApiInfo 
			{
				get { return hostApiInfo; }
			}
			
			public UserControl HostApiDeviceControl 
			{
				get { return hostApiDeviceControl; }
			}
			
			public HostApiItem(PortAudio.PaHostApiInfo hostApiInfo) 
			{
				this.hostApiInfo = hostApiInfo;
				switch(hostApiInfo.type) {
				case PortAudio.PaHostApiTypeId.paMME:
					hostApiDeviceControl = new MMEDeviceControl(hostApiInfo);
					break;
				case PortAudio.PaHostApiTypeId.paDirectSound:
					hostApiDeviceControl = new DirectSoundDeviceControl(hostApiInfo);
					break;
				case PortAudio.PaHostApiTypeId.paASIO:
					hostApiDeviceControl = new ASIODeviceControl(hostApiInfo);
					break;
				}
			}
			
			public override string ToString()
			{
				return hostApiInfo.name;
			}
		}
}
