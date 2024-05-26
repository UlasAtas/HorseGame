using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SembolSpawner : MonoBehaviour
{
    public GameObject numberPrefab;
    public float spawnInterval = 2f;
    public int minRandomNumber = 0;
    public int maxRandomNumber = 11;

    private void Start()
    {
        StartCoroutine(SpawnPrefabs());
    }

    private IEnumerator SpawnPrefabs()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            SpawnPrefab();
        }
    }

    private void SpawnPrefab()
    {
        GameObject instantiatedPrefab = Instantiate(numberPrefab);
        NumberHolder numberHolder = instantiatedPrefab.GetComponent<NumberHolder>();

        if (numberHolder != null)
        {
            int randomNumber = Random.Range(minRandomNumber, maxRandomNumber);
            numberHolder.SetNumber(randomNumber);
        }
    }
}
