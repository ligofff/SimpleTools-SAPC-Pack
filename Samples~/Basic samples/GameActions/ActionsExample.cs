using Sirenix.OdinInspector;
using UnityEngine;

namespace Ligoffff.GameActions.Samples
{
    public class ActionsExample : MonoBehaviour
    {
        [SerializeReference]
        private GameObject_GameActionBase _action;

        [SerializeField, InlineButton("@SetThisGameobject()")]
        private GameObject _gameObjectForAction;

        [Button]
        private void InvokeAction()
        {
            _action.Invoke(_gameObjectForAction);
            Debug.Log($"Action {_action.ToString(_gameObjectForAction)} invoked!");
        }

        private void SetThisGameobject()
        {
            _gameObjectForAction = gameObject;
        }
    }
}