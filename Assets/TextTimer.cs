using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextTimer : MonoBehaviour {

	public float gameMin=10,gameSec=10;
	float minutes,seconds;
	[HideInInspector]string timeText;
	Text txtTimer;
	// Use this for initialization
	void Start () {
	
		txtTimer = GetComponent<Text>();
		minutes = gameMin;
		seconds = gameSec;
		//txtTimer.rectTransform.position = new Vector2(Screen.width/2,Screen.height-txtTimer.rectTransform.sizeDelta.y-15f);
	}
	
	// Update is called once per frame
	void Update () {


		seconds -= Time.deltaTime;
			Debug.Log(seconds);
		if(seconds <= 0)
		{
			minutes--;

			seconds = 60f;
		}
			timeText = minutes.ToString("00") + ":" + seconds.ToString("00");
		
			txtTimer.text = timeText;

	}



}
