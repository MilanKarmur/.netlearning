using System.Collections.Concurrent;
using StudentManagementAPI.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

var app = builder.Build();
app.UseCors();
app.UseDefaultFiles();
app.UseStaticFiles();
app.UseSwagger();
app.UseSwaggerUI();

// In-memory storage: no database or database setup is required.
var students = new ConcurrentDictionary<int, Student>();
var nextId = 4;

students[1] = new Student { Id = 1, FullName = "Aarav Shah", Email = "aarav.shah@example.com", Course = "Computer Science", Semester = 5, Phone = "9876543210", EnrollmentNo = "MU2024001" };
students[2] = new Student { Id = 2, FullName = "Diya Patel", Email = "diya.patel@example.com", Course = "Information Technology", Semester = 3, Phone = "9876543211", EnrollmentNo = "MU2024002" };
students[3] = new Student { Id = 3, FullName = "Reyansh Mehta", Email = "reyansh.mehta@example.com", Course = "Computer Science", Semester = 5, Phone = "9876543212", EnrollmentNo = "MU2024003" };

app.MapGet("/api/students", (string? search) =>
{
    var result = students.Values.AsEnumerable();
    if (!string.IsNullOrWhiteSpace(search))
        result = result.Where(s => s.FullName.Contains(search, StringComparison.OrdinalIgnoreCase)
            || s.Email.Contains(search, StringComparison.OrdinalIgnoreCase)
            || s.EnrollmentNo.Contains(search, StringComparison.OrdinalIgnoreCase)
            || s.Course.Contains(search, StringComparison.OrdinalIgnoreCase));
    return Results.Ok(result.OrderBy(s => s.Id).ToList());
}).WithName("GetStudents");

app.MapGet("/api/students/{id:int}", (int id) =>
    students.TryGetValue(id, out var student)
        ? Results.Ok(student)
        : Results.NotFound(new { message = "Student not found." }))
    .WithName("GetStudentById");

app.MapPost("/api/students", (Student student) =>
{
    var error = Validate(student);
    if (error is not null) return Results.BadRequest(new { message = error });
    if (students.Values.Any(s => s.Email.Equals(student.Email, StringComparison.OrdinalIgnoreCase)
        || s.EnrollmentNo.Equals(student.EnrollmentNo, StringComparison.OrdinalIgnoreCase)))
        return Results.Conflict(new { message = "Email or enrollment number already exists." });

    var id = Interlocked.Increment(ref nextId) - 1;
    var created = CopyStudent(student, id);
    students[id] = created;
    return Results.Created($"/api/students/{id}", created);
}).WithName("CreateStudent");

app.MapPut("/api/students/{id:int}", (int id, Student input) =>
{
    if (!students.ContainsKey(id)) return Results.NotFound(new { message = "Student not found." });
    var error = Validate(input);
    if (error is not null) return Results.BadRequest(new { message = error });
    if (students.Values.Any(s => s.Id != id &&
        (s.Email.Equals(input.Email, StringComparison.OrdinalIgnoreCase)
         || s.EnrollmentNo.Equals(input.EnrollmentNo, StringComparison.OrdinalIgnoreCase))))
        return Results.Conflict(new { message = "Email or enrollment number already exists." });

    var updated = CopyStudent(input, id);
    students[id] = updated;
    return Results.Ok(updated);
}).WithName("UpdateStudent");

app.MapDelete("/api/students/{id:int}", (int id) =>
{
    return students.TryRemove(id, out _)
        ? Results.Ok(new { message = "Student deleted successfully." })
        : Results.NotFound(new { message = "Student not found." });
}).WithName("DeleteStudent");

app.MapGet("/api/health", () => Results.Ok(new
{
    status = "Healthy",
    storage = "In-memory",
    application = "Practical 10 - Student Management REST API"
}));

app.Run();

static Student CopyStudent(Student source, int id) => new()
{
    Id = id,
    FullName = source.FullName.Trim(),
    Email = source.Email.Trim(),
    Course = source.Course.Trim(),
    Semester = source.Semester,
    Phone = source.Phone?.Trim() ?? "",
    EnrollmentNo = source.EnrollmentNo.Trim()
};

static string? Validate(Student s)
{
    if (string.IsNullOrWhiteSpace(s.FullName)) return "Full name is required.";
    if (string.IsNullOrWhiteSpace(s.Email) || !s.Email.Contains('@')) return "A valid email is required.";
    if (string.IsNullOrWhiteSpace(s.Course)) return "Course is required.";
    if (s.Semester < 1 || s.Semester > 12) return "Semester must be between 1 and 12.";
    if (string.IsNullOrWhiteSpace(s.EnrollmentNo)) return "Enrollment number is required.";
    return null;
}
