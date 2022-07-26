namespace cTower.Interfaces
{
    public interface ICreated<T>
    {
        T Creator { get; set; }
        string CreatorId { get; set; }
    }
}