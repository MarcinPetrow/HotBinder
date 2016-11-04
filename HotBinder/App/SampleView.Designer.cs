using BinderPlayground.Core.Controls;

namespace BinderPlayground.App
{
	partial class SampleView
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
			this.mTextBox4 = new BinderPlayground.Core.Controls.MTextBox();
			this.enabler = new BinderPlayground.Core.Controls.MCheckBox();
			this.mCheckBox3 = new BinderPlayground.Core.Controls.MCheckBox();
			this.mTextBox3 = new BinderPlayground.Core.Controls.MTextBox();
			this.mCheckBox2 = new BinderPlayground.Core.Controls.MCheckBox();
			this.mCheckBox1 = new BinderPlayground.Core.Controls.MCheckBox();
			this.mTextBox2 = new BinderPlayground.Core.Controls.MTextBox();
			this.mTextBox1 = new BinderPlayground.Core.Controls.MTextBox();
			this.mButton1 = new BinderPlayground.Core.Controls.MButton();
			this.mButton2 = new BinderPlayground.Core.Controls.MButton();
			this.mButton3 = new BinderPlayground.Core.Controls.MButton();
			this.mListBox1 = new HotBinder.Core.Controls.MListBox();
			this.mButton4 = new BinderPlayground.Core.Controls.MButton();
			this.mTextBox5 = new BinderPlayground.Core.Controls.MTextBox();
			this.mNumericUpDown1 = new HotBinder.Core.Controls.MNumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.mNumericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// mTextBox4
			// 
			this.mTextBox4.BindEnabled = null;
			this.mTextBox4.BindText = "Name";
			this.mTextBox4.BindVisible = null;
			this.mTextBox4.Context = null;
			this.mTextBox4.Location = new System.Drawing.Point(114, 34);
			this.mTextBox4.Name = "mTextBox4";
			this.mTextBox4.Size = new System.Drawing.Size(100, 20);
			this.mTextBox4.TabIndex = 17;
			// 
			// enabler
			// 
			this.enabler.BindChecked = "IsEnabled";
			this.enabler.BindEnabled = null;
			this.enabler.BindVisible = null;
			this.enabler.Context = null;
			this.enabler.Location = new System.Drawing.Point(99, 70);
			this.enabler.Name = "enabler";
			this.enabler.Size = new System.Drawing.Size(100, 24);
			this.enabler.TabIndex = 16;
			this.enabler.Text = "Enable options";
			this.enabler.UseVisualStyleBackColor = true;
			// 
			// mCheckBox3
			// 
			this.mCheckBox3.BindChecked = "IsChecked";
			this.mCheckBox3.BindEnabled = "IsEnabled";
			this.mCheckBox3.BindVisible = null;
			this.mCheckBox3.Context = null;
			this.mCheckBox3.Location = new System.Drawing.Point(5, 130);
			this.mCheckBox3.Name = "mCheckBox3";
			this.mCheckBox3.Size = new System.Drawing.Size(104, 24);
			this.mCheckBox3.TabIndex = 15;
			this.mCheckBox3.Text = "Option 3";
			this.mCheckBox3.UseVisualStyleBackColor = true;
			// 
			// mTextBox3
			// 
			this.mTextBox3.BindEnabled = null;
			this.mTextBox3.BindText = "Name";
			this.mTextBox3.BindVisible = null;
			this.mTextBox3.Context = null;
			this.mTextBox3.Location = new System.Drawing.Point(114, 8);
			this.mTextBox3.Name = "mTextBox3";
			this.mTextBox3.Size = new System.Drawing.Size(100, 20);
			this.mTextBox3.TabIndex = 14;
			// 
			// mCheckBox2
			// 
			this.mCheckBox2.BindChecked = "IsChecked";
			this.mCheckBox2.BindEnabled = "IsEnabled";
			this.mCheckBox2.BindVisible = null;
			this.mCheckBox2.Context = null;
			this.mCheckBox2.Location = new System.Drawing.Point(5, 100);
			this.mCheckBox2.Name = "mCheckBox2";
			this.mCheckBox2.Size = new System.Drawing.Size(104, 24);
			this.mCheckBox2.TabIndex = 13;
			this.mCheckBox2.Text = "Option 2";
			this.mCheckBox2.UseVisualStyleBackColor = true;
			// 
			// mCheckBox1
			// 
			this.mCheckBox1.BindChecked = "IsChecked";
			this.mCheckBox1.BindEnabled = "IsEnabled";
			this.mCheckBox1.BindVisible = null;
			this.mCheckBox1.Context = null;
			this.mCheckBox1.Location = new System.Drawing.Point(5, 70);
			this.mCheckBox1.Name = "mCheckBox1";
			this.mCheckBox1.Size = new System.Drawing.Size(104, 24);
			this.mCheckBox1.TabIndex = 12;
			this.mCheckBox1.Text = "Option 1";
			this.mCheckBox1.UseVisualStyleBackColor = true;
			// 
			// mTextBox2
			// 
			this.mTextBox2.BindEnabled = null;
			this.mTextBox2.BindText = "Name";
			this.mTextBox2.BindVisible = null;
			this.mTextBox2.Context = null;
			this.mTextBox2.Location = new System.Drawing.Point(5, 34);
			this.mTextBox2.Name = "mTextBox2";
			this.mTextBox2.Size = new System.Drawing.Size(100, 20);
			this.mTextBox2.TabIndex = 10;
			// 
			// mTextBox1
			// 
			this.mTextBox1.BindEnabled = null;
			this.mTextBox1.BindText = "Name";
			this.mTextBox1.BindVisible = null;
			this.mTextBox1.Context = null;
			this.mTextBox1.Location = new System.Drawing.Point(5, 8);
			this.mTextBox1.Name = "mTextBox1";
			this.mTextBox1.Size = new System.Drawing.Size(100, 20);
			this.mTextBox1.TabIndex = 9;
			// 
			// mButton1
			// 
			this.mButton1.BindEnabled = null;
			this.mButton1.BindVisible = null;
			this.mButton1.ClickAction = "SampleAction";
			this.mButton1.Context = null;
			this.mButton1.Location = new System.Drawing.Point(115, 101);
			this.mButton1.Name = "mButton1";
			this.mButton1.Size = new System.Drawing.Size(135, 53);
			this.mButton1.TabIndex = 18;
			this.mButton1.Text = "Show message";
			this.mButton1.TextChecked = null;
			this.mButton1.UseVisualStyleBackColor = true;
			// 
			// mButton2
			// 
			this.mButton2.BindEnabled = null;
			this.mButton2.BindVisible = null;
			this.mButton2.ClickAction = "NewWindowAction";
			this.mButton2.Context = null;
			this.mButton2.Location = new System.Drawing.Point(114, 160);
			this.mButton2.Name = "mButton2";
			this.mButton2.Size = new System.Drawing.Size(136, 53);
			this.mButton2.TabIndex = 19;
			this.mButton2.Text = "Duplicate window";
			this.mButton2.TextChecked = null;
			this.mButton2.UseVisualStyleBackColor = true;
			// 
			// mButton3
			// 
			this.mButton3.BindEnabled = null;
			this.mButton3.BindVisible = null;
			this.mButton3.ClickAction = "DuplicateWindowAction";
			this.mButton3.Context = null;
			this.mButton3.Location = new System.Drawing.Point(114, 219);
			this.mButton3.Name = "mButton3";
			this.mButton3.Size = new System.Drawing.Size(136, 53);
			this.mButton3.TabIndex = 20;
			this.mButton3.Text = "Duplicate window (same model)";
			this.mButton3.TextChecked = null;
			this.mButton3.UseVisualStyleBackColor = true;
			// 
			// mListBox1
			// 
			this.mListBox1.BindDataSource = "Items";
			this.mListBox1.BindEnabled = "";
			this.mListBox1.BindSelectedIndex = "SelectedIndex";
			this.mListBox1.BindSelectedItem = "SelectedItem";
			this.mListBox1.BindVisible = null;
			this.mListBox1.ClickAction = null;
			this.mListBox1.Context = null;
			this.mListBox1.FormattingEnabled = true;
			this.mListBox1.Location = new System.Drawing.Point(256, 100);
			this.mListBox1.Name = "mListBox1";
			this.mListBox1.Size = new System.Drawing.Size(278, 95);
			this.mListBox1.TabIndex = 21;
			// 
			// mButton4
			// 
			this.mButton4.BindEnabled = null;
			this.mButton4.BindVisible = null;
			this.mButton4.ClickAction = "AddItemAction";
			this.mButton4.Context = null;
			this.mButton4.Location = new System.Drawing.Point(256, 201);
			this.mButton4.Name = "mButton4";
			this.mButton4.Size = new System.Drawing.Size(120, 53);
			this.mButton4.TabIndex = 22;
			this.mButton4.Text = "Add item";
			this.mButton4.TextChecked = null;
			this.mButton4.UseVisualStyleBackColor = true;
			// 
			// mTextBox5
			// 
			this.mTextBox5.BindEnabled = null;
			this.mTextBox5.BindText = "SelectedItem";
			this.mTextBox5.BindVisible = null;
			this.mTextBox5.Context = null;
			this.mTextBox5.Location = new System.Drawing.Point(256, 70);
			this.mTextBox5.Name = "mTextBox5";
			this.mTextBox5.Size = new System.Drawing.Size(278, 20);
			this.mTextBox5.TabIndex = 23;
			// 
			// mNumericUpDown1
			// 
			this.mNumericUpDown1.BindEnabled = null;
			this.mNumericUpDown1.BindValue = "SelectedIndex";
			this.mNumericUpDown1.BindVisible = null;
			this.mNumericUpDown1.Context = null;
			this.mNumericUpDown1.Location = new System.Drawing.Point(383, 201);
			this.mNumericUpDown1.Name = "mNumericUpDown1";
			this.mNumericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.mNumericUpDown1.TabIndex = 24;
			// 
			// SampleView
			// 
			this.Controls.Add(this.mNumericUpDown1);
			this.Controls.Add(this.mTextBox5);
			this.Controls.Add(this.mButton4);
			this.Controls.Add(this.mListBox1);
			this.Controls.Add(this.mButton3);
			this.Controls.Add(this.mButton2);
			this.Controls.Add(this.mButton1);
			this.Controls.Add(this.mTextBox4);
			this.Controls.Add(this.enabler);
			this.Controls.Add(this.mCheckBox3);
			this.Controls.Add(this.mTextBox3);
			this.Controls.Add(this.mCheckBox2);
			this.Controls.Add(this.mCheckBox1);
			this.Controls.Add(this.mTextBox2);
			this.Controls.Add(this.mTextBox1);
			this.Name = "SampleView";
			this.Size = new System.Drawing.Size(537, 355);
			((System.ComponentModel.ISupportInitialize)(this.mNumericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MTextBox mTextBox4;
		private MCheckBox enabler;
		private MCheckBox mCheckBox3;
		private MTextBox mTextBox3;
		private MCheckBox mCheckBox2;
		private MCheckBox mCheckBox1;
		private MTextBox mTextBox2;
		private MTextBox mTextBox1;
		private MButton mButton1;
		private MButton mButton2;
		private MButton mButton3;
		private HotBinder.Core.Controls.MListBox mListBox1;
		private MButton mButton4;
		private MTextBox mTextBox5;
		private HotBinder.Core.Controls.MNumericUpDown mNumericUpDown1;
	}
}
