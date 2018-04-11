using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GameManager : MonoBehaviour {


	//CRIATURAS

	public int Creatures;

	public Text CountCreatures;

	//SCOREBAR
	public Slider ScoreBar;

	[SerializeField]
	float MaxScore;

	public float Score;


	//COMBO BAR
	public Slider ComboBar;

	public float ComboTime;

	[SerializeField]
	float ComboTimeEnd;


	//TIEMPO
	[SerializeField]
	float Minutes, Seconds;

	[SerializeField]
	Text TimeText;


	//SPAWN
	public GameObject[] Ghoslys;

	float SpawnTime;

	[SerializeField]
	float DelayFrom, DelayTo;

	int Descarte;

	// Use this for initialization
	void Start () {
		SpawnTime = Random.Range (DelayFrom, DelayTo);
	}
	
	// Update is called once per frame
	void Update () {

		//SPAWN
		SpawnTime -= 1 + Time.deltaTime;

		if (SpawnTime <= 0) {
			
			for (int i = 0; i < Ghoslys.Length; i++) {
				Descarte = Random.Range (0, Ghoslys.Length);
				if (Ghoslys[Descarte] != null) {
					Ghoslys [Descarte].gameObject.SetActive (true);
					break;
				}
			}
			SpawnTime = Random.Range (DelayFrom, DelayTo);
		}

		//SCOREBAR
		ScoreBar.value = Score / MaxScore;


		//ComboBar

		ComboTime -= 1 * Time.deltaTime;

		if (ComboTime <= 0) {
			ComboTime = 0;
		}

		if (ComboTime >= 15) {
			ComboTime = 15;
		}

		ComboBar.value = ComboTime / ComboTimeEnd;

		//TIEMPO
		Seconds -= 1 * Time.deltaTime;

		if (Seconds < 0) {
			Minutes -= 1;
			Seconds = 59;
		}

		if (Minutes == 0 && Seconds == 0) {
			Debug.Log ("Se acabo el tiempo!!");
		}

		TimeText.text = Minutes.ToString("00") + ":" + Seconds.ToString("00");

		//Creatures Counter

		CountCreatures.text = Creatures.ToString ("D");
		
	}


}