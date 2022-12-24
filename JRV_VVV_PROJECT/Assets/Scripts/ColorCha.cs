using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCha : MonoBehaviour
{
   public Renderer ObjectRender1, ObjectRender2, ObjectRender3;
   public GameObject obj1, obj2, obj3;
   //[SerializeField] private Color newColor;
   //[SerializeField] private Color[] colors;
   //private int ColorValue;
   [SerializeField] private Material newMesh;

   void Start()
   {
    ObjectRender1 = obj1.GetComponent<Renderer>();
    ObjectRender2 = obj2.GetComponent<Renderer>();
    ObjectRender3 = obj3.GetComponent<Renderer>();
   }

    public void ChangeMaterial()
    {
        /*
        //newColor = Random.ColorHSV();
        ObjectRender1.material.color = newColor;
        ObjectRender2.material.color = newColor;
        ObjectRender3.material.color = newColor;
        */
        
        ObjectRender1.material= newMesh;
        ObjectRender2.material= newMesh;
        ObjectRender3.material= newMesh;
    }

}
