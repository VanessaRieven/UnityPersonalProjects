using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectables : MonoBehaviour
{
    PointBoard pointBoardScript;
    public Animator anim;
    public float newAnimationSpeed = 2f;
    public Color player1Color = new Color(1.7f, 1.5f, 0.75f, 1f);
    public GameObject[] floorBoxs;
    

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
            Debug.Log(other.tag);

            floorBoxs = GameObject.FindGameObjectsWithTag("Floor");

            foreach (GameObject floorBox in floorBoxs)
            {
                if (floorBox. GetComponent<Renderer>().material.color == player1Color) {
                    floorBox.GetComponent<Renderer>().material.color = Color.white;
                }
            }

;        }
        if(other.tag == "Collectable2"){
            //pointBoardScript.points += 300;
            Destroy(other.gameObject);
            anim.speed = newAnimationSpeed;
        }
    }
}
