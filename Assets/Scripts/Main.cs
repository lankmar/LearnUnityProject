using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BerserkAdventure
{
    public class Main : MonoBehaviour
    {
        Main main;

        [SerializeField] Canvas[] canvases;
        [SerializeField] InputManager inputManager;
        [SerializeField] MovementCharController charController;
        // Start is called before the first frame update
        void Start()
        {
            main = new Main();
            if (canvases.Length == 0) canvases = FindObjectsOfType<Canvas>();
            if (!inputManager) inputManager = FindObjectOfType<InputManager>();
            if (!charController) charController = FindObjectOfType<MovementCharController>();

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}