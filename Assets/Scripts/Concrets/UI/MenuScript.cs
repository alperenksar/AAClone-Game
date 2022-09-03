using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AAClone.Manager;

namespace AAClone.UI
{
    public class MenuScript : MonoBehaviour
    {

        public void PlayGame()
        {
            GameManager.Instance.LoadLevelScene(1);
        }

        public void QuitGame()
        {

            GameManager.Instance.Exit();

        }

    }

}

