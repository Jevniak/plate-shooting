using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateInfo : MonoBehaviour
{
    public float timeToDestroy = 0.25f;

    private void Awake()
    {
        StartCoroutine(IncrementTimeToDestory());
    }

    private IEnumerator IncrementTimeToDestory()
    {
        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(1f);
            timeToDestroy += 0.25f;
        }
        
        
    }
}
