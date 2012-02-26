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

namespace PortAudioSharp {

	/**
		<summary>
			A simplified high-level audio class
		</summary>
	*/
	public class Audio : IDisposable {
	
		private int inputChannels, outputChannels, frequency;
		private uint framesPerBuffer;
		private PortAudio.PaStreamCallbackDelegate paStreamCallback;
		private int hostApi;
		PortAudio.PaHostApiInfo apiInfo;
		PortAudio.PaDeviceInfo inputDeviceInfo, outputDeviceInfo;
		private IntPtr stream;
		private static bool loggingEnabled = false;
	 	private bool disposed = false;
	 	
	 	public static bool LoggingEnabled {
	 		get { return loggingEnabled; }
	 		set { loggingEnabled = value; }
	 	}
	 	
	 	public Audio(int inputChannels, int outputChannels, int frequency, uint framesPerBuffer,
	 		PortAudio.PaStreamCallbackDelegate paStreamCallback) {
	 		log("Initializing...");
	 		this.inputChannels = inputChannels;
	 		this.outputChannels = outputChannels;
	 		this.frequency = frequency;
	 		this.framesPerBuffer = framesPerBuffer;
	 		this.paStreamCallback = paStreamCallback;
	 		if (errorCheck("Initialize",PortAudio.Pa_Initialize())) {
	 			this.disposed = true; 
	 			// if Pa_Initialize() returns an error code, 
	 			// Pa_Terminate() should NOT be called.
	 			throw new Exception("Can't initialize audio");
	 		}
	 		int apiCount = PortAudio.Pa_GetHostApiCount();
			for (int i = 0; i < apiCount; i++) {
				PortAudio.PaHostApiInfo availableApiInfo = PortAudio.Pa_GetHostApiInfo(i);
				log("available API index: " + i + "\n" + availableApiInfo.ToString());
			}
	 		this.hostApi = apiSelect();
	 		log("selected Host API: " + this.hostApi);
	 		this.apiInfo = PortAudio.Pa_GetHostApiInfo(this.hostApi);
			this.inputDeviceInfo = PortAudio.Pa_GetDeviceInfo(apiInfo.defaultInputDevice);
			this.outputDeviceInfo = PortAudio.Pa_GetDeviceInfo(apiInfo.defaultOutputDevice);
			log("input device:\n" + inputDeviceInfo.ToString());
	 		log("output device:\n" + outputDeviceInfo.ToString());
	 	}
	 	
	 	public void Start() {
	 		log("Starting...");
	 		this.stream = streamOpen(this.apiInfo.defaultInputDevice, this.inputChannels,
				this.apiInfo.defaultOutputDevice,this.outputChannels,
				this.frequency,this.framesPerBuffer);
			log("Stream pointer: " + stream.ToInt32());
			streamStart(stream);
	 	}
	 	
	 	public void Stop() {
	 		log("Stopping...");
	 		streamStop(this.stream);
			streamClose(this.stream);
			this.stream = new IntPtr(0);
	 	}
			
	 	private void log(String logString) {
	 		if (loggingEnabled)  
	 			System.Console.WriteLine("PortAudio: " + logString);
	 			System.Console.WriteLine();
	 	} 
	 	
	 	private bool errorCheck(String action, PortAudio.PaError errorCode) {
	 		if (errorCode != PortAudio.PaError.paNoError) {
	 			log(action + " error: " + PortAudio.Pa_GetErrorText(errorCode));
	 			if (errorCode == PortAudio.PaError.paUnanticipatedHostError) {
	 				PortAudio.PaHostErrorInfo errorInfo = PortAudio.Pa_GetLastHostErrorInfo();
	 				log("- Host error API type: " + errorInfo.hostApiType);
	 				log("- Host error code: " + errorInfo.errorCode);
	 				log("- Host error text: " + errorInfo.errorText);
	 			}
	 			return true;
	 		} else {
	 			log(action + " OK");
	 			return false;
	 		}
	 	}
	 	
