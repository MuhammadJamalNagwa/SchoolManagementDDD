using SchoolManagement.Domain.Abstractions;
using SchoolManagement.Domain.Student.Enums;

namespace SchoolManagement.Domain.Student.ValueObjects;
public class EnrollmentValueObject : ValueObject
{
    public Guid CourseId { get; }
    public Grade? Grade { get; }
    private EnrollmentValueObject(Guid courseId, Grade grade)
    {
        CourseId = courseId;
        Grade = grade;
    }
    public static EnrollmentValueObject Create(Guid courseId, Grade grade)
    {
        return new(courseId, grade);
    }
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return CourseId;
        yield return Grade;
    }
}
