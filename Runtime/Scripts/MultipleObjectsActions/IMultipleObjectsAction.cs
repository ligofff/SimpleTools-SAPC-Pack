namespace Ligofff.SAPC.MultipleObjectsActions
{
    public interface IMultipleObjectsAction<T, T2> where T : class where T2 : class
    {
        void Invoke(T contextObject1, T2 contextObject2);
        bool CheckConditions(T contextObject1, T2 contextObject2);
        string ToString(T contextObject, T2 contextObject2);
    }
}