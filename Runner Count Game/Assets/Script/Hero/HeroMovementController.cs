using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovementController : MonoBehaviour
{
    [SerializeField] private HeroDataTransmitter heroDataTransmitter;

    Vector3 newHeroPosition;

    public float runningSpeed;



    void Update()
    {
        newHeroPosition = new Vector3
            (heroDataTransmitter.HeroXValues(),
            transform.position.y,
            transform.position.z + runningSpeed * Time.deltaTime);


        transform.position = newHeroPosition;

    }
}
