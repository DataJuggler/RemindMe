

#region using statements

#endregion

namespace ObjectLibrary.Enumerations
{

    #region enum RecurringTypeEnum : int
    /// <summary>
    /// This enum is only here so that the Enumerations reference compiles.
    /// You can remove this but if you do you also need to remove the reference
    /// in DataManager for this object.
    /// </summary>
    public enum RecurringTypeEnum : int
    {
        None = 0,
        Annual = 1,
        Daily = 2,
        Weekly = 3,
        Bi_Weekly = 4,
        Monthly = 5,
        Five_Years = 6,
        Ten_Years = 7
    }
    #endregion

}
