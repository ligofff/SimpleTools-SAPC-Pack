using System;

namespace Ligofff.SAPC.Events
{
    [Serializable]
    public abstract class EventSourceProviderBase<TTrg, TObs>
    {
        public event Action<TTrg, TObs> Open;

        protected bool subscribed = false;

        public void SetupProvider()
        {
            SetupProviderInternal();
            subscribed = true;
        }

        public void DestroyProvider()
        {
            if (!subscribed) return;
            
            DestroyProviderInternal();
            subscribed = false;
        }

        protected abstract void SetupProviderInternal();
        protected abstract void DestroyProviderInternal();

        protected void InvokeOpen(TTrg target, TObs observer)
        {
            Open?.Invoke(target, observer);
        }
    }
}