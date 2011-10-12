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
	partial class AudioSettingsControl
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
			this.audioSettingsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.sampleRateLabel = new System.Windows.Forms.Label();
			this.driverTypeLabel = new System.Windows.Forms.Label();
			this.driverTypeComboBox = new System.Windows.Forms.ComboBox();
			this.sampleRateComboBox = new System.Windows.Forms.ComboBox();
			this.audioSettingsPanel = new System.Windows.Forms.Panel();
			this.latencyLabel = new System.Windows.Forms.Label();
			this.audioSettingsTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// audioSettingsTableLayoutPanel
			// 
			this.audioSettingsTableLayoutPanel.AutoSize = true;
			this.audioSettingsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.audioSettingsTableLayoutPanel.ColumnCount = 2;
			this.audioSettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.audioSettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.audioSettingsTableLayoutPanel.Controls.Add(this.sampleRateLabel, 0, 2);
			this.audioSettingsTableLayoutPanel.Controls.Add(this.driverTypeLabel, 0, 0);
			this.audioSettingsTableLayoutPanel.Controls.Add(this.driverTypeComboBox, 1, 0);
			this.audioSettingsTableLayoutPanel.Controls.Add(this.sampleRateComboBox, 1, 2);
			this.audioSettingsTableLayoutPanel.Controls.Add(this.audioSettingsPanel, 1, 1);
			this.audioSettingsTableLayoutPanel.Controls.Add(this.latencyLabel, 1, 3);
			this.audioSettingsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.audioSettingsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.audioSettingsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.audioSettingsTableLayoutPanel.Name = "audioSettingsTableLayoutPanel";
			this.audioSettingsTableLayoutPanel.RowCount = 4;
			this.audioSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
			this.audioSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 204F));
			this.audioSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
			this.audioSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.audioSettingsTableLayoutPanel.Size = new System.Drawing.Size(354, 319);
			this.audioSettingsTableLayoutPanel.TabIndex = 2;
			// 
			// sampleRateLabel
			// 
			this.sampleRateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.sampleRateLabel.AutoSize = true;
			this.sampleRateLabel.Location = new System.Drawing.Point(26, 262);
			this.sampleRateLabel.Name = "sampleRateLabel";
			this.sampleRateLabel.Size = new System.Drawing.Size(66, 13);
			this.sampleRateLabel.TabIndex = 3;
			this.sampleRateLabel.Text = "Sample rate:";
			// 
			// driverTypeLabel
			// 
			this.driverTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.driverTypeLabel.AutoSize = true;
			this.driverTypeLabel.Location = new System.Drawing.Point(3, 15);
			this.driverTypeLabel.Name = "driverTypeLabel";
			this.driverTypeLabel.Size = new System.Drawing.Size(89, 13);
			this.driverTypeLabel.TabIndex = 0;
			this.driverTypeLabel.Text = "Audio driver type:";
			// 
			// driverTypeComboBox
			// 
			this.driverTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.driverTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.driverTypeComboBox.FormattingEnabled = true;
			this.driverTypeComboBox.Location = new System.Drawing.Point(100, 11);
			this.driverTypeComboBox.Margin = new System.Windows.Forms.Padding(5);
			this.driverTypeComboBox.Name = "driverTypeComboBox";
			this.driverTypeComboBox.Size = new System.Drawing.Size(249, 21);
			this.driverTypeComboBox.TabIndex = 1;
			this.driverTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.DriverTypeComboBoxSelectedIndexChanged);
			// 
			// sampleRateComboBox
			// 
			this.sampleRateComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.sampleRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sampleRateComboBox.FormattingEnabled = true;
			this.sampleRateComboBox.Location = new System.Drawing.Point(100, 258);
			this.sampleRateComboBox.Margin = new System.Windows.Forms.Padding(5);
			this.sampleRateComboBox.Name = "sampleRateComboBox";
			this.sampleRateComboBox.Size = new System.Drawing.Size(249, 21);
			this.sampleRateComboBox.TabIndex = 4;
			this.sampleRateComboBox.SelectionChangeCommitted += new System.EventHandler(this.SampleRateComboBoxSelectionChangeCommitted);
			// 
			// audioSettingsPanel
			// 
			this.audioSettingsPanel.AutoSize = true;
			this.audioSettingsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.audioSettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.audioSettingsPanel.Location = new System.Drawing.Point(98, 46);
			this.audioSettingsPanel.Name = "audioSettingsPanel";
			this.audioSettingsPanel.Size = new System.Drawing.Size(253, 198);
			this.audioSettingsPanel.TabIndex = 5;
			// 
			// latencyLabel
			// 
			this.latencyLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.latencyLabel.AutoSize = true;
			this.latencyLabel.Location = new System.Drawing.Point(272, 298);
			this.latencyLabel.Name = "latencyLabel";
			this.latencyLabel.Size = new System.Drawing.Size(79, 13);
			this.latencyLabel.TabIndex = 6;
			this.latencyLabel.Text = "Latency: 10 ms";
			this.latencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// AudioSettingsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.audioSettingsTableLayoutPanel);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "AudioSettingsControl";
			this.Size = new System.Drawing.Size(354, 319);
			this.Load += new System.EventHandler(this.AudioSettingsControlLoad);
			this.audioSettingsTableLayoutPanel.ResumeLayout(false);
			this.audioSettingsTableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label latencyLabel;
		private System.Windows.Forms.Label sampleRateLabel;
		private System.Windows.Forms.Panel audioSettingsPanel;
		private System.Windows.Forms.TableLayoutPanel audioSettingsTableLayoutPanel;
		private System.Windows.Forms.ComboBox sampleRateComboBox;
		private System.Windows.Forms.ComboBox driverTypeComboBox;
		private System.Windows.Forms.Label driverTypeLabel;
	}
}
