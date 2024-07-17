namespace TelefonkonyvGUI {
    struct Person {
        private string name;
        private string address;
        private string father_name;
        private string mother_name;
        private long mobile_no;
        private string sex;
        private string email;
        private string citizen_no;

        public string Name => name;
        public string Address => address;
        public string FatherName => father_name;
        public string MotherName => mother_name;
        public long MobileNo => mobile_no;
        public string Sex => sex;
        public string Email => email;
        public string CitizenNo => citizen_no;

        public Person(string name, string address, string fatherName, string motherName, long mobileNo, string sex, string email, string citizenNo)
        {
            this.name = name;
            this.address = address;
            father_name = fatherName;
            mother_name = motherName;
            mobile_no = mobileNo;
            this.sex = sex;
            this.email = email;
            citizen_no = citizenNo;
        }
    }
}
