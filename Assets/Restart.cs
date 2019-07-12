using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	// Use this for initialization
	public void RestartGame () 
	{
		SceneManager.LoadScene ("AR_SurgeHouse");	
	}
}
