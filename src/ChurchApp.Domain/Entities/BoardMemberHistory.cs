namespace ChurchApp.Domain.Entities;

public class BoardMemberHistory
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid MemberId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; } // Null significa que é o atual
    public virtual Member Member { get; set; } = null!;
}