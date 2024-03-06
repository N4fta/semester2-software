namespace Week14_Day1___Extending_Student_Group
{
    public partial class Form1 : Form
    {
        ProjectGroup projectGroup;
        public Form1()
        {
            InitializeComponent();
            projectGroup = new ProjectGroup("Test");
            cbxProjectGroup.Items.Add(projectGroup);
            cbxProjectGroup.SelectedItem = projectGroup;
        }

        private void cbxProjectGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxProjectGroup.DataSource = ((ProjectGroup)cbxProjectGroup.SelectedItem).GetMembers();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxStudentName.Text))
            {
                MessageBox.Show("Invalid Name");
                return;
            }
            if (cbxProjectGroup.SelectedItem==null)
            {
                MessageBox.Show("No Project Selected");
                return;
            }
            ((ProjectGroup)cbxProjectGroup.SelectedItem).AddMember(new Member(tbxStudentName.Text, Convert.ToInt32(nudStudentNumber.Value)));
            cbxProjectGroup_SelectedIndexChanged(sender, e);
        }
    }
}