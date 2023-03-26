using System;
using Ligofff.GameActions.Conditions;
using UnityEngine;

namespace Ligofff.GameConditions
{
    public class Bool_GameCondition<T> : GameConditionBase<T> where T : class
    {
        [SerializeField]
        private bool _result = false;

        protected override bool CheckConditionInternal(T contextObject)
        {
            return _result;
        }
    }
}