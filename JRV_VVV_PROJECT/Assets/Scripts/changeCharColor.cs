using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeCharColor : MonoBehaviour
{
    [SerializeField]
    private GameObject player1;
    private Renderer player1render;
    private Color newPlayer1Color;
    private Color newPlayer1Color2;
    private float randomChannelOne;

    //Make sure to attach these Buttons in the Inspector
    public Button m_YourFirstButton;
    
    // Start is called before the first frame update
    void Start()
    {
        player1render = player1.GetComponent<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(ChangePlayerColor);
    }

    private void ChangePlayerColor()
    {
        randomChannelOne = Random.Range(0f, 1f);

        newPlayer1Color = new Color(randomChannelOne, 0.5f, 0.5f, 1f);

        player1render.material.SetColor("_Color", newPlayer1Color);
        Debug.Log("Trocou para a cor: " + newPlayer1Color);
    }
    
    private void ChangePlayerColor2()
    {
        newPlayer1Color2 = new Color(1f, 1f, 1f, 1f);
        player1render.material.SetColor("_Color", newPlayer1Color2);
        Debug.Log("ENTROU"+ newPlayer1Color2);
    }

    /*
     [SerializeField]
     public Color color;
 
     [SerializeField]
     private GameObject targetObject;
 
     public void SetColor()
     {
         if(targetObject == null)
         {
             Debug.Log("Traget Object is not assigned!");
             return;
         }
 
         Renderer objectRenderer = targetObject.GetComponent<Renderer>();
         if(objectRenderer == null)
         {
             Debug.Log("Traget Object has no renderer!");
             return;
         }
             
         Material mat = objectRenderer.material;
         mat.color = color;
     }
    */

}
