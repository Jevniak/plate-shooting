using System;
using UnityEngine;

namespace Plate
{
    public class PlateCollision : PlateBase
    {
        private void OnCollisionEnter(Collision coll)
        {
            print($"coll: {coll.gameObject.name}");
            switch (coll.gameObject.tag)
            {
                case "Floor":
                    DestroyObject();
                    break;
            }
        }
        
    }
}
