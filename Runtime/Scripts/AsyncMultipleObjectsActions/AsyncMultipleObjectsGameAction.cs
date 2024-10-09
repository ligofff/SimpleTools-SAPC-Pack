using System;
using System.Threading.Tasks;

namespace Ligofff.SAPC.MultipleObjectsActions
{
    public abstract class AsyncMultipleObjectsGameAction<T, T2> : IAsyncMultipleObjectsAction<T, T2> where T : class where T2 : class
    {
        public async void InvokeAsync(T contextObject1, T2 contextObject2)
        {
            try
            {
                await InvokeAsyncInternal(contextObject1, contextObject2);
            }
            catch (Exception e)
            {
                var str =
                    $"Exception on trying to <color=red>INVOKE</color> Async Multiple Objects Game Action ({GetType().Name})!\n\nObj1: {contextObject1}\n\nObj2: {contextObject2}\n\nLog: {e}";
                throw new Exception(str);
            }
        }

        protected abstract Task InvokeAsyncInternal(T contextObject1, T2 contextObject2);

        public bool CheckStartConditions(T contextObject1, T2 contextObject2)
        {
            try
            {
                return CheckStartConditionsInternal(contextObject1, contextObject2);
            }
            catch (Exception e)
            {
                var str =
                    $"Exception on trying to <color=red>CHECK CONDITIONS</color> Multiple Objects Game Action ({GetType().Name})!\n\nObj1: {contextObject1}\n\nObj2: {contextObject2}\n\nLog: {e}";
                throw new Exception(str);
            }
        }
        
        protected virtual bool CheckStartConditionsInternal(T contextObject, T2 contextObject2)
        {
            return true;
        }

        public string ToString(T contextObject, T2 contextObject2)
        {
            return GetType().Name;
        }
    }
}