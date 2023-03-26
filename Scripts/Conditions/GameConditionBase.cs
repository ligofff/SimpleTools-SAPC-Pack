using System;
using UnityEngine;

namespace Ligofff.GameConditions
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