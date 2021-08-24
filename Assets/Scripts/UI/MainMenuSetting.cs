using UnityEngine;
using UnityEngine.UI;

namespace BerserkAdventure
{
    [RequireComponent(typeof(Image), typeof(RectTransform))]
    public class MainMenuSetting : MonoBehaviour
    {
        //Camera camera;
        Image backgraund;
        void Start()
        {
            if (Screen.height<Screen.width)   Display.main.SetRenderingResolution(Screen.height, Screen.width);
           // camera = FindObjectOfType<Camera>();
            backgraund = GetComponent<Image>();
        }
    }
}