using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class CarSpawner : MonoBehaviour
{
   [SerializeField]
   private Object _prefab;

   [SerializeField]
   private Transform _parent;
   private void Awake()
   {
      Instantiate(_prefab,_parent, true);
   }
}
