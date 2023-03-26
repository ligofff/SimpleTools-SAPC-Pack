using System;
using Ligofff.GameActions;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Ligoffff.GameActions.Samples
{
    public abstract class GameObject_GameActionBase : GameActionBase<GameObject> {}

    [Serializable]
    public class DestroyGameObject_GameAction : GameObject_GameActionBase
    {
        protected override void InvokeInternal(GameObject contextObject)
        {
            Object.Destroy(contextObject);
        }
    }
    
    [Serializable]
    public class ChangeGameObjectName_GameAction : GameObject_GameActionBase
    {
        [SerializeField]
        private string newName;
        protected override void InvokeInternal(GameObject contextObject)
        {
            contextObject.name = newName;
        }
    }
    
    [Serializable]
    public class MoveGameobjectUp_GameAction : GameObject_GameActionBase
    {
        [SerializeField]
        private Vector3 moveFor = Vector3.zero;
        protected override void InvokeInternal(GameObject contextObject)
        {
            contextObject.transform.position += moveFor;
        }
    }
}