using Microsoft.AspNetCore.Mvc;
using StudentApp.Models;

namespace StudentApp.Controllers
{
    public class StudentController : Controller
    {

        public ViewResult Remove(int id)
        {
            Student s = StudentRepository.students.Find(s => s.Id == id);
            StudentRepository.students.Remove(s);
            return View("ListStudent", StudentRepository.students);
        }
        public ViewResult Details(int id)
        {
            Student s=StudentRepository.students.Find(s=>s.Id==id); 
            return View("Thanks",s);
        }

        public ViewResult Edit(int id)
        {
            Student s = StudentRepository.students.Find(s => s.Id == id);
            return View("Edit", s);
        }
        [HttpPost]
        public ViewResult Edit(Student s)
        {
            foreach(Student std in StudentRepository.students)
            {
                if(std.Id==s.Id)
                {
                    std.Name = s.Name;
                    std.CGPA = s.CGPA;
                    std.Semester = s.Semester;
                    break;
                }
            }
            return View("ListStudent", StudentRepository.students);
        }
        public ViewResult Index()

        {
            return View("Index");
        }

        [HttpGet]
        public ViewResult StudentForm() 
        {
            return View();
        }
        [HttpPost]

        public ViewResult StudentForm(Student s)
        {
            StudentRepository.AddStudent(s);
            
            return View("Thanks",s);
        }

        public ViewResult ListStudent()
        {
            return View(StudentRepository.students);
        }
        //public ViewResult StudentForm(int id, string name,float CGPA,string semester)
        //{
        //    return View();
        //}
    }
}
