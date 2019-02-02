using System;
using System.Collections.Generic;

[Serializable]

public class QuizManager
{

    public string question;
    public string[] answers = new string[4];

    public QuizManager(string _question, string _answer0, string _answer1, string _answer2, string _answer3)
    {

        question = _question;
        answers[0] = _answer0;
        answers[1] = _answer1;
        answers[2] = _answer2;
        answers[3] = _answer3;
    }


}
