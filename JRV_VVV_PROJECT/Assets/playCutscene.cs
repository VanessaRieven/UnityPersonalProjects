using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class playCutscene : MonoBehaviour
{
    public VideoPlayer cutscene;
    public GameObject background;
    public Transition transitionScript;
    public GameObject SpaceText;

    private void Start()
    {
        cutscene.loopPointReached += CheckOver;
    }

    public void PlayCutscene(){
        background.SetActive(true);
        cutscene.Play();
        SpaceText.SetActive(true);
    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        transitionScript.LoadNextScene();
    }

    public void LoadingNextScene()
    {
        transitionScript.LoadNextScene();
    }
}
