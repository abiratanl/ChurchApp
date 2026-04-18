using ChurchApp.Domain.Enums;
using ChurchApp.Domain.ValueObjects;

namespace ChurchApp.Domain.Entities;

public class Member
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FullName { get; set; } = string.Empty;
    public EcclesiasticRole EcclesiasticRole { get; set; } // Pastor, Diácono, Membro...
    public DateTime BirthDate { get; set; }
    public Address Address { get; set; } = null!; // Objeto Composto
    public bool IsActive { get; set; } = true;
    
    // Relacionamento com a Congregação
    public Guid CongregationId { get; set; }
    public virtual Congregation Congregation { get; set; } = null!;

    // Vínculo opcional com o Usuário (0 ou 1)
    public virtual User? User { get; set; }
}