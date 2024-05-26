using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class HedefRandom : MonoBehaviour
{
    public static HedefRandom Instance { get; private set; }

    public TextMeshProUGUI[] hedefSayi;

    public int[] sayiHedef;
    
    int sayac;

    private void Awake()
    {
        
        if (Instance != null)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    private void Start()
    {
        InvokeRepeating("zamanlayýcý",5,5);
    }

    void Spawner()
    {
        for (int i = 0; i <= hedefSayi.Length; i++)
        {
            hedefSayi[i].gameObject.SetActive(true);
        }

    }

    IEnumerator zamanlayýcý()
    {
        yield return new WaitForSeconds(5);
        for (int i = 0; i <= hedefSayi.Length; i++)
        {
            hedefSayi[i].gameObject.SetActive(false);
        } 
    }


    //void Start()
    //{
    //    RandomStart();
    //}


    //public void RandomStart()
    //{
    //    randomHedef = Random.Range(20, 40);
    //    hedefSayi.text = randomHedef.ToString();
    //}
}
