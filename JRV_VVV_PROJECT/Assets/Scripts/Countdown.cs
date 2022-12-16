using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;

    public Text TimerTxt;
   
    void Start()
    {
        TimerOn = true; //Arranca timer com o jogo
    }

    void Update()
    {
        if(TimerOn) //se o contador for true, entra
        {
            if(TimeLeft > 0) //condicao que faz update ao tempo, reduzindo um segundo de cada vez
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft); //funcao de update do timer, envia um parametro a funcao (time left)
            }
            else
            {
                Debug.Log("Time is UP!");
                TimeLeft = 0; //quando chegar a 0, ele entra aqui inves do if, passa o timerOn a falso e termina
                TimerOn = false;
            }
        }
    }

    void updateTimer(float currentTime) //funcao de update do valor do timer
    {
        currentTime += 1; 

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

