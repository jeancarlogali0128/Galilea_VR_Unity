using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateCuota : MonoBehaviour {

	public Text precioTxt;
	public Text tasaTxt;
	public Text prestamoTxt;
	public Text cuotaInicialTxt;
	public Text plazoTxt;
	public Text CuotaMensualTxt;

	// Update is called once per frame
	void Update () {
		MyUpdateCuota ();
	}

	void MyUpdateCuota(){
		//Conviertes todos tus campos a numeros usables
		float precio = getInt (precioTxt);
		float tasa = getInt (tasaTxt);
		float prestamo = getInt (prestamoTxt);
		float cuotaInicial = getInt (cuotaInicialTxt);
		float plazo = getInt (plazoTxt);


		float montoPrestamo = precio - (precio * cuotaInicial / 100);
	
		float cuotaMensual = (montoPrestamo * (1.0f + (tasa / 100.0f)) / (plazo * 12.0f));


		CuotaMensualTxt.text = "$ " + cuotaMensual.ToString ("F2");
		prestamoTxt.text = "$ " + montoPrestamo.ToString ();
		Debug.Log ("Debugg");
		Debug.Log (precio);
		Debug.Log (tasa);
		Debug.Log (prestamo);
		Debug.Log (cuotaInicial);
		Debug.Log (plazo);
	}

	int getInt(Text precio){

		string tmp = "";
		foreach (char character in precio.text) {
			if ("1234567890".Contains (character.ToString())) {
				tmp += character;
			}
		}
		int precioInt;
		int.TryParse (tmp, out precioInt);
		return precioInt;
	}

}
