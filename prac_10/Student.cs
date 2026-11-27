using System.ComponentModel.DataAnnotations;

namespace StudentManagementAPI.Models;

public class Student
{
    public int Id { get; set; }
    [Required, StringLength(100)]
    public string FullName { get; set; } = "";
    [Required, EmailAddress, StringLength(150)]
    public string Email { get; set; } = "";
    [Required, StringLength(80)]
    public string Course { get; set; } = "";
    [Range(1, 12)]
    public int Semester { get; set; }
    [StringLength(15)]
    public string Phone { get; set; } = "";
    [Required, StringLength(30)]
    public string EnrollmentNo { get; set; } = "";
}
