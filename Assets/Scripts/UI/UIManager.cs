using System;
using System.Collections;
using System.Collections.Generic;
using Plate;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button buttonStartFlyPlate;
   

    public static UIManager Instance; 

    private void Awake()
    {
        Instance = this;
        buttonStartFlyPlate.onClick.AddListener(PlateManager.Instance.SpawnPlate);
    }


    public void DisableButtonStartFlyPlate()
    {
        buttonStartFlyPlate.gameObject.SetActive(false);
    }
    
    public void EnableButtonStartFlyPlate()
    {
        buttonStartFlyPlate.gameObject.SetActive(true);
    }
}
