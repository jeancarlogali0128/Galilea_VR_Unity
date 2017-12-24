using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giroscopio : MonoBehaviour {

	public GameObject VRCam;
	private float PosicionInicialY = 0f;
	private float PosicionDelGyroEnY= 0f;
	private float CalibrarEnLaPosicionY =0f;

	public bool SeInicio;


	void Start () {
		Input.gyro.enabled = true;
		PosicionInicialY = VRCam.transform.eulerAngles.y;
	}
	void Update () {
		AplicarRotacionDelGyroscopio ();
		AplicarCalibracion ();

		if (SeInicio == true) {
			Invoke ("CalibrarPosicionY",3f);
			SeInicio = false;
		}
	}
	void AplicarRotacionDelGyroscopio(){
		//devuelve la orientacion en el espacio del dispositivo
		VRCam.transform.rotation = Input.gyro.attitude;
		VRCam.transform.Rotate (0f, 0f, 180f,Space.Self);
		VRCam.transform.Rotate (90f, 180f, 0f,Space.World);
		PosicionDelGyroEnY = VRCam.transform.eulerAngles.y;
	}
	void CalibrarPosicionY(){
		CalibrarEnLaPosicionY = PosicionDelGyroEnY - PosicionInicialY;
	}
	void AplicarCalibracion(){
		VRCam.transform.Rotate (0f, -CalibrarEnLaPosicionY, 0f, Space.World);
	}
}
