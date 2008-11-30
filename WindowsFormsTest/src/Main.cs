 /*
  * PortAudioSharp - PortAudio bindings for .NET
  * Copyright 2006-2007, Riccardo Gerosa, and individual contributors as indicated
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
using System.Reflection;
using System.Windows.Forms;

using PortAudioSharp;

namespace PortAudioSharpTest
{

	internal sealed class MainClass
	{
		[STAThread]
		private static void Main(string[] args)
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
			
			PortAudio.Pa_Initialize();
			
			Application.EnableVisualStyles();
			
			Application.Run(new ApiHostSelectionForm());
			
			PortAudio.Pa_Terminate();
		}
	}

}
