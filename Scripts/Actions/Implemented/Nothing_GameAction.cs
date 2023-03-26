namespace Ligofff.GameActions
{
    public class Nothing_GameAction<T> : GameActionBase<T> where T : class
    {
        protected override void InvokeInternal(T contextObject)
        {
            // Just nothing
        }
    }
}