using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class cambiarScena : MonoBehaviour {

	public GameObject Pointer;






	public void ingresar (string scena){


		SceneManager.LoadScene(scena);
	}
}
