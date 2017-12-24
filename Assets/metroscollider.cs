using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metroscollider : MonoBehaviour {

	public GameObject medida;

	// Use this for initialization


	void OnTriggerEnter(Collider other){

		if (other.tag == "Player") {
			
			medida.SetActive (true);
		} else {
		
			medida.SetActive (false);
		
		}

	}



	void OnTriggerExit(Collider other){

		if (other.tag == "Player") {

			medida.SetActive (false);
		} else {

			medida.SetActive (true);

		}

	}

}
