using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float TimeLeft;
    public float TimeLeft2;
    public bool TimerOn = false;
    private float secondsLeft = 0;
    private float secondsLeft2 = 0;
    Collectables collectables;
    Collectables collectables2;
    public GameObject[] myObjects;

    public Text TimerTxt;

    //Countdown and GO!
    public Text countdownTextField;
    public AudioSource audioSource;
   
    void Start()
    {
        TimerOn = false; //Arranca timer com o jogo
        collectables = GameObject.Find("Player").GetComponent<Collectables>();
        collectables2 = GameObject.Find("Player 2").GetComponent<Collectables>();
        StartCoroutine(CountdownCoroutine());
    }

    IEnumerator CountdownCoroutine() {
        countdownTextField.text = "3";
        audioSource.Play();
        yield return new WaitForSeconds(1.0f);
        countdownTextField.text = "2";
        yield return new WaitForSeconds(1.0f);
        countdownTextField.text = "1";
        yield return new WaitForSeconds(1.0f);
        countdownTextField.text = "Go!";
        // Começa o jogo:
        TimerOn = true;
        yield return new WaitForSeconds(1.0f);
        countdownTextField.text = "";
        yield return null;
    }

    void Update()
    {
        if(TimerOn) //se o contador for true, entra
        {
            if(TimeLeft > 0) //condicao que faz update ao tempo, reduzindo um segundo de cada vez
            {
                TimeLeft -= Time.deltaTime; // Tempo atualizado
                updateTimer(TimeLeft); //funcao de update do timer, envia um parametro a funcao (time left)
                if (collectables.timeTrigger1 == true)
                {
                    if (secondsLeft ==  0) {
                        secondsLeft = TimeLeft;
                    }
                    if ((secondsLeft - 10) >= TimeLeft && collectables.anim.speed == 2f) {
                        collectables.anim.speed = 1f;
                        Debug.Log("Acabou SPEED player 1.");
                        collectables.timeTrigger1 = false;
                        secondsLeft = 0;
                    }
                }

                if (collectables2.timeTrigger2 == true)
                {
                    if (secondsLeft2 ==  0) {
                        secondsLeft2 = TimeLeft;
                    }
                    if ((secondsLeft2 - 10) >= TimeLeft && collectables2.anim.speed == 2f) {
                        collectables2.anim.speed = 1f;
                        Debug.Log("Acabou SPEED player 2.");
                        collectables2.timeTrigger2 = false;
                        secondsLeft2 = 0;
                    }
                }
                //Object drop 5 em 5 sec:
                if ((TimeLeft2 - 5) >= TimeLeft || TimeLeft2 == 0)
                {
                    int randomIndex = Random.Range(0, myObjects.Length);
                    Vector3 randomSpawnPosition = new Vector3((int)Random.Range(-6f, 2f), 1, (int)Random.Range(-6f, 2f)+0.5f);

                    Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
                    TimeLeft2 = TimeLeft; // Step 3 - Igualar o tempo 1.55
                }
                if (TimeLeft2 == 0)
                {
                    TimeLeft2 = TimeLeft;
                }
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

        TimerTxt.text = string.Format("{0:0 0}  {1 :0 0}", minutes, seconds);
    }
}

