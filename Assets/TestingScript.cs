using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingScript : MonoBehaviour
{
    public const string TITLE = "Tugas #1 Kelas C# Dojo";
    public string variable;
    public int score;
    public bool answer1, answer2, answerRestart, stop;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(TITLE);
        Restart();
    }

    void Restart()
    {
        Debug.Log("Uji kemampuan sains kamu, yuk!");
        Debug.Log("1 + 1 = ...? \nA. 2 B. Jendela");
        answer1 = false;
        answer2 = false;
        answerRestart = false;
        stop = false;
        variable = "";
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(variable);
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Pilih A");
            if (variable == "Jawaban Restart") variable = "Restarted";
            else if (answer1 == false) variable = "A";
            else if (answer2 == false && answer1 == true && stop == false) variable = "AA";
            // Debug.Log(variable);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("Pilih B");
            if (variable == "Jawaban Restart") variable = "Not Restarted";
            else if (answer1 == false) variable = "B";
            else if (answer2 == false && answer1 == true && stop == false) variable = "AB";
        }

        if (variable == "A")
        {

            Debug.Log("Hebat! Kamu pasti ranking 1");
            Debug.Log(score = score + 100);
            answer1 = true;
            Debug.Log("kalau turunan dari Sin (A)? \nA. -Cos (A) \nB. Cos (A)");
            variable = "";
        }
        else if (variable == "B")
        {
            Debug.Log("Kamu pasti orangnya humoris ya :D");
            Debug.Log(score);
            answer1 = true;
            stop = true;
            variable = "";
        }


        else if (variable == "AA")
        {
            Debug.Log("Goodluck next time!");
            Debug.Log(score - 100);
            answer2 = true;
            stop = true;
            variable = "";
        }

        else if (variable == "AB")
        {
            Debug.Log("Pasti sains kamu top global!");
            Debug.Log(score = score + 100);
            answer2 = true;
            stop = true;
            variable = "";
        }

        else if (variable == "Restarted")
        {
            Debug.Log("Restarting game");
            Restart();
        }

        else if (variable == "Not Restarted")
        {
            answerRestart = true;
        }

        else if (stop == true && variable != "Jawaban Restart")
        {
            Debug.Log("Restart gak? \nA. Yes B. No");
            variable = "Jawaban Restart";
        }




    }
}
