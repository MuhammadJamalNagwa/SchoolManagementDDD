using SchoolManagement.Domain.Abstractions;

namespace SchoolManagement.Domain.Student.ValueObjects;
public sealed class StudentId : ValueObject
{
    public Guid Value { get; }
    private StudentId(Guid value)
    {
        Value = value;
    }
    public static StudentId Create()
    {
        return new(Guid.NewGuid());
    }
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
