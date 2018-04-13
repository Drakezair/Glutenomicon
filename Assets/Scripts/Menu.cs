using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void startButton(){
		SceneManager.LoadScene("InGame");
	}

	public void exitButton(){
		Application.Quit ();
		Debug.Log ("SE CERRO A LA VERGA");
	}
}
