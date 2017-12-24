using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GestionBD : MonoBehaviour {

	public InputField txtusuario;
	public InputField txtdni;
	public string nombreUsuario;
	public string dni;

	public void iniciarSesion(){
	
		StartCoroutine (login ());
		StartCoroutine (registrar());
	}
		

	IEnumerator login (){
	
		WWW coneccion = new WWW ("http://shared-host.azurewebsites.net/galilea/conexion.php?uss="+ txtusuario.text);
		yield return(coneccion);
		if (coneccion.text == "bien") {
			SceneManager.LoadScene("ciudadesusuario");
		} else if (coneccion.text == "mal") {
			
			SceneManager.LoadScene("ciudades");
		
		}
	}

	IEnumerator registrar (){

		WWW coneccion = new WWW ("http://shared-host.azurewebsites.net/galilea/registro.php?uss=" + txtusuario.text + "&$dni" + txtdni.text);
		yield return(coneccion);
		if (coneccion.text == "mal") {

		} else if (coneccion.text == "bien") {

			nombreUsuario = txtusuario.text;
			dni = txtdni.text;

			
		}

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
