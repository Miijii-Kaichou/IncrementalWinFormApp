using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blah
{
    public partial class Form1 : Form
    {
        Image[] images
        {
            get
            {
                int index = 1;
                string path = @"C:\Users\tclte\source\repos\Blah\IMG";
                return new Image[]
                {
                    Image.FromFile(path + index++ + ".png"),
                    Image.FromFile(path + index++ + ".png"),
                    Image.FromFile(path + index++ + ".png"),
                    Image.FromFile(path + index++ + ".png"),
                    Image.FromFile(path + index++ + ".png"),
                    Image.FromFile(path + index++ + ".png"),
                    Image.FromFile(path + index++ + ".png"),
                    Image.FromFile(path + index++ + ".png"),
                    Image.FromFile(path + index + ".png")
                };
            }
        }

        //Num1 for ForLoop
        //Num2 for WhileLoop
        int num1, num2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Our For-Loop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (num1 < pictureBoxes.Length + 1 && num1 > 0)
            {
                for (int i = 0; i < pictureBoxes.Length; i++)
                {
                    pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;

                    //Set the image
                    if (i < num1)
                    {
                        pictureBoxes[i].Image = images[i];
                    } else
                    {
                        pictureBoxes[i].Image = null;
                    }
                    
                } 
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out num1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out num1);
        }

        void ShowText(string input)
        {
            textBox2.Text = input+"\r";
        }
    }
}
