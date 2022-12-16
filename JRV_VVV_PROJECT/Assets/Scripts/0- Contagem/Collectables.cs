using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectables : MonoBehaviour
{
    PointBoard pointBoardScript;

    private void Start()
    {
        pointBoardScript = GameObject.Find("Texto Pontuação").GetComponent<PointBoard>(); //vai buscar o script pointBoard a pasta
    }

//script soma 300 pontos ao colidir com o Collectable (diamond)
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Collectable"){
            pointBoardScript.points += 300;
            pointBoardScript.pointsText.text = pointBoardScript.points.ToString();
            Destroy(other.gameObject);
        }
    }
}
