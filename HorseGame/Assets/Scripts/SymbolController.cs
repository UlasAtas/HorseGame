using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SymbolController : MonoBehaviour
{
    //public int sayi = 0;
    //public string operationTag; // Ýþlemi belirleyen tag
    private int targetNumber; // Hedef sayý
    //bool esitmi;
    public TextMeshProUGUI islem;
    public int sonuc;
    public TextMeshPro sayiText;
    //public int[] number;
    //int can = 3;
    float sayac = 5f;
    public int dogruCevap;
    //int yanlisCevap;
    
    public static SymbolController Instance {  get; private set; }

    private void Awake()
    {
        Instance = this;

    }




    private void Start()
    {
        GenerateProblem();
    }
    private void Update()
    {
        sayac -= Time.deltaTime;
        if (sayac < 0f)
        {
            islem.text = "";
        }

        //CheckAnswer();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Addition")) // Oyuncu sembole temas ettiðinde
        {
            //GameManager.Instance.SetTargetNumber(targetNumber); // GameManager'a hedef sayýyý bildirme
            //GameManager.Instance.StartOperation(operationTag); // GameManager'a iþlemi baþlatma komutu verme

            GenerateProblem();
            //CheckAnswer();

            //if (gameObject.CompareTag("Addition")) // Toplama sembolüne temas
            //{
            //    GameManager.Instance.StartOperation("Addition"); // Toplama iþlemi baþlatma
            //    //sayi += RandomKodu.Instance.tutulanSayi;
            //}
            //else if (gameObject.CompareTag("Substraction")) // Çýkarma sembolüne temas
            //{
            //    GameManager.Instance.StartOperation("Substraction"); // Çýkarma iþlemi baþlatma
            //    //sayi -= RandomKodu.Instance.tutulanSayi;
            //}
            //else if (gameObject.CompareTag("Multiplication")) // Çarpma sembolüne temas
            //{
            //    GameManager.Instance.StartOperation("Multiplication"); // Çarpma iþlemi baþlatma
            //    //sayi *= RandomKodu.Instance.tutulanSayi;
            //}

            //Debug.Log(sayi);



            //if (RandomKodu.Instance.number[] == HedefRandom.Instance.sayiHedef[])
            //{
            //    //HedefRandom.Instance.RandomStart();
            //}

            //if (Esitmi(/*sonuc,number*/))
            //{
            //    Debug.Log("esit");
            //    //Debug.Log(HedefRandom.Instance.sayiHedef[1]);
            //    //Debug.Log(RandomKodu.Instance.number[1]);
            //    for (int i = 0; i < islem.Length; i++) 
            //    {
            //        islem[i].enabled = true;
            //    }
            //}
            //else
            //{
            //    Debug.Log("esitdegil");
            //    //Debug.Log(HedefRandom.Instance.sayiHedef[1]);
            //    //Debug.Log(RandomKodu.Instance.number[1]);
            //    can--;
            //    if (can == 0 && collision.CompareTag("Obstacle"))
            //    {                                        
            //         GameManager.Instance.GameOver();                    
            //    }
            //}

            //Destroy(GameObject.FindGameObjectWithTag("Addition")); // Sembolü yok etme

        }
    }

    //bool Esitmi(/*int[] sonuc, int[] number*/)
    //{        

    //}


    //public void CheckAnswer()
    //{
    //    if (dogruCevap == RandomKodu.Instance.randomNumber)
    //    {
    //        Debug.Log("cevap dogru");
    //    }

    //    else
    //    {
    //        Debug.Log("cevap yanlis");
    //        Debug.Log(RandomKodu.Instance.randomNumber);
    //    }
    //}

    public void GenerateProblem()
    {
        //sayac = 5f; // Problem ekranda kalacak süreyi 5 saniye olarak ayarla

        //int num1 = Random.Range(1, 31);
        //int ciftSayi1 = num1 * 2;
        //int num2 = Random.Range(1, 31);
        //int ciftSayi2 = num2 * 2;
        //int operation = Random.Range(0, 4);
        //int num3 = Random.Range(1, 11);
        //int ciftSayi3 = num3 * 2;
        //int num4 = Random.Range(1, 11);
        //int ciftSayi4 = num4 * 2;


        //if (ciftSayi1 > ciftSayi2)
        //{
        //    switch (operation)
        //    {
        //        case 0:
        //            islem.text = $"{ciftSayi1} + {ciftSayi2} = ?";
        //            dogruCevap = ciftSayi1 + ciftSayi2;
        //            break;
        //        case 1:
        //            islem.text = $"{ciftSayi1} - {ciftSayi2} = ?";
        //            dogruCevap = ciftSayi1 - ciftSayi2;
        //            break;
        //    } 


        //    if (ciftSayi3 > ciftSayi4)
        //    {
        //        switch (operation)
        //        {

        //            case 2:
        //                islem.text = $"{ciftSayi3} * {ciftSayi4} = ?";
        //                dogruCevap = ciftSayi3 * ciftSayi4;
        //                break;
        //            case 3:
        //                //int result = num1 * num2;
        //                islem.text = $"{ciftSayi3} / {ciftSayi4} = ?";
        //                dogruCevap = ciftSayi3 / ciftSayi4;
        //                break;
        //        }
        //    }

        //}


        sayac = 5f; // Problem ekranda kalacak süreyi 5 saniye olarak ayarla

        int num1 = Random.Range(1, 31);
        int ciftSayi1 = num1 * 2;
        int num2 = Random.Range(1, 31);
        int ciftSayi2 = num2 * 2;

        //ciftSayi1'in her zaman ciftSayi2'den büyük olmasýný saðla
        if (ciftSayi1 < ciftSayi2)
        {
            int temp = ciftSayi1;
            ciftSayi1 = ciftSayi2;
            ciftSayi2 = temp;
        }

        int operation = Random.Range(0, 4);
        int num3 = Random.Range(1, 11);
        int ciftSayi3 = num3 * 2;
        int num4 = Random.Range(1, 11);
        int ciftSayi4 = num4 * 2;

        //ciftSayi3'ün her zaman ciftSayi4'ten büyük olmasýný saðla
        if (ciftSayi3 < ciftSayi4)
        {
            int temp = ciftSayi3;
            ciftSayi3 = ciftSayi4;
            ciftSayi4 = temp;
        }

        //if (ciftSayi1 > ciftSayi2)
        //{
        //    switch (operation)
        //    {
        //        case 0:
        //            islem.text = $"{ciftSayi1} + {ciftSayi2} = ?";
        //            dogruCevap = ciftSayi1 + ciftSayi2;
        //            break;
        //        case 1:
        //            islem.text = $"{ciftSayi1} - {ciftSayi2} = ?";
        //            dogruCevap = ciftSayi1 - ciftSayi2;
        //            break;
        //    }

        //    if (ciftSayi3 > ciftSayi4)
        //    {
        //        switch (operation)
        //        {
        //            case 2:
        //                islem.text = $"{ciftSayi3} * {ciftSayi4} = ?";
        //                dogruCevap = ciftSayi3 * ciftSayi4;
        //                break;
        //            case 3:
        //                islem.text = $"{ciftSayi3} / {ciftSayi4} = ?";
        //                dogruCevap = ciftSayi3 / ciftSayi4;
        //                break;
        //        }
        //    }
        //}


        switch (operation)
        {
            case 0:
                islem.text = $"{ciftSayi1} + {ciftSayi2} = ?";
                dogruCevap = ciftSayi1 + ciftSayi2;
                break;
            case 1:
                islem.text = $"{ciftSayi1} - {ciftSayi2} = ?";
                dogruCevap = ciftSayi1 - ciftSayi2;
                break;
            case 2:
                islem.text = $"{ciftSayi3} * {ciftSayi4} = ?";
                dogruCevap = ciftSayi3 * ciftSayi4;
                break;
            case 3:
                //int result = num1 * num2;
                islem.text = $"{ciftSayi3} / {ciftSayi4} = ?";
                dogruCevap = ciftSayi3 / ciftSayi4;
                break;
        }

        //public void SetTargetNumber(int number)
        //{
        //    targetNumber = number; // Hedef sayýyý belirleme
        //}
    }
    }
