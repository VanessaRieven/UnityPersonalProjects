using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//= Diamont
public class ColectColor : MonoBehaviour
{
    PlayerMovement playerMovementScript;
    Collectables collectablesScript;
    PointBoard pointBoardScript;
    public bool boxColored = false;
    public bool p1Entered = false;
    public bool p2Entered = false;
    public GameObject box;
    public Color player1Color = new Color(1.7f, 1.5f, 0.75f, 1f);
    public Color player2Color = new Color(4.7f, 4.5f, 4.75f, 1f);
    public ParticleSystem particles;

    void Start()
    {
        playerMovementScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        collectablesScript = GameObject.Find("PointsText").GetComponent<Collectables>();
        pointBoardScript = GameObject.Find("Texto Pontuação").GetComponent<PointBoard>();
    }

    public void ChangeColor(){
        box = this.gameObject;
        if(p1Entered) box.GetComponent<Renderer>().material.color = player1Color; else box.GetComponent<Renderer>().material.color = player2Color;
        particles.Play();
        addBoxPoints();
    }

    public void addBoxPoints(){
        pointBoardScript.points = pointBoardScript.points + 100;
        pointBoardScript.pointsText.text = pointBoardScript.points.ToString();
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player" && !boxColored){
            p1Entered = true;
            boxColored = true;
            ChangeColor();
        } else if(this.gameObject.tag == "Player2" && !boxColored){
            p2Entered = true;
            ChangeColor();
        }   
    }
}
