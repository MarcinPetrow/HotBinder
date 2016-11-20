using HotBinder.Core.Controls;

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
			this.mTextBox1 = new HTextBox();
			this.mTextBox2 = new HTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.hButton1 = new HButton();
			this.hButton2 = new HButton();
			this.hButton3 = new HButton();
			this.hPictureBox1 = new HotBinder.Core.Controls.HPictureBox();
			this.hPictureBox2 = new HotBinder.Core.Controls.HPictureBox();
			this.hProgressBar1 = new HotBinder.Core.Controls.HProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.hPictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hPictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// mTextBox1
			// 
			this.mTextBox1.BindEnabled = null;
			this.mTextBox1.BindText = "SourcePath";
			this.mTextBox1.BindVisible = null;
			this.mTextBox1.Context = null;
			this.mTextBox1.Location = new System.Drawing.Point(24, 21);
			this.mTextBox1.Name = "mTextBox1";
			this.mTextBox1.Size = new System.Drawing.Size(313, 20);
			this.mTextBox1.TabIndex = 0;
			// 
			// mTextBox2
			// 
			this.mTextBox2.BindEnabled = "IsSourceValid";
			this.mTextBox2.BindText = "DestinationPath";
			this.mTextBox2.BindVisible = null;
			this.mTextBox2.Context = null;
			this.mTextBox2.Location = new System.Drawing.Point(24, 61);
			this.mTextBox2.Name = "mTextBox2";
			this.mTextBox2.Size = new System.Drawing.Size(313, 20);
			this.mTextBox2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Source path";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Destination path";
			// 
			// hButton1
			// 
			this.hButton1.BindEnabled = "IsReadyToCopying";
			this.hButton1.BindText = "";
			this.hButton1.BindVisible = null;
			this.hButton1.ClickAction = "CopyCommand";
			this.hButton1.Context = null;
			this.hButton1.Location = new System.Drawing.Point(343, 149);
			this.hButton1.Name = "hButton1";
			this.hButton1.Size = new System.Drawing.Size(75, 23);
			this.hButton1.TabIndex = 4;
			this.hButton1.Text = "Copy";
			this.hButton1.UseVisualStyleBackColor = true;
			// 
			// hButton2
			// 
			this.hButton2.BindEnabled = null;
			this.hButton2.BindText = null;
			this.hButton2.BindVisible = null;
			this.hButton2.ClickAction = "ChooseSourceCommand";
			this.hButton2.Context = null;
			this.hButton2.Location = new System.Drawing.Point(343, 21);
			this.hButton2.Name = "hButton2";
			this.hButton2.Size = new System.Drawing.Size(75, 20);
			this.hButton2.TabIndex = 5;
			this.hButton2.Text = "Browse";
			this.hButton2.UseVisualStyleBackColor = true;
			// 
			// hButton3
			// 
			this.hButton3.BindEnabled = "IsSourceValid";
			this.hButton3.BindText = null;
			this.hButton3.BindVisible = null;
			this.hButton3.ClickAction = "ChooseDestinationCommand";
			this.hButton3.Context = null;
			this.hButton3.Location = new System.Drawing.Point(343, 61);
			this.hButton3.Name = "hButton3";
			this.hButton3.Size = new System.Drawing.Size(75, 20);
			this.hButton3.TabIndex = 6;
			this.hButton3.Text = "Browse";
			this.hButton3.UseVisualStyleBackColor = true;
			// 
			// hPictureBox1
			// 
			this.hPictureBox1.BackColor = System.Drawing.Color.Olive;
			this.hPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hPictureBox1.BackgroundImage")));
			this.hPictureBox1.BindEnabled = null;
			this.hPictureBox1.BindVisible = "IsDestinationValid";
			this.hPictureBox1.Context = null;
			this.hPictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("hPictureBox1.InitialImage")));
			this.hPictureBox1.Location = new System.Drawing.Point(3, 61);
			this.hPictureBox1.Name = "hPictureBox1";
			this.hPictureBox1.Size = new System.Drawing.Size(22, 20);
			this.hPictureBox1.TabIndex = 7;
			this.hPictureBox1.TabStop = false;
			// 
			// hPictureBox2
			// 
			this.hPictureBox2.BackColor = System.Drawing.Color.Olive;
			this.hPictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hPictureBox2.BackgroundImage")));
			this.hPictureBox2.BindEnabled = null;
			this.hPictureBox2.BindVisible = "IsSourceValid";
			this.hPictureBox2.Context = null;
			this.hPictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("hPictureBox2.InitialImage")));
			this.hPictureBox2.Location = new System.Drawing.Point(3, 21);
			this.hPictureBox2.Name = "hPictureBox2";
			this.hPictureBox2.Size = new System.Drawing.Size(22, 20);
			this.hPictureBox2.TabIndex = 8;
			this.hPictureBox2.TabStop = false;
			// 
			// hProgressBar1
			// 
			this.hProgressBar1.BindEnabled = "IsReadyToCopying";
			this.hProgressBar1.BindMaximum = "FilesCount";
			this.hProgressBar1.BindMinimum = null;
			this.hProgressBar1.BindValue = "FilesDone";
			this.hProgressBar1.BindVisible = null;
			this.hProgressBar1.Context = null;
			this.hProgressBar1.Location = new System.Drawing.Point(24, 149);
			this.hProgressBar1.MarqueeAnimationSpeed = 0;
			this.hProgressBar1.Name = "hProgressBar1";
			this.hProgressBar1.Size = new System.Drawing.Size(313, 23);
			this.hProgressBar1.TabIndex = 9;
			this.hProgressBar1.UseWaitCursor = true;
			// 
			// MainView
			// 
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
			this.Name = "MainView";
			this.Size = new System.Drawing.Size(421, 175);
			((System.ComponentModel.ISupportInitialize)(this.hPictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hPictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private HTextBox mTextBox1;
		private HTextBox mTextBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private HButton hButton1;
		private HButton hButton2;
		private HButton hButton3;
		private HPictureBox hPictureBox1;
		private HPictureBox hPictureBox2;
		private HProgressBar hProgressBar1;
	}
}
