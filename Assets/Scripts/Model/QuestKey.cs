using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BerserkAdventure
{
    public class QuestKey : MonoBehaviour, IInteractibleObject
    {
        string massage = "Нажать";
        [ SerializeField] GameObject openedObject;

        public void ActivationObject()
        {
            if (!openedObject) return;
            if (openedObject.GetComponent<IInteractibleObject>() == null) return;

            openedObject.GetComponent<IInteractibleObject>().ActivationObject();
        }

        public string ObjectMassage()
        {
           //Debug.Log(massage);
            return massage;
        }
    }
}
