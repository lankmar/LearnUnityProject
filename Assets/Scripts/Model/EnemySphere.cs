using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BerserkAdventure {
[RequireComponent (typeof(Renderer), typeof (SphereCollider))]
    public class EnemySphere : MonoBehaviour, IInteractibleObject
    {
        string massage = "Забрать";
        [SerializeField] GameObject openedObject;
        UiActionMassageText uiActionMassageText;

        public void ActivationObject()
        {
            Debug.Log("ActivationObject Enemy");
            GetComponent<Renderer>().enabled = true;
            GetComponent<SphereCollider>().enabled = true;

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
