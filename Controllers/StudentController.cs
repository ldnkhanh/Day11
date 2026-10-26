using Microsoft.AspNetCore.Mvc;
using Day11.Models;

namespace Day11.Controllers
{
    public class StudentController : Controller
    {
        private static readonly List<Student> students = new List<Student>
        {
            new Student
            {
                Id = 001,
                Name = "Nguyên Văn Anh",
                Email = "nguyenvananh@gmail.com",
                Password = "Password123!",
                Branch = Branch.IT,
                Gender = Gender.Male,
                IsRegular = true,
                Address = "123 Đường Lê Lợi, Phường Bến Nghé, Quận 1, TP. Hồ Chí Minh",
                BirthDate = new DateTime(2002, 5, 15)
            },
            new Student
            {
                Id = 002,
                Name = "Trần Thị Bình",
                Email = "tranthibinh@yahoo.com",
                Password = "SecurePass456#",
                Branch = Branch.CE,
                Gender = Gender.Female,
                IsRegular = true,
                Address = "456 Đường Nguyễn Huệ, Phường 1, Quận 3, TP. Hồ Chí Minh",
                BirthDate = new DateTime(2003, 11, 20)
            },
            new Student
            {
                Id = 003,
                Name = "Lê Hoàng Cường",
                Email = "lehoangcuong@outlook.com",
                Password = "MyPassword789$",
                Branch = Branch.EE,
                Gender = Gender.Male,
                IsRegular = false,
                Address = "789 Đường Cầu Giấy, Phường Dịch Vọng, Quận Cầu Giấy, Hà Nội",
                BirthDate = new DateTime(2001, 8, 8)
            },
            new Student
            {
                Id = 004,
                Name = "Phạm Ánh Dung",
                Email = "phamanhdung@gmail.com",
                Password = "DungPass2004@",
                Branch = Branch.IT,
                Gender = Gender.Female,
                IsRegular = true,
                Address = "101 Đường Trần Phú, Phường Phước Ninh, Quận Hải Châu, Đà Nẵng",
                BirthDate = new DateTime(2004, 2, 28)
            }
        };

        public IActionResult Index()
        {
            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student s)
        {
            s.Id = students.Max(x => x.Id) + 1;
            if (ModelState.IsValid)
            {
                students.Add(s);
                return RedirectToAction("Index");
            }
            return View(s);
        }
    }
}
