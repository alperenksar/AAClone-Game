using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AAClone.Abstracts.Controller;


namespace AAClone.Controller
{
    public class RandomMainCircleTurnSpeedController : CircleController
    {
        
        private void Start()
        {
           StartCoroutine(RandomSpeedCounter());
        }

       

        IEnumerator RandomSpeedCounter()
        {
            while (true)
            {
                yield return new WaitForSeconds(3f);
                _turnSpeed = Random.Range(-100f, 100f);
            }
        }
    }

}

