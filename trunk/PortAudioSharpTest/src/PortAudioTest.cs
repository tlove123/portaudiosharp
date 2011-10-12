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
		 		// log("statusFlags: "+statusFlags);
		 		
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
				audio = new Audio(1, 2, 44100, 2048,
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