	 	private int apiSelect() {
			int selectedHostApi = PortAudio.Pa_GetDefaultHostApi();
			int apiCount = PortAudio.Pa_GetHostApiCount();
			for (int i = 0; i<apiCount; i++) {
				PortAudio.PaHostApiInfo apiInfo = PortAudio.Pa_GetHostApiInfo(i);
				if ((apiInfo.type == PortAudio.PaHostApiTypeId.paDirectSound)
				    || (apiInfo.type == PortAudio.PaHostApiTypeId.paALSA))
					selectedHostApi = i;
			}
			return selectedHostApi;
		}
		
	 	private IntPtr streamOpen(int inputDevice,int inputChannels,
                         int outputDevice,int outputChannels,
                         int sampleRate, uint framesPerBuffer) {
	 		IntPtr stream = new IntPtr();
	 		IntPtr data = new IntPtr(0);
            
	 		PortAudio.PaStreamParameters? inputParams;
            if (inputDevice == -1 || inputChannels <= 0) {
                inputParams = null;
            } else {
                PortAudio.PaStreamParameters inputParamsTemp = new PortAudio.PaStreamParameters();
                inputParamsTemp.channelCount = inputChannels;
                inputParamsTemp.device = inputDevice;
                inputParamsTemp.sampleFormat = PortAudio.PaSampleFormat.paFloat32;
                inputParamsTemp.suggestedLatency = this.inputDeviceInfo.defaultLowInputLatency;
                inputParams = inputParamsTemp;
            }
            PortAudio.PaStreamParameters? outputParams; 
            if (outputDevice == -1 || outputChannels <= 0) {
                outputParams = null;
            } else {
                PortAudio.PaStreamParameters outputParamsTemp = new PortAudio.PaStreamParameters();
	 		    outputParamsTemp.channelCount = outputChannels;
	 		    outputParamsTemp.device = outputDevice;
	 		    outputParamsTemp.sampleFormat = PortAudio.PaSampleFormat.paFloat32;
	 		    outputParamsTemp.suggestedLatency = this.outputDeviceInfo.defaultLowOutputLatency;
                outputParams = outputParamsTemp;
            }
	 		errorCheck("OpenDefaultStream",PortAudio.Pa_OpenStream(
			    out stream,
                ref inputParams,
                ref outputParams,
			    sampleRate,
			    framesPerBuffer,
			    PortAudio.PaStreamFlags.paNoFlag,
			    this.paStreamCallback,
			    data));     
			return stream;
		}
	 	
	 	/*
	 	private IntPtr streamOpen(int inputChannels,int outputChannels,
	 		int sampleRate, uint framesPerBuffer) {
	 		IntPtr stream = new IntPtr();
	 		IntPtr data = new IntPtr(0);
	 		errorCheck("OpenDefaultStream",PortAudio.Pa_OpenDefaultStream(
			    out stream,
			    inputChannels,
			    outputChannels,
			    (uint) PortAudio.PaSampleFormat.paFloat32,
			    sampleRate,
			    framesPerBuffer,
			    this.paStreamCallback,
			    data));     
			return stream;
		}
		*/
		
		private void streamClose(IntPtr stream) {
			errorCheck("CloseStream",PortAudio.Pa_CloseStream(stream));
		}
		
		private void streamStart(IntPtr stream) {
			errorCheck("StartStream",PortAudio.Pa_StartStream(stream));
		}
		
		private void streamStop(IntPtr stream) {
			errorCheck("StopStream",PortAudio.Pa_StopStream(stream));
		}
		
		/*
		private void streamWrite(IntPtr stream, float[] buffer) {
			errorCheck("WriteStream",PortAudio.Pa_WriteStream(
				stream,buffer,(uint)(buffer.Length/2)));
		}
		*/
   
        private void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                	// Dispose here any managed resources
                }
             
             	// Dispose here any unmanaged resources
                log("Terminating...");
	 			errorCheck("Terminate",PortAudio.Pa_Terminate());
            }
            this.disposed = true;         
        }
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        ~Audio() {
	 		Dispose(false);
	 	}
	}

}
