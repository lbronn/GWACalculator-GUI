﻿namespace GWACalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxUnit = new System.Windows.Forms.TextBox();
            this.txtBoxGrade = new System.Windows.Forms.TextBox();
            this.txtBoxSubject = new System.Windows.Forms.TextBox();
            this.calcGWAPanel = new System.Windows.Forms.Panel();
            this.clrAllButton = new System.Windows.Forms.Button();
            this.displayGWA = new System.Windows.Forms.TextBox();
            this.clearSubButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calcGWAButton = new System.Windows.Forms.Button();
            this.addSubjButton = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.calcGWAYear = new System.Windows.Forms.GroupBox();
            this.calcGWAPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxUnit
            // 
            this.txtBoxUnit.BackColor = System.Drawing.Color.White;
            this.txtBoxUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxUnit.ForeColor = System.Drawing.Color.LightGray;
            this.txtBoxUnit.Location = new System.Drawing.Point(243, 63);
            this.txtBoxUnit.Name = "txtBoxUnit";
            this.txtBoxUnit.Size = new System.Drawing.Size(188, 30);
            this.txtBoxUnit.TabIndex = 3;
            this.txtBoxUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxUnit.TextChanged += new System.EventHandler(this.txtBoxUnit_TextChanged);
            this.txtBoxUnit.Enter += new System.EventHandler(this.txtBoxUnit_Enter);
            this.txtBoxUnit.Leave += new System.EventHandler(this.txtBoxUnit_Leave);
            // 
            // txtBoxGrade
            // 
            this.txtBoxGrade.BackColor = System.Drawing.Color.White;
            this.txtBoxGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxGrade.ForeColor = System.Drawing.Color.LightGray;
            this.txtBoxGrade.Location = new System.Drawing.Point(462, 63);
            this.txtBoxGrade.Name = "txtBoxGrade";
            this.txtBoxGrade.Size = new System.Drawing.Size(188, 30);
            this.txtBoxGrade.TabIndex = 4;
            this.txtBoxGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxGrade.TextChanged += new System.EventHandler(this.txtBoxGrade_TextChanged);
            this.txtBoxGrade.Enter += new System.EventHandler(this.txtBoxGrade_Enter);
            this.txtBoxGrade.Leave += new System.EventHandler(this.txtBoxGrade_Leave);
            // 
            // txtBoxSubject
            // 
            this.txtBoxSubject.BackColor = System.Drawing.Color.White;
            this.txtBoxSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSubject.ForeColor = System.Drawing.Color.LightGray;
            this.txtBoxSubject.Location = new System.Drawing.Point(27, 63);
            this.txtBoxSubject.Name = "txtBoxSubject";
            this.txtBoxSubject.Size = new System.Drawing.Size(188, 30);
            this.txtBoxSubject.TabIndex = 5;
            this.txtBoxSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxSubject.TextChanged += new System.EventHandler(this.txtBoxSubject_TextChanged);
            this.txtBoxSubject.Enter += new System.EventHandler(this.txtBoxSubject_Enter);
            this.txtBoxSubject.Leave += new System.EventHandler(this.txtBoxSubject_Leave);
            // 
            // calcGWAPanel
            // 
            this.calcGWAPanel.BackColor = System.Drawing.Color.Silver;
            this.calcGWAPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcGWAPanel.Controls.Add(this.clrAllButton);
            this.calcGWAPanel.Controls.Add(this.displayGWA);
            this.calcGWAPanel.Controls.Add(this.clearSubButton);
            this.calcGWAPanel.Controls.Add(this.label3);
            this.calcGWAPanel.Controls.Add(this.label2);
            this.calcGWAPanel.Controls.Add(this.label1);
            this.calcGWAPanel.Controls.Add(this.calcGWAButton);
            this.calcGWAPanel.Controls.Add(this.addSubjButton);
            this.calcGWAPanel.Controls.Add(this.txtBoxSubject);
            this.calcGWAPanel.Controls.Add(this.txtBoxGrade);
            this.calcGWAPanel.Controls.Add(this.txtBoxUnit);
            this.calcGWAPanel.Location = new System.Drawing.Point(27, 121);
            this.calcGWAPanel.Name = "calcGWAPanel";
            this.calcGWAPanel.Size = new System.Drawing.Size(823, 555);
            this.calcGWAPanel.TabIndex = 6;
            this.calcGWAPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.calcGWAPanel_Paint);
            // 
            // clrAllButton
            // 
            this.clrAllButton.BackColor = System.Drawing.Color.Red;
            this.clrAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clrAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrAllButton.ForeColor = System.Drawing.Color.Black;
            this.clrAllButton.Location = new System.Drawing.Point(698, 503);
            this.clrAllButton.Name = "clrAllButton";
            this.clrAllButton.Size = new System.Drawing.Size(103, 38);
            this.clrAllButton.TabIndex = 13;
            this.clrAllButton.Text = "CLEAR";
            this.clrAllButton.UseVisualStyleBackColor = false;
            this.clrAllButton.Click += new System.EventHandler(this.clrAllButton_Click);
            // 
            // displayGWA
            // 
            this.displayGWA.BackColor = System.Drawing.Color.White;
            this.displayGWA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayGWA.Cursor = System.Windows.Forms.Cursors.Default;
            this.displayGWA.Location = new System.Drawing.Point(400, 509);
            this.displayGWA.Name = "displayGWA";
            this.displayGWA.ReadOnly = true;
            this.displayGWA.Size = new System.Drawing.Size(284, 30);
            this.displayGWA.TabIndex = 12;
            this.displayGWA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.displayGWA.TextChanged += new System.EventHandler(this.displayGWA_TextChanged);
            // 
            // clearSubButton
            // 
            this.clearSubButton.BackColor = System.Drawing.Color.Red;
            this.clearSubButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSubButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSubButton.Location = new System.Drawing.Point(674, 63);
            this.clearSubButton.Name = "clearSubButton";
            this.clearSubButton.Size = new System.Drawing.Size(127, 30);
            this.clearSubButton.TabIndex = 11;
            this.clearSubButton.Text = "REMOVE";
            this.clearSubButton.UseVisualStyleBackColor = false;
            this.clearSubButton.Click += new System.EventHandler(this.clearSubButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Grade";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Unit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Subject";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcGWAButton
            // 
            this.calcGWAButton.BackColor = System.Drawing.Color.Chartreuse;
            this.calcGWAButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calcGWAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcGWAButton.Location = new System.Drawing.Point(214, 503);
            this.calcGWAButton.Name = "calcGWAButton";
            this.calcGWAButton.Size = new System.Drawing.Size(170, 38);
            this.calcGWAButton.TabIndex = 7;
            this.calcGWAButton.Text = "Calculate GWA";
            this.calcGWAButton.UseVisualStyleBackColor = false;
            this.calcGWAButton.Click += new System.EventHandler(this.calcGWAButton_Click);
            // 
            // addSubjButton
            // 
            this.addSubjButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.addSubjButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSubjButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSubjButton.Location = new System.Drawing.Point(27, 503);
            this.addSubjButton.Name = "addSubjButton";
            this.addSubjButton.Size = new System.Drawing.Size(170, 38);
            this.addSubjButton.TabIndex = 6;
            this.addSubjButton.Text = "Add Subject";
            this.addSubjButton.UseVisualStyleBackColor = false;
            this.addSubjButton.Click += new System.EventHandler(this.addSubjButton_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(405, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(662, 58);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Calculate your GWA here 👇";
            // 
            // calcGWAYear
            // 
            this.calcGWAYear.BackColor = System.Drawing.Color.White;
            this.calcGWAYear.Location = new System.Drawing.Point(880, 114);
            this.calcGWAYear.Name = "calcGWAYear";
            this.calcGWAYear.Size = new System.Drawing.Size(412, 562);
            this.calcGWAYear.TabIndex = 8;
            this.calcGWAYear.TabStop = false;
            this.calcGWAYear.Text = "GWA for one Academic Year 👇";
            this.calcGWAYear.Enter += new System.EventHandler(this.calcGWAYear_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1323, 700);
            this.Controls.Add(this.calcGWAYear);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.calcGWAPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GWA Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.calcGWAPanel.ResumeLayout(false);
            this.calcGWAPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxUnit;
        private System.Windows.Forms.TextBox txtBoxGrade;
        private System.Windows.Forms.TextBox txtBoxSubject;
        private System.Windows.Forms.TextBox displayGWA;
        private System.Windows.Forms.Button addSubjButton;
        private System.Windows.Forms.Button clearSubButton;
        private System.Windows.Forms.Button calcGWAButton;
        private System.Windows.Forms.Button clrAllButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel calcGWAPanel;
        private System.Windows.Forms.GroupBox calcGWAYear;
        
    }
}

