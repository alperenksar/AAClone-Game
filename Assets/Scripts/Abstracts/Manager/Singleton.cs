using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AAClone.Abstracts.Utilities
{
    public abstract class Singleton<T> : MonoBehaviour
    {
      public static T Instance { get; private set; }

        protected void SingletonThisGameObject(T entity)
        {
            if (Instance == null)
            {
                Instance = entity;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

}
