using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AAClone.Manager;

namespace AAClone.UI
{
    public class GameOverObject : MonoBehaviour
    {
        public GameObject _gameOverPanel;

        private void Awake()
        {
            if (_gameOverPanel.activeSelf)
            {
                _gameOverPanel.SetActive(false);
            }
        }

        public void Restart()
        {
            GameManager.Instance.LoadLevelScene(0);
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnGameOver;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnGameOver;

        }

        private void HandleOnGameOver()
        {
            if (!_gameOverPanel.activeSelf)
            {
                _gameOverPanel.SetActive(true);
            }
        }
    }

       

}
