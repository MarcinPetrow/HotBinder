namespace HotBinder
{
    partial class AppHost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppHost));
			this.ViewPanel = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// ViewPanel
			// 
			this.ViewPanel.AutoSize = true;
			this.ViewPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ViewPanel.Location = new System.Drawing.Point(0, 0);
			this.ViewPanel.Name = "ViewPanel";
			this.ViewPanel.Size = new System.Drawing.Size(341, 293);
			this.ViewPanel.TabIndex = 0;
			// 
			// AppHost
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(341, 293);
			this.Controls.Add(this.ViewPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AppHost";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AppHostForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Panel ViewPanel;
	}
}

