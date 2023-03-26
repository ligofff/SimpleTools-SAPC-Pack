using System;
using Ligofff.GameActions;

namespace _1GAME._0_Scr.Other.DelaresActions.Options
{
    public class ScriptedAction_GameAction<T> : GameActionBase<T> where T : class
    {
        private Action _action;
        protected override void InvokeInternal(T contextObject)
        {
            _action?.Invoke();
        }
    }
}