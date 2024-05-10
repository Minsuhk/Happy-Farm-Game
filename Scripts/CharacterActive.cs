using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterActive : MonoBehaviour
{
    public GameObject Farmer;
    public GameObject Farmer1;
    public static bool firstCharacter = false;
    public static bool secondCharacter = false;
    // Start is called before the first frame update
    void Start()
    {
        if (firstCharacter == true){
            Farmer.SetActive(true);
            Farmer1.SetActive(false);
        } else if (secondCharacter == true){
            Farmer1.SetActive(true);
            Farmer.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
