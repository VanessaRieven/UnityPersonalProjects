using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LoadCharacter : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public Transform spawnPoint;
    //public TMP_Text label;

    //Sprites:
    public Image Player2Head;
    public Sprite BunnySprite;
    public Sprite ChubbySprite;
    public Sprite ClovySprite;
    public Sprite HelmySprite;
    public Sprite KingySprite;
    public Sprite LeafySprite;
    public Sprite MewmewSprite;
    public Sprite RockySprite;
    public Sprite VickySprite;

    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        GameObject child1 = GameObject.Find("Bunny");
        GameObject child2 = GameObject.Find("Chubby");
        GameObject child3 = GameObject.Find("Clovy");
        GameObject child4 = GameObject.Find("Helmy");
        GameObject child5 = GameObject.Find("Kingy");
        GameObject child6 = GameObject.Find("Leafy");
        GameObject child7 = GameObject.Find("Mewmew");
        GameObject child8 = GameObject.Find("Rocky");
        GameObject child9 = GameObject.Find("Vicky");
        //Acessórios:
        GameObject KingyCrown = GameObject.Find("KingyCrown");
        GameObject HelmyMetal = GameObject.Find("HelmyMetal");
        GameObject VickyViking = GameObject.Find("VickyViking");
        GameObject ClovySprout = GameObject.Find("ClovySprout");
        GameObject LeafyLeaf = GameObject.Find("LeafyLeaf");
        GameObject ChubbyCrown = GameObject.Find("ChubbyCrown");

        if (selectedCharacter == 0)
        {
            child1.GetComponent<Renderer>().enabled = true;
            child2.GetComponent<Renderer>().enabled = false;
            child3.GetComponent<Renderer>().enabled = false;
            child4.GetComponent<Renderer>().enabled = false;
            child5.GetComponent<Renderer>().enabled = false;
            child6.GetComponent<Renderer>().enabled = false;
            child7.GetComponent<Renderer>().enabled = false;
            child8.GetComponent<Renderer>().enabled = false;
            child9.GetComponent<Renderer>().enabled = false;
            //Acessórios:
            KingyCrown.GetComponent<Renderer>().enabled = false;
            HelmyMetal.GetComponent<Renderer>().enabled = false;
            VickyViking.GetComponent<Renderer>().enabled = false;
            ClovySprout.GetComponent<Renderer>().enabled = false;
            LeafyLeaf.GetComponent<Renderer>().enabled = false;
            ChubbyCrown.GetComponent<Renderer>().enabled = false;
            //Sprite:
            Player2Head.sprite = BunnySprite;
        }
        else if (selectedCharacter == 1)
        {
            child1.GetComponent<Renderer>().enabled = false;
            child2.GetComponent<Renderer>().enabled = true;
            child3.GetComponent<Renderer>().enabled = false;
            child4.GetComponent<Renderer>().enabled = false;
            child5.GetComponent<Renderer>().enabled = false;
            child6.GetComponent<Renderer>().enabled = false;
            child7.GetComponent<Renderer>().enabled = false;
            child8.GetComponent<Renderer>().enabled = false;
            child9.GetComponent<Renderer>().enabled = false;
            //Acessórios:
            KingyCrown.GetComponent<Renderer>().enabled = false;
            HelmyMetal.GetComponent<Renderer>().enabled = false;
            VickyViking.GetComponent<Renderer>().enabled = false;
            ClovySprout.GetComponent<Renderer>().enabled = false;
            LeafyLeaf.GetComponent<Renderer>().enabled = false;
            ChubbyCrown.GetComponent<Renderer>().enabled = true;
            //Sprite:
            Player2Head.sprite = ChubbySprite;
        }
        else if (selectedCharacter == 2)
        {
            child1.GetComponent<Renderer>().enabled = false;
            child2.GetComponent<Renderer>().enabled = false;
            child3.GetComponent<Renderer>().enabled = true;
            child4.GetComponent<Renderer>().enabled = false;
            child5.GetComponent<Renderer>().enabled = false;
            child6.GetComponent<Renderer>().enabled = false;
            child7.GetComponent<Renderer>().enabled = false;
            child8.GetComponent<Renderer>().enabled = false;
            child9.GetComponent<Renderer>().enabled = false;
            //Acessórios:
            KingyCrown.GetComponent<Renderer>().enabled = false;
            HelmyMetal.GetComponent<Renderer>().enabled = false;
            VickyViking.GetComponent<Renderer>().enabled = false;
            ClovySprout.GetComponent<Renderer>().enabled = true;
            LeafyLeaf.GetComponent<Renderer>().enabled = false;
            ChubbyCrown.GetComponent<Renderer>().enabled = false;
            //Sprite:
            Player2Head.sprite = ClovySprite;
        }
        else if (selectedCharacter == 3)
        {
            child1.GetComponent<Renderer>().enabled = false;
            child2.GetComponent<Renderer>().enabled = false;
            child3.GetComponent<Renderer>().enabled = false;
            child4.GetComponent<Renderer>().enabled = true;
            child5.GetComponent<Renderer>().enabled = false;
            child6.GetComponent<Renderer>().enabled = false;
            child7.GetComponent<Renderer>().enabled = false;
            child8.GetComponent<Renderer>().enabled = false;
            child9.GetComponent<Renderer>().enabled = false;
            //Acessórios:
            KingyCrown.GetComponent<Renderer>().enabled = false;
            HelmyMetal.GetComponent<Renderer>().enabled = true;
            VickyViking.GetComponent<Renderer>().enabled = false;
            ClovySprout.GetComponent<Renderer>().enabled = false;
            LeafyLeaf.GetComponent<Renderer>().enabled = false;
            ChubbyCrown.GetComponent<Renderer>().enabled = false;
            //Sprite:
            Player2Head.sprite = HelmySprite;
        }
        else if (selectedCharacter == 4)
        {
            child1.GetComponent<Renderer>().enabled = false;
            child2.GetComponent<Renderer>().enabled = false;
            child3.GetComponent<Renderer>().enabled = false;
            child4.GetComponent<Renderer>().enabled = false;
            child5.GetComponent<Renderer>().enabled = true;
            child6.GetComponent<Renderer>().enabled = false;
            child7.GetComponent<Renderer>().enabled = false;
            child8.GetComponent<Renderer>().enabled = false;
            child9.GetComponent<Renderer>().enabled = false;
            //Acessórios:
            KingyCrown.GetComponent<Renderer>().enabled = true;
            HelmyMetal.GetComponent<Renderer>().enabled = false;
            VickyViking.GetComponent<Renderer>().enabled = false;
            ClovySprout.GetComponent<Renderer>().enabled = false;
            LeafyLeaf.GetComponent<Renderer>().enabled = false;
            ChubbyCrown.GetComponent<Renderer>().enabled = false;
            //Sprite:
            Player2Head.sprite = KingySprite;
        }
        else if (selectedCharacter == 5)
        {
            child1.GetComponent<Renderer>().enabled = false;
            child2.GetComponent<Renderer>().enabled = false;
            child3.GetComponent<Renderer>().enabled = false;
            child4.GetComponent<Renderer>().enabled = false;
            child5.GetComponent<Renderer>().enabled = false;
            child6.GetComponent<Renderer>().enabled = true;
            child7.GetComponent<Renderer>().enabled = false;
            child8.GetComponent<Renderer>().enabled = false;
            child9.GetComponent<Renderer>().enabled = false;
            //Acessórios:
            KingyCrown.GetComponent<Renderer>().enabled = false;
            HelmyMetal.GetComponent<Renderer>().enabled = false;
            VickyViking.GetComponent<Renderer>().enabled = false;
            ClovySprout.GetComponent<Renderer>().enabled = false;
            LeafyLeaf.GetComponent<Renderer>().enabled = true;
            ChubbyCrown.GetComponent<Renderer>().enabled = false;
            //Sprite:
            Player2Head.sprite = LeafySprite;
        }
        else if (selectedCharacter == 6)
        {
            child1.GetComponent<Renderer>().enabled = false;
            child2.GetComponent<Renderer>().enabled = false;
            child3.GetComponent<Renderer>().enabled = false;
            child4.GetComponent<Renderer>().enabled = false;
            child5.GetComponent<Renderer>().enabled = false;
            child6.GetComponent<Renderer>().enabled = false;
            child7.GetComponent<Renderer>().enabled = true;
            child8.GetComponent<Renderer>().enabled = false;
            child9.GetComponent<Renderer>().enabled = false;
            //Acessórios:
            KingyCrown.GetComponent<Renderer>().enabled = false;
            HelmyMetal.GetComponent<Renderer>().enabled = false;
            VickyViking.GetComponent<Renderer>().enabled = false;
            ClovySprout.GetComponent<Renderer>().enabled = false;
            LeafyLeaf.GetComponent<Renderer>().enabled = false;
            ChubbyCrown.GetComponent<Renderer>().enabled = false;
            //Sprite:
            Player2Head.sprite = MewmewSprite;
        }
        else if (selectedCharacter == 7)
        {
            child1.GetComponent<Renderer>().enabled = false;
            child2.GetComponent<Renderer>().enabled = false;
            child3.GetComponent<Renderer>().enabled = false;
            child4.GetComponent<Renderer>().enabled = false;
            child5.GetComponent<Renderer>().enabled = false;
            child6.GetComponent<Renderer>().enabled = false;
            child7.GetComponent<Renderer>().enabled = false;
            child8.GetComponent<Renderer>().enabled = true;
            child9.GetComponent<Renderer>().enabled = false;
            //Acessórios:
            KingyCrown.GetComponent<Renderer>().enabled = false;
            HelmyMetal.GetComponent<Renderer>().enabled = false;
            VickyViking.GetComponent<Renderer>().enabled = false;
            ClovySprout.GetComponent<Renderer>().enabled = false;
            LeafyLeaf.GetComponent<Renderer>().enabled = false;
            ChubbyCrown.GetComponent<Renderer>().enabled = false;
            //Sprite:
            Player2Head.sprite = RockySprite;
        }
        else if (selectedCharacter == 8)
        {
            child1.GetComponent<Renderer>().enabled = false;
            child2.GetComponent<Renderer>().enabled = false;
            child3.GetComponent<Renderer>().enabled = false;
            child4.GetComponent<Renderer>().enabled = false;
            child5.GetComponent<Renderer>().enabled = false;
            child6.GetComponent<Renderer>().enabled = false;
            child7.GetComponent<Renderer>().enabled = false;
            child8.GetComponent<Renderer>().enabled = false;
            child9.GetComponent<Renderer>().enabled = true;
            //Acessórios:
            KingyCrown.GetComponent<Renderer>().enabled = false;
            HelmyMetal.GetComponent<Renderer>().enabled = false;
            VickyViking.GetComponent<Renderer>().enabled = true;
            ClovySprout.GetComponent<Renderer>().enabled = false;
            LeafyLeaf.GetComponent<Renderer>().enabled = false;
            ChubbyCrown.GetComponent<Renderer>().enabled = false;
            //Sprite:
            Player2Head.sprite = VickySprite;
        }

        //GameObject prefab = characterPrefabs[selectedCharacter];
        // GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        //label.text = prefab.name;
    }
}
