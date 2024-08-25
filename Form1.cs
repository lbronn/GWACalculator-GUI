using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
            txtBoxSubject.Text = "Enter subject code";
            txtBoxUnit.Text = "Enter no. of units";
            txtBoxGrade.Text = "Enter grade";
        }

        private void txtBoxSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxUnit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayGWA_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcGWAPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void calcGWAYear_Enter(object sender, EventArgs e)
        {

        }

        private void addSubjButton_Click(object sender, EventArgs e)
        {
            int txtBoxCtr = calcGWAPanel.Controls.OfType<System.Windows.Forms.TextBox>().Count() / 3;
            int vertDistance = (txtBoxSubject.Height + 10) * txtBoxCtr;

            //New textbox for adding new subject/s
            System.Windows.Forms.TextBox txtBoxSubjNew = new System.Windows.Forms.TextBox
            {
                Name = "txtBoxSubject" + txtBoxCtr,
                Size = txtBoxSubject.Size,
                Location = new Point(txtBoxSubject.Location.X, txtBoxSubject.Location.Y + vertDistance),
                Text = "Enter subject code",
                TextAlign = HorizontalAlignment.Center,
                ForeColor = Color.LightGray,
                BorderStyle = BorderStyle.FixedSingle
            };
            txtBoxSubjNew.Enter += new EventHandler(txtBoxSubject_Enter);
            txtBoxSubjNew.Leave += new EventHandler(txtBoxSubject_Leave);

            //New textbox for adding new unit/s
            System.Windows.Forms.TextBox txtBoxUnitNew = new System.Windows.Forms.TextBox
            {
                Name = "txtBoxUnit" + txtBoxCtr,
                Size = txtBoxUnit.Size,
                Location = new Point(txtBoxUnit.Location.X, txtBoxUnit.Location.Y + vertDistance),
                Text = "Enter no. of units",
                TextAlign = HorizontalAlignment.Center,
                ForeColor = Color.LightGray,
                BorderStyle = BorderStyle.FixedSingle
            };
            txtBoxUnitNew.Enter += new EventHandler(txtBoxUnit_Enter);
            txtBoxUnitNew.Leave += new EventHandler(txtBoxUnit_Leave);

            //New textbox for adding new grade/s
            System.Windows.Forms.TextBox txtBoxGradeNew = new System.Windows.Forms.TextBox
            {
                Name = "txtBoxGrade" + txtBoxCtr,
                Size = txtBoxGrade.Size,
                Location = new Point(txtBoxGrade.Location.X, txtBoxGrade.Location.Y + vertDistance),
                Text = "Enter grade",
                TextAlign = HorizontalAlignment.Center,
                ForeColor = Color.LightGray,
                BorderStyle = BorderStyle.FixedSingle
            };
            txtBoxGradeNew.Enter += new EventHandler(txtBoxGrade_Enter);
            txtBoxGradeNew.Leave += new EventHandler(txtBoxGrade_Leave);

            //New clear button for each subject/s added
            System.Windows.Forms.Button clearSubButtonNew = new System.Windows.Forms.Button
            {
                Name = "clearSubButton" + txtBoxCtr,
                Size = clearSubButton.Size,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold),
                Location = new Point(clearSubButton.Location.X, clearSubButton.Location.Y + vertDistance),
                Text = "REMOVE",
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
            double unit = 0.0, totalUnits = 0.0, grade = 0.0, totalGrade = 0.0, gwa = 0.0, finalGWA = 0;
            int subjectLength = 0;

            //Get the text from the textboxes
            foreach(Control textBoxes in calcGWAPanel.Controls)
            {
                if(textBoxes is System.Windows.Forms.TextBox txtBoxes)
                {
                    if(txtBoxes.Name.StartsWith("txtBoxUnit"))
                    {
                        if(double.TryParse(txtBoxes.Text, out unit))
                        {
                            string gradeName = txtBoxes.Name.Replace("txtBoxUnit", "txtBoxGrade");
                            System.Windows.Forms.TextBox gradeTextBox = calcGWAPanel.Controls.OfType<System.Windows.Forms.TextBox>().FirstOrDefault(txtBox  => txtBox.Name == gradeName);
                            
                            if(gradeTextBox != null && double.TryParse(gradeTextBox.Text, out grade))
                            {
                                totalGrade += unit * grade;
                                totalUnits += unit;
                                subjectLength++;
                                gwa = totalGrade / totalUnits;
                                finalGWA = Math.Round(gwa, 3);
                            }
                        }
                    }
                }
            }

            //Displays the GWA
            gwa.ToString();
            if(subjectLength > 0)
            {
                displayGWA.Text = "Your GWA is: " + finalGWA;
            } else
            {
                gwa = 0.0;
                displayGWA.Text = "Your GWA is: " + finalGWA;
            }
        }

        private void clearSubButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedSubButton = sender as System.Windows.Forms.Button;

            if(clickedSubButton != null)
            {
                int setIndex = (int)clickedSubButton.Tag;

                List<Control> txtBoxesToRemove = new List<Control>();
                foreach(Control txtBoxes in calcGWAPanel.Controls)
                {
                    if(txtBoxes is System.Windows.Forms.TextBox && (txtBoxes.Name == "txtBoxSubject" + setIndex || txtBoxes.Name == "txtBoxUnit" + setIndex || txtBoxes.Name == "txtBoxGrade" + setIndex))
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

        private void clrAllButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedClearAllButton = sender as System.Windows.Forms.Button;
            
            if(clickedClearAllButton != null)
            {
                foreach(Control txtBoxes in calcGWAPanel.Controls)
                {
                    if(txtBoxes is System.Windows.Forms.TextBox txtBox)
                    {
                        if(txtBox.Name.StartsWith("txtBoxSubject")) {
                            txtBox.Text = "Enter subject code";
                            txtBox.ForeColor = Color.LightGray;
                        }
                        else if (txtBox.Name.StartsWith("txtBoxUnit"))
                        {
                            txtBox.Text = "Enter no. of units";
                            txtBox.ForeColor = Color.LightGray;
                        }
                        else if (txtBox.Name.StartsWith("txtBoxGrade"))
                        {
                            txtBox.Text = "Enter grade";
                            txtBox.ForeColor = Color.LightGray;
                        } else
                        {
                            txtBox.Clear();
                        }
                    }
                }
            }
        }

        private void txtBoxSubject_Enter(object sender, EventArgs e)
        {
            if(sender is System.Windows.Forms.TextBox txtBoxSubject && txtBoxSubject.Text == "Enter subject code")
            {
                txtBoxSubject.Text = "";
                txtBoxSubject.ForeColor = Color.Black;
            }
        }

        private void txtBoxSubject_Leave(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox txtBoxSubject && txtBoxSubject.Text == "")
            {
                txtBoxSubject.Text = "Enter subject code";
                txtBoxSubject.ForeColor = Color.LightGray;
            }
        }

        private void txtBoxUnit_Enter(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox txtBoxUnit && txtBoxUnit.Text == "Enter no. of units")
            {
                txtBoxUnit.Text = "";
                txtBoxUnit.ForeColor = Color.Black;
            }
        }

        private void txtBoxUnit_Leave(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox txtBoxUnit && txtBoxUnit.Text == "")
            {
                txtBoxUnit.Text = "Enter no. of units";
                txtBoxUnit.ForeColor = Color.LightGray;
            }
        }

        private void txtBoxGrade_Enter(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox txtBoxGrade && txtBoxGrade.Text == "Enter grade")
            {
                txtBoxGrade.Text = "";
                txtBoxGrade.ForeColor = Color.Black;
            }
        }

        private void txtBoxGrade_Leave(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox txtBoxGrade && txtBoxGrade.Text == "")
            {
                txtBoxGrade.Text = "Enter grade";
                txtBoxGrade.ForeColor = Color.LightGray;
            }
        }
    }
}
