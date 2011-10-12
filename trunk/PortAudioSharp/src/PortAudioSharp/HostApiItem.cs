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
using System.Windows.Forms;

namespace PortAudioSharp
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
			
			public HostApiItem(PortAudio.PaHostApiInfo hostApiInfo, IUpdatableControl updatableControl) 
			{
				this.hostApiInfo = hostApiInfo;
				
				int deviceCount = PortAudio.Pa_GetDeviceCount();
				int selectedHostApiDeviceCount = 0;
				for (int i = 0; i < deviceCount; i++) {
					PortAudio.PaDeviceInfo paDeviceInfo = PortAudio.Pa_GetDeviceInfo(i);
					PortAudio.PaHostApiInfo paHostApi = PortAudio.Pa_GetHostApiInfo(paDeviceInfo.hostApi);
					if (paHostApi.type == hostApiInfo.type) { selectedHostApiDeviceCount++; }
				}
				
				if (selectedHostApiDeviceCount > 0) {
					switch(hostApiInfo.type) {
					case PortAudio.PaHostApiTypeId.paMME:
						hostApiDeviceControl = new MMEDeviceControl(hostApiInfo, updatableControl);
						break;
					case PortAudio.PaHostApiTypeId.paDirectSound:
						hostApiDeviceControl = new DirectSoundDeviceControl(hostApiInfo, updatableControl);
						break;
					case PortAudio.PaHostApiTypeId.paASIO:
						hostApiDeviceControl = new ASIODeviceControl(hostApiInfo, updatableControl);
						break;
					case PortAudio.PaHostApiTypeId.paALSA:
						hostApiDeviceControl = new ALSADeviceControl(hostApiInfo, updatableControl);
						break;
					}
				} else {
					hostApiDeviceControl = new NoDevicesDeviceControl(hostApiInfo, updatableControl);
				}
			}
			
			public override string ToString()
			{
				return hostApiInfo.name;
			}
		}
}
