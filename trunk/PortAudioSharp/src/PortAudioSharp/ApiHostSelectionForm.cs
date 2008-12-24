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
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace PortAudioSharp
{
	public partial class ApiHostSelectionForm : Form
	{
		/**
		 * <...>
		 *   <ApiHost id="0" name="MME" sampleRate="44100">
		 *     <InputDevice id="2" name="Bla bla" />
		 *     <OutputDevice id="4" name="Ble ble" />
		 *     <Buffer size="512" />
		 *   </ApiHost>
		 * </...>
		 */
		private XmlElement apiHostConfigElement;
		
		public XmlElement ApiHostConfigElement {
			set { apiHostConfigElement = value; }
			get { return apiHostConfigElement; }
		}
			
		public ApiHostSelectionForm()
		{
			apiHostConfigElement = null;
			InitializeComponent();
		}
		
	}
}
