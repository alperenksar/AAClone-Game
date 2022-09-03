using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AAClone.Manager;

namespace AAClone.UI
{
    public class WinConditionObject : MonoBehaviour
    {
        [SerializeField] GameObject _WinConditionPanel;

        private void Awake()
        {
            _WinConditionPanel.SetActive(false);
        }

        private void OnEnable()
        {
            GameManager.Instance.OnMissionSucced += HandleOnMissionSucced;
        }

        private void HandleOnMissionSucced()
        {
            if (!_WinConditionPanel.activeSelf)
            {
                _WinConditionPanel.SetActive(true);
            }
        }

        private void OnDisable()
        {
            GameManager.Instance.OnMissionSucced -= HandleOnMissionSucced;
        }

        public void NextLevel()
        {
            GameManager.Instance.LoadLevelScene(1);
        }


    }

}
