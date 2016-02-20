using UnityEngine;
using System.Collections;

public class TextTimer : MonoBehaviour {

    float timer;

    
    // Use this for initialization
	void Start () {
        timer = 5f;

    }
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            gameObject.SetActive(false);
            timer = 5f;
        }
        
	}
}
