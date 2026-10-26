using System.ComponentModel.DataAnnotations;

namespace Day11.Models
{
    public class Student
    {
        [Display(Name = "Mã")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Họ và Tên")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage ="Email bat buoc nhap")]
        [RegularExpression(@"^[a-zA-Z0-9]+@gmail\.com$", ErrorMessage = "Email khong hop le")]
        public string Email { get; set; }

        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [Display(Name = "Ngành")]
        public Branch Branch { get; set; }

        [Display(Name = "Giới tính")]
        public Gender Gender { get; set; }

        [Display(Name = "Hệ ĐT")]
        public bool IsRegular { get; set; }

        [Display(Name = "Địa chỉ")]
        [DataType(DataType.MultilineText)]
        [Required]
        public string Address { get; set; }

        [Display(Name = "Ngày sinh")]
        [Range(typeof(DateTime), "1/1/1900", "1/1/2006" , ErrorMessage = "Ngay sinh khong hop le")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Ngay sinh bat buoc nhap")]
        public DateTime BirthDate { get; set; }
    }
}
