using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFood : MonoBehaviour {

    private int foodPoints;

    public void Refill(int refillPts ) {
        foodPoints += refillPts;
    }

    public int getFoodPoints() {
        return this.foodPoints;
    }

    public void setFoodPoints( int foodPts ) {
        this.foodPoints = foodPts;
    }
}
