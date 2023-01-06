using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToCharaterSelectTransition : MonoBehaviour
{
    public void BackToCharacterSelection(){
        SceneManager.LoadScene("Character Selected");
    }
}
