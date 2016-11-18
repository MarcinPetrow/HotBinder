namespace HelloWorld.Views
{
	partial class SimpleView
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
			this.hTextBox1 = new BinderPlayground.Core.Controls.HTextBox();
			this.hLabel1 = new HotBinder.Core.Controls.HLabel();
			this.hLabel2 = new HotBinder.Core.Controls.HLabel();
			this.hLabel3 = new HotBinder.Core.Controls.HLabel();
			this.SuspendLayout();
			// 
			// hTextBox1
			// 
			this.hTextBox1.BindEnabled = null;
			this.hTextBox1.BindText = "Name";
			this.hTextBox1.BindVisible = null;
			this.hTextBox1.Context = null;
			this.hTextBox1.Location = new System.Drawing.Point(207, 129);
			this.hTextBox1.Name = "hTextBox1";
			this.hTextBox1.Size = new System.Drawing.Size(170, 20);
			this.hTextBox1.TabIndex = 0;
			// 
			// hLabel1
			// 
			this.hLabel1.BindEnabled = null;
			this.hLabel1.BindText = null;
			this.hLabel1.BindVisible = null;
			this.hLabel1.Context = null;
			this.hLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.hLabel1.Location = new System.Drawing.Point(204, 194);
			this.hLabel1.Name = "hLabel1";
			this.hLabel1.Size = new System.Drawing.Size(100, 23);
			this.hLabel1.TabIndex = 1;
			this.hLabel1.Text = "Hello";
			// 
			// hLabel2
			// 
			this.hLabel2.BindEnabled = null;
			this.hLabel2.BindText = "Name";
			this.hLabel2.BindVisible = null;
			this.hLabel2.Context = null;
			this.hLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.hLabel2.Location = new System.Drawing.Point(264, 194);
			this.hLabel2.Name = "hLabel2";
			this.hLabel2.Size = new System.Drawing.Size(100, 23);
			this.hLabel2.TabIndex = 2;
			// 
			// hLabel3
			// 
			this.hLabel3.AutoSize = true;
			this.hLabel3.BindEnabled = null;
			this.hLabel3.BindText = null;
			this.hLabel3.BindVisible = null;
			this.hLabel3.Context = null;
			this.hLabel3.Location = new System.Drawing.Point(222, 113);
			this.hLabel3.Name = "hLabel3";
			this.hLabel3.Size = new System.Drawing.Size(142, 13);
			this.hLabel3.TabIndex = 3;
			this.hLabel3.Text = "Please enter your name here";
			// 
			// SimpleView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.hLabel3);
			this.Controls.Add(this.hLabel2);
			this.Controls.Add(this.hLabel1);
			this.Controls.Add(this.hTextBox1);
			this.Name = "SimpleView";
			this.Size = new System.Drawing.Size(577, 359);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private BinderPlayground.Core.Controls.HTextBox hTextBox1;
		private HotBinder.Core.Controls.HLabel hLabel1;
		private HotBinder.Core.Controls.HLabel hLabel2;
		private HotBinder.Core.Controls.HLabel hLabel3;
	}
}