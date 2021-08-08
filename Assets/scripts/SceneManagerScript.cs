using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public static SceneManagerScript instance;
    void Awake(){
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void selectScene(string nivel_name)
    {
        SceneManager.LoadScene(nivel_name); 
    }


}
