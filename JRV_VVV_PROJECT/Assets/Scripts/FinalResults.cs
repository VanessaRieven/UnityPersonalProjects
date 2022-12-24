using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinalResults : MonoBehaviour
{
    PointBoard pointBoardScript;
    public Text p1_total_1;
    public Text p2_total_1;
    public Text p1_total_2;
    public Text p2_total_2;
    private string my_text1;
    private string my_text2;

    public GameObject P1_FinalWinner;
    public GameObject P2_FinalWinner;
    public GameObject P1_FinalLoser;
    public GameObject P2_FinalLoser;
    
    void Start()
    {
        pointBoardScript = GameObject.Find("Texto Pontuação").GetComponent<PointBoard>();
    }

    void Update()
    {
        my_text1 = pointBoardScript.p1_pointsText.text;
        p1_total_1.text = my_text1;
        p1_total_2.text = my_text1;

        my_text2 = pointBoardScript.p2_pointsText.text;
        p2_total_1.text = my_text2;
        p2_total_2.text = my_text2;


        //Player 1 Win:
        if (int.Parse(my_text1) > int.Parse(my_text2))
        {
            P1_FinalWinner.SetActive(true);
            P2_FinalWinner.SetActive(false);
            P1_FinalLoser.SetActive(false);
            P2_FinalLoser.SetActive(true);
        }

        //Player 2 Win:
        if (int.Parse(my_text1) < int.Parse(my_text2))
        {
            P1_FinalWinner.SetActive(false);
            P2_FinalWinner.SetActive(true);
            P1_FinalLoser.SetActive(true);
            P2_FinalLoser.SetActive(false);
        }
    }

}
