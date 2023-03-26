using System;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Ligofff.ObjectProviders
{
    [Serializable]
    public abstract class UniversalObjectProviderBase<T> : IObjectProvider<T>
    {
        public virtual T Get
        {
            get
            {
                if (!CheckAllParametersAssigned())
                    throw new Exception($"Needed parameters is not assigned in provider {GetType().Name}!");

                if (_cacheValue)
                {
                    return _cached ??= GetInternal();
                }
                
                return GetInternal();
            }
        }

        [SerializeField]
        private T _cached;

        [SerializeField]
        private bool _cacheValue = false;

        private bool CheckAllParametersAssigned()
        {
            if (NeedParameters.Count == 0) return true;

            if (NeedParameters.Count != 0 && (ActionParameters == null || ActionParameters.Length == 0))
                throw new Exception($"Action parameters is not assigned for provider {GetType().Name}!");
            
            foreach (var needParameter in NeedParameters)
            {
                if (!ActionParameters.Any(parms => parms.Item1 == needParameter))
                    throw new Exception($"Parameter {needParameter} is not setted in entity provider!");
            }

            return true;
        }

        protected abstract T GetInternal();

        [ShowInInspector, DisplayAsString, ShowIf("@NeedParameters.Count > 0")]
        protected virtual List<string> NeedParameters => new List<string>(){};

        [NonSerialized]
        protected (string, object)[] ActionParameters;

        public void SetParams(params (string, object)[] parameters)
        {
            ActionParameters = parameters;
        }

        public object GetParameter(string parameterName)
        {
            for (int i = 0; i < ActionParameters.Length; i++)
            {
                if (ActionParameters[i].Item1 == parameterName)
                {
                    return ActionParameters[i].Item2;
                }
            }

            return null;
        }
    }
}