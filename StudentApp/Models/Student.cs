using System.ComponentModel.DataAnnotations;
namespace StudentApp.Models;
using System.Threading;

public class Student
{
    [Required(ErrorMessage="Please Enter Name")]
    public string Name { get; set; }

    //public int age { get; set; }
    [Required(ErrorMessage ="Please Enter Id")]


    public static int _currentId = 0;
    public int Id { get;}=Interlocked.Increment(ref _currentId);
        
    //public string email { get; set; }

    public float CGPA { get; set; }
    [Required(ErrorMessage = "Please Enter Id")]
    [Range(1,10)]
    public string Semester { get; set; }

}
