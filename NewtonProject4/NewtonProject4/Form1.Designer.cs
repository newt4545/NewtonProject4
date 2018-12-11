namespace NewtonProject4
{
	partial class CourseForm
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
			this.components = new System.ComponentModel.Container();
			this.numCourseBox = new System.Windows.Forms.TextBox();
			this.studentName = new System.Windows.Forms.TextBox();
			this.calendarBox = new System.Windows.Forms.DateTimePicker();
			this.hybridButton = new System.Windows.Forms.RadioButton();
			this.onlineButton = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.setBtn = new System.Windows.Forms.Button();
			this.getBtn = new System.Windows.Forms.Button();
			this.studentCourseDataDataSet = new NewtonProject4.StudentCourseDataDataSet();
			this.studentCourseDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.coursesTableAdapter = new NewtonProject4.StudentCourseDataDataSetTableAdapters.CoursesTableAdapter();
			this.tableAdapterManager = new NewtonProject4.StudentCourseDataDataSetTableAdapters.TableAdapterManager();
			this.courseIDComboBox = new System.Windows.Forms.ComboBox();
			this.coursesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.txtCourseNumOutput = new System.Windows.Forms.TextBox();
			this.txtNameOutput = new System.Windows.Forms.TextBox();
			this.txtDateOutput = new System.Windows.Forms.TextBox();
			this.txtCourseIDOutput = new System.Windows.Forms.TextBox();
			this.txtCourseTypeOutput = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.studentCourseDataDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentCourseDataDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// numCourseBox
			// 
			this.numCourseBox.Location = new System.Drawing.Point(404, 94);
			this.numCourseBox.Name = "numCourseBox";
			this.numCourseBox.Size = new System.Drawing.Size(357, 31);
			this.numCourseBox.TabIndex = 0;
			// 
			// studentName
			// 
			this.studentName.Location = new System.Drawing.Point(404, 204);
			this.studentName.Name = "studentName";
			this.studentName.Size = new System.Drawing.Size(357, 31);
			this.studentName.TabIndex = 1;
			// 
			// calendarBox
			// 
			this.calendarBox.Location = new System.Drawing.Point(404, 310);
			this.calendarBox.MaxDate = new System.DateTime(2019, 1, 31, 0, 0, 0, 0);
			this.calendarBox.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
			this.calendarBox.Name = "calendarBox";
			this.calendarBox.Size = new System.Drawing.Size(357, 31);
			this.calendarBox.TabIndex = 2;
			this.calendarBox.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
			// 
			// hybridButton
			// 
			this.hybridButton.AutoSize = true;
			this.hybridButton.Location = new System.Drawing.Point(404, 565);
			this.hybridButton.Name = "hybridButton";
			this.hybridButton.Size = new System.Drawing.Size(105, 29);
			this.hybridButton.TabIndex = 4;
			this.hybridButton.Text = "Hybrid";
			this.hybridButton.UseVisualStyleBackColor = true;
			// 
			// onlineButton
			// 
			this.onlineButton.AutoSize = true;
			this.onlineButton.Checked = true;
			this.onlineButton.Location = new System.Drawing.Point(656, 565);
			this.onlineButton.Name = "onlineButton";
			this.onlineButton.Size = new System.Drawing.Size(105, 29);
			this.onlineButton.TabIndex = 5;
			this.onlineButton.TabStop = true;
			this.onlineButton.Text = "Online";
			this.onlineButton.UseVisualStyleBackColor = true;
			this.onlineButton.CheckedChanged += new System.EventHandler(this.onlineButton_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(341, 25);
			this.label1.TabIndex = 6;
			this.label1.Text = "Number of Courses This Semester";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(243, 210);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 25);
			this.label2.TabIndex = 7;
			this.label2.Text = "Name (F/L)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(173, 316);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(189, 25);
			this.label3.TabIndex = 8;
			this.label3.Text = "Date of First Class";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(186, 430);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(176, 25);
			this.label4.TabIndex = 9;
			this.label4.Text = "Course Selection";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(183, 569);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(179, 25);
			this.label5.TabIndex = 10;
			this.label5.Text = "Hybrid or Online?";
			// 
			// setBtn
			// 
			this.setBtn.Location = new System.Drawing.Point(178, 671);
			this.setBtn.Name = "setBtn";
			this.setBtn.Size = new System.Drawing.Size(231, 52);
			this.setBtn.TabIndex = 11;
			this.setBtn.Text = "Set";
			this.setBtn.UseVisualStyleBackColor = true;
			this.setBtn.Click += new System.EventHandler(this.setBtn_Click);
			// 
			// getBtn
			// 
			this.getBtn.Location = new System.Drawing.Point(546, 671);
			this.getBtn.Name = "getBtn";
			this.getBtn.Size = new System.Drawing.Size(215, 52);
			this.getBtn.TabIndex = 12;
			this.getBtn.Text = "Get";
			this.getBtn.UseVisualStyleBackColor = true;
			this.getBtn.Click += new System.EventHandler(this.getBtn_Click);
			// 
			// studentCourseDataDataSet
			// 
			this.studentCourseDataDataSet.DataSetName = "StudentCourseDataDataSet";
			this.studentCourseDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// studentCourseDataDataSetBindingSource
			// 
			this.studentCourseDataDataSetBindingSource.DataSource = this.studentCourseDataDataSet;
			this.studentCourseDataDataSetBindingSource.Position = 0;
			// 
			// coursesBindingSource
			// 
			this.coursesBindingSource.DataMember = "Courses";
			this.coursesBindingSource.DataSource = this.studentCourseDataDataSet;
			// 
			// coursesTableAdapter
			// 
			this.coursesTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CoursesTableAdapter = this.coursesTableAdapter;
			this.tableAdapterManager.StudentsTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = NewtonProject4.StudentCourseDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// courseIDComboBox
			// 
			this.courseIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CourseID", true));
			this.courseIDComboBox.DataSource = this.coursesBindingSource1;
			this.courseIDComboBox.DisplayMember = "CourseID";
			this.courseIDComboBox.FormattingEnabled = true;
			this.courseIDComboBox.Location = new System.Drawing.Point(449, 427);
			this.courseIDComboBox.Name = "courseIDComboBox";
			this.courseIDComboBox.Size = new System.Drawing.Size(312, 33);
			this.courseIDComboBox.TabIndex = 13;
			// 
			// coursesBindingSource1
			// 
			this.coursesBindingSource1.DataMember = "Courses";
			this.coursesBindingSource1.DataSource = this.studentCourseDataDataSetBindingSource;
			// 
			// txtCourseNumOutput
			// 
			this.txtCourseNumOutput.Location = new System.Drawing.Point(1032, 94);
			this.txtCourseNumOutput.Name = "txtCourseNumOutput";
			this.txtCourseNumOutput.Size = new System.Drawing.Size(303, 31);
			this.txtCourseNumOutput.TabIndex = 14;
			// 
			// txtNameOutput
			// 
			this.txtNameOutput.Location = new System.Drawing.Point(1032, 203);
			this.txtNameOutput.Name = "txtNameOutput";
			this.txtNameOutput.Size = new System.Drawing.Size(303, 31);
			this.txtNameOutput.TabIndex = 15;
			// 
			// txtDateOutput
			// 
			this.txtDateOutput.Location = new System.Drawing.Point(1032, 310);
			this.txtDateOutput.Name = "txtDateOutput";
			this.txtDateOutput.Size = new System.Drawing.Size(303, 31);
			this.txtDateOutput.TabIndex = 16;
			// 
			// txtCourseIDOutput
			// 
			this.txtCourseIDOutput.Location = new System.Drawing.Point(1032, 427);
			this.txtCourseIDOutput.Name = "txtCourseIDOutput";
			this.txtCourseIDOutput.Size = new System.Drawing.Size(303, 31);
			this.txtCourseIDOutput.TabIndex = 17;
			// 
			// txtCourseTypeOutput
			// 
			this.txtCourseTypeOutput.Location = new System.Drawing.Point(1032, 562);
			this.txtCourseTypeOutput.Name = "txtCourseTypeOutput";
			this.txtCourseTypeOutput.Size = new System.Drawing.Size(303, 31);
			this.txtCourseTypeOutput.TabIndex = 18;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(1074, 44);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(213, 25);
			this.label6.TabIndex = 19;
			this.label6.Text = "Course Data Outputs";
			// 
			// CourseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1462, 831);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtCourseTypeOutput);
			this.Controls.Add(this.txtCourseIDOutput);
			this.Controls.Add(this.txtDateOutput);
			this.Controls.Add(this.txtNameOutput);
			this.Controls.Add(this.txtCourseNumOutput);
			this.Controls.Add(this.courseIDComboBox);
			this.Controls.Add(this.getBtn);
			this.Controls.Add(this.setBtn);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.onlineButton);
			this.Controls.Add(this.hybridButton);
			this.Controls.Add(this.calendarBox);
			this.Controls.Add(this.studentName);
			this.Controls.Add(this.numCourseBox);
			this.Name = "CourseForm";
			this.Text = "Course Data";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.studentCourseDataDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentCourseDataDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox numCourseBox;
		private System.Windows.Forms.TextBox studentName;
		private System.Windows.Forms.DateTimePicker calendarBox;
		private System.Windows.Forms.RadioButton hybridButton;
		private System.Windows.Forms.RadioButton onlineButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button setBtn;
		private System.Windows.Forms.Button getBtn;
		private StudentCourseDataDataSet studentCourseDataDataSet;
		private System.Windows.Forms.BindingSource studentCourseDataDataSetBindingSource;
		private System.Windows.Forms.BindingSource coursesBindingSource;
		private StudentCourseDataDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
		private StudentCourseDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.ComboBox courseIDComboBox;
		private System.Windows.Forms.BindingSource coursesBindingSource1;
		private System.Windows.Forms.TextBox txtCourseNumOutput;
		private System.Windows.Forms.TextBox txtNameOutput;
		private System.Windows.Forms.TextBox txtDateOutput;
		private System.Windows.Forms.TextBox txtCourseIDOutput;
		private System.Windows.Forms.TextBox txtCourseTypeOutput;
		private System.Windows.Forms.Label label6;
	}
}

