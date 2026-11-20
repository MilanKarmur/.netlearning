using System.ComponentModel.DataAnnotations;
namespace DN_9.Models;
public class Placement{
public int Id{get;set;}
[Required,StringLength(100)][Display(Name="Student Name")] public string StudentName{get;set;}="";
[Required,StringLength(20)][Display(Name="Enrollment No.")] public string EnrollmentNo{get;set;}="";
[Required,StringLength(100)] public string Department{get;set;}="";
[Required,StringLength(100)][Display(Name="Company Name")] public string CompanyName{get;set;}="";
[Required,StringLength(30)] public string Status{get;set;}="Applied";
[Range(0,999999)][Display(Name="Package (LPA)")] public decimal PackageLpa{get;set;}
[StringLength(100)] public string? Email{get;set;}
}