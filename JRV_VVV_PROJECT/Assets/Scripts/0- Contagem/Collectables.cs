using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectables : MonoBehaviour
{
    PointBoard pointBoardScript;
    private Animator anim;
    public float newAnimationSpeed = 2f; 

    private void Start()
    {
        pointBoardScript = GameObject.Find("Texto Pontuação").GetComponent<PointBoard>(); //vai buscar o script pointBoard a pasta
        anim = GetComponent<Animator>(); 
    }

//script soma 300 pontos ao colidir com o Collectable (diamond)
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Collectable"){
            //pointBoardScript.points += 300;
            pointBoardScript.pointsText.text = pointBoardScript.points.ToString();
            Destroy(other.gameObject);
        }
        if(other.tag == "Collectable2"){
            //pointBoardScript.points += 300;
            Destroy(other.gameObject);
            anim.speed = newAnimationSpeed; 
        }
    }
}
