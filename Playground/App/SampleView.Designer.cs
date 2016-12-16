using System.Windows.Forms;

namespace Playground.App
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
			this.mTextBox4 = new System.Windows.Forms.TextBox();
			this.enabler = new System.Windows.Forms.CheckBox();
			this.mCheckBox3 = new System.Windows.Forms.CheckBox();
			this.mTextBox3 = new System.Windows.Forms.TextBox();
			this.mCheckBox2 = new System.Windows.Forms.CheckBox();
			this.mCheckBox1 = new System.Windows.Forms.CheckBox();
			this.mTextBox2 = new System.Windows.Forms.TextBox();
			this.mTextBox1 = new System.Windows.Forms.TextBox();
			this.mButton1 = new System.Windows.Forms.Button();
			this.mButton2 = new System.Windows.Forms.Button();
			this.mButton3 = new System.Windows.Forms.Button();
			this.mListBox1 = new System.Windows.Forms.ListBox();
			this.mButton4 = new System.Windows.Forms.Button();
			this.mTextBox5 = new System.Windows.Forms.TextBox();
			this.mNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.mRadioButton1 = new System.Windows.Forms.RadioButton();
			this.mRadioButton2 = new System.Windows.Forms.RadioButton();
			this.mRadioButton3 = new System.Windows.Forms.RadioButton();
			this.mTrackBar1 = new System.Windows.Forms.TrackBar();
			this.mComboBox1 = new System.Windows.Forms.ComboBox();
			this.mComboBox2 = new System.Windows.Forms.ComboBox();
			this.mDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.hProgressBar1 = new System.Windows.Forms.ProgressBar();
			this.hButton1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.mNumericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mTrackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// mTextBox4
			// 
			this.ClickBindingProvider.SetClickBinding(this.mTextBox4, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.mTextBox4, "IsEnabled");
			this.mTextBox4.Location = new System.Drawing.Point(114, 34);
			this.mTextBox4.Name = "mTextBox4";
			this.mTextBox4.Size = new System.Drawing.Size(100, 20);
			this.mTextBox4.TabIndex = 17;
			this.mTextBox4.Text = "Name";
			this.TextBindingProvider.SetTextBinding(this.mTextBox4, "Name");
			this.VisibleBindingProvider.SetVisibleBinding(this.mTextBox4, "");
			// 
			// enabler
			// 
			this.CheckedBindingProvider.SetCheckedBinding(this.enabler, "IsEnabled");
			this.ClickBindingProvider.SetClickBinding(this.enabler, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.enabler, "");
			this.enabler.Location = new System.Drawing.Point(99, 70);
			this.enabler.Name = "enabler";
			this.enabler.Size = new System.Drawing.Size(100, 24);
			this.enabler.TabIndex = 16;
			this.enabler.Text = "Enable options";
			this.enabler.UseVisualStyleBackColor = true;
			this.VisibleBindingProvider.SetVisibleBinding(this.enabler, "");
			// 
			// mCheckBox3
			// 
			this.CheckedBindingProvider.SetCheckedBinding(this.mCheckBox3, "");
			this.ClickBindingProvider.SetClickBinding(this.mCheckBox3, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.mCheckBox3, "");
			this.mCheckBox3.Location = new System.Drawing.Point(5, 130);
			this.mCheckBox3.Name = "mCheckBox3";
			this.mCheckBox3.Size = new System.Drawing.Size(104, 24);
			this.mCheckBox3.TabIndex = 15;
			this.mCheckBox3.Text = "Option 3";
			this.mCheckBox3.UseVisualStyleBackColor = true;
			this.VisibleBindingProvider.SetVisibleBinding(this.mCheckBox3, "");
			// 
			// mTextBox3
			// 
			this.ClickBindingProvider.SetClickBinding(this.mTextBox3, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.mTextBox3, "IsEnabled");
			this.mTextBox3.Location = new System.Drawing.Point(114, 8);
			this.mTextBox3.Name = "mTextBox3";
			this.mTextBox3.Size = new System.Drawing.Size(100, 20);
			this.mTextBox3.TabIndex = 14;
			this.mTextBox3.Text = "Name";
			this.TextBindingProvider.SetTextBinding(this.mTextBox3, "Name");
			this.VisibleBindingProvider.SetVisibleBinding(this.mTextBox3, "");
			// 
			// mCheckBox2
			// 
			this.CheckedBindingProvider.SetCheckedBinding(this.mCheckBox2, "OptionA");
			this.ClickBindingProvider.SetClickBinding(this.mCheckBox2, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.mCheckBox2, "");
			this.mCheckBox2.Location = new System.Drawing.Point(5, 100);
			this.mCheckBox2.Name = "mCheckBox2";
			this.mCheckBox2.Size = new System.Drawing.Size(104, 24);
			this.mCheckBox2.TabIndex = 13;
			this.mCheckBox2.Text = "Option 2";
			this.mCheckBox2.UseVisualStyleBackColor = true;
			this.VisibleBindingProvider.SetVisibleBinding(this.mCheckBox2, "");
			// 
			// mCheckBox1
			// 
			this.CheckedBindingProvider.SetCheckedBinding(this.mCheckBox1, "OptionA");
			this.ClickBindingProvider.SetClickBinding(this.mCheckBox1, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.mCheckBox1, "");
			this.mCheckBox1.Location = new System.Drawing.Point(5, 70);
			this.mCheckBox1.Name = "mCheckBox1";
			this.mCheckBox1.Size = new System.Drawing.Size(104, 24);
			this.mCheckBox1.TabIndex = 12;
			this.mCheckBox1.Text = "Option 1";
			this.mCheckBox1.UseVisualStyleBackColor = true;
			this.VisibleBindingProvider.SetVisibleBinding(this.mCheckBox1, "");
			// 
			// mTextBox2
			// 
			this.ClickBindingProvider.SetClickBinding(this.mTextBox2, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.mTextBox2, "IsEnabled");
			this.mTextBox2.Location = new System.Drawing.Point(5, 34);
			this.mTextBox2.Name = "mTextBox2";
			this.mTextBox2.Size = new System.Drawing.Size(100, 20);
			this.mTextBox2.TabIndex = 10;
			this.TextBindingProvider.SetTextBinding(this.mTextBox2, "Name");
			this.VisibleBindingProvider.SetVisibleBinding(this.mTextBox2, "");
			// 
			// mTextBox1
			// 
			this.ClickBindingProvider.SetClickBinding(this.mTextBox1, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.mTextBox1, "IsEnabled");
			this.mTextBox1.Location = new System.Drawing.Point(5, 8);
			this.mTextBox1.Name = "mTextBox1";
			this.mTextBox1.Size = new System.Drawing.Size(100, 20);
			this.mTextBox1.TabIndex = 9;
			this.TextBindingProvider.SetTextBinding(this.mTextBox1, "Name");
			this.VisibleBindingProvider.SetVisibleBinding(this.mTextBox1, "");
			// 
			// mButton1
			// 
			this.ClickBindingProvider.SetClickBinding(this.mButton1, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.mButton1, "");
			this.mButton1.Location = new System.Drawing.Point(115, 101);
			this.mButton1.Name = "mButton1";
			this.mButton1.Size = new System.Drawing.Size(135, 53);
			this.mButton1.TabIndex = 18;
			this.mButton1.Text = "Show message";
			this.mButton1.UseVisualStyleBackColor = true;
			this.VisibleBindingProvider.SetVisibleBinding(this.mButton1, "");
			// 
			// mButton2
			// 
			this.ClickBindingProvider.SetClickBinding(this.mButton2, "NewWindowAction");
			this.EnabledBindingProvider.SetEnabledBinding(this.mButton2, "");
			this.mButton2.Location = new System.Drawing.Point(114, 160);
			this.mButton2.Name = "mButton2";
			this.mButton2.Size = new System.Drawing.Size(136, 53);
			this.mButton2.TabIndex = 19;
			this.mButton2.Text = "Duplicate window";
			this.mButton2.UseVisualStyleBackColor = true;
			this.VisibleBindingProvider.SetVisibleBinding(this.mButton2, "");
			// 
			// mButton3
			// 
			this.ClickBindingProvider.SetClickBinding(this.mButton3, "DuplicateWindowAction");
			this.EnabledBindingProvider.SetEnabledBinding(this.mButton3, "");
			this.mButton3.Location = new System.Drawing.Point(114, 219);
			this.mButton3.Name = "mButton3";
			this.mButton3.Size = new System.Drawing.Size(136, 53);
			this.mButton3.TabIndex = 20;
			this.mButton3.Text = "Duplicate window (same model)";
			this.mButton3.UseVisualStyleBackColor = true;
			this.VisibleBindingProvider.SetVisibleBinding(this.mButton3, "");
			// 
			// mListBox1
			// 
			this.ClickBindingProvider.SetClickBinding(this.mListBox1, "");
			this.DataSourceBindingProvider.SetDataSourceBinding(this.mListBox1, "Items");
			this.EnabledBindingProvider.SetEnabledBinding(this.mListBox1, "");
			this.mListBox1.Location = new System.Drawing.Point(256, 154);
			this.mListBox1.Name = "mListBox1";
			this.mListBox1.Size = new System.Drawing.Size(278, 56);
			this.mListBox1.TabIndex = 35;
			this.VisibleBindingProvider.SetVisibleBinding(this.mListBox1, "");
			// 
			// mButton4
			// 
			this.ClickBindingProvider.SetClickBinding(this.mButton4, "AddItemAction");
			this.EnabledBindingProvider.SetEnabledBinding(this.mButton4, "");
			this.mButton4.Location = new System.Drawing.Point(256, 219);
			this.mButton4.Name = "mButton4";
			this.mButton4.Size = new System.Drawing.Size(120, 53);
			this.mButton4.TabIndex = 22;
			this.mButton4.Text = "Add item";
			this.mButton4.UseVisualStyleBackColor = true;
			this.VisibleBindingProvider.SetVisibleBinding(this.mButton4, "");
			// 
			// mTextBox5
			// 
			this.ClickBindingProvider.SetClickBinding(this.mTextBox5, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.mTextBox5, "");
			this.mTextBox5.Location = new System.Drawing.Point(256, 130);
			this.mTextBox5.Name = "mTextBox5";
			this.mTextBox5.Size = new System.Drawing.Size(278, 20);
			this.mTextBox5.TabIndex = 23;
			this.TextBindingProvider.SetTextBinding(this.mTextBox5, "");
			this.VisibleBindingProvider.SetVisibleBinding(this.mTextBox5, "");
			// 
			// mNumericUpDown1
			// 
			this.ClickBindingProvider.SetClickBinding(this.mNumericUpDown1, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.mNumericUpDown1, "");
			this.mNumericUpDown1.Location = new System.Drawing.Point(382, 219);
			this.mNumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.mNumericUpDown1.Name = "mNumericUpDown1";
			this.mNumericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.mNumericUpDown1.TabIndex = 24;
			this.mNumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.ValueBindingProvider.SetValueBinding(this.mNumericUpDown1, "SelectedIndex");
			this.VisibleBindingProvider.SetVisibleBinding(this.mNumericUpDown1, "");
			// 
			// mRadioButton1
			// 
			this.ClickBindingProvider.SetClickBinding(this.mRadioButton1, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.mRadioButton1, "");
			this.mRadioButton1.Location = new System.Drawing.Point(4, 160);
			this.mRadioButton1.Name = "mRadioButton1";
			this.mRadioButton1.Size = new System.Drawing.Size(104, 24);
			this.mRadioButton1.TabIndex = 25;
			this.mRadioButton1.TabStop = true;
			this.mRadioButton1.Text = "OptionA";
			this.mRadioButton1.UseVisualStyleBackColor = true;
			this.VisibleBindingProvider.SetVisibleBinding(this.mRadioButton1, "");
			// 
			// mRadioButton2
			// 
			this.ClickBindingProvider.SetClickBinding(this.mRadioButton2, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.mRadioButton2, "");
			this.mRadioButton2.Location = new System.Drawing.Point(4, 191);
			this.mRadioButton2.Name = "mRadioButton2";
			this.mRadioButton2.Size = new System.Drawing.Size(104, 24);
			this.mRadioButton2.TabIndex = 26;
			this.mRadioButton2.TabStop = true;
			this.mRadioButton2.Text = "OptionB";
			this.mRadioButton2.UseVisualStyleBackColor = true;
			this.VisibleBindingProvider.SetVisibleBinding(this.mRadioButton2, "");
			// 
			// mRadioButton3
			// 
			this.ClickBindingProvider.SetClickBinding(this.mRadioButton3, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.mRadioButton3, "");
			this.mRadioButton3.Location = new System.Drawing.Point(4, 219);
			this.mRadioButton3.Name = "mRadioButton3";
			this.mRadioButton3.Size = new System.Drawing.Size(104, 24);
			this.mRadioButton3.TabIndex = 27;
			this.mRadioButton3.TabStop = true;
			this.mRadioButton3.Text = "OptionC";
			this.mRadioButton3.UseVisualStyleBackColor = true;
			this.VisibleBindingProvider.SetVisibleBinding(this.mRadioButton3, "");
			// 
			// mTrackBar1
			// 
			this.ClickBindingProvider.SetClickBinding(this.mTrackBar1, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.mTrackBar1, "");
			this.mTrackBar1.Location = new System.Drawing.Point(256, 79);
			this.mTrackBar1.Name = "mTrackBar1";
			this.mTrackBar1.Size = new System.Drawing.Size(278, 45);
			this.mTrackBar1.TabIndex = 28;
			this.mTrackBar1.Value = 2;
			this.ValueBindingProvider.SetValueBinding(this.mTrackBar1, "SelectedIndex");
			this.VisibleBindingProvider.SetVisibleBinding(this.mTrackBar1, "");
			// 
			// mComboBox1
			// 
			this.ClickBindingProvider.SetClickBinding(this.mComboBox1, "");
			this.DataSourceBindingProvider.SetDataSourceBinding(this.mComboBox1, "Items");
			this.EnabledBindingProvider.SetEnabledBinding(this.mComboBox1, "");
			this.mComboBox1.FormattingEnabled = true;
			this.mComboBox1.Location = new System.Drawing.Point(256, 52);
			this.mComboBox1.Name = "mComboBox1";
			this.mComboBox1.Size = new System.Drawing.Size(278, 21);
			this.mComboBox1.TabIndex = 29;
			this.VisibleBindingProvider.SetVisibleBinding(this.mComboBox1, "");
			// 
			// mComboBox2
			// 
			this.ClickBindingProvider.SetClickBinding(this.mComboBox2, "");
			this.DataSourceBindingProvider.SetDataSourceBinding(this.mComboBox2, "Items");
			this.mComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.EnabledBindingProvider.SetEnabledBinding(this.mComboBox2, "");
			this.mComboBox2.FormattingEnabled = true;
			this.mComboBox2.Location = new System.Drawing.Point(256, 3);
			this.mComboBox2.Name = "mComboBox2";
			this.mComboBox2.Size = new System.Drawing.Size(278, 21);
			this.mComboBox2.TabIndex = 30;
			this.VisibleBindingProvider.SetVisibleBinding(this.mComboBox2, "");
			// 
			// mDateTimePicker1
			// 
			this.ClickBindingProvider.SetClickBinding(this.mDateTimePicker1, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.mDateTimePicker1, "");
			this.mDateTimePicker1.Location = new System.Drawing.Point(392, 246);
			this.mDateTimePicker1.Name = "mDateTimePicker1";
			this.mDateTimePicker1.Size = new System.Drawing.Size(285, 20);
			this.mDateTimePicker1.TabIndex = 31;
			this.ValueBindingProvider.SetValueBinding(this.mDateTimePicker1, "SampleDate");
			this.VisibleBindingProvider.SetVisibleBinding(this.mDateTimePicker1, "");
			// 
			// pictureBox1
			// 
			this.ClickBindingProvider.SetClickBinding(this.pictureBox1, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.pictureBox1, "");
			this.pictureBox1.Image = global::Playground.Properties.Resources.Logo;
			this.pictureBox1.Location = new System.Drawing.Point(5, 249);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 73);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 32;
			this.pictureBox1.TabStop = false;
			this.VisibleBindingProvider.SetVisibleBinding(this.pictureBox1, "IsEnabled");
			// 
			// hProgressBar1
			// 
			this.ClickBindingProvider.SetClickBinding(this.hProgressBar1, "");
			this.EnabledBindingProvider.SetEnabledBinding(this.hProgressBar1, "");
			this.hProgressBar1.Location = new System.Drawing.Point(256, 278);
			this.hProgressBar1.Name = "hProgressBar1";
			this.hProgressBar1.Size = new System.Drawing.Size(278, 23);
			this.hProgressBar1.TabIndex = 33;
			this.ValueBindingProvider.SetValueBinding(this.hProgressBar1, "SelectedIndex");
			this.VisibleBindingProvider.SetVisibleBinding(this.hProgressBar1, "");
			// 
			// hButton1
			// 
			this.ClickBindingProvider.SetClickBinding(this.hButton1, "PerformAction");
			this.EnabledBindingProvider.SetEnabledBinding(this.hButton1, "");
			this.hButton1.Location = new System.Drawing.Point(114, 278);
			this.hButton1.Name = "hButton1";
			this.hButton1.Size = new System.Drawing.Size(136, 53);
			this.hButton1.TabIndex = 34;
			this.hButton1.Text = "Perform controller action";
			this.hButton1.UseVisualStyleBackColor = true;
			this.VisibleBindingProvider.SetVisibleBinding(this.hButton1, "");
			// 
			// SampleView
			// 
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClickBindingProvider.SetClickBinding(this, "");
			this.Controls.Add(this.hButton1);
			this.Controls.Add(this.hProgressBar1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.mDateTimePicker1);
			this.Controls.Add(this.mComboBox2);
			this.Controls.Add(this.mComboBox1);
			this.Controls.Add(this.mTrackBar1);
			this.Controls.Add(this.mRadioButton3);
			this.Controls.Add(this.mRadioButton2);
			this.Controls.Add(this.mRadioButton1);
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
			this.EnabledBindingProvider.SetEnabledBinding(this, "");
			this.Name = "SampleView";
			this.Size = new System.Drawing.Size(680, 334);
			this.VisibleBindingProvider.SetVisibleBinding(this, "");
			((System.ComponentModel.ISupportInitialize)(this.mNumericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mTrackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox mTextBox4;
		private CheckBox enabler;
		private CheckBox mCheckBox3;
		private TextBox mTextBox3;
		private CheckBox mCheckBox2;
		private CheckBox mCheckBox1;
		private TextBox mTextBox2;
		private TextBox mTextBox1;
		private Button mButton1;
		private Button mButton2;
		private Button mButton3;
		private ListBox mListBox1;
		private Button mButton4;
		private TextBox mTextBox5;
		private NumericUpDown mNumericUpDown1;
		private RadioButton mRadioButton1;
		private RadioButton mRadioButton2;
		private RadioButton mRadioButton3;
		private TrackBar mTrackBar1;
		private ComboBox mComboBox1;
		private ComboBox mComboBox2;
		private DateTimePicker mDateTimePicker1;
		private PictureBox pictureBox1;
		private ProgressBar hProgressBar1;
		private Button hButton1;
	}
}
