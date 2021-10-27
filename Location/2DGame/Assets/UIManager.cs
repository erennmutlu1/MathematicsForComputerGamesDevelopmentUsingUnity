﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject tank;
    public GameObject fuel;
    public Text tankPosition;
    public Text fuelPosition;
    public Text energyAmt;

    public void AddEnergy(string amt)
    {
        
        if (int.TryParse(amt, out _))
        {
            energyAmt.text = amt;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        tankPosition.text = tank.transform.position + "";
        fuelPosition.text = fuel.GetComponent<ObjectManager>().objPosition + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
