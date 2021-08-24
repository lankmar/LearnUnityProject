using UnityEngine;
using UnityEngine.UI;

namespace BerserkAdventure
{

    public class PauseMenuSettings : MonoBehaviour
    {
        [SerializeField] Image backgraund;
        [SerializeField] Button continueButton;
        [SerializeField] Button exit;

        private void SetSprites()
        {
            if (!backgraund)
            {
                backgraund = gameObject.GetComponent<Image>();
            } 

            if (Main.mainGame.gameSettings.LanguageSetting == Language.English)
            {
                backgraund.sprite = Resources.Load<Sprite>("UI/En/Pause") as Sprite;
                continueButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("UI/En/Continue") as Sprite;
                exit.GetComponent<Image>().sprite = Resources.Load<Sprite>("UI/En/Exit") as Sprite;
            }
            if (Main.mainGame.gameSettings.LanguageSetting == Language.Russian)
            {
                backgraund.sprite = Resources.Load<Sprite>("UI/Ru/Pause") as Sprite;
                continueButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("UI/Ru/Continue") as Sprite;
                exit.GetComponent<Image>().sprite = Resources.Load<Sprite>("UI/Ru/Exit") as Sprite;
            }
        }

        public void SetMenu()
        {
            SetSprites();
        }
    }
}