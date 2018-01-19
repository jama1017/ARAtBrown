using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangScenes : MonoBehaviour {

	// Use this for initialization
	public void paw () {
		SceneManager.LoadScene("PawScene");
	}
	
	// Update is called once per frame
	public void schedule () {
		SceneManager.LoadScene ("ScheduleScene");
	}
}
