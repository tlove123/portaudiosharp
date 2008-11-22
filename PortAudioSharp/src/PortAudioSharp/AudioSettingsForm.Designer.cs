/*
 * Creato da SharpDevelop.
 * Utente: Riccardo
 * Data: 14/12/2007
 * Ora: 17.15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PortAudioSharp
{
	partial class ApiHostSelectionForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
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
			this.settingsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.cancelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.settingsTableLayoutPanel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// settingsTableLayoutPanel
			// 
			this.settingsTableLayoutPanel.ColumnCount = 1;
			this.settingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
			this.settingsTableLayoutPanel.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.settingsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.settingsTableLayoutPanel.Location = new System.Drawing.Point(10, 10);
			this.settingsTableLayoutPanel.Name = "settingsTableLayoutPanel";
			this.settingsTableLayoutPanel.RowCount = 2;
			this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 340F));
			this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.settingsTableLayoutPanel.Size = new System.Drawing.Size(353, 376);
			this.settingsTableLayoutPanel.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.cancelButton);
			this.flowLayoutPanel1.Controls.Add(this.okButton);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 343);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.flowLayoutPanel1.Size = new System.Drawing.Size(347, 30);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(269, 3);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.Location = new System.Drawing.Point(188, 3);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 0;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			// 
			// ApiHostSelectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 396);
			this.Controls.Add(this.settingsTableLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ApiHostSelectionForm";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Audio hardware settings";
			this.Load += new System.EventHandler(this.ApiHostSelectionFormLoad);
			this.settingsTableLayoutPanel.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TableLayoutPanel settingsTableLayoutPanel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	
		private PortAudioSharp.AudioSettingsControl audioSettingsControl;
		
		void ApiHostSelectionFormLoad(object sender, System.EventArgs e)
		{
			audioSettingsControl = new PortAudioSharp.AudioSettingsControl();
			this.settingsTableLayoutPanel.Controls.Add(audioSettingsControl, 0, 0);
			
		}
	}
}
