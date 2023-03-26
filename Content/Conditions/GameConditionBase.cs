using System;
using System.Collections.Generic;
using UnityEngine;

namespace Ligofff.GameActions.Conditions
{
    public abstract class GameConditionBase<T> : IGameCondition<T> where T : class
    {
        [SerializeField]
        private bool _invert;
        protected abstract bool CheckConditionInternal(T contextObject);

        public bool CheckCondition(T contextObject)
        {
            try
            {
                var result = CheckConditionInternal(contextObject);

                if (_invert)
                {
                    result = !result;
                }

                return result;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}