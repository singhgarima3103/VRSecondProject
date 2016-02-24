using UnityEngine;
using System.Collections;

public class Player_Particle : MonoBehaviour {

	public GameObject PartSys;
	float timer,timer1;
	// Use this for initialization
	void Start () {
	}
	void OnTriggerEnter( Collider collider)
	{
		if (collider.gameObject.tag == "Player") {
			collider.isTrigger (true);
		} else
			collider.isTrigger (false);
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (collider.isTrigger == "true" && timer >= 0) {
			timer = 5f;
			PartSys.gameObject.SetActive (true);
		}
	}
}
