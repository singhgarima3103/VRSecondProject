//Wgat?
using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Trigger : MonoBehaviour {

    Ray playerRay;
    RaycastHit playerRaycastHit;
    int range = 20;
    public Text ankylosaurus_info;
    public Text brontosaurus_info;
	public Text carnotaurus_info;
	public Text velociraptor_info;
	public Text triceratops_info;
	public Text tiranosaurus_info;
	public Text stegosaurus_info;
	public Text spinosaurus_info;
	public Text parasaurolophus_info;
	public AudioSource ankylosaurus_audio;
	public AudioSource brontosaurus_audio;
	public AudioSource carnotaurus_audio;
	public AudioSource velociraptor_audio;
	public AudioSource triceratops_audio;
	public AudioSource tiranosaurus_audio;
	public AudioSource stegosaurus_audio;
	public AudioSource spinosaurus_audio;
	public AudioSource parasaurolophus_audio;


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
			ankylosaurus_audio.gameObject.SetActive (true);
            ankylosaurus_info.gameObject.SetActive(true);
            background.gameObject.SetActive(true);
        }
		if (aim.CompareTag("Brontosaurus"))
        {
			brontosaurus_audio.gameObject.SetActive (true);
            brontosaurus_info.gameObject.SetActive(true);
            background.gameObject.SetActive(true);
        }
		if (aim.CompareTag("Carnotaurus"))
		{
			carnotaurus_audio.gameObject.SetActive (true);
			carnotaurus_info.gameObject.SetActive(true);
			background.gameObject.SetActive(true);
		}
		if (aim.CompareTag("Velociraptor"))
		{
			velociraptor_audio.gameObject.SetActive (true);
			velociraptor_info.gameObject.SetActive(true);
			background.gameObject.SetActive(true);
		}
		if (aim.CompareTag("Triceratops"))
		{
			triceratops_audio.gameObject.SetActive (true);
			triceratops_info.gameObject.SetActive(true);
			background.gameObject.SetActive(true);
		}
		if (aim.CompareTag("Tiranosaurus"))
		{
			tiranosaurus_audio.gameObject.SetActive (true);
			tiranosaurus_info.gameObject.SetActive(true);
			background.gameObject.SetActive(true);
		}
		if (aim.CompareTag("Stegosaurus"))
		{
			stegosaurus_audio.gameObject.SetActive (true);
			stegosaurus_info.gameObject.SetActive(true);
			background.gameObject.SetActive(true);
		}
		if (aim.CompareTag("Spinosaurus"))
		{
			spinosaurus_audio.gameObject.SetActive (true);
			spinosaurus_info.gameObject.SetActive(true);
			background.gameObject.SetActive(true);
		}
		if (aim.CompareTag("Parasaurolophus"))
		{
			parasaurolophus_audio.gameObject.SetActive (true);
			parasaurolophus_info.gameObject.SetActive(true);
			background.gameObject.SetActive(true);
		}

        

    }
}
