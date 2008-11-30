/*
 * Creato da SharpDevelop.
 * Utente: Riccardo
 * Data: 27/01/2008
 * Ora: 16.30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PortAudioSharp.PortAudioSharp
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
			this.samleRateLabel = new System.Windows.Forms.Label();
			this.driverTypeLabel = new System.Windows.Forms.Label();
			this.driverTypeComboBox = new System.Windows.Forms.ComboBox();
			this.sampleRateComboBox = new System.Windows.Forms.ComboBox();
			this.audioSettingsPanel = new System.Windows.Forms.Panel();
			this.audioSettingsTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// audioSettingsTableLayoutPanel
			// 
			this.audioSettingsTableLayoutPanel.AutoSize = true;
			this.audioSettingsTableLayoutPanel.ColumnCount = 2;
			this.audioSettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.audioSettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 255F));
			this.audioSettingsTableLayoutPanel.Controls.Add(this.samleRateLabel, 0, 2);
			this.audioSettingsTableLayoutPanel.Controls.Add(this.driverTypeLabel, 0, 0);
			this.audioSettingsTableLayoutPanel.Controls.Add(this.driverTypeComboBox, 1, 0);
			this.audioSettingsTableLayoutPanel.Controls.Add(this.sampleRateComboBox, 1, 2);
			this.audioSettingsTableLayoutPanel.Controls.Add(this.audioSettingsPanel, 1, 1);
			this.audioSettingsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.audioSettingsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.audioSettingsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.audioSettingsTableLayoutPanel.Name = "audioSettingsTableLayoutPanel";
			this.audioSettingsTableLayoutPanel.RowCount = 3;
			this.audioSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.audioSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
			this.audioSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.audioSettingsTableLayoutPanel.Size = new System.Drawing.Size(370, 350);
			this.audioSettingsTableLayoutPanel.TabIndex = 2;
			// 
			// samleRateLabel
			// 
			this.samleRateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.samleRateLabel.AutoSize = true;
			this.samleRateLabel.Location = new System.Drawing.Point(26, 326);
			this.samleRateLabel.Name = "samleRateLabel";
			this.samleRateLabel.Size = new System.Drawing.Size(66, 13);
			this.samleRateLabel.TabIndex = 3;
			this.samleRateLabel.Text = "Sample rate:";
			// 
			// driverTypeLabel
			// 
			this.driverTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.driverTypeLabel.AutoSize = true;
			this.driverTypeLabel.Location = new System.Drawing.Point(3, 11);
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
			this.driverTypeComboBox.Location = new System.Drawing.Point(98, 7);
			this.driverTypeComboBox.Name = "driverTypeComboBox";
			this.driverTypeComboBox.Size = new System.Drawing.Size(269, 21);
			this.driverTypeComboBox.TabIndex = 1;
			this.driverTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.DriverTypeComboBoxSelectedIndexChanged);
			// 
			// sampleRateComboBox
			// 
			this.sampleRateComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.sampleRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sampleRateComboBox.FormattingEnabled = true;
			this.sampleRateComboBox.Location = new System.Drawing.Point(98, 322);
			this.sampleRateComboBox.Name = "sampleRateComboBox";
			this.sampleRateComboBox.Size = new System.Drawing.Size(269, 21);
			this.sampleRateComboBox.TabIndex = 4;
			// 
			// audioSettingsPanel
			// 
			this.audioSettingsPanel.AutoSize = true;
			this.audioSettingsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.audioSettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.audioSettingsPanel.Location = new System.Drawing.Point(98, 38);
			this.audioSettingsPanel.Name = "audioSettingsPanel";
			this.audioSettingsPanel.Size = new System.Drawing.Size(269, 274);
			this.audioSettingsPanel.TabIndex = 5;
			// 
			// AudioSettingsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.audioSettingsTableLayoutPanel);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "AudioSettingsControl";
			this.Size = new System.Drawing.Size(370, 350);
			this.Load += new System.EventHandler(this.AudioSettingsControlLoad);
			this.audioSettingsTableLayoutPanel.ResumeLayout(false);
			this.audioSettingsTableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Panel audioSettingsPanel;
		private System.Windows.Forms.TableLayoutPanel audioSettingsTableLayoutPanel;
		private System.Windows.Forms.ComboBox sampleRateComboBox;
		private System.Windows.Forms.ComboBox driverTypeComboBox;
		private System.Windows.Forms.Label driverTypeLabel;
		private System.Windows.Forms.Label samleRateLabel;
	}
}
