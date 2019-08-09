using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	// Reload scene using scene name
	public void RestartGame () 
	{
		SceneManager.LoadScene ("AR_SurgeHouse");	
	}

    // Reload active scene
	public void ResetScene ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
