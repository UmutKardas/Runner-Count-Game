using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroTriggerController : MonoBehaviour
{
    [SerializeField] private HeroDataTransmitter heroDataTransmitter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Quad"))
        {
            heroDataTransmitter.heroCount += other.gameObject.GetComponent<QuadRandomNumber>().randomNumber;
            Destroy(other.gameObject);
            if (heroDataTransmitter.heroCount <= 0)
            {
                SceneManager.LoadScene(0);
            }
        }
        else if (other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(0);
        }

    }
}
