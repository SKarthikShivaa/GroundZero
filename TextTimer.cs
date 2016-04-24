using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextTimer : MonoBehaviour {

	public float gameMin=0,gameSec=10;
	float minutes,seconds;
	[HideInInspector]public bool timerEnd = false;
	[HideInInspector]public bool startTimer = false;
	[HideInInspector]string timeText;
	Text txtTimer;
	// Use this for initialization
	void Start () {
		Reset();
		txtTimer = GetComponent<Text>();
		txtTimer.rectTransform.position = new Vector2(Screen.width/2,Screen.height-txtTimer.rectTransform.sizeDelta.y-15f);
	}
	
	// Update is called once per frame
	void Update () {

		if(startTimer)
		{
		seconds -= Time.deltaTime;
		if(seconds <= 0)
		{
			minutes--;
			if(minutes<0)
			{
				timerEnd = true;
			}
			seconds = 60f;
		}

		if(!timerEnd)
		{
			
			timeText = minutes.ToString("00") + ":" + seconds.ToString("00");
		}
		else
			timeText = "00:00";
		}
		else
		timeText = minutes.ToString("00") + ":" + seconds.ToString("00");

		txtTimer.text = timeText;

	}

	public void Reset()
	{
		minutes=gameMin;
		seconds=gameSec;
		timerEnd = false;
		startTimer = false;
	}

	public void Restart()
	{
		startTimer = true;
	}


}
