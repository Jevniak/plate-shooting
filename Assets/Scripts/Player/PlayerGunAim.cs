using System;
using System.Collections;
using System.Collections.Generic;
using Plate;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGunAim : PlayerBase
{
    private Coroutine aim;
    [SerializeField] private Slider aimSlider;
    [SerializeField] private LayerMask layerCrosshair;

    [SerializeField] private Transform aimStart;

    private void Awake()
    {
        Vector3 screenPos = new Vector3(Screen.width /2.0f, Screen.height/2.0f,10);

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
        transform.LookAt(worldPos);
    }

    private void Update()
    {
        RaycastHit hit;
        
        if (Physics.Raycast(thisTransform.position,  transform.TransformDirection(Vector3.forward) , out hit, 100f, layerCrosshair))
        {
            if (aim == null)
            {
                aimSlider.gameObject.SetActive(true);
                aim = StartCoroutine(Aim(hit.transform.GetComponent<PlateInfo>().timeToDestroy, hit.transform.gameObject));
            }
        }
        else
        {
            if (aimSlider.gameObject.activeSelf)
            {
                if (aim!= null)
                    StopCoroutine(aim);
                aim = null;
                aimSlider.gameObject.SetActive(false);
            }
        }
    }
    

    private IEnumerator Aim(float time, GameObject target)
    {
        float elapsedTime = 0;
        aimSlider.maxValue = time;
        
        while (elapsedTime < time)
        {
            elapsedTime += Time.deltaTime;
            aimSlider.value = elapsedTime;
            yield return null;
        }

        target.GetComponent<PlateBase>().DestroyObject();
        aim = null;
    }
}
