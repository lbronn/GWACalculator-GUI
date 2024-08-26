/*
 * Made By: Le Bronn A. Samson
 * Last Date Modified: August 27, 2024 12:08 AM
 * GWA Calculator GUI on C# .Net Framework
 * Personal Project Purposes Only
 */

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
            txtBoxSubject.Text = "e.g. CS497";
            txtBoxUnit.Text = "e.g. 3";
            txtBoxGrade.Text = "e.g. 3.0";
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
                Text = "e.g. CS497",
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
                Text = "e.g. 3",
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
                Text = "e.g. 3.0",
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

            //Show the new textbox/es and clear button/s inside the panel if less than 12 subject/s added
            if(txtBoxCtr < 12)
            {
                calcGWAPanel.Controls.Add(txtBoxSubjNew);
                calcGWAPanel.Controls.Add(txtBoxUnitNew);
                calcGWAPanel.Controls.Add(txtBoxGradeNew);
                calcGWAPanel.Controls.Add(clearSubButtonNew);
            } 
            else
            {
                MessageBox.Show("You have reached the maximum number of subjects to add.", "Warning for Maximum Subjects", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
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
                    if(!(txtBoxes.Text == "e.g. CS497" || txtBoxes.Text == "e.g. 3" || txtBoxes.Text == "e.g. 3.0"))
                    {
                        if (txtBoxes.Name.StartsWith("txtBox"))
                        {
                            if (!double.TryParse(txtBoxes.Text, out unit) || !double.TryParse(txtBoxes.Text, out grade))
                            {
                                MessageBox.Show("Please input a valid number for the unit and grade.", "Warning for Invalid Unit and Grade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtBoxes.Clear();
                                return;
                            }
                        }
                        else
                        {
                            if (txtBoxes.Name.StartsWith("txtBoxUnit"))
                            {
                                if (double.TryParse(txtBoxes.Text, out unit))
                                {
                                    string gradeName = txtBoxes.Name.Replace("txtBoxUnit", "txtBoxGrade");
                                    System.Windows.Forms.TextBox gradeTextBox = calcGWAPanel.Controls.OfType<System.Windows.Forms.TextBox>().FirstOrDefault(txtBox => txtBox.Name == gradeName);

                                    if (gradeTextBox != null && double.TryParse(gradeTextBox.Text, out grade))
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
                    else
                    {
                        MessageBox.Show("Please fill in all the fields.", "Warning for Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            //Displays the GWA
            gwa.ToString();
            if(subjectLength > 0)
            {
                displayGWA.Text = "Your GWA is: " + finalGWA;
            } 
            else
            {
                gwa = 0.0;
                displayGWA.Text = "Your GWA is: " + finalGWA;
            }
        }

        private void clearSubButton_Click(object sender, EventArgs e)
        {
            if(sender is System.Windows.Forms.Button clickedSubButton)
            {
                //Prevents the user from removing the first subject
                if (clickedSubButton.Tag == null)
                {
                    MessageBox.Show("You cannot remove the first subject.", "Warning for Removing First Subject", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                } 
                else
                {
                    //Adds 'remove' button together with the textboxes
                    int setIndex = (int)clickedSubButton.Tag;

                    List<Control> txtBoxesToRemove = new List<Control>();
                    foreach (Control txtBoxes in calcGWAPanel.Controls)
                    {
                        if (txtBoxes is System.Windows.Forms.TextBox && (txtBoxes.Name == "txtBoxSubject" + setIndex || txtBoxes.Name == "txtBoxUnit" + setIndex || txtBoxes.Name == "txtBoxGrade" + setIndex))
                        {
                            txtBoxesToRemove.Add(txtBoxes);
                        }
                    }

                    txtBoxesToRemove.Add(clickedSubButton);

                    foreach (Control txtBoxes in txtBoxesToRemove)
                    {
                        calcGWAPanel.Controls.Remove(txtBoxes);
                    }
                }
            }
        }

        private void clrAllButton_Click(object sender, EventArgs e)
        {
            //Clears all texts in textboxes inside the panel
            if(sender is System.Windows.Forms.Button clickedClearAllButton)
            {
                foreach (Control txtBoxes in calcGWAPanel.Controls)
                {
                    if(txtBoxes is System.Windows.Forms.TextBox txtBox)
                    {
                        if(txtBox.Name.StartsWith("txtBoxSubject"))
                        {
                            txtBox.Text = "e.g. CS497";
                            txtBox.ForeColor = Color.LightGray;
                        }
                        else if(txtBox.Name.StartsWith("txtBoxUnit"))
                        {
                            txtBox.Text = "e.g. 3";
                            txtBox.ForeColor = Color.LightGray;
                        }
                        else if(txtBox.Name.StartsWith("txtBoxGrade"))
                        {
                            txtBox.Text = "e.g. 3.0";
                            txtBox.ForeColor = Color.LightGray;
                        }
                        else
                        {
                            txtBox.Clear();
                        }
                    }
                }
            }
        }

        private void calcGWAYearButton_Click(object sender, EventArgs e)
        {
            double gwaFirstSem = 0.0, gwaSecondSem = 0.0, totalGrade = 0.0, gwa = 0.0, finalGWA = 0;
            string acadYear = txtBoxYear.Text;
            bool isValidGWA = false;

            //Get the text from the textboxes
            foreach (Control textBoxes in calcGWAYear.Controls)
            {
                if(textBoxes is System.Windows.Forms.TextBox txtBoxes)
                {
                    //Checks if the textboxes are empty
                    if (txtBoxes.Text == "" && !txtBoxes.Name.StartsWith("displayGWAYear"))
                    {
                        MessageBox.Show("Please fill in all the fields.", "Warning for Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    //Checks if the textbox for first semester GWA is valid
                    if (txtBoxes.Name.StartsWith("txtBoxGWAFrstSem"))
                    {
                        if(!double.TryParse(txtBoxes.Text, out gwaFirstSem))
                        {
                            isValidGWA = true;
                            txtBoxes.Clear();
                        }
                        else
                        {
                            isValidGWA = false;
                            double.TryParse(txtBoxes.Text, out gwaFirstSem);
                        }
                    }
                    //Checks if the textbox for second semester GWA is valid
                    if (txtBoxes.Name.StartsWith("txtBoxGWAScndSem"))
                    {
                        if (!double.TryParse(txtBoxes.Text, out gwaSecondSem))
                        {
                            isValidGWA = true;
                            txtBoxes.Clear();
                        } 
                        else
                        {
                            isValidGWA = false;
                            double.TryParse(txtBoxes.Text, out gwaSecondSem);
                        }
                    }
                }

                totalGrade = gwaFirstSem + gwaSecondSem;
                gwa = totalGrade / 2;
                finalGWA = Math.Round(gwa, 3);
            }

            //Displays the GWA if it is valid and not empty
            if (isValidGWA == false && gwaFirstSem > 0 && gwaSecondSem > 0)
            {
                gwa.ToString();
                displayGWAYear.Text = "Your " + acadYear + " GWA is: " + finalGWA;
            } 
            else
            {
                MessageBox.Show("Please enter a valid number for all GWA fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void clrAllGWAYearButton_Click(object sender, EventArgs e)
        {
            //Clears all texts in textboxes inside the panel
            if (sender is System.Windows.Forms.Button clickedClearGWAYearButton)
            {
                foreach (Control txtBoxes in calcGWAYear.Controls)
                {
                    if(txtBoxes is System.Windows.Forms.TextBox txtBox)
                    {
                        txtBox.Clear();
                    }
                }
            }
        }

        //Event Handlers for the textboxes
        private void txtBoxSubject_Enter(object sender, EventArgs e)
        {
            if(sender is System.Windows.Forms.TextBox txtBoxSubject && txtBoxSubject.Text == "e.g. CS497")
            {
                txtBoxSubject.Text = "";
                txtBoxSubject.ForeColor = Color.Black;
            }
        }

        private void txtBoxSubject_Leave(object sender, EventArgs e)
        {
            if(sender is System.Windows.Forms.TextBox txtBoxSubject && txtBoxSubject.Text == "")
            {
                txtBoxSubject.Text = "e.g. CS497";
                txtBoxSubject.ForeColor = Color.LightGray;
            }
        }

        private void txtBoxUnit_Enter(object sender, EventArgs e)
        {
            if(sender is System.Windows.Forms.TextBox txtBoxUnit && txtBoxUnit.Text == "e.g. 3")
            {
                txtBoxUnit.Text = "";
                txtBoxUnit.ForeColor = Color.Black;
            }
        }

        private void txtBoxUnit_Leave(object sender, EventArgs e)
        {
            if(sender is System.Windows.Forms.TextBox txtBoxUnit && txtBoxUnit.Text == "")
            {
                txtBoxUnit.Text = "e.g. 3";
                txtBoxUnit.ForeColor = Color.LightGray;
            }
        }

        private void txtBoxGrade_Enter(object sender, EventArgs e)
        {
            if(sender is System.Windows.Forms.TextBox txtBoxGrade && txtBoxGrade.Text == "e.g. 3.0")
            {
                txtBoxGrade.Text = "";
                txtBoxGrade.ForeColor = Color.Black;
            }
        }

        private void txtBoxGrade_Leave(object sender, EventArgs e)
        {
            if(sender is System.Windows.Forms.TextBox txtBoxGrade && txtBoxGrade.Text == "")
            {
                txtBoxGrade.Text = "e.g. 3.0";
                txtBoxGrade.ForeColor = Color.LightGray;
            }
        }
    }
}