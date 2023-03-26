using Sirenix.OdinInspector;
using UnityEngine;

namespace Ligoffff.GameConditions.Samples
{
    public class ConditionsExample : MonoBehaviour
    {
        [SerializeReference]
        private GameObject_GameConditionBase _condition;

        [SerializeField, InlineButton("@SetThisGameobject()")]
        private GameObject _gameObjectToCheck;

        [Button]
        private void CheckCondition()
        {
            Debug.Log($"{_condition.GetType().Name} is {_condition.CheckCondition(_gameObjectToCheck)} for {_gameObjectToCheck}");
        }
        
        private void SetThisGameobject()
        {
            _gameObjectToCheck = gameObject;
        }
    }
}