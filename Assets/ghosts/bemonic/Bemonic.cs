using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bemonic : MonoBehaviour {

	[SerializeField]
	GameObject[] Points;

	int Lives;

	int ToPoint = -1;

	[SerializeField]
	Image Amount;

	[SerializeField]
	Image BarColor;

	[SerializeField]
	float[] Times; //Tiempos que corren

	int ThisTime; //selector de tiempos

	float[] timeEnd; //tiempos estaticos

	// Use this for initialization
	void Start () {
		BarColor.color = Color.green;

		timeEnd = new float[Times.Length];

		for (int i = 0; i < Times.Length; i++) {
			timeEnd [i] = Times [i];
		}
	}
	
	// Update is called once per frame
	void Update () {

		Times [ThisTime] -= 1 * Time.deltaTime;

		Amount.fillAmount = Times [ThisTime] / timeEnd[ThisTime];

		if (Amount.fillAmount <= 0.5) {
			BarColor.color = Color.yellow;
			if (Amount.fillAmount <= 0.2) {
				BarColor.color = Color.red;
			}
		}

		if (Times [ThisTime] <= 0) {
			Destroy (gameObject);
		}

		gameObject.transform.position = Vector3.MoveTowards (gameObject.transform.position, Points [ToPoint].transform.position, 5f);
	}

	public void tap(){

		BarColor.color = Color.green;

		ThisTime += 1;

		Lives += 1;

		ToPoint += 1;


		if (Lives > Points.Length) {
			Destroy (gameObject);
		}

		if (Points [ToPoint].transform.position.x > transform.position.x) {
			transform.localScale = new Vector3 (-1, 1, 1);
			Amount.transform.localScale = new Vector3 (-1, 1, 1);
		} else {
			transform.localScale = new Vector3 (1, 1, 1);
			Amount.transform.localScale = new Vector3 (1, 1, 1); 

		}
	}
}
