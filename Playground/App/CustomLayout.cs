using HotBinder.Core.Binding.Commands;
using HotBinder.Core.Controls;
using HotBinder.Core.Layout;
using HotBinder.Core.Layout.Default;
using System.Windows.Input;

namespace Playground.App
{
	[Layout]
	public class CustomLayout : BaseLayout
	{
		private HMenuStrip menuStrip1;
		private HToolStripMenuItem hToolStripMenuItem1;
		private HToolStripMenuItem hToolStripMenuItem2;
		private HButton hButton1;
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
			this.menuStrip1 = new HotBinder.Core.Controls.HMenuStrip();
			this.hToolStripMenuItem1 = new HotBinder.Core.Controls.HToolStripMenuItem();
			this.hToolStripMenuItem2 = new HotBinder.Core.Controls.HToolStripMenuItem();
			this.hButton1 = new HotBinder.Core.Controls.HButton();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// viewHost1
			// 
			this.viewHost1.AutoSize = true;
			this.viewHost1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.viewHost1.Location = new System.Drawing.Point(20, 30);
			this.viewHost1.Margin = new System.Windows.Forms.Padding(20);
			this.viewHost1.Name = "viewHost1";
			this.viewHost1.Padding = new System.Windows.Forms.Padding(20);
			this.viewHost1.Size = new System.Drawing.Size(40, 40);
			this.viewHost1.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BindEnabled = null;
			this.menuStrip1.BindSize = null;
			this.menuStrip1.BindText = null;
			this.menuStrip1.BindVisible = null;
			this.menuStrip1.ClickAction = null;
			this.menuStrip1.Context = null;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.hToolStripMenuItem1,
			this.hToolStripMenuItem2});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(80, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// hToolStripMenuItem1
			// 
			this.hToolStripMenuItem1.BindEnabled = null;
			this.hToolStripMenuItem1.BindSize = null;
			this.hToolStripMenuItem1.BindText = null;
			this.hToolStripMenuItem1.BindVisible = null;
			this.hToolStripMenuItem1.ClickAction = "PerformAction";
			this.hToolStripMenuItem1.Context = null;
			this.hToolStripMenuItem1.Name = "hToolStripMenuItem1";
			this.hToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
			this.hToolStripMenuItem1.Text = "Action 1";
			// 
			// hToolStripMenuItem2
			// 
			this.hToolStripMenuItem2.BindEnabled = null;
			this.hToolStripMenuItem2.BindSize = null;
			this.hToolStripMenuItem2.BindText = null;
			this.hToolStripMenuItem2.BindVisible = null;
			this.hToolStripMenuItem2.ClickAction = null;
			this.hToolStripMenuItem2.Context = null;
			this.hToolStripMenuItem2.Name = "hToolStripMenuItem2";
			this.hToolStripMenuItem2.Size = new System.Drawing.Size(63, 20);
			this.hToolStripMenuItem2.Text = "Action 2";
			// 
			// hButton1
			// 
			this.hButton1.BindEnabled = null;
			this.hButton1.BindSize = null;
			this.hButton1.BindText = null;
			this.hButton1.BindVisible = null;
			this.hButton1.ClickAction = "PerformAction";
			this.hButton1.Context = null;
			this.hButton1.Dock = System.Windows.Forms.DockStyle.Left;
			this.hButton1.Location = new System.Drawing.Point(0, 24);
			this.hButton1.Name = "hButton1";
			this.hButton1.Size = new System.Drawing.Size(75, 66);
			this.hButton1.TabIndex = 2;
			this.hButton1.Text = "hButton1";
			this.hButton1.UseVisualStyleBackColor = true;
			// 
			// CustomLayout
			// 
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Maroon;
			this.Controls.Add(this.hButton1);
			this.Controls.Add(this.viewHost1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "CustomLayout";
			this.Size = new System.Drawing.Size(80, 90);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
