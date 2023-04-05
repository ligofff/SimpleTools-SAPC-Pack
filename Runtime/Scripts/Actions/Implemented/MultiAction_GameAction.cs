using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Ligofff.GameActions
{
    public class MultiAction_GameAction<T> : GameActionBase<T> where T : class
    {
        [SerializeReference]
        private List<GameActionBase<T>> _actions = new();

        private bool _execOnlyIfAllAvailable = true;

        protected override void InvokeInternal(T contextObject)
        {
            foreach (var action in _actions)
                if (action.CheckConditions(contextObject))
                    action.Invoke(contextObject);
        }

        protected override bool CheckConditionsInternal(T contextObject)
        {
            if (_execOnlyIfAllAvailable)
                return _actions.All(act => act.CheckConditions(contextObject));
            return _actions.Any(act => act.CheckConditions(contextObject));
        }
    }
}