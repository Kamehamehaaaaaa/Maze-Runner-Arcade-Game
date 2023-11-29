using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class End : MonoBehaviour {

    public Text EndText;
    public static bool Success = false;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Success = true;
            EndText.text = "You Win";
            ThirdPersonUserControl.PlayerMove = false;
            FindObjectOfType<AudioManager>().Pause("Theme");
            FindObjectOfType<AudioManager>().Play("Victory");
        }
    }
}
