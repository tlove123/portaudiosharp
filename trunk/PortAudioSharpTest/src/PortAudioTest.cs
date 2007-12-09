 /*
  * PortAudioSharp - PortAudio bindings for .NET
  * Copyright 2006, Riccardo Gerosa, and individual contributors as indicated
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
using System.Runtime.InteropServices;

using PortAudioSharp;

namespace PortAudioSharpTest
{
	
	public class PortAudioTest
	{
	 	private float[] callbackBuffer = new float[512];
	 	private int callbackPos = 0;
	 	
	 	public PortAudioTest()
		{ }
	 
	 	public PortAudio.PaStreamCallbackResult myPaStreamCallback(
	 		IntPtr input,
	 		IntPtr output,
	 		uint frameCount, 
	 		ref PortAudio.PaStreamCallbackTimeInfo timeInfo,
	 		PortAudio.PaStreamCallbackFlags statusFlags,
	 		IntPtr userData)
	 	{
	 		try {
	 			// log("Callback called");
		 		// log("time: " + timeInfo.currentTime 
		 		// 		+ " " + timeInfo.inputBufferAdcTime
		 		//		+ " " + timeInfo.outputBufferDacTime);
		 		//	log("statusFlags: "+statusFlags);
		 		
		 		if (callbackBuffer.Length < frameCount*2) 
		 			callbackBuffer = new float[frameCount*2];
		 	
		 		for (int j = 0; j < frameCount*2; j++)
					callbackBuffer[j] = (float) Math.Sin((double)(callbackPos++)/20.0);
				
				Marshal.Copy(callbackBuffer, 0, output, (int)frameCount*2);
				
	 		} catch (Exception e) { 
	 			Console.WriteLine(e.ToString());
	 		}
	 		 
	 		return PortAudio.PaStreamCallbackResult.paContinue;
	 	}
		
		public void Run() {
			Audio audio = null;
			
			try {
			
				Audio.LoggingEnabled = true;
				audio = new Audio(2,44100,2048,
					new PortAudio.PaStreamCallbackDelegate(myPaStreamCallback));
				
				audio.Start();
				
				System.Threading.Thread.Sleep(3000);

				audio.Stop();
				
			} catch(Exception e) {
				Console.WriteLine(e.ToString());
			} finally {
				if (audio != null) audio.Dispose();
			}
		}
	}
	
}
