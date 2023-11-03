using APIforstudents__of__a__school;

namespace APIforstudents__of__a__school
{
    public class studentofhighschool:student
    {
        public studentofhighschool(student student)
        {
            Console.WriteLine($"student info :{name},,,\n{lname},,,\n{age},,,{id}");
        }

    }
    public class student
    {
      public string name {  get; set; }
     public string lname {  get; set; }
        public int id { get; set; } 
        public int age { get; set; }
    }
    
}
public class studentlist
{
    public List<student> students = new List<student>();
}
