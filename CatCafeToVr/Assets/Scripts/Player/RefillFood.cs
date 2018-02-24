using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillFood : ITouch
{
    CatFood catFood;

    private readonly int refillPoint = 30;

    // Pass the food GameObject in, instead of the ref to the food script attached
    public void Touch(GameObject obj)
    {
        // Player refill this food
        catFood = obj.GetComponent<CatFood>();
        catFood.Refill(refillPoint);
    }
}
