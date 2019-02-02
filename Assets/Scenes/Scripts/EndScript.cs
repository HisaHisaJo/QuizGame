using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour {

    public int score;
    string truepoint;
    public Text scoreText;

	// Use this for initialization
	void Start () {
        score = PlayerPrefs.GetInt(truepoint);
        scoreText.text = score.ToString() + "点";
        Debug.Log(score);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        SceneManager.LoadScene("Start");
    }
}

