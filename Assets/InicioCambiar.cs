using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class InicioCambiar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine ("Countdown");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private IEnumerator Countdown(){
		yield return new WaitForSeconds (2f);
		SceneManager.LoadScene("ingresar");
	
	}
}
