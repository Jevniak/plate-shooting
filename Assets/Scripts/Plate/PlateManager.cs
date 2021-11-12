using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Plate
{
    public class PlateManager : PlateBase
    {
        public static PlateManager Instance;
    
        [SerializeField] private GameObject prefabPlate;
        [SerializeField] private List<Transform> spawnPlateTransformList;

        private void Awake()
        {
            Instance = this;
        }
    
        public void SpawnPlate()
        {
            Transform spawnPlateTransform = spawnPlateTransformList[Random.Range(0, spawnPlateTransformList.Count)];
            UIManager.Instance.DisableButtonStartFlyPlate();
            GameObject plate = Instantiate(prefabPlate, spawnPlateTransform.position, Quaternion.Euler(-90, 0, 0), null);
            Rigidbody plateRigidbody = plate.GetComponent<Rigidbody>();
            plateRigidbody.AddForce(new Vector3(spawnPlateTransform.CompareTag("SpawnRight") ? -0.4f : 0.4f, 0.5f, 0),
                ForceMode.Impulse);
        }


    }
}
