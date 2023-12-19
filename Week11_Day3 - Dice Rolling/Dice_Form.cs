using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week11_Day3_2___Dice_Rolling
{
    public partial class Dice_Form : Form
    {
        public Dice_Form()
        {
            InitializeComponent();
            Random random = new Random();
            switch (random.Next(6))
            {
                case 0:
                    pictureBox1.ImageLocation = "Resources/DiceFace1.png";
                    return;
                case 1:
                    pictureBox1.ImageLocation = "Resources/DiceFace2.png";
                    return;
                case 2:
                    pictureBox1.ImageLocation = "Resources/DiceFace3.png";
                    return;
                case 3:
                    pictureBox1.ImageLocation = "Resources/DiceFace4.png";
                    return;
                case 4:
                    pictureBox1.ImageLocation = "Resources/DiceFace5.png";
                    return;
                case 5:
                    pictureBox1.ImageLocation = "Resources/DiceFace6.png";
                    return;
            }
        }
    }
}
