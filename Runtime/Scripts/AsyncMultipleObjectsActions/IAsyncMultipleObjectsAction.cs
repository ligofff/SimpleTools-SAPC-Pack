﻿using System.Threading.Tasks;

namespace Ligofff.SAPC.MultipleObjectsActions
{
    public interface IAsyncMultipleObjectsAction<T, T2> where T : class where T2 : class
    {
        void InvokeAsync_Root(T contextObject1, T2 contextObject2);
        Task InvokeAsync_Task(T contextObject1, T2 contextObject2);
        bool CheckStartConditions(T contextObject1, T2 contextObject2);
        string ToString(T contextObject, T2 contextObject2);
    }
}