namespace Ligofff.GameActions.Conditions
{
    public interface IGameCondition<T> where T : class
    {
        bool CheckCondition(T contextObject);
    }
}