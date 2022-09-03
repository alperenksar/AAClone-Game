using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using AAClone.Abstracts.Controller;
using AAClone.Manager;


namespace AAClone.Controller
{
    public class MainCircleController : CircleController
    {
        ArrowManager arrowManager;

        private void Awake()
        {
            arrowManager=GetComponent<ArrowManager>();
            StartCoroutine("ChangeSpeedWithTime");
        }


        IEnumerator ChangeSpeedWithTime()
        {
            while (true)
            {
                yield return new WaitForSeconds(10f);
                _turnSpeed = _turnSpeed * 1.1f;
            }
        }

       


    }

    

}
