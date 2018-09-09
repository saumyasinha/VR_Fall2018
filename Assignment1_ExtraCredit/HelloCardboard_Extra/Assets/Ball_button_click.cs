using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball_button_click : MonoBehaviour {

	public Rigidbody rb;
	public Text winText;
	// Use this for initialization
	void Start () {
		winText.text = "";
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) 
		{
			

//			rb.GetComponent<Rigidbody> ().AddForce (Camera.main.transform.forward * Random.Range (500, 750));
			rb.GetComponent<Rigidbody> ().useGravity=true;
		}

	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.transform.tag == "Target")
		{
			other.gameObject.SetActive(false);
			winText.text = "WHAMMM!!";
		}

	}


}