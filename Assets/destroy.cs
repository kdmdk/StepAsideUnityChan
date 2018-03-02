using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

	private GameObject unitychan;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		this.unitychan = GameObject.Find ("unitychan");
		if (unitychan.transform.position.z - 5 > this.transform.position.z) {
			Destroy (this.gameObject);
		}
	}
}
