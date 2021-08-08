using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planet : MonoBehaviour
{
    public InputField init_p_x;
    public InputField init_p_y;
    public InputField init_p_z;

    public InputField radius;



    void Start()
    {
        this.init_position_values();
        this.init_radius_value();
    }

    // Update is called once per frame
    void Update()
    {
        this.update_position_values();
        this.update_radius_value();
        
    }


    void init_position_values(){
        this.init_p_x.text = this.transform.position[0]+ "";
        this.init_p_y.text = this.transform.position[1]+ "";
        this.init_p_z.text = this.transform.position[2]+ "";
    }

    void init_radius_value(){
        float radius = (this.transform.localScale[0] + this.transform.localScale[1] + this.transform.localScale[2])/6f;
        this.radius.text = radius+ "";
    }


    void update_position_values(){
        this.transform.position = new Vector3(
           float.Parse(this.init_p_x.text),
           float.Parse(this.init_p_y.text),
           float.Parse(this.init_p_z.text)            
        );
    }

    void update_radius_value(){
        //this.transform.localScale = new Vector3( float.Parse(this.radius.text), float.Parse(this.radius.text), float.Parse(this.radius.text) );
    }



}
