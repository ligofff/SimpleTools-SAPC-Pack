namespace Ligofff.GameConditions
{
    public interface IGameCondition<T> where T : class
    {
        bool CheckCondition(T contextObject);
    }
}