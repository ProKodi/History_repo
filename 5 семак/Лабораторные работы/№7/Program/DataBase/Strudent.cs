



/// <summary> Студенты со своими специальностями </summary>
record Strudent{
    public readonly string Name;
    public readonly string Sex;
    public readonly string Parents;
    public readonly string Address;
    public readonly string PhoneNumber; 
    public readonly string passportData;
    public readonly string Group;
    public readonly DateTime Birthday;
    public readonly DateTime DateReceipt;
    public readonly bool IsFullTime;
    public readonly int NumberRecordBook;
    public readonly short NuberCourse;
    public readonly string NameSpecialty;

    public Strudent(
        string Name, string Sex, string Parents, string Address, string PhoneNumber, string passportData,
        string Group, DateTime Birthday, DateTime DateReceipt, bool IsFullTime, int NumberRecordBook,
        short NuberCourse, string NameSpecialty
    ){
        this.Name = Name;
        this.Sex = Sex;
        this.Parents = Parents;
        this.Address = Address;
        this.PhoneNumber = PhoneNumber;
        this.passportData = passportData;
        this.Group = Group;
        this.Birthday = Birthday;
        this.DateReceipt = DateReceipt;
        this.IsFullTime = IsFullTime;
        this.NumberRecordBook = NumberRecordBook;
        this.NuberCourse = NuberCourse;
        this.NameSpecialty = NameSpecialty;
    }
}