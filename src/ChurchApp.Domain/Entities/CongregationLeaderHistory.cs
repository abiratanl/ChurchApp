namespace ChurchApp.Domain.Entities;

public class CongregationLeaderHistory
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid CongregationId { get; set; }
    public Guid MemberId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; } // Null significa que é o atual

    public virtual Congregation Congregation { get; set; } = null!;
    public virtual Member Member { get; set; } = null!;
}