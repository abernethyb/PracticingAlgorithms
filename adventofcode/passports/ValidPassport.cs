namespace passports
{
    /*
    eyr:2029 
    ecl:blu 
    cid:129 
    byr:1989
    iyr:2014 
    pid:896056539 
    hcl:#a97842 
    hgt:165cm
    */
    public class Passport
    {
        public int? eyr { get; set; }
        public string ecl { get; set; }
        public int? cid { get; set; }
        public int? byr { get; set; }
        public int? iyr { get; set; }
        public int? pid { get; set; }
        public string hcl { get; set; }
        public int? hgt { get; set; }

    }
}