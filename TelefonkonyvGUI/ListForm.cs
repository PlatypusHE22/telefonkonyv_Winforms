using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace TelefonkonyvGUI {
    public partial class ListForm : Form {
        private BindingList<Person> people = new BindingList<Person>();

        public ListForm()
        {
            if (!File.Exists("project.dat"))
            {
                MessageBox.Show("Az adatfájl még nem létezik. Adjon hozzá egy új kontaktot, hogy létrehozza.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            using (FileStream fs = new FileStream("project.dat", FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                while (fs.Position < fs.Length)
                {
                    Person p = new Person(reader.ReadString(), reader.ReadString(), reader.ReadString(), reader.ReadString(), reader.ReadInt64(), reader.ReadString(), reader.ReadString(), reader.ReadString());
                    people.Add(p);
                }
            }

            InitializeComponent();
            lbList.DataSource = people;
            lbList.DisplayMember = "Name";
        }

        private void lbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person p = (Person)lbList.SelectedItem;
            tbName.Text = p.Name;
            tbAddress.Text = p.Address;
            tbFather.Text = p.FatherName;
            tbMother.Text = p.MotherName;
            tbMobile.Text = p.MobileNo.ToString();
            tbSex.Text = p.Sex;
            tbId.Text = p.CitizenNo;
            tbEmail.Text = p.Email;
        }
    }
}