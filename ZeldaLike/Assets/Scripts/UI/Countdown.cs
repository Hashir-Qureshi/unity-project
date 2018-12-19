using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    public IntValue timeLeft;
    public Text timer;
	// Use this for initialization
	void Start () {
        StartCoroutine(LoseTime());
	}
	
	// Update is called once per frame
	void Update () {
        string minutes = Mathf.Floor(timeLeft.RuntimeValue / 60).ToString("00");
        string seconds = (timeLeft.RuntimeValue % 60).ToString("00");
        timer.text = (string.Format("{0}:{1}", minutes, seconds));
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft.RuntimeValue--;
        }
    }
}
