using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerS : MonoBehaviour
{
    public float maxWrath = 100;
    private float decreaseSpeed = 0.1f;
    [SerializeField] private bool startDestroing = false;

    public static GameManagerS curret;
    private void Awake()
    {
        curret = this;
        startDestroing = true;
    }
    private void LateUpdate()
    {
        WrahtCountDown();
    }
    private void WrahtCountDown()
    {
        if(startDestroing)
        {
            maxWrath -= decreaseSpeed* Time.deltaTime;
            if(maxWrath<=0)
            {
                Debug.Log("WrathOver");
                startDestroing = false;
            }
        }
    }
    public void WrathConsume(float quantity)
    {
        maxWrath -= quantity;
    }
}
