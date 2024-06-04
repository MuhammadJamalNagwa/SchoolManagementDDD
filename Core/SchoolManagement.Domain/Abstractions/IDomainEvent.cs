namespace SchoolManagement.Domain.Abstractions;
public interface IDomainEvent
{
    DateTime OccurredOn { get; }
}

