using System;

namespace Ligofff.GameActions
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