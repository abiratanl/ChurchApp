namespace ChurchApp.Domain.Entities;

public class AssetCategory
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty; // Ex: Informática, Móveis
    public string? Description { get; set; }

    // Relacionamento: Uma categoria tem muitos bens
    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();
}