using System;

namespace Ligofff.GameActions
{
    public abstract class GameActionBase<T> : IGameAction<T> where T : class
    {
        public void Invoke(T contextObject)
        {
            try
            {
                InvokeInternal(contextObject);
            }
            catch (Exception e)
            {
                var str =
                    $"Exception on trying to <color=red>INVOKE</color> Game Action ({GetType().Name})!\n\nInvoked user: {contextObject}\n\nLog: {e}";
                throw new Exception(str);
            }
        }

        protected abstract void InvokeInternal(T contextObject);

        public bool CheckConditions(T contextObject)
        {
            try
            {
                return CheckConditionsInternal(contextObject);
            }
            catch (Exception e)
            {
                var str =
                    $"Exception on trying to <color=red>CHECK CONDITIONS</color> Game Action ({GetType().Name})!\n\nInvoked user: {contextObject}\n\nLog: {e}";
                throw new Exception(str);
            }
        }

        public virtual string ToString(T contextObject)
        {
            return GetType().Name;
        }

        protected virtual bool CheckConditionsInternal(T contextObject)
        {
            return true;
        }
    }
}