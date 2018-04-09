using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour {

	public bool Check = false ; //Va a enviar el estado del objeto

	public int id;

	public void HandleState(){
		Check = true;
		Destroy (this.gameObject);

	}
}
