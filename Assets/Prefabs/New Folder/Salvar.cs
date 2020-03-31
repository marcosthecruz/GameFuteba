using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Salvar : MonoBehaviour {

	public Text txt;
	public InputField caixaTxt;
	private float testeF;
	private int testeI;
	private string testeS;


	void Start () {
		txt.text = PlayerPrefs.GetString("pontoss");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SalvarFloat(){
		testeS = caixaTxt.text;
		PlayerPrefs.SetString ("pontoss", testeS);

	}
}
