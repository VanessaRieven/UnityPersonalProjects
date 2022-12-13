using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    // Ref: https://www.youtube.com/watch?v=3qlRgICRoeA
    public GameObject[] characters;
    public int selectedCharacter = 0;

    public void NextCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter +1) % characters.Length;
        characters[selectedCharacter].SetActive(true);
    }

    public void PreviousCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter --;
        if (selectedCharacter < 0)
        {
            selectedCharacter += characters.Length;
        }
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

}
