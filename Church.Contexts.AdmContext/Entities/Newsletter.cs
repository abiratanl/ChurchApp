using Church.Contexts.SharedContext.Entities;

namespace Church.Contexts.AdmContext.Entities;

public class Newsletter : Entity
{
    #region Contructors

    public Newsletter() { }

    public Newsletter(
        DateTime endDate,
        string eventDescription,
        string eventTime,
        string eventLocal,
        bool isDeleted,
        DateTime startDate)
    {
        EndDate = endDate;
        EventDescription = eventDescription;
        EventTime = eventTime;
        EventLocal = eventLocal;
        IsDeleted = isDeleted;
        StartDate = startDate;
    }

    #endregion

    #region Public Properties

    public DateTime EndDate { get; private set; }
    public string EventDescription { get; private set; } = null!;
    public string EventLocal { get; private set; } = null!;
    public string EventTime { get; private set; } = null!;
    public bool IsDeleted { get; set; } = false;
    public DateTime StartDate { get; private set; }

    #endregion

    #region Public Methods

    public void Modify(
        DateTime endDate,
        string eventDescription,
        string eventLocal,
        string eventTime,
        DateTime startDate)
    {
        EndDate = endDate;
        EventDescription = eventDescription;
        EventLocal = eventLocal;
        EventTime = eventTime;
        StartDate = startDate;
    }

    public void Delete() => IsDeleted = true;

    #endregion
}