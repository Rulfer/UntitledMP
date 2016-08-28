using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class InteractEnvironment : MonoBehaviour 
{
    public bool entered = false;
    public Text theText;
    public GameObject interactiveCar;
    public GameObject actualCar;

    void Start()
    {
        theText.text = "";
    }

	// Update is called once per frame
	void Update () 
    {
        if (entered == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                activateCar();
            }
        }
	}

    private void activateCar()
    {
        interactiveCar.SetActive(false);
        actualCar.SetActive(true);

        this.gameObject.SetActive(false);
    }
}
