using System;
using UnityEngine;

namespace Ligofff.GameActions
{
    [Serializable]
    public class Looped_GameAction<T> : GameActionBase<T> where T : class
    {
        [SerializeReference]
        private GameActionBase<T> _action;

        [SerializeField]
        private int _invokeCount = 1;

        protected override void InvokeInternal(T contextObject)
        {
            for (int i = 0; i < _invokeCount; i++)
            {
                _action.Invoke(contextObject);
            }
        }

        protected override bool CheckConditionsInternal(T contextObject)
        {
            return _action.CheckConditions(contextObject);
        }
    }
}