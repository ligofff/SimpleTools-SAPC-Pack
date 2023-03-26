using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Ligofff.GameConditions
{
    public class MultipleConditions_GameCondition<T> : GameConditionBase<T> where T : class
    {
        [SerializeReference]
        private List<GameConditionBase<T>> _conditions;

        [SerializeField]
        private ConditionBlockMode _mode;

        protected override bool CheckConditionInternal(T contextObject)
        {
            switch (_mode)
            {
                case ConditionBlockMode.All:
                    return _conditions.All(opt => opt.CheckCondition(contextObject));
                case ConditionBlockMode.Any:
                    return _conditions.Any(opt => opt.CheckCondition(contextObject));
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}