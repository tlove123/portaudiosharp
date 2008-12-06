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
