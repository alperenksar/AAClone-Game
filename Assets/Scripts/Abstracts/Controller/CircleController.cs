using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AAClone.Abstracts.Controller
{
    public abstract class CircleController : MonoBehaviour
    {
        public  float _turnSpeed;

        private void Update()
        {
            gameObject.transform.Rotate(new Vector3(0, 0, _turnSpeed * Time.deltaTime));
        }
    }

}
