using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDataTransmitter : MonoBehaviour
{
    [SerializeField] private HeroInputController heroInputController;
    [SerializeField] private HeroTriggerController heroTriggerController;


    public int heroCount = 1;

    public float HeroXValues()
    {
        return heroInputController.newX;
    }

}
