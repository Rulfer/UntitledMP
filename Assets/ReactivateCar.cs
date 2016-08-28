using UnityEngine;
using System.Collections;

public class ReactivateCar : MonoBehaviour 
{
    private bool entered = false;
    public GameObject car;

    void Start()
    {
        car.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            other.GetComponent<InteractEnvironment>().entered = true;
            other.GetComponent<InteractEnvironment>().theText.text = "E";
            other.GetComponent<InteractEnvironment>().interactiveCar = this.gameObject;
            other.GetComponent<InteractEnvironment>().actualCar = car;
        }
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<InteractEnvironment>().entered = false;
        other.GetComponent<InteractEnvironment>().theText.text = "";
        other.GetComponent<InteractEnvironment>().interactiveCar = null;
        other.GetComponent<InteractEnvironment>().actualCar = null;
    }
}
