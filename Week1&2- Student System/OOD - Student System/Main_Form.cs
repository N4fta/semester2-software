using OOD___Student_System.Classes;
using System;
using System.Diagnostics.Eventing.Reader;

namespace OOD___Student_System
{
    public partial class Main_Form : Form
    {
        Administration administration;
        public Main_Form()
        {
            InitializeComponent();
            administration = new Administration();
            cmbBxShowFilter.SelectedIndex = 0;
        }

        // Add Form
        private void rdBtnAddFormStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnAddFormStudent.Checked)
            {
                nudAddFormSalary.Enabled = false;
                nudAddFormECs.Enabled = true;
            }
            else
            {
                nudAddFormSalary.Enabled = true;
                nudAddFormECs.Enabled = false;
            }
        }
        private void btnNewPerson_Click(object sender, EventArgs e)
        {
            Person person;
            if (rdBtnAddFormStudent.Checked)
            {
                person = new Student(txtBxAddFormName.Text, (int)nudAddFormAge.Value, (int)nudAddFormPCN.Value, (int)nudAddFormYearsAtSchool.Value, (int)nudAddFormECs.Value);
            }
            else
            {
                person = new Teacher(txtBxAddFormName.Text, (int)nudAddFormAge.Value, (int)nudAddFormPCN.Value, (int)nudAddFormYearsAtSchool.Value, (double)nudAddFormSalary.Value);
            }
            if (!administration.AddPerson(person)) MessageBox.Show("PCN already in use");
        }

        // List Box functions
        private void RefreshListBox(Person[] displaySource)
        {
            lstBxMainDisplay.DataSource = null;
            lstBxMainDisplay.Items.Clear();
            lstBxMainDisplay.DataSource = displaySource;
        }
        private void RefreshListBox(Person displayItem)
        {
            lstBxMainDisplay.DataSource = null;
            lstBxMainDisplay.Items.Clear();
            lstBxMainDisplay.Items.Add(displayItem);
        }
        private void cmbBxShowFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxShowFilter.SelectedIndex == 0) RefreshListBox(administration.GetPersons());
            else if (cmbBxShowFilter.SelectedIndex == 1) RefreshListBox(administration.GetStudents());
            else RefreshListBox(administration.GetTeachers());
        }
        private void btnShowAllPesons_Click(object sender, EventArgs e)
        {
            RefreshListBox(administration.GetPersons());
        }
        private void btnSearchViaPartialName_Click(object sender, EventArgs e)
        {
            if (cmbBxShowFilter.SelectedIndex == 0) RefreshListBox(administration.GetPersons(txtBxPartialName.Text));
            else if (cmbBxShowFilter.SelectedIndex == 1) RefreshListBox(administration.GetStudents(txtBxPartialName.Text));
            else RefreshListBox(administration.GetTeachers(txtBxPartialName.Text));
        }

        // Action Form
        private Person? CheckPCN()
        {
            Person? p = administration.GetPerson((int)nudPCN.Value);
            if (p == null) MessageBox.Show("Person not found");
            return p;
        }
        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Person? p = CheckPCN();
            if (p != null) RefreshListBox(p);
        }
        private void btnCelebrateBirthday_Click(object sender, EventArgs e)
        {
            Person? p = CheckPCN();
            if (p != null) p.CelebrateBirthday();
        }
        private void btnStartNewSchoolyear_Click(object sender, EventArgs e)
        {
            Person? p = CheckPCN();
            if (p != null) p.StartAnotherSchoolyear();
        }
        private void btnAddECs_Click(object sender, EventArgs e)
        {
            Person? p = CheckPCN();
            if (p != null && p is Student) ((Student)p).AddECs((int)nudStudentECs.Value);
        }
        private void btnPromoteTeacher_Click(object sender, EventArgs e)
        {
            Person? p = CheckPCN();
            if (p != null && p is Teacher) ((Teacher)p).MakePromotion();
        }
    }
}
