using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleDisplay : MonoBehaviour {

	public GameObject info;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			info.SetActive (true);

		}

		if (Input.GetKeyDown (KeyCode.Z)) {
			info.SetActive (false);

		}
			
	}
}
