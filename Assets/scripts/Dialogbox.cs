using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Dialogbox : MonoBehaviour
{
    public string[] positive_defaults;
    public string[] negative_defaults;
    public GameObject  panel;
    private float time;
    private bool view =  false; 

    public Text m_MyText;

    // Start is called before the first frame update
    void Start()
    {
        this.panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space")){
            float res = Random.Range(0,2); 
            string text_raw = "";
            if (res == 0){
                text_raw = this.positive_defaults[Random.Range(0,this.positive_defaults.Length)];
            } else {
                text_raw = this.negative_defaults[Random.Range(0,this.negative_defaults.Length)];
            }
            this.setText(text_raw);
        } else if (this.view) {
            if (this.time >=2){
                this.panel.SetActive(false);
            } else {
                this.time += Time.deltaTime;
            }
            
        }
        
    }


    void setText(string str){
        this.m_MyText.text = str;
        this.time =0f;
        this.view = true;
        this.panel.SetActive(true);
    }
}
