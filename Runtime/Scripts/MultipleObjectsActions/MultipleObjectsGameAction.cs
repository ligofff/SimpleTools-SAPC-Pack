using System;

namespace Ligofff.SAPC.MultipleObjectsActions
{
    public abstract class MultipleObjectsGameAction<T, T2> : IMultipleObjectsAction<T, T2> where T : class where T2 : class
    {
        public void Invoke(T contextObject1, T2 contextObject2)
        {
            try
            {
                InvokeInternal(contextObject1, contextObject2);
            }
            catch (Exception e)
            {
                var str =
                    $"Exception on trying to <color=red>INVOKE</color> Multiple Objects Game Action ({GetType().Name})!\n\nObj1: {contextObject1}\n\nObj2: {contextObject2}\n\nLog: {e}";
                throw new Exception(str);
            }
        }
        
        protected abstract void InvokeInternal(T contextObject, T2 contextObject2);

        public bool CheckConditions(T contextObject1, T2 contextObject2)
        {
            try
            {
                return CheckConditionsInternal(contextObject1, contextObject2);
            }
            catch (Exception e)
            {
                var str =
                    $"Exception on trying to <color=red>CHECK CONDITIONS</color> Multiple Objects Game Action ({GetType().Name})!\n\nObj1: {contextObject1}\n\nObj2: {contextObject2}\n\nLog: {e}";
                throw new Exception(str);
            }
        }
        
        protected virtual bool CheckConditionsInternal(T contextObject, T2 contextObject2)
        {
            return true;
        }

        public string ToString(T contextObject, T2 contextObject2)
        {
            return GetType().Name;
        }
    }
}