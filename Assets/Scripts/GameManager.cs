using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GameManager : MonoBehaviour {

	public DataBase DB;

	public GameObject[] Angels;

	public Slider ScoreBar;

	[SerializeField]
	float MaxScore;

	public float Score;

	 
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		ScoreBar.value = Score / MaxScore;
		
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