using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


namespace AAClone.Manager
{
    public class ArrowManager : MonoBehaviour
    {
        [SerializeField] int _counter = 10;

        [SerializeField] TextMeshProUGUI _needleText;

        [SerializeField] GameObject _arrowPrefab;        

        Vector3 _startPos = new Vector3(0, -5.5f, 0);

        float _force = 400f;
       
        bool IsMouseDown;

        bool _canThrow;
   
   
        void Awake()
        {
            _canThrow = true;
        }

        void Update()
        {
            if (_counter == 0)
            {
                StartCoroutine(WinOrGameOverDebug());
                
            }       

            
            if (Input.GetMouseButtonDown(0) && _counter != 0 && _canThrow) 
            {
                IsMouseDown = true;
                _counter--;
            }

        }
        private void FixedUpdate()
        {
            if (IsMouseDown)
            {
                GameObject _arrow = Instantiate(_arrowPrefab, _startPos, _arrowPrefab.transform.rotation);
                _arrow.GetComponent<Rigidbody2D>().AddForce(Vector3.up * _force);
                IsMouseDown = false;
            }

            _needleText.text =_counter.ToString();
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnEventTrigger;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnEventTrigger;
        }

        void HandleOnEventTrigger()
        {
            _canThrow = false;            
        }

        IEnumerator WinOrGameOverDebug()
        {
            yield return new WaitForSeconds(1.1f);
            if (_canThrow)
            {
                GameManager.Instance.MissionSucced();
            }

        }









    }

}
