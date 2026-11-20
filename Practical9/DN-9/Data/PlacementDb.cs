using Microsoft.Data.Sqlite;
namespace DN_9.Data;
public static class PlacementDb{
public static string Cs=>$"Data Source={Path.Combine(AppContext.BaseDirectory,"placement.db")}";
public static void Initialize(){
using var c=new SqliteConnection(Cs);c.Open();using var cmd=c.CreateCommand();
cmd.CommandText=@"CREATE TABLE IF NOT EXISTS Placements(Id INTEGER PRIMARY KEY AUTOINCREMENT,StudentName TEXT NOT NULL,EnrollmentNo TEXT NOT NULL,Department TEXT NOT NULL,CompanyName TEXT NOT NULL,Status TEXT NOT NULL,PackageLpa NUMERIC NOT NULL,Email TEXT NULL);";cmd.ExecuteNonQuery();
cmd.CommandText="SELECT COUNT(*) FROM Placements;";
if(Convert.ToInt32(cmd.ExecuteScalar())==0){cmd.CommandText=@"INSERT INTO Placements(StudentName,EnrollmentNo,Department,CompanyName,Status,PackageLpa,Email) VALUES
('Brij Sheth','92400120404','Computer Engineering','TCS','Placed',4.5,'brij@example.com'),
('Dhyey Joshi','92400120405','Computer Engineering','Infosys','Placed',5.2,'dhyey@example.com'),
('Jenil Delvadiya','92400120406','Information Technology','Wipro','Interview',0,'jenil@example.com');";cmd.ExecuteNonQuery();}
}}