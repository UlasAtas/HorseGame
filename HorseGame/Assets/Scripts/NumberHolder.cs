using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberHolder : MonoBehaviour
{
    public int number;
    public TextMeshProUGUI numberText;

    private void Start()
    {
        if (numberText != null)
        {
            numberText.text = number.ToString();
        }
    }

    public void SetNumber(int newNumber)
    {
        number = newNumber;
        if (numberText != null)
        {
            numberText.text = number.ToString();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Player tag'ini kontrol ediyoruz
        {
            //Debug.Log("Çarptýðýnýz prefab'ýn sayýsý: " + number);
            CheckAnswer();
            Destroy(gameObject);
        }


    }

    public void CheckAnswer()
    {
        if (SymbolController.Instance.dogruCevap == number)
        {
            //Debug.Log("cevap dogru");
            GameManager.Instance.score += 50;

        }

        else
        {
            //Debug.Log("cevap yanlis");
            //Debug.Log(SymbolController.Instance.dogruCevap);


            for (int i = 0; i < GameManager.Instance.canUI.Length; i++)
            {
                if (GameManager.Instance.canUI[2])
                {
                    Destroy(GameManager.Instance.canUI[2]);
                }
                else if (GameManager.Instance.canUI[1])
                {
                    Destroy(GameManager.Instance.canUI[1]);
                }
                else if (GameManager.Instance.canUI[0])
                {
                    Destroy(GameManager.Instance.canUI[0]);
                }
            }
            GameManager.Instance.can--;
            Debug.Log(GameManager.Instance.can);
            if (GameManager.Instance.can == 0)
            {
                GameManager.Instance.GameOver();
            }

        }
    }

    
}
