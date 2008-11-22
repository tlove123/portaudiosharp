/*
 * Creato da SharpDevelop.
 * Utente: Riccardo
 * Data: 27/01/2008
 * Ora: 15.24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PortAudioSharp.PortAudioSharp
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
			this.dsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.inputGroupBox = new System.Windows.Forms.GroupBox();
			this.inputTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.inputDeviceComboBox = new System.Windows.Forms.ComboBox();
			this.inputBufferComboBox = new System.Windows.Forms.ComboBox();
			this.inputDeviceLabel = new System.Windows.Forms.Label();
			this.inputBufferLabel = new System.Windows.Forms.Label();
			this.outputGroupBox = new System.Windows.Forms.GroupBox();
			this.outputTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.outputDeviceComboBox = new System.Windows.Forms.ComboBox();
			this.outputBufferComboBox = new System.Windows.Forms.ComboBox();
			this.outputDeviceLabel = new System.Windows.Forms.Label();
			this.outputBufferLabel = new System.Windows.Forms.Label();
			this.dsTableLayoutPanel.SuspendLayout();
			this.inputGroupBox.SuspendLayout();
			this.inputTableLayoutPanel.SuspendLayout();
			this.outputGroupBox.SuspendLayout();
			this.outputTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// dsTableLayoutPanel
			// 
			this.dsTableLayoutPanel.ColumnCount = 1;
			this.dsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.dsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.dsTableLayoutPanel.Controls.Add(this.outputGroupBox, 0, 1);
			this.dsTableLayoutPanel.Controls.Add(this.inputGroupBox, 0, 0);
			this.dsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.dsTableLayoutPanel.Name = "dsTableLayoutPanel";
			this.dsTableLayoutPanel.RowCount = 2;
			this.dsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.dsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.dsTableLayoutPanel.Size = new System.Drawing.Size(250, 270);
			this.dsTableLayoutPanel.TabIndex = 0;
			// 
			// inputGroupBox
			// 
			this.inputGroupBox.Controls.Add(this.inputTableLayoutPanel);
			this.inputGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputGroupBox.Location = new System.Drawing.Point(3, 3);
			this.inputGroupBox.Name = "inputGroupBox";
			this.inputGroupBox.Size = new System.Drawing.Size(244, 129);
			this.inputGroupBox.TabIndex = 1;
			this.inputGroupBox.TabStop = false;
			this.inputGroupBox.Text = "DirectSound input settings";
			// 
			// inputTableLayoutPanel
			// 
			this.inputTableLayoutPanel.ColumnCount = 3;
			this.inputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.inputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.inputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.inputTableLayoutPanel.Controls.Add(this.inputDeviceComboBox, 1, 1);
			this.inputTableLayoutPanel.Controls.Add(this.inputBufferComboBox, 1, 3);
			this.inputTableLayoutPanel.Controls.Add(this.inputDeviceLabel, 1, 0);
			this.inputTableLayoutPanel.Controls.Add(this.inputBufferLabel, 1, 2);
			this.inputTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
			this.inputTableLayoutPanel.Name = "inputTableLayoutPanel";
			this.inputTableLayoutPanel.RowCount = 5;
			this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
			this.inputTableLayoutPanel.Size = new System.Drawing.Size(238, 110);
			this.inputTableLayoutPanel.TabIndex = 0;
			// 
			// inputDeviceComboBox
			// 
			this.inputDeviceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.inputDeviceComboBox.FormattingEnabled = true;
			this.inputDeviceComboBox.Location = new System.Drawing.Point(18, 29);
			this.inputDeviceComboBox.Name = "inputDeviceComboBox";
			this.inputDeviceComboBox.Size = new System.Drawing.Size(202, 21);
			this.inputDeviceComboBox.TabIndex = 1;
			// 
			// inputBufferComboBox
			// 
			this.inputBufferComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.inputBufferComboBox.FormattingEnabled = true;
			this.inputBufferComboBox.Location = new System.Drawing.Point(18, 81);
			this.inputBufferComboBox.Name = "inputBufferComboBox";
			this.inputBufferComboBox.Size = new System.Drawing.Size(202, 21);
			this.inputBufferComboBox.TabIndex = 2;
			// 
			// inputDeviceLabel
			// 
			this.inputDeviceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.inputDeviceLabel.Location = new System.Drawing.Point(18, 8);
			this.inputDeviceLabel.Name = "inputDeviceLabel";
			this.inputDeviceLabel.Size = new System.Drawing.Size(202, 18);
			this.inputDeviceLabel.TabIndex = 3;
			this.inputDeviceLabel.Text = "Device:";
			// 
			// inputBufferLabel
			// 
			this.inputBufferLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.inputBufferLabel.Location = new System.Drawing.Point(18, 60);
			this.inputBufferLabel.Name = "inputBufferLabel";
			this.inputBufferLabel.Size = new System.Drawing.Size(202, 18);
			this.inputBufferLabel.TabIndex = 4;
			this.inputBufferLabel.Text = "Buffer size (samples):";
			// 
			// outputGroupBox
			// 
			this.outputGroupBox.Controls.Add(this.outputTableLayoutPanel);
			this.outputGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outputGroupBox.Location = new System.Drawing.Point(3, 138);
			this.outputGroupBox.Name = "outputGroupBox";
			this.outputGroupBox.Size = new System.Drawing.Size(244, 129);
			this.outputGroupBox.TabIndex = 2;
			this.outputGroupBox.TabStop = false;
			this.outputGroupBox.Text = "DirectSound output settings";
			// 
			// outputTableLayoutPanel
			// 
			this.outputTableLayoutPanel.ColumnCount = 3;
			this.outputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.outputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.outputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.outputTableLayoutPanel.Controls.Add(this.outputDeviceComboBox, 1, 1);
			this.outputTableLayoutPanel.Controls.Add(this.outputBufferComboBox, 1, 3);
			this.outputTableLayoutPanel.Controls.Add(this.outputDeviceLabel, 1, 0);
			this.outputTableLayoutPanel.Controls.Add(this.outputBufferLabel, 1, 2);
			this.outputTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outputTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
			this.outputTableLayoutPanel.Name = "outputTableLayoutPanel";
			this.outputTableLayoutPanel.RowCount = 5;
			this.outputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.outputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.outputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.outputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.outputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
			this.outputTableLayoutPanel.Size = new System.Drawing.Size(238, 110);
			this.outputTableLayoutPanel.TabIndex = 0;
			// 
			// outputDeviceComboBox
			// 
			this.outputDeviceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.outputDeviceComboBox.FormattingEnabled = true;
			this.outputDeviceComboBox.Location = new System.Drawing.Point(18, 29);
			this.outputDeviceComboBox.Name = "outputDeviceComboBox";
			this.outputDeviceComboBox.Size = new System.Drawing.Size(202, 21);
			this.outputDeviceComboBox.TabIndex = 1;
			// 
			// outputBufferComboBox
			// 
			this.outputBufferComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.outputBufferComboBox.FormattingEnabled = true;
			this.outputBufferComboBox.Location = new System.Drawing.Point(18, 81);
			this.outputBufferComboBox.Name = "outputBufferComboBox";
			this.outputBufferComboBox.Size = new System.Drawing.Size(202, 21);
			this.outputBufferComboBox.TabIndex = 2;
			// 
			// outputDeviceLabel
			// 
			this.outputDeviceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.outputDeviceLabel.Location = new System.Drawing.Point(18, 8);
			this.outputDeviceLabel.Name = "outputDeviceLabel";
			this.outputDeviceLabel.Size = new System.Drawing.Size(202, 18);
			this.outputDeviceLabel.TabIndex = 3;
			this.outputDeviceLabel.Text = "Device:";
			// 
			// outputBufferLabel
			// 
			this.outputBufferLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.outputBufferLabel.Location = new System.Drawing.Point(18, 60);
			this.outputBufferLabel.Name = "outputBufferLabel";
			this.outputBufferLabel.Size = new System.Drawing.Size(202, 18);
			this.outputBufferLabel.TabIndex = 4;
			this.outputBufferLabel.Text = "Buffer size (samples):";
			// 
			// DirectSoundDeviceControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dsTableLayoutPanel);
			this.Name = "DirectSoundDeviceControl";
			this.Size = new System.Drawing.Size(250, 270);
			this.dsTableLayoutPanel.ResumeLayout(false);
			this.inputGroupBox.ResumeLayout(false);
			this.inputTableLayoutPanel.ResumeLayout(false);
			this.outputGroupBox.ResumeLayout(false);
			this.outputTableLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label inputBufferLabel;
		private System.Windows.Forms.Label inputDeviceLabel;
		private System.Windows.Forms.ComboBox inputBufferComboBox;
		private System.Windows.Forms.ComboBox inputDeviceComboBox;
		private System.Windows.Forms.TableLayoutPanel inputTableLayoutPanel;
		private System.Windows.Forms.GroupBox inputGroupBox;
		private System.Windows.Forms.Label outputBufferLabel;
		private System.Windows.Forms.Label outputDeviceLabel;
		private System.Windows.Forms.ComboBox outputBufferComboBox;
		private System.Windows.Forms.ComboBox outputDeviceComboBox;
		private System.Windows.Forms.TableLayoutPanel outputTableLayoutPanel;
		private System.Windows.Forms.GroupBox outputGroupBox;
		private System.Windows.Forms.TableLayoutPanel dsTableLayoutPanel;
	}
}
