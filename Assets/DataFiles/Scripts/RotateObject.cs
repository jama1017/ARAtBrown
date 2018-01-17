using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

	Vector3 rotate;
	// Use this for initialization
	void Start () {
		rotate = new Vector3 (0, 0, 100);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (rotate * Time.deltaTime);
	}
}
