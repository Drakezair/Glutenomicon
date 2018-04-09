using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour {

	public DataBase DB;

	public bool[] ToFind; //Por encontrar

	public bool[] ToCheck; //Lista de confirmacion

	public bool[] Finded; //ya encontrados

	public GameObject[] Objects; //lista de objetos del nivel

	public bool Right;

	public bool Left;

	public float speed;

	public GameObject cameraObject;
	 
	// Use this for initialization
	void Start () {

		Objects = GameObject.FindGameObjectsWithTag ("Object");

		ToCheck = new bool[Objects.Length];

	}
	
	// Update is called once per frame
	void Update () {
		moveCamera ();
		
	}

	public void ReciveList(){
		for(int i = 0; i < ToCheck.Length; i++){

			ToCheck [i] = Objects[i].GetComponent<Objeto> ().Check;

		}
	}

	void CheckingList(){


	}

	void HandleListChange(){

	
	}

	public void moveCamera(){


		if (cameraObject.gameObject.transform.position.x <= 5.64
			&& cameraObject.gameObject.transform.position.x <= -5.64) {

			if (Right) {
				GetComponent<Camera>().gameObject.transform.position = (new Vector2 (1 * speed * Time.deltaTime, 0));
			}
		}
	}

	public void goToRight(){
		Right = true;
		Debug.Log ("hola");
	}

	public void goToLeft(){
		Left = true;
	}


}


[System.Serializable]
public class DataBase {

	public Objeto[] Objetos;

}

[System.Serializable]
public class objeto : MonoBehaviour  {

	public int id;
	public Sprite Imagen;

}