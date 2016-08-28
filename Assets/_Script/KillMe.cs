using UnityEngine;
using System.Collections;

public class KillMe : MonoBehaviour 
{
    public GameObject boomParticle;
	private void OnCollisionEnter(Collision hit)
	{
		if (hit.transform.tag == "Player") 
		{
			hit.gameObject.GetComponent<Health>().TakeDamage(10);
		}
		Debug.Log (hit.transform.tag);
        Instantiate(boomParticle, this.transform.position, this.transform.rotation);
		Destroy (this.gameObject);
	}
}
