using OOD___Animals___Inheritence;

namespace OOD___Animals___Inheritance
{
    public partial class Form1 : Form
    {
        PetShop petShop;
        public Form1()
        {
            InitializeComponent();
            petShop = new PetShop();
            lstBxAnimals.DataSource = petShop.GetList();
            cmbBxClasses.Items.AddRange(new string[] { "Cat", "Dog", "Turtle" });
        }

        private void cmbBxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxClasses.SelectedItem.ToString() == "Cat")
            {
                nudAge.Maximum = 25;
            }
            if (cmbBxClasses.SelectedItem.ToString() == "Dog")
            {
                nudAge.Maximum = 20;
            }
            if (cmbBxClasses.SelectedItem.ToString() == "Turtle")
            {
                nudAge.Maximum = 200;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cmbBxClasses.SelectedItem != null)
            {
                if (cmbBxClasses.SelectedItem.ToString() == "Cat")
                {
                    petShop.Add(new Cat(tbName.Text, Convert.ToInt32(nudAge.Value)));
                }
                if (cmbBxClasses.SelectedItem.ToString() == "Dog")
                {
                    petShop.Add(new Dog(tbName.Text, Convert.ToInt32(nudAge.Value)));
                }
                if (cmbBxClasses.SelectedItem.ToString() == "Turtle")
                {
                    petShop.Add(new Turtle(tbName.Text, Convert.ToInt32(nudAge.Value)));
                }
            }
            lstBxAnimals.DataSource = null;
            lstBxAnimals.DataSource = petShop.GetList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstBxAnimals.SelectedItems != null)
            {
                petShop.Remove((Animal)lstBxAnimals.SelectedItem);
            }
            lstBxAnimals.DataSource = null;
            lstBxAnimals.DataSource = petShop.GetList();
        }

        private void btnCelebrateBirthday_Click(object sender, EventArgs e)
        {
            if (lstBxAnimals.SelectedItems != null)
            {
                ((Animal)lstBxAnimals.SelectedItem).CelebrateBirthday();
            }
            lstBxAnimals.DataSource = null;
            lstBxAnimals.DataSource = petShop.GetList();
        }
    }
}
