using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BerserkAdventure
{
    public class QuestKey : MonoBehaviour, IInteractibleObject
    {
        string massage = "Нажать";
        [ SerializeField] GameObject openedObject;
        UiActionMassageText uiActionMassageText;

        public void ActivationObject()
        {
            if (!openedObject) return;
            if (openedObject.GetComponent<IInteractibleObject>() == null) return;

            openedObject.GetComponent<IInteractibleObject>().ActivationObject();
        }

        public string ObjectMassage()
        {
            if (!uiActionMassageText)
            {
                uiActionMassageText = FindObjectOfType<UiActionMassageText>();
            }
            uiActionMassageText.Text = massage;
           //Debug.Log(massage);
            return massage;
        }
    }
}
