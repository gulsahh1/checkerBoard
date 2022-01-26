using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();

        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0, left = 0;

            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left; // ilk butonu formda en sola yerleştirdik.
                    buttons[i, j].Top = top; // ilk satırda top sıfır
                    left += 50; // butonları 50 px artırarak yan yana yerleştirdik.
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;

                    }
                    this.Controls.Add(buttons[i, j]); // ekrana buton nesnesini yerleştirir 
                }
                top += 50; // satırları alt alta sıralamak için top' artırdık 
                left = 0; // her satıra 8 buton yerleştridikten sonra alt satırda en soldan başlaması için left'i sıfırladık.

            }
        }
    }
}
