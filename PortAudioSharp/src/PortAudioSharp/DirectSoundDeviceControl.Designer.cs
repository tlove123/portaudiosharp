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

namespace PortAudioSharp
{
	partial class DirectSoundDeviceControl
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.settingsGroupBox = new System.Windows.Forms.GroupBox();
			this.inputTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.inputDeviceComboBox = new System.Windows.Forms.ComboBox();
			this.outputDeviceComboBox = new System.Windows.Forms.ComboBox();
			this.inputDeviceLabel = new System.Windows.Forms.Label();
			this.outputDeviceLabel = new System.Windows.Forms.Label();
			this.bufferSizeComboBox = new System.Windows.Forms.ComboBox();
			this.bufferSizeLabel = new System.Windows.Forms.Label();
			this.settingsGroupBox.SuspendLayout();
			this.inputTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// settingsGroupBox
			// 
			this.settingsGroupBox.AutoSize = true;
			this.settingsGroupBox.Controls.Add(this.inputTableLayoutPanel);
			this.settingsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.settingsGroupBox.Location = new System.Drawing.Point(0, 0);
			this.settingsGroupBox.Name = "settingsGroupBox";
			this.settingsGroupBox.Size = new System.Drawing.Size(250, 195);
			this.settingsGroupBox.TabIndex = 2;
			this.settingsGroupBox.TabStop = false;
			this.settingsGroupBox.Text = "DirectSound settings";
			// 
			// inputTableLayoutPanel
			// 
			this.inputTableLayoutPanel.ColumnCount = 3;
			this.inputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.inputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.inputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.inputTableLayoutPanel.Controls.Add(this.inputDeviceComboBox, 1, 1);
			this.inputTableLayoutPanel.Controls.Add(this.outputDeviceComboBox, 1, 3);
			this.inputTableLayoutPanel.Controls.Add(this.inputDeviceLabel, 1, 0);
			this.inputTableLayoutPanel.Controls.Add(this.outputDeviceLabel, 1, 2);
			this.inputTableLayoutPanel.Controls.Add(this.bufferSizeComboBox, 1, 5);
			this.inputTableLayoutPanel.Controls.Add(this.bufferSizeLabel, 1, 4);
			this.inputTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
			this.inputTableLayoutPanel.Name = "inputTableLayoutPanel";
			this.inputTableLayoutPanel.RowCount = 7;
			this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
			this.inputTableLayoutPanel.Size = new System.Drawing.Size(244, 176);
			this.inputTableLayoutPanel.TabIndex = 0;
			// 
			// inputDeviceComboBox
			// 
			this.inputDeviceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.inputDeviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inputDeviceComboBox.FormattingEnabled = true;
			this.inputDeviceComboBox.Location = new System.Drawing.Point(18, 29);
			this.inputDeviceComboBox.Name = "inputDeviceComboBox";
			this.inputDeviceComboBox.Size = new System.Drawing.Size(208, 21);
			this.inputDeviceComboBox.TabIndex = 1;
			// 
			// outputDeviceComboBox
			// 
			this.outputDeviceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.outputDeviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.outputDeviceComboBox.FormattingEnabled = true;
			this.outputDeviceComboBox.Location = new System.Drawing.Point(18, 81);
			this.outputDeviceComboBox.Name = "outputDeviceComboBox";
			this.outputDeviceComboBox.Size = new System.Drawing.Size(208, 21);
			this.outputDeviceComboBox.TabIndex = 2;
			// 
			// inputDeviceLabel
			// 
			this.inputDeviceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.inputDeviceLabel.Location = new System.Drawing.Point(18, 8);
			this.inputDeviceLabel.Name = "inputDeviceLabel";
			this.inputDeviceLabel.Size = new System.Drawing.Size(208, 18);
			this.inputDeviceLabel.TabIndex = 3;
			this.inputDeviceLabel.Text = "Input device:";
			// 
			// outputDeviceLabel
			// 
			this.outputDeviceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.outputDeviceLabel.Location = new System.Drawing.Point(18, 60);
			this.outputDeviceLabel.Name = "outputDeviceLabel";
			this.outputDeviceLabel.Size = new System.Drawing.Size(208, 18);
			this.outputDeviceLabel.TabIndex = 4;
			this.outputDeviceLabel.Text = "Output device:";
			// 
			// bufferSizeComboBox
			// 
			this.bufferSizeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.bufferSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.bufferSizeComboBox.FormattingEnabled = true;
			this.bufferSizeComboBox.Location = new System.Drawing.Point(18, 133);
			this.bufferSizeComboBox.Name = "bufferSizeComboBox";
			this.bufferSizeComboBox.Size = new System.Drawing.Size(208, 21);
			this.bufferSizeComboBox.TabIndex = 5;
			this.bufferSizeComboBox.SelectionChangeCommitted += new System.EventHandler(this.BufferSizeComboBoxSelectionChangeCommitted);
			// 
			// bufferSizeLabel
			// 
			this.bufferSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.bufferSizeLabel.Location = new System.Drawing.Point(18, 112);
			this.bufferSizeLabel.Name = "bufferSizeLabel";
			this.bufferSizeLabel.Size = new System.Drawing.Size(208, 18);
			this.bufferSizeLabel.TabIndex = 6;
			this.bufferSizeLabel.Text = "Buffer size (samples):";
			// 
			// DirectSoundDeviceControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.settingsGroupBox);
			this.Name = "DirectSoundDeviceControl";
			this.Size = new System.Drawing.Size(250, 195);
			this.Load += new System.EventHandler(this.DirectSoundDeviceControlLoad);
			this.settingsGroupBox.ResumeLayout(false);
			this.inputTableLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.GroupBox settingsGroupBox;
		private System.Windows.Forms.Label bufferSizeLabel;
		private System.Windows.Forms.ComboBox bufferSizeComboBox;
		private System.Windows.Forms.ComboBox outputDeviceComboBox;
		private System.Windows.Forms.Label outputDeviceLabel;
		private System.Windows.Forms.Label inputDeviceLabel;
		private System.Windows.Forms.ComboBox inputDeviceComboBox;
		private System.Windows.Forms.TableLayoutPanel inputTableLayoutPanel;
	}
}
