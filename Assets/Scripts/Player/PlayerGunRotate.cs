using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGunRotate : PlayerBase
{
    [SerializeField] private float speed = 0.01f;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                Vector3 rotation = Camera.main.transform.rotation.eulerAngles;

                Camera.main.transform.rotation = Quaternion.Euler(
                    rotation.x + touch.deltaPosition.y * speed * -1,
                    rotation.y + touch.deltaPosition.x * speed,
                    rotation.z
                );

                // Vector3 localPosition = crosshair.localPosition;
                //
                // crosshair.localPosition = new Vector3(localPosition.x, localPosition.y, 0);
            }
        }

        // Vector3 rotation = Quaternion.LookRotation(crosshair.position - transform.position).eulerAngles;
        // transform.rotation = Quaternion.Euler(0, rotation.y - 90f,-rotation.x);
    }
}