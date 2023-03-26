using Ligofff.GameActions;

namespace _1GAME._0_Scr.Other.DelaresActions.Options
{
    public class Nothing_GameAction<T> : GameActionBase<T> where T : class
    {
        protected override void InvokeInternal(T contextObject)
        {
            // Just nothing
        }
    }
}