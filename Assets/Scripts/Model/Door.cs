using UnityEngine;

namespace BerserkAdventure
{
    [RequireComponent(typeof(Animation))]
    public class Door : MonoBehaviour, IInteractibleObject
    {

        public void ActivationObject()
        {
            GetComponent<Animation>().Play();
        }

       public string ObjectMassage()
        {
            return string.Empty;
        }
    }
}