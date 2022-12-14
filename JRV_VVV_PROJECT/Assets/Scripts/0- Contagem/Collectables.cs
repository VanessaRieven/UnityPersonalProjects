using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectables : MonoBehaviour
{
    PointBoard pointBoardScript;
    //PointBoard pointBoardScript2;
    public Animator anim;
    public float newAnimationSpeed = 2f;
    public Color player1Color = new Color(1.7f, 1.5f, 0.75f, 1f);
    public Color player2Color = new Color(0f, 1f, 1f, 1f);
    public GameObject[] floorBoxs;
    public bool timeTrigger1 = false;  
    public bool timeTrigger2 = false;  

    private void Start()
    {
        pointBoardScript = GameObject.Find("Texto Pontuação").GetComponent<PointBoard>(); //vai buscar o script pointBoard a pasta
        //pointBoardScript2 = GameObject.Find("Final Results").GetComponent<PointBoard>();
        anim = GetComponent<Animator>();
    }

    //script soma 300 pontos ao colidir com o Collectable (diamond)
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Collectable"){
            if(tag == "Player")
            {
                pointBoardScript.p1_pointsText.text = pointBoardScript.p1_Points.ToString();
                //pointBoardScript2.p1_pointsText.text = pointBoardScript.p1_Points.ToString();
                Destroy(other.gameObject);
                Debug.Log("Player 1 tem " + pointBoardScript.p1_Points + " pontos.");

                floorBoxs = GameObject.FindGameObjectsWithTag("Floor");
                
                foreach (GameObject floorBox in floorBoxs)
                {
                    if (floorBox.GetComponent<Renderer>().material.color == player1Color) {
                        floorBox.GetComponent<Renderer>().material.color = Color.white;
                    }
                }
            }

            
            if(tag == "Player2")
            {
                pointBoardScript.p2_pointsText.text = pointBoardScript.p2_Points.ToString();
                //pointBoardScript2.p1_pointsText.text = pointBoardScript.p1_Points.ToString();
                Destroy(other.gameObject);
                Debug.Log("Player 2 tem " + pointBoardScript.p2_Points + " pontos.");

                floorBoxs = GameObject.FindGameObjectsWithTag("Floor");

                foreach (GameObject floorBox in floorBoxs)
                {
                    if (floorBox. GetComponent<Renderer>().material.color == player2Color) {
                        floorBox.GetComponent<Renderer>().material.color = Color.white;
                    }
                }
            }
            
        }
        if(other.tag == "Collectable2"){
            //pointBoardScript.points += 300;
            if(tag == "Player")
            {
                Destroy(other.gameObject);
                anim.speed = newAnimationSpeed;
                Debug.Log("Player 1 apanhou SPEED (10sec).");
                timeTrigger1 = true;
            }
            if(tag == "Player2")
            {
                Destroy(other.gameObject);
                anim.speed = newAnimationSpeed;
                Debug.Log("Player 2 apanhou SPEED (10sec).");
                timeTrigger2 = true; 
            }
            
        }
    }
}
