using ChurchApp.Domain.Enums;

namespace ChurchApp.Domain.Entities;

public class Asset
{
    public Guid Id { get; set; } = Guid.NewGuid();

    // --- Identificação ---
    public string TagNumber { get; set; } = string.Empty; // Ex: PAT-001
    public string Description { get; set; } = string.Empty;
    public string? SerialNumber { get; set; }
    
    public Guid CategoryId { get; set; }
    public virtual AssetCategory Category { get; set; } = null!;

    // --- Aquisição ---
    public DateTime PurchaseDate { get; set; }
    public string? InvoiceNumber { get; set; }
    public decimal PurchaseValue { get; set; }

    // --- Localização e Responsabilidade ---
    public Guid CongregationId { get; set; }
    public virtual Congregation Congregation { get; set; } = null!;
    
    public string Department { get; set; } = string.Empty; // Ex: Som, Secretaria
    
    public Guid? ResponsibleMemberId { get; set; } // Link com a entidade Member
    public virtual Member? ResponsibleMember { get; set; }

    public AssetCondition Condition { get; set; } // Enum (Ótimo, Bom, etc)
    public AssetStatus Status { get; set; } // Enum (Em uso, Manutenção, Baixado)

    // --- Contábil ---
    public int UsefulLifeMonths { get; set; }

    // Propriedades Calculadas (Logic Inside Domain)
    public decimal AccumulatedDepreciation => CalculateDepreciation();
    public decimal CurrentNetValue => PurchaseValue - AccumulatedDepreciation;

    private decimal CalculateDepreciation()
    {
        if (UsefulLifeMonths <= 0) return 0;
        
        var monthsPassed = ((DateTime.Now.Year - PurchaseDate.Year) * 12) + DateTime.Now.Month - PurchaseDate.Month;
        if (monthsPassed <= 0) return 0;
        if (monthsPassed >= UsefulLifeMonths) return PurchaseValue;

        return (PurchaseValue / UsefulLifeMonths) * monthsPassed;
    }
}