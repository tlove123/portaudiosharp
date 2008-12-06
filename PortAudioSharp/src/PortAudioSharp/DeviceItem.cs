/*
 * Creato da SharpDevelop.
 * Utente: Riccardo
 * Data: 06/12/2008
 * Ora: 20.18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PortAudioSharp.PortAudioSharp
{

	public class DeviceItem
	{
		private PortAudio.PaDeviceInfo deviceInfo;
		
		public PortAudio.PaDeviceInfo DeviceInfo 
		{
			get { return deviceInfo; }
		}
			
		public DeviceItem(PortAudio.PaDeviceInfo deviceInfo) 
		{
			this.deviceInfo = deviceInfo;
		}
		
		public override string ToString()
		{
			return deviceInfo.name;
		}
	}
	
}
