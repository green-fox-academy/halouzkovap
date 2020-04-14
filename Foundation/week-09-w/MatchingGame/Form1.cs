using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        Label firstClick = null;
        Label secondClick = null;

        Random random = new Random();

        List<string> icons = new List<string>()
        {
            "!","!",
            "w","w",
            "a","a",
            "l","l",
            "k","k",
            "j","j",
            "h","h",
            "f","f",
        };

        public Form1()
        {
            InitializeComponent();
            AssignIconeToLabel();

        }
        private void AssignIconeToLabel()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNum = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNum];

                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNum);
                }
            }
        }

        private void label_click(object sender, EventArgs e)
        {
            Label labelClick = sender as Label;
            if (timer1.Enabled == true)
                return;

            if (labelClick != null)
            {
                if (labelClick.ForeColor == Color.Black)
                    return;

                if (firstClick == null)
                {
                    firstClick = labelClick;
                    firstClick.ForeColor = Color.Black;
                    return;
                }


                secondClick = labelClick;
                secondClick.ForeColor = Color.Black;


                CheckWinner();

                if (firstClick.Text == secondClick.Text)
                {
                    firstClick = null;
                    secondClick = null;
                    return;
                }


                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClick.ForeColor = firstClick.BackColor;
            secondClick.ForeColor = secondClick.BackColor;
            firstClick = null;
            secondClick = null;
        }

        private void CheckWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                    {
                        return;
                    }
                }
            }
            MessageBox.Show("You win");
            Close();
        }
    }
}
