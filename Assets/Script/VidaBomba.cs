﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaBomba : MonoBehaviour {

	private GameObject bombaRep;

	void Start () {
		bombaRep = GameObject.Find ("BombaR");
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (Vida ());
	}

	IEnumerator Vida(){	
		Destroy (bombaRep.gameObject);
		yield return new WaitForSeconds (0.5f);
		Destroy(this.gameObject);	


	}
}
