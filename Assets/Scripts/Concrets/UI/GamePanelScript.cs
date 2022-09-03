using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AAClone.Manager;

namespace AAClone.UI
{
    public class GamePanelScript : MonoBehaviour
    {

        public void TurnMenu()
        {
            GameManager.Instance.LoadMenuScene();
        }

        public void Quit()
        {
            GameManager.Instance.Exit();
        }
    }

}

