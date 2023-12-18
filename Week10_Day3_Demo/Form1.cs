using System.Runtime.InteropServices;

namespace Demo_Day_3
{
    public partial class Form1 : Form
    {
        List<Students> listStudents = new List<Students>();
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students student = new Students();
            student.SetName(textBox1.Text);
            student.SetGrade(Convert.ToDouble(textBox2.Text));
            listStudents.Add(student);
        }

    }
}