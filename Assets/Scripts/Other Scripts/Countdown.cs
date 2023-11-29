using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class Countdown : MonoBehaviour {

    public int timeLeft = 60;
    public Text countdownText;
    public Text restartText;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        if (End.Success == false)
        {
            countdownText.text = ("Time Left = " + timeLeft);

            if (timeLeft <= 0)
            {
                StopCoroutine("LoseTime");
                countdownText.text = "Times Up!";
                ThirdPersonUserControl.PlayerMove = false;
                restartText.text = "Press R for New Maze";
            }
        }
        else
        {
            StopCoroutine("LoseTime");
            countdownText.text = "";
            restartText.text = "";
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
