using Church.Contexts.SharedContext.ValueObjects;


namespace Church.Contexts.SharedContext.Entities;

public class Entity
{
    #region Public Properties

    public Guid Id { get; } = Guid.NewGuid();
    public Tracker Tracker { get; set; } = new Tracker("Criação da entidade.");

    #endregion
}
