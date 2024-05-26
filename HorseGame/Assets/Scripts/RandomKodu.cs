using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class RandomKodu : MonoBehaviour
{
    public static RandomKodu Instance { get; private set; }

    public TextMeshProUGUI sayiText;

    public int randomNumber;

    //public int tutulanSayi;
    private void Awake()
    {

        Instance = this;

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
        randomNumber = UnityEngine.Random.Range(1, 11);
        sayiText.text = randomNumber.ToString();
        //RandomNumber();
        //Debug.Log(RandomNumber());
    }

    //private void OnEnable()
    //{    
    //    randomNumber = UnityEngine.Random.Range(1, 11);
    //    sayiText.text = randomNumber.ToString();
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player")) 
    //    {

    //        SymbolController.Instance.CheckAnswer();
            
    //        Destroy(gameObject);
    //    }
    //}

    //public int RandomNumber()
    //{
    //    randomNumber = UnityEngine.Random.Range(1, 11);
    //    sayiText.text = randomNumber.ToString();
    //    return randomNumber;
    //    //tutulanSayi = Convert.ToInt32(sayiText.text);
    //}


}
