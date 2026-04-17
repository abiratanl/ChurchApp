using ChurchApp.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace ChurchApp.Domain.Entities;

public class User : IdentityUser
{
    // O IdentityUser já possui: Id, Email, PasswordHash, PhoneNumber, etc.
    
    public string FullName { get; set; } = string.Empty;
    public UserRole Role { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    // Controle de senha
    public bool MustChangePassword { get; set; } = true;
    
    // Multi-tenant (Segregação por Congregação)
    public int CongregationId { get; set; }
    
    // Observação: O Identity já gerencia tokens de reset nativamente, 
    // mas se precisar de campos customizados, eles entram aqui.
}