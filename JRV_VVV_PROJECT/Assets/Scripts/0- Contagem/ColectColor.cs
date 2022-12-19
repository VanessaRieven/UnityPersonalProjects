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

    //Vai buscar as cores do player, cada vez q o player colidir com a caixa, valida se ja tinha entrado ou nao e altera a cor. 
    void Start()
    {
        playerMovementScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        collectablesScript = GameObject.Find("PointsText").GetComponent<Collectables>();
        pointBoardScript = GameObject.Find("Texto Pontuação").GetComponent<PointBoard>();
        pointBoardScript.p1_Points = -10;
        pointBoardScript.p2_Points = -10;
    }

    public void ChangeColor(){
        box = this.gameObject;
        if(p1Entered)
        {
            box.GetComponent<Renderer>().material.color = player1Color;
        }
        else if(p2Entered)
        {
            box.GetComponent<Renderer>().material.color = player2Color;
        }
        particles.Play();
        addBoxPoints();
    }

    //acrescenta 100 pontos 
    public void addBoxPoints(){
        if(p1Entered) {
            pointBoardScript.p1_Points = pointBoardScript.p1_Points + 10; 
            pointBoardScript.p1_pointsText.text = pointBoardScript.p1_Points.ToString();
        }
        else if(p2Entered) {
            pointBoardScript.p2_Points = pointBoardScript.p2_Points + 10;
            pointBoardScript.p2_pointsText.text = pointBoardScript.p2_Points.ToString();
        }
        //pointBoardScript.pointsText.text = pointBoardScript.points.ToString();
        
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){ // && !boxColored){
            p2Entered = false;
            p1Entered = true;
            //boxColored = true;
            ChangeColor();
        } else if(other.gameObject.tag == "Player2"){ // && !boxColored){
            p1Entered = false;
            p2Entered = true;
            //boxColored = true;
            ChangeColor();
        }   
    }
}
