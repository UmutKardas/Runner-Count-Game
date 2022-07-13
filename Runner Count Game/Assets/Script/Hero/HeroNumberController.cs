using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class HeroNumberController : MonoBehaviour
{
    [SerializeField] private HeroDataTransmitter heroDataTransmitter;
    [SerializeField] private TMP_Text additiveNumber;

    void Update()
    {
        HeroNumberValues();

    }

    private void HeroNumberValues()
    {

        additiveNumber.text = heroDataTransmitter.heroCount.ToString();

    }
}
