using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleButton : MonoBehaviour {

    public GameObject Bean;
    public GameObject Lady;
    public GameObject Bear;
    public GameObject Car;

     

    public void showBean(bool enabled)
    {
        Bean.SetActive(enabled);
    }

    public void showLady(bool enabled)
    {
        Lady.SetActive(enabled);
    }
    public void showBear(bool enabled)
    {
        Bear.SetActive(enabled);
    }
    public void showCar(bool enabled)
    {
        Car.SetActive(enabled);
    }
}
