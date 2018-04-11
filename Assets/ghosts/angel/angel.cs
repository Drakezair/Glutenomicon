using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class angel : MonoBehaviour {

	[SerializeField]
	float speed = 0.2f;

	[SerializeField]
	float limit;

	[SerializeField]
	bool Taped = false;

	float X,Y;

	[SerializeField]
	int Dir;

	public GameManager GM;

	// Use this for initialization
	void Start () {

		selector (Dir);

	}

	// Update is called once per frame
	void Update () {

		if (gameObject.transform.localPosition.x <= -28 ||gameObject.transform.localPosition.x >= 1540) {
			Destroy (gameObject);
			Debug.Log ("HOLA");
		}

		gameObject.transform.Translate (X * speed,Y * speed,0);
		
	}


	public void taped(){

		if (Taped) {
			GM.ComboTime += 15;
			GM.Score += 10;
			GM.Creatures += 1;
			Destroy (gameObject);
		} else {

			Taped = true;
			speed += 0.4f;
		}

	}

	// MOVIMIENTOS

	public void toLeft(){
		X = -1;
		Y = 0;
	}


	public void toRight(){
		X = 1;
		Y = 0;
		gameObject.transform.localScale = new Vector3(-1,1,1);
	}

	// SELECTOR

	public void selector(int i){

		switch (i) {

		case 0:
			toLeft ();
			break;
		case 1:
			toRight ();
			break;
		}
	}
}

