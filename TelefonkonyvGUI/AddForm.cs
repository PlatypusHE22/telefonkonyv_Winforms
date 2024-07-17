using System;
using System.IO;
using System.Windows.Forms;

namespace TelefonkonyvGUI {
    public partial class AddForm : Form {
        public AddForm()
        {
            InitializeComponent();
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Person p = new Person(tbName.Text, tbAddress.Text, tbFather.Text, tbMother.Text, long.Parse(tbMobile.Text), tbSex.Text, tbEmail.Text, tbId.Text);
            using (FileStream fs = new FileStream("project.dat", FileMode.Append, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(p.Name);
                writer.Write(p.Address);
                writer.Write(p.FatherName);
                writer.Write(p.MotherName);
                writer.Write(p.MobileNo);
                writer.Write(p.Sex);
                writer.Write(p.Email);
                writer.Write(p.CitizenNo);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}