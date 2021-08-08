using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacterScript : MonoBehaviour
{
    public GameObject[] characters;
    public TMPro.TextMeshProUGUI input;

    // Start is called before the first frame update
    public void SelectBoy(){
        characters[1].GetComponent<Image>().color = Color.black;
        characters[0].GetComponent<Image>().color = Color.gray;
        // Debug.Log("A boy is selected");
        GameManagerScript.instance.characterSelection('M');
    }

    public void SelectGirl(){
        characters[0].GetComponent<Image>().color = Color.black;
        characters[1].GetComponent<Image>().color = Color.gray;
        // Debug.Log("A girl is selected");
        GameManagerScript.instance.characterSelection('F');
    }

    public void ready(){
        // Debug.Log("this is my real name: " + input.text.Trim());
        GameManagerScript.instance.setUserName(input.text.Trim());

    }

}
