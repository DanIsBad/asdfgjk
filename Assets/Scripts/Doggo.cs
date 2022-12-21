using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doggo : MonoBehaviour
{
    private static string[] moves = new string[]{"walk", "charge", "wait"};

    public static float walkVelocity = 2;
    public static float chargeVelocity = 10;
    string currentMove;
    float currentMoveEnd;
    Vector2 currentDirection;
    void Start()
    {
    }

    private void chooseMove(){
        float res = Random.value;
        if(res<=0.5){
            currentMove = moves[0];
            currentMoveEnd = Time.time + 5;
            currentDirection = Random.insideUnitCircle.normalized * walkVelocity;
            return;
        }
        if(res<=0.7){
            currentMove = moves[1];
            currentMoveEnd = Time.time + 1;
            currentDirection = Random.insideUnitCircle.normalized * chargeVelocity;
            return;
        }
        currentDirection = Vector2.zero;
        currentMove = moves[2];
        currentMoveEnd = Time.time + 2;
    }

    private void step(){
        transform.Translate(currentDirection);
    }


    void Update()
    {
        if(Time.time > currentMoveEnd)
            chooseMove();
        step();
    }
}
