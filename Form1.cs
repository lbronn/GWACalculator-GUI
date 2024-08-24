using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GWACalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            title.ForeColor = Color.Black;

            txtBoxSubject.Text = "Enter subject";
            txtBoxUnit.Text = "Enter no. of units";
            txtBoxGrade.Text = "Enter grade";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcGWATotalPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void calcGWAPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addSubjButton_Click(object sender, EventArgs e)
        {
            int txtBoxCtr = calcGWAPanel.Controls.OfType<TextBox>().Count() / 3;
            int vertDistance = (txtBoxSubject.Height + 10) * (txtBoxCtr + 1);

            //New textbox for adding new subject/s
            TextBox txtBoxSubjNew = new TextBox
            {
                Name = "txtBoxSubject" + txtBoxCtr,
                Size = txtBoxSubject.Size,
                Location = new Point(txtBoxSubject.Location.X, txtBoxSubject.Location.Y + vertDistance),
                Text = "Enter subject",
                ForeColor = Color.LightGray,
                BorderStyle = BorderStyle.FixedSingle
            };
            txtBoxSubjNew.Enter += new EventHandler(txtBoxSubject_Enter);
            txtBoxSubjNew.Leave += new EventHandler(txtBoxSubject_Leave);

            //New textbox for adding new subject/s
            TextBox txtBoxUnitNew = new TextBox
            {
                Name = "txtBoxUnit" + txtBoxCtr,
                Size = txtBoxUnit.Size,
                Location = new Point(txtBoxUnit.Location.X, txtBoxUnit.Location.Y + vertDistance),
                Text = "Enter no. of units",
                ForeColor = Color.LightGray,
                BorderStyle = BorderStyle.FixedSingle
            };
            txtBoxUnitNew.Enter += new EventHandler(txtBoxUnit_Enter);
            txtBoxUnitNew.Leave += new EventHandler(txtBoxUnit_Leave);

            //New textbox for adding new subject/s
            TextBox txtBoxGradeNew = new TextBox
            {
                Name = "txtBoxSubject" + txtBoxCtr,
                Size = txtBoxGrade.Size,
                Location = new Point(txtBoxGrade.Location.X, txtBoxGrade.Location.Y + vertDistance),
                Text = "Enter grade",
                ForeColor = Color.LightGray,
                BorderStyle = BorderStyle.FixedSingle
            };
            txtBoxGradeNew.Enter += new EventHandler(txtBoxGrade_Enter);
            txtBoxGradeNew.Leave += new EventHandler(txtBoxGrade_Leave);

            //New clear button for each subject/s added
            Button clearSubButtonNew = new Button
            {
                Name = "clearSubButton" + txtBoxCtr,
                Size = clearSubButton.Size,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular),
                Location = new Point(clearSubButton.Location.X, clearSubButton.Location.Y + vertDistance),
                Text = "CLEAR",
                BackColor = Color.Red,
                Cursor = Cursors.Hand,
                Tag = txtBoxCtr
            };
            clearSubButtonNew.Click += new EventHandler(clearSubButton_Click);

            //Show the new textbox/es and clear button/s inside the panel
            calcGWAPanel.Controls.Add(txtBoxSubjNew);
            calcGWAPanel.Controls.Add(txtBoxUnitNew);
            calcGWAPanel.Controls.Add(txtBoxGradeNew);
            calcGWAPanel.Controls.Add(clearSubButtonNew);
        }

        private void calcGWAButton_Click(object sender, EventArgs e)
        {

        }

        private void clearSubButton_Click(object sender, EventArgs e)
        {
            Button clickedSubButton = sender as Button;

            if(clickedSubButton != null)
            {
                int setIndex = (int)clickedSubButton.Tag;

                List<Control> txtBoxesToRemove = new List<Control>();
                foreach(Control txtBoxes in calcGWAPanel.Controls)
                {
                    if(txtBoxes is TextBox && (txtBoxes.Name == "txtBoxSubject" + setIndex || txtBoxes.Name == "txtBoxUnit" + setIndex || txtBoxes.Name == "txtBoxGrade" + setIndex))
                    {
                        txtBoxesToRemove.Add(txtBoxes);
                    }
                }

                txtBoxesToRemove.Add(clickedSubButton);

                foreach(Control txtBoxes in txtBoxesToRemove)
                {
                    calcGWAPanel.Controls.Remove(txtBoxes);
                }
            }
        }

        private void txtBoxSubject_Enter(object sender, EventArgs e)
        {
            if(txtBoxSubject.Text == "Enter subject")
            {
                txtBoxSubject.Text = "";
                txtBoxSubject.ForeColor = Color.Black;
            }
        }

        private void txtBoxSubject_Leave(object sender, EventArgs e)
        {
            if (txtBoxSubject.Text == "")
            {
                txtBoxSubject.Text = "Enter subject";
                txtBoxSubject.ForeColor = Color.LightGray;
            }
        }

        private void txtBoxUnit_Enter(object sender, EventArgs e)
        {
            if (txtBoxUnit.Text == "Enter no. of units")
            {
                txtBoxUnit.Text = "";
                txtBoxUnit.ForeColor = Color.Black;
            }
        }

        private void txtBoxUnit_Leave(object sender, EventArgs e)
        {
            if (txtBoxUnit.Text == "")
            {
                txtBoxUnit.Text = "Enter no. of units";
                txtBoxUnit.ForeColor = Color.LightGray;
            }
        }

        private void txtBoxGrade_Enter(object sender, EventArgs e)
        {
            if (txtBoxGrade.Text == "Enter grade")
            {
                txtBoxGrade.Text = "";
                txtBoxGrade.ForeColor = Color.Black;
            }
        }

        private void txtBoxGrade_Leave(object sender, EventArgs e)
        {
            if (txtBoxGrade.Text == "")
            {
                txtBoxGrade.Text = "Enter grade";
                txtBoxGrade.ForeColor = Color.LightGray;
            }
        }

        
    }
}
