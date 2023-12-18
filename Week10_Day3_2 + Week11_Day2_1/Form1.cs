namespace Week10_Day3_2
{
    public partial class Form1 : Form
    {
        List<Course> CourseList = new List<Course>() { null };
        public Form1()
        {
            InitializeComponent();
        }

        private void btCreateCourse_Click(object sender, EventArgs e)
        {
            try
            {
                CourseList.Add(new Course(tbCourseName.Text, Convert.ToInt32(tbCourseECs.Text)));
                int indexNewCourse = CourseList.Count - 1;
                lvCourses.Items.Add(CourseList[indexNewCourse].ToString());
            }
            catch
            {
                lblInformationOnCourse.Text = "Input Invalid";
            }
        }

        private void btShowInformationOnCourse_Click(object sender, EventArgs e)
        {
            if (CourseList.Count == 1)
            {
                lblInformationOnCourse.Text = "No Courses";
            }
            else if (lvCourses.SelectedIndices.Count != 0)
            {
                Course selectedCourse = CourseList[lvCourses.SelectedIndices[0] + 1];
                string infoToDisplay = $"Course: {selectedCourse.GetName()}\r\nECs: {selectedCourse.GetEc()}";
                lblInformationOnCourse.Text = infoToDisplay;
            }
            else
            {
                lblInformationOnCourse.Text = "No Course Selected";
            }
        }
    }
}