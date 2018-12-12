using System;
using System.Linq;
using System.Windows.Forms;

namespace NewtonProject4
{
	public partial class CourseForm : Form
	{
		private CustomClass1 _customClass1 = new CustomClass1();
		private CustomClass2 _customClass2 = new CustomClass2();

		public CourseForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
			this.coursesTableAdapter.Fill(this.studentCourseDataDataSet.Courses);

		}

		private void onlineButton_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void setBtn_Click(object sender, EventArgs e)
		{
			bool isGoodState = true;
			try
			{
				if (numCourseBox.Text == "" || studentName.Text == "")
				{
					//throws error for missing text inputs
					throw new MissingFieldException();
				}

			}

			catch (MissingFieldException)
			{
				//catches missing inputs
				MessageBox.Show("All text inputs must be filled in");
				isGoodState = false;
			}

			try
			{
				int hours = Convert.ToInt32(numCourseBox.Text);

			}

			catch
			{
				MessageBox.Show("Please enter an integer value.");
				isGoodState = false;
			}

			try
			{
				if (studentName.Text.All(c => Char.IsLetter(c) || c == ' '))
				{ }
				else
				{
					throw new FormatException();
				}
			}

			//Displays error for improper name format, must only contain letters and spaces
			catch (FormatException)
			{
				MessageBox.Show("Please enter a \"First Name\" \"Last Name\".");
				isGoodState = false;
			}

			if (isGoodState)
			{
				_customClass1.Hours = Convert.ToInt32(numCourseBox.Text);
				_customClass1.StudentName = studentName.Text;
				_customClass1.CourseDate = calendarBox.Value;
				_customClass1.CourseID = courseIDComboBox.Text;
				_customClass1.CourseType = onlineButton.Checked;
				//passes input data to CC1

				//checks for a change to the number of classes being taken
				if (_customClass1.Hours != _customClass2.Hours)
				{
					MessageBox.Show("Hours has changed to " + _customClass1.Hours);
					//displays change notification modal
				}



				_customClass2.Hours = _customClass1.Hours;
				_customClass2.StudentName = _customClass1.StudentName;
				_customClass2.CourseDate = _customClass1.CourseDate;
				_customClass2.CourseID = _customClass1.CourseID;
				_customClass2.CourseType = _customClass1.CourseType;
				//passes the data from CC1 to CC2
			}

				else
				{
					// do nothing unless all fields are valid
				}
		}


		//gets data from CC2 and writes to output boxes
		private void getBtn_Click(object sender, EventArgs e)
		{
			txtCourseNumOutput.Text = _customClass2.Hours.ToString();
			txtNameOutput.Text = _customClass2.StudentName;
			txtDateOutput.Text = _customClass2.CourseDate.ToString();
			txtCourseIDOutput.Text = _customClass2.CourseID;

			//checks radio button bool and returns correct text
			if (_customClass2.CourseType)
			{
				txtCourseTypeOutput.Text = "Online";
			}
			else
			{
				txtCourseTypeOutput.Text = "Hybrid";
			}
		}
	}
}
