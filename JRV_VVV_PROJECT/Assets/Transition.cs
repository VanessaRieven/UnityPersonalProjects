using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public Image fadeImage;
    public Animator anim;
    public Scene scene;
    int nextLevelBuildIndex;


    public void LoadNextScene()
    {
/*         scene = SceneManager.GetActiveScene();
        nextLevelBuildIndex = 1 - scene.buildIndex; */
        // SceneManager.LoadScene(scene);
    }
}
