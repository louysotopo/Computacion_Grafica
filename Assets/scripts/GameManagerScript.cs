using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {


    public static GameManagerScript instance;
    public string user_name = "";
    public char user_gender = 'F';
    public int user_points = 0;
    public AudioSource [] music;

    void Awake(){
        instance = this;
        DontDestroyOnLoad(this.gameObject);
        music[0].Play();
    }
    // Start is called before the first frame update

    // Update is called once per frame
    public void characterSelection(char user_gender){
        this.user_gender = user_gender;
    }
    public void setUserName(string user_name){
        this.user_name = user_name;
    }
    public void addPoints(int add_points){
        this.user_points += add_points;
    }

    public string getUserName(){
        return this.user_name;
    }
    public int getUserPoints(){
        return this.user_points;
    }
    public char getUserGender(){
        return this.user_gender;
    }
}
