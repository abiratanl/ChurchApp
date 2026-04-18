using Microsoft.AspNetCore.Identity;
using ChurchApp.Domain.Enums;

namespace ChurchApp.Domain.Entities;

public class User : IdentityUser<Guid> // Usando Guid explicitamente no Identity
{
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool MustChangePassword { get; set; } = true;

    // Perfil
    public UserRole UserRole { get; set; }
    
    // Chave Estrangeira obrigatória para Member
    public Guid MemberId { get; set; }
    
    // Propriedade de Navegação: O vínculo de volta para o membro
    public virtual Member Member { get; set; } = null!;
}