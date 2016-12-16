using HotBinder.Core.Binding.Commands;
using HotBinder.Core.Layout;
using HotBinder.Core.Layout.Default;
using System.Windows.Forms;
using System.Windows.Input;

namespace Playground.App
{
	[Layout]
	public class CustomLayout : BaseLayout
	{
		private MenuStrip menuStrip1;
		private ToolStripMenuItem hToolStripMenuItem1;
		private ToolStripMenuItem hToolStripMenuItem2;
		private ViewHost viewHost1;

		private ICommand performAction;

		public ICommand PerformAction
		{
			get { return performAction; }
			set
			{
				SetProperty(ref performAction, value);
			}
		}

		public CustomLayout()
		{
			InitializeComponent();
			PerformAction = new RelayCommands(PerformActionExecute);
		}

		private void PerformActionExecute(object obj)
		{
			Redirect("SampleController", "Message");
		}

		public override ViewHost GetViewContainer()
		{
			return viewHost1;
		}

		private void InitializeComponent()
		{
			this.viewHost1 = new HotBinder.Core.Layout.ViewHost();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.hToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.hToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// viewHost1
			// 
			this.viewHost1.AutoSize = true;
			this.viewHost1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.viewHost1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.viewHost1.Location = new System.Drawing.Point(0, 24);
			this.viewHost1.Margin = new System.Windows.Forms.Padding(20);
			this.viewHost1.Name = "viewHost1";
			this.viewHost1.Padding = new System.Windows.Forms.Padding(20);
			this.viewHost1.Size = new System.Drawing.Size(40, 40);
			this.viewHost1.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hToolStripMenuItem1,
            this.hToolStripMenuItem2});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(40, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// hToolStripMenuItem1
			// 
			this.hToolStripMenuItem1.Name = "hToolStripMenuItem1";
			this.hToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
			this.hToolStripMenuItem1.Text = "Action 1";
			// 
			// hToolStripMenuItem2
			// 
			this.hToolStripMenuItem2.Name = "hToolStripMenuItem2";
			this.hToolStripMenuItem2.Size = new System.Drawing.Size(63, 20);
			this.hToolStripMenuItem2.Text = "Action 2";
			// 
			// CustomLayout
			// 
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Maroon;
			this.Controls.Add(this.viewHost1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "CustomLayout";
			this.Size = new System.Drawing.Size(40, 64);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
