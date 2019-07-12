using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


	// Update is called once per frame
	void Update () {
		
	}

	private Color frntcrop = Color.white;

	void OnTriggerEnter(Collider other)
	{
		Renderer render = GetComponent<Renderer>();

		frntcrop = render.material.color;
		render.material.color = Color.green;
	}
	void OnTriggerExit(Collider other)
	{
		Renderer render = GetComponent<Renderer>();
	    render.material.color = Color.white;
	}

}
