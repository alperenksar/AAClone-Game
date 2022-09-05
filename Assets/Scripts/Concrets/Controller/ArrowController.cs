using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AAClone.Manager;
using UnityEngine.SceneManagement;



namespace AAClone.Controller
{
    public class ArrowController : MonoBehaviour
    {
        Rigidbody2D _rb;
        ArrowManager _arrowManager;
        
        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            _arrowManager = GetComponent<ArrowManager>();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {         
            if (other.gameObject.CompareTag("MainCircle"))
            {
                SoundManager.Instance.HitSound();
                transform.SetParent(other.transform, true);
                Destroy(_rb);
            }

            if (other.gameObject.CompareTag("Arrow"))
            {
                
                GameManager.Instance.GameOver();
            }
        }

       




    }


}