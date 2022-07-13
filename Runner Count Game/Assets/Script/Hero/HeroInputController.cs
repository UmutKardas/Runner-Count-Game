using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInputController : MonoBehaviour
{
    public float limitX;
    public float mouseX;
    public float newX;
    public float speedX;

    void Update()
    {
        GetHeroX();

    }


    // GetHeroHorizontalPoisiton
    private void GetHeroX()
    {
        if (Input.GetMouseButton(0))
        {
            mouseX = Input.GetAxis("Mouse X");
        }
        newX = transform.position.x + speedX * mouseX * Time.deltaTime;
        newX = Mathf.Clamp(newX, -limitX, limitX);

    }
}
