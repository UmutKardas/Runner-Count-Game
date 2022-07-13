using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuadRandomNumber : MonoBehaviour
{
    public int randomNumber;
    [SerializeField] private TMP_Text randomNumberText;
    [SerializeField] private bool isPositive;
    [SerializeField] private Color positiveColor;
    [SerializeField] private Color negativeColor;

    void Start()
    {
        GenerateRandomQuadNumber();
        SetQuadNumberText();
    }


    private void GenerateRandomQuadNumber()
    {
        if (isPositive)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = positiveColor;
            randomNumber = Random.Range(1, 9);
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material.color = negativeColor;
            randomNumber = Random.Range(-9, -1);

        }
    }



    private void SetQuadNumberText()
    {
        randomNumberText.text = randomNumber.ToString();
    }

}
