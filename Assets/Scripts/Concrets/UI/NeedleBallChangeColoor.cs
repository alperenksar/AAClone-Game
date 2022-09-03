using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace AAClone.UI
{
    public class NeedleBallChangeColoor : MonoBehaviour
    {
        [SerializeField] SpriteRenderer _spriteRenderer;

        private void Awake()
        {
            Material material = _spriteRenderer.material;

            GetComponent<SpriteRenderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }

        //private void Start()
        //{
        //    _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        //}

        //private void Update()
        //{
        //    _spriteRenderer.color = new Color(1, 0, 0, 1);
        //}

    }

}
