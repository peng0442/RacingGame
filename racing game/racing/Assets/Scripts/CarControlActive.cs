﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarControlActive : MonoBehaviour
{
    public GameObject CarControl;
    
    
    void Start()
    {
        CarControl.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;
      
    }

    
}
