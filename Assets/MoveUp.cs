using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MoveUp : MonoBehaviour {

	//public GameObject botton;
	public GameObject Pointer;

	public bool activado = false;

	void Update () {
		if (Pointer.activeInHierarchy) {
			
			activado = true;
			//botton.SetActive (true);
		} else {
			activado = false;
			//botton.SetActive (false);
			StopCoroutine ("wait");

		}
			
	}
		
	public void MoveBoxUp(){
		if (activado = true) {
			StartCoroutine ("wait");

		} else if(activado = false) {
			StopCoroutine ("wait");

		}
	

	}


	void aparecer(){
		SceneManager.LoadScene("cotiza");

	}
		
	public void CambiarScena(string scena){
			SceneManager.LoadScene(scena);

	}



	private IEnumerator wait(){
		yield return new WaitForSeconds (2.3f);
		SceneManager.LoadScene("cotiza");

	}
}
