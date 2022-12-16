using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//variavel global que serve para guardar o valor dos pontos, assim é acessivel a partir de todos os scripts
public class PointBoard : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    public float points = 0;
}
