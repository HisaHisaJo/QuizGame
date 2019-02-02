using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadCSV2 : MonoBehaviour {
    //TextAsset csvFile; // CSVファイル
    //List<string[]> csvDatas = new List<string[]>(); // CSVの中身を入れるリスト;

    string[,] questionDate;

    public Text questionNumber;
    public Text questionText;
    public Text Line1;
    public Text Line2;
    public Text Line3;
    public Text Line4;

    void Start()
    {
        questionDate = csvManager.ReadCsvFile("CSV/QuizGameSpred");

        //for(int i = 0; i < questionDate.GetLength(0); i++)
        //{
        //    for (int j = 0; j < questionDate.GetLength(1); j++) ;
        //}

        questionNumber.text = questionDate[2, 0];
        questionText.text = questionDate[2,1];
        Line1.text = questionDate[2, 2];
        Line2.text = questionDate[2, 3];
        Line3.text = questionDate[2, 4];
        Line4.text = questionDate[2, 5];
    }
}

//CSVデータの読み込みは完了
//これをどうやってクイズに落とし込むのか。
//逆の思考から考えよう
//クイズ1問ずつSceneで整備
//questionDateの(x,x)を1,2,3のボタンのtextに配置
//1だったら正解
//2,3だったら不正解
//といったようにしてデータを保持していく
//最終問題終わったらEndScene用意しておいてあなたの点数はx点というものを表示する
