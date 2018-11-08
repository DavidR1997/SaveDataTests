﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace GoHome
{
    public class OnGoal : MonoBehaviour
    {
        public UnityEvent onGoal;


        public void OnTriggerEnter(Collider other)
        {
            onGoal.Invoke();
        }
    }
}