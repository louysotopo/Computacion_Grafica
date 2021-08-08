using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoManagerScript : MonoBehaviour {

    public TMPro.TextMeshProUGUI user_name;
    public TMPro.TextMeshProUGUI user_points;
    public GameObject user_character;
    public Sprite [] characters;

    void Start()
    {
        user_name.text = GameManagerScript.instance.getUserName();
        user_points.text = GameManagerScript.instance.getUserPoints().ToString();

        char gender = GameManagerScript.instance.getUserGender();

        if (gender == 'M'){
            user_character.GetComponent<Image>().sprite = characters[0];
        }
        else{
            user_character.GetComponent<Image>().sprite = characters[1];
        }
    }

}
