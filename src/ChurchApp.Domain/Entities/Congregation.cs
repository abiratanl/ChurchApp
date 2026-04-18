using ChurchApp.Domain.ValueObjects;

namespace ChurchApp.Domain.Entities;

public class Congregation
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public Address Address { get; set; } = null!; // Objeto Composto
    public bool IsMainChurch { get; set; } // Define se é a Sede

    // Relacionamentos
    public virtual ICollection<User> Members { get; set; } = new List<User>();
    public virtual ICollection<CongregationLeaderHistory> LeaderHistories { get; set; } = new List<CongregationLeaderHistory>();
}