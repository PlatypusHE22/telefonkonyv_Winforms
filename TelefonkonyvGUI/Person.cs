namespace TelefonkonyvGUI {
    struct Person {
        public string name;
        public string address;
        public string father_name;
        public string mother_name;
        public long mobile_no;
        public string sex;
        public string email;
        public string citizen_no;

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
