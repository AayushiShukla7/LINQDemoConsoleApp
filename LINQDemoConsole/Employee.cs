class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    //public List<string> Programming { get; set; }
    public List<Techs> Programming { get; set; }
}

class Techs
{
    public string Technology { get; set; }
}


