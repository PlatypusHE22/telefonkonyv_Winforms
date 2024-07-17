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
                writer.Write(p.name);
                writer.Write(p.address);
                writer.Write(p.father_name);
                writer.Write(p.mother_name);
                writer.Write(p.mobile_no);
                writer.Write(p.sex);
                writer.Write(p.email);
                writer.Write(p.citizen_no);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}