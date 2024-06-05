using SchoolManagement.Domain.Abstractions;

namespace SchoolManagement.Domain.Student.ValueObjects;
public sealed class AttendenceValueObject : ValueObject
{
    public Guid CourseId { get; }
    public DateTime Date { get; }
    public bool IsPresent { get; }
    private AttendenceValueObject(Guid courseId, DateTime date, bool isPresent)
    {
        CourseId = courseId;
        Date = date;
        IsPresent = isPresent;
    }
    public static AttendenceValueObject Create(Guid courseId, DateTime date, bool isPresent)
    {
        return new(courseId, date, isPresent);
    }
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return CourseId;
        yield return Date;
        yield return IsPresent;
    }
}
