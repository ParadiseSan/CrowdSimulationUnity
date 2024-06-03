using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    // SerializeField attribute allows you to set these values in the Unity Inspector
    [SerializeField] private GameObject RedPlayer;
    [SerializeField] private GameObject BluePlayer;
    [SerializeField] private GameObject YellowPlayer;
    [SerializeField] private GameObject GreenPlayer;

    [SerializeField] private int amountType1 = 10;
    [SerializeField] private int amountType2 = 10;
    [SerializeField] private int amountType3 = 10;
    [SerializeField] private int amountType4 = 10;

    

    [SerializeField] GameObject RedSpawnPosition , BlueSpawnPosition, YellowSpawnPosition , GreenSpawnPosition;

    void Start()
    {
        SpawnObjects(RedPlayer, amountType1 , RedSpawnPosition.transform.position);
        SpawnObjects(BluePlayer, amountType2, BlueSpawnPosition.transform.position);
        SpawnObjects(GreenPlayer, amountType3 , GreenSpawnPosition.transform.position);
        SpawnObjects(YellowPlayer, amountType4, YellowSpawnPosition.transform.position);
    }

    private void SpawnObjects(GameObject objectType, int amount , Vector3 spawnPosition)
    {
        for (int i = 0; i < amount; i++)
        {
            
            Instantiate(objectType, spawnPosition, Quaternion.identity);
        }
    }

   
}

