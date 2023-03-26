namespace Ligofff.GameActions
{
    public interface IGameAction<T> where T : class
    {
        void Invoke(T contextObject);
        bool CheckConditions(T contextObject);

        string ToString(T contextObject);
    }
}