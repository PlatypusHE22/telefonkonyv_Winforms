using System.ComponentModel;

namespace TelefonkonyvGUI {
    partial class ListForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tbId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMother = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFather = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(334, 264);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(180, 20);
            this.tbId.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(228, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "Személyi szám";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(334, 238);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(180, 20);
            this.tbEmail.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(228, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "E-mail";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSex
            // 
            this.tbSex.Location = new System.Drawing.Point(334, 212);
            this.tbSex.Name = "tbSex";
            this.tbSex.ReadOnly = true;
            this.tbSex.Size = new System.Drawing.Size(180, 20);
            this.tbSex.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(228, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "Nem";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMobile
            // 
            this.tbMobile.Location = new System.Drawing.Point(334, 186);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.ReadOnly = true;
            this.tbMobile.Size = new System.Drawing.Size(180, 20);
            this.tbMobile.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(228, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Telefonszám";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMother
            // 
            this.tbMother.Location = new System.Drawing.Point(334, 160);
            this.tbMother.Name = "tbMother";
            this.tbMother.ReadOnly = true;
            this.tbMother.Size = new System.Drawing.Size(180, 20);
            this.tbMother.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(228, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Anyja neve";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFather
            // 
            this.tbFather.Location = new System.Drawing.Point(334, 134);
            this.tbFather.Name = "tbFather";
            this.tbFather.ReadOnly = true;
            this.tbFather.Size = new System.Drawing.Size(180, 20);
            this.tbFather.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(228, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Apja neve";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(334, 108);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(180, 20);
            this.tbAddress.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(228, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cím";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(334, 82);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(180, 20);
            this.tbName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(228, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Név";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.Location = new System.Drawing.Point(12, 12);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(202, 368);
            this.lbList.TabIndex = 32;
            this.lbList.SelectedIndexChanged += new System.EventHandler(this.lbList_SelectedIndexChanged);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 387);
            this.Controls.Add(this.lbList);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSex);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMother);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFather);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMother;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFather;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbList;

        #endregion
    }
}