/*
 * Creato da SharpDevelop.
 * Utente: Riccardo
 * Data: 27/01/2008
 * Ora: 14.55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PortAudioSharp.PortAudioSharp
{
	partial class ASIODeviceControl
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
			this.asioGroupBox = new System.Windows.Forms.GroupBox();
			this.asioTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.deviceSettingsButton = new System.Windows.Forms.Button();
			this.deviceComboBox = new System.Windows.Forms.ComboBox();
			this.bufferComboBox = new System.Windows.Forms.ComboBox();
			this.deviceLabel = new System.Windows.Forms.Label();
			this.bufferLabel = new System.Windows.Forms.Label();
			this.asioGroupBox.SuspendLayout();
			this.asioTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// asioGroupBox
			// 
			this.asioGroupBox.Controls.Add(this.asioTableLayoutPanel);
			this.asioGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.asioGroupBox.Location = new System.Drawing.Point(0, 0);
			this.asioGroupBox.Name = "asioGroupBox";
			this.asioGroupBox.Size = new System.Drawing.Size(250, 166);
			this.asioGroupBox.TabIndex = 0;
			this.asioGroupBox.TabStop = false;
			this.asioGroupBox.Text = "ASIO settings";
			// 
			// asioTableLayoutPanel
			// 
			this.asioTableLayoutPanel.ColumnCount = 3;
			this.asioTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.asioTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.asioTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.asioTableLayoutPanel.Controls.Add(this.deviceSettingsButton, 1, 5);
			this.asioTableLayoutPanel.Controls.Add(this.deviceComboBox, 1, 1);
			this.asioTableLayoutPanel.Controls.Add(this.bufferComboBox, 1, 3);
			this.asioTableLayoutPanel.Controls.Add(this.deviceLabel, 1, 0);
			this.asioTableLayoutPanel.Controls.Add(this.bufferLabel, 1, 2);
			this.asioTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.asioTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
			this.asioTableLayoutPanel.Name = "asioTableLayoutPanel";
			this.asioTableLayoutPanel.RowCount = 7;
			this.asioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.asioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.asioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.asioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.asioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
			this.asioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.asioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
			this.asioTableLayoutPanel.Size = new System.Drawing.Size(244, 147);
			this.asioTableLayoutPanel.TabIndex = 0;
			// 
			// deviceSettingsButton
			// 
			this.deviceSettingsButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.deviceSettingsButton.Location = new System.Drawing.Point(108, 116);
			this.deviceSettingsButton.Name = "deviceSettingsButton";
			this.deviceSettingsButton.Size = new System.Drawing.Size(118, 21);
			this.deviceSettingsButton.TabIndex = 0;
			this.deviceSettingsButton.Text = "Device settings...";
			this.deviceSettingsButton.UseVisualStyleBackColor = true;
			// 
			// deviceComboBox
			// 
			this.deviceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.deviceComboBox.FormattingEnabled = true;
			this.deviceComboBox.Location = new System.Drawing.Point(18, 30);
			this.deviceComboBox.Name = "deviceComboBox";
			this.deviceComboBox.Size = new System.Drawing.Size(208, 21);
			this.deviceComboBox.TabIndex = 1;
			// 
			// bufferComboBox
			// 
			this.bufferComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.bufferComboBox.FormattingEnabled = true;
			this.bufferComboBox.Location = new System.Drawing.Point(18, 84);
			this.bufferComboBox.Name = "bufferComboBox";
			this.bufferComboBox.Size = new System.Drawing.Size(208, 21);
			this.bufferComboBox.TabIndex = 2;
			// 
			// deviceLabel
			// 
			this.deviceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.deviceLabel.Location = new System.Drawing.Point(18, 9);
			this.deviceLabel.Name = "deviceLabel";
			this.deviceLabel.Size = new System.Drawing.Size(208, 18);
			this.deviceLabel.TabIndex = 3;
			this.deviceLabel.Text = "Device:";
			// 
			// bufferLabel
			// 
			this.bufferLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.bufferLabel.Location = new System.Drawing.Point(18, 63);
			this.bufferLabel.Name = "bufferLabel";
			this.bufferLabel.Size = new System.Drawing.Size(208, 18);
			this.bufferLabel.TabIndex = 4;
			this.bufferLabel.Text = "Buffer size (samples):";
			// 
			// ASIODeviceControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.asioGroupBox);
			this.Name = "ASIODeviceControl";
			this.Size = new System.Drawing.Size(250, 166);
			this.asioGroupBox.ResumeLayout(false);
			this.asioTableLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label bufferLabel;
		private System.Windows.Forms.Label deviceLabel;
		private System.Windows.Forms.ComboBox bufferComboBox;
		private System.Windows.Forms.ComboBox deviceComboBox;
		private System.Windows.Forms.Button deviceSettingsButton;
		private System.Windows.Forms.TableLayoutPanel asioTableLayoutPanel;
		private System.Windows.Forms.GroupBox asioGroupBox;
	}
}
