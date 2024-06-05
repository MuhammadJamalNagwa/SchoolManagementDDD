using SchoolManagement.Domain.Abstractions;
using SchoolManagement.Domain.Student.ValueObjects;

namespace SchoolManagement.Domain.Student;
public sealed class Student : AggregateRoot<StudentId>
{
    private Student(StudentId studentId, string firstName, string lastName, DateTime dateOfBirth, string email) : base(studentId)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Email = email;
    }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public DateTime DateOfBirth { get; private set; }
    public string Email { get; private set; }

    private readonly List<AttendenceValueObject> _attendences = new();
    public IReadOnlyList<AttendenceValueObject> Attendences => _attendences.ToList();

    private readonly List<EnrollmentValueObject> _enrollments = new();
    public IReadOnlyList<EnrollmentValueObject> Enrollments => _enrollments.ToList();

    public void AddAttendence(AttendenceValueObject attendence)
    {
        _attendences.Add(attendence);
    }

    public void AddEnrollment(EnrollmentValueObject enrollment)
    {
        _enrollments.Add(enrollment);
    }

    public static Student Create(string firstName, string lastName, DateTime dateOfBirth, string email)
    {
        return new(StudentId.Create(), firstName, lastName, dateOfBirth, email);
    }

}
