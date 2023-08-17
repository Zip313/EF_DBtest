namespace DataAccess.Entities
{
    /// <summary> Родительский класс сущности </summary>
    public interface IEntity
    {
        /// <summary> Идентификатор </summary>
        int Id { get; set; }
    }
}