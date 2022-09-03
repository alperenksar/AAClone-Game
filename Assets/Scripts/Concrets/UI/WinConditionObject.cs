using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AAClone.Manager;

namespace AAClone.UI
{
    public class WinConditionObject : MonoBehaviour
    {
        public GameObject _WinConditionPanel;

        private void Awake()
        {
            if (_WinConditionPanel.activeSelf)
            {
                _WinConditionPanel.SetActive(false);
            }
        }

        public void NextLevel()
        {
            GameManager.Instance.LoadLevelScene(1);
        }

        private void OnEnable()
        {
            GameManager.Instance.OnMissionSucced += HandleOnMissionSucced;
        }     

        private void OnDisable()
        {
            GameManager.Instance.OnMissionSucced -= HandleOnMissionSucced;
        }

        private void HandleOnMissionSucced()
        {
            if (!_WinConditionPanel.activeSelf)
            {
                _WinConditionPanel.SetActive(true);
            }
        }




    }

}
