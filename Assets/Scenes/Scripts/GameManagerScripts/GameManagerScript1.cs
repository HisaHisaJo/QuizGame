using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript1 : MonoBehaviour
{

    public int score;
    public string truepoint;

    void Start()
    {
        //Debug.Log("現在のスコアは" + score + "点です");
    }

    void Update()
    {

    }

    public void OnClick(int number)
    {
        switch (number)//other.gameObject.tagにしたいのにできない。なんで。
        {
            case 0:
                score += 1;
                PlayerPrefs.SetInt(truepoint, score);
                Debug.Log("正解：現在のスコアは"　+ score + "点です");
                SceneManager.LoadScene("Game2");
                break;
            case 1:
                PlayerPrefs.SetInt(truepoint, score);
                Debug.Log("不正解：現在のスコアは"　+ score　+ "点です");
                SceneManager.LoadScene("Game2");
                break;
            default:
                break;
        }
    }
}