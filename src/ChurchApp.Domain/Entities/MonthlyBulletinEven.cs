namespace ChurchApp.Domain.Entities;

public class MonthlyBulletinEvent
{
    public Guid Id { get; set; } = Guid.NewGuid();
    
    // Identificação do período
    public int Month { get; set; } // 1 a 12
    public int Year { get; set; }
    
    // Sugestão: "15" ou "15 a 17"
    public string Day { get; set; } = string.Empty; 
    
    // Sugestão: "19:00h" ou "09:00h e 19:00h"
    public string Time { get; set; } = string.Empty;

    public string EventDescription { get; set; } = string.Empty;

    // --- Flexibilidade de Local ---
    // Se for em uma congregação específica:
    public Guid? CongregationId { get; set; }
    public virtual Congregation? Congregation { get; set; }

    // Se for local externo ou para complementar o nome da congregação
    public string CustomLocation { get; set; } = string.Empty;

    // Propriedade calculada para exibição na Circular
    public string FinalLocation => Congregation != null 
        ? $"{Congregation.Name} - {CustomLocation}".TrimEnd(' ', '-') 
        : CustomLocation;
}