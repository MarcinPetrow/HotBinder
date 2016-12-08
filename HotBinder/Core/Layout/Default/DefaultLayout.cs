namespace HotBinder.Core.Layout.Default
{
	public class DefaultLayout : BaseLayout
	{
		private ViewHost host;

		public DefaultLayout()
		{
			InitializeComponent();
		}

		public override ViewHost GetViewContainer()
		{
			return host;
		}

		private void InitializeComponent()
		{
			this.host = new HotBinder.Core.Layout.ViewHost();
			this.SuspendLayout();
			// 
			// host
			// 
			this.host.AutoSize = true;
			this.host.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.host.Dock = System.Windows.Forms.DockStyle.Fill;
			this.host.Location = new System.Drawing.Point(0, 0);
			this.host.Name = "host";
			this.host.Size = new System.Drawing.Size(0, 0);
			this.host.TabIndex = 0;
			// 
			// DefaultLayout
			// 
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.host);
			this.Name = "DefaultLayout";
			this.Size = new System.Drawing.Size(0, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
