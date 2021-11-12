using UnityEngine;

namespace Plate
{
    public class PlateBase : MonoBehaviour
    {
        public virtual void DestroyObject()
        {
            UIManager.Instance.EnableButtonStartFlyPlate();
            Destroy(gameObject);
        }
        
    }
}