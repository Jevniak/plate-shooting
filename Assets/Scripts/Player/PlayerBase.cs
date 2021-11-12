using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    protected static Transform crosshair;
    protected Transform thisTransform;
    
    private void Start()
    {
        crosshair = GameObject.FindWithTag("Crosshair").transform;
        thisTransform = transform;
    }
    
    protected virtual void Shoot() {

    }

}
