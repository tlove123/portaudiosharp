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
using System.Reflection;

using PortAudioSharp;

namespace PortAudioSharpTest
{

	class MainClass
	{
		[STAThread]
		public static void Main(string[] args)
		{
			Console.WriteLine("PortAudioSharp Test");
			Console.WriteLine("*******************");
			Console.WriteLine();
			Console.WriteLine("PortAudioSharpTest version: "
				+ Assembly.GetExecutingAssembly().GetName().Version.ToString());
			Console.WriteLine("PortAudioSharp version: "
				+ Assembly.GetAssembly(typeof(PortAudio)).GetName().Version.ToString());
			Console.WriteLine("PortAudio version: " 
				+ PortAudio.Pa_GetVersionText() 
				+ " (" + PortAudio.Pa_GetVersion() + ")");
			Console.WriteLine(); 
			
			new PortAudioTest().Run();
		}
	}

}
