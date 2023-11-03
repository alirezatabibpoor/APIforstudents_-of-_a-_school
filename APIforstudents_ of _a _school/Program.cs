using APIforstudents__of__a__school;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
student s1 = new student() { name = "alireza ", lname = "tabibpoor", age = 19, id = 159 };
student s2 = new student() { name = "reza ", lname = "yousefi", age = 19, id = 4546 };
student s3 = new student() { name = "kazem", lname = "abbasi", age = 45, id = 65 };
student s4 = new student() { name = "taher", lname = "hassani", age = 78, id = 421 };
student s5 = new student() { name = "nima", lname = "omidi", age = 54, id = 215 };
student s6 = new student() { name = "taghi", lname = "qasemi", age = 36, id = 46521 };
List<student>students = new List<student>() {  s1, s2, s3 ,s4,s5,s6};


    app.MapGet("/", () => students);

   


app.Run();

