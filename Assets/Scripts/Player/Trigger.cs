using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Trigger : MonoBehaviour {

    Ray playerRay;
    RaycastHit playerRaycastHit;
    int range = 20;
    public Text ankylosaurus_info;
    public Text brontosaurus_info;
    public Image background;

    void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
        {
            Interact();
        }
    }

    void Interact()
    {
        playerRay.origin = GetComponent<Transform>().position;
        playerRay.direction = GetComponent<Transform>().forward;
        Physics.Raycast(playerRay, out playerRaycastHit, range);
        GameObject aim = playerRaycastHit.collider.gameObject;
        //ankylosaurus_info.gameObject.SetActive(true);
        //aim.SetActive(false);
		if ( aim.tag == "Ankylosaurus")
        {
            ankylosaurus_info.gameObject.SetActive(true);
            background.gameObject.SetActive(true);
        }
		if (aim.CompareTag("Brontosaurus"))
        {
            brontosaurus_info.gameObject.SetActive(true);
            background.gameObject.SetActive(true);
        }

        

    }
}
