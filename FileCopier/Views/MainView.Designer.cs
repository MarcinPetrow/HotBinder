using System.Windows.Forms;

namespace FileCopier.Views
{
	partial class MainView
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
			this.mTextBox1 = new System.Windows.Forms.TextBox();
			this.mTextBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.hButton1 = new System.Windows.Forms.Button();
			this.hButton2 = new System.Windows.Forms.Button();
			this.hButton3 = new System.Windows.Forms.Button();
			this.hPictureBox1 = new System.Windows.Forms.PictureBox();
			this.hPictureBox2 = new System.Windows.Forms.PictureBox();
			this.hProgressBar1 = new System.Windows.Forms.ProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.hPictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hPictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// mTextBox1
			// 
			this.ClickBindingProvider.SetClickBinding(this.mTextBox1, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.mTextBox1, "");
			this.mTextBox1.Location = new System.Drawing.Point(24, 21);
			this.mTextBox1.Name = "mTextBox1";
			this.mTextBox1.Size = new System.Drawing.Size(313, 20);
			this.mTextBox1.TabIndex = 0;
			this.TextBindingProvider.SetTextBinding(this.mTextBox1, "SourcePath");
			this.VisibleBindingProvider.SetVisibleBinding(this.mTextBox1, "");
			// 
			// mTextBox2
			// 
			this.ClickBindingProvider.SetClickBinding(this.mTextBox2, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.mTextBox2, "");
			this.mTextBox2.Location = new System.Drawing.Point(24, 61);
			this.mTextBox2.Name = "mTextBox2";
			this.mTextBox2.Size = new System.Drawing.Size(313, 20);
			this.mTextBox2.TabIndex = 1;
			this.TextBindingProvider.SetTextBinding(this.mTextBox2, "DestinationPath");
			this.VisibleBindingProvider.SetVisibleBinding(this.mTextBox2, "");
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.ClickBindingProvider.SetClickBinding(this.label1, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.label1, "");
			this.label1.Location = new System.Drawing.Point(21, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Source path";
			this.VisibleBindingProvider.SetVisibleBinding(this.label1, "");
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.ClickBindingProvider.SetClickBinding(this.label2, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.label2, "");
			this.label2.Location = new System.Drawing.Point(21, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Destination path";
			this.VisibleBindingProvider.SetVisibleBinding(this.label2, "");
			// 
			// hButton1
			// 
			this.ClickBindingProvider.SetClickBinding(this.hButton1, "CopyCommand");
			this.EnabledBindingProvider.SetEnabledBinding(this.hButton1, "IsReadyToCopying");
			this.hButton1.Location = new System.Drawing.Point(343, 149);
			this.hButton1.Name = "hButton1";
			this.hButton1.Size = new System.Drawing.Size(75, 23);
			this.hButton1.TabIndex = 4;
			this.hButton1.Text = "Copy";
			this.hButton1.UseVisualStyleBackColor = true;
			this.VisibleBindingProvider.SetVisibleBinding(this.hButton1, "");
			// 
			// hButton2
			// 
			this.ClickBindingProvider.SetClickBinding(this.hButton2, "ChooseSourceCommand");
			this.EnabledBindingProvider.SetEnabledBinding(this.hButton2, "");
			this.hButton2.Location = new System.Drawing.Point(343, 21);
			this.hButton2.Name = "hButton2";
			this.hButton2.Size = new System.Drawing.Size(75, 20);
			this.hButton2.TabIndex = 5;
			this.hButton2.Text = "Browse";
			this.hButton2.UseVisualStyleBackColor = true;
			this.VisibleBindingProvider.SetVisibleBinding(this.hButton2, "");
			// 
			// hButton3
			// 
			this.ClickBindingProvider.SetClickBinding(this.hButton3, "ChooseDestinationCommand");
			this.EnabledBindingProvider.SetEnabledBinding(this.hButton3, "");
			this.hButton3.Location = new System.Drawing.Point(343, 61);
			this.hButton3.Name = "hButton3";
			this.hButton3.Size = new System.Drawing.Size(75, 20);
			this.hButton3.TabIndex = 6;
			this.hButton3.Text = "Browse";
			this.hButton3.UseVisualStyleBackColor = true;
			this.VisibleBindingProvider.SetVisibleBinding(this.hButton3, "");
			// 
			// hPictureBox1
			// 
			this.hPictureBox1.BackColor = System.Drawing.Color.Olive;
			this.hPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hPictureBox1.BackgroundImage")));
			this.ClickBindingProvider.SetClickBinding(this.hPictureBox1, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.hPictureBox1, "");
			this.hPictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("hPictureBox1.InitialImage")));
			this.hPictureBox1.Location = new System.Drawing.Point(3, 61);
			this.hPictureBox1.Name = "hPictureBox1";
			this.hPictureBox1.Size = new System.Drawing.Size(22, 20);
			this.hPictureBox1.TabIndex = 7;
			this.hPictureBox1.TabStop = false;
			this.VisibleBindingProvider.SetVisibleBinding(this.hPictureBox1, "IsDestinationValid");
			// 
			// hPictureBox2
			// 
			this.hPictureBox2.BackColor = System.Drawing.Color.Olive;
			this.hPictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hPictureBox2.BackgroundImage")));
			this.ClickBindingProvider.SetClickBinding(this.hPictureBox2, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.hPictureBox2, "");
			this.hPictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("hPictureBox2.InitialImage")));
			this.hPictureBox2.Location = new System.Drawing.Point(3, 21);
			this.hPictureBox2.Name = "hPictureBox2";
			this.hPictureBox2.Size = new System.Drawing.Size(22, 20);
			this.hPictureBox2.TabIndex = 8;
			this.hPictureBox2.TabStop = false;
			this.VisibleBindingProvider.SetVisibleBinding(this.hPictureBox2, "IsSourceValid");
			// 
			// hProgressBar1
			// 
			this.ClickBindingProvider.SetClickBinding(this.hProgressBar1, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.hProgressBar1, "");
			this.hProgressBar1.Location = new System.Drawing.Point(24, 149);
			this.hProgressBar1.MarqueeAnimationSpeed = 0;
			this.hProgressBar1.Name = "hProgressBar1";
			this.hProgressBar1.Size = new System.Drawing.Size(313, 23);
			this.hProgressBar1.TabIndex = 9;
			this.hProgressBar1.UseWaitCursor = true;
			this.ValueBindingProvider.SetValueBinding(this.hProgressBar1, "");
			this.VisibleBindingProvider.SetVisibleBinding(this.hProgressBar1, "IsInProgress");
			// 
			// MainView
			// 
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClickBindingProvider.SetClickBinding(this, "");
			this.Controls.Add(this.hProgressBar1);
			this.Controls.Add(this.hPictureBox2);
			this.Controls.Add(this.hPictureBox1);
			this.Controls.Add(this.hButton3);
			this.Controls.Add(this.hButton2);
			this.Controls.Add(this.hButton1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.mTextBox2);
			this.Controls.Add(this.mTextBox1);
			this.EnabledBindingProvider.SetEnabledBinding(this, "");
			this.Name = "MainView";
			this.Size = new System.Drawing.Size(421, 175);
			this.VisibleBindingProvider.SetVisibleBinding(this, "");
			((System.ComponentModel.ISupportInitialize)(this.hPictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hPictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox mTextBox1;
		private TextBox mTextBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Button hButton1;
		private Button hButton2;
		private Button hButton3;
		private PictureBox hPictureBox1;
		private PictureBox hPictureBox2;
		private ProgressBar hProgressBar1;
	}
}
