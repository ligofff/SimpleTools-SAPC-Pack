using System;
using Ligofff.GameActions.Conditions;
using UnityEngine;

namespace Ligoffff.GameActions.Examples
{
    public abstract class GameObject_GameConditionBase : GameConditionBase<GameObject> { }

    [Serializable]
    public class IsGameObjectActive_GameCondition : GameObject_GameConditionBase
    {
        protected override bool CheckConditionInternal(GameObject contextObject)
        {
            return contextObject.activeSelf;
        }
    }
    
    [Serializable]
    public class GameObjectName_GameCondition : GameObject_GameConditionBase
    {
        [SerializeField]
        private string nameContains;
        protected override bool CheckConditionInternal(GameObject contextObject)
        {
            return contextObject.name.Contains(nameContains);
        }
    }
}