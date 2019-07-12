using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleText : MonoBehaviour {
	public GameObject UiObject;
	public GameObject cube;
	// Use this for initialization
	void Start () {
		UiObject.SetActive(false);
	}
	 void OnTriggerEnter(Collider other)
	{
		//if (other.tag -- "Untagged")
		{
			UiObject.SetActive(true);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerExit(Collider other)
	{
		UiObject.SetActive(false);
		Destroy(cube);
	}
}

