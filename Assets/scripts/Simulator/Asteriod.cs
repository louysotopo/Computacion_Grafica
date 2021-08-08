using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Asteriod : MonoBehaviour
{
    public InputField init_p_x;
    public InputField init_p_y;
    public InputField init_p_z;

    public InputField init_v_x;
    public InputField init_v_y;
    public InputField init_v_z;
    public bool isruning = false;

    public Vector3 speed_initial;
    
    public Vector3 speed;
    Vector3 myVector;
    void Start()
    {

        this.init_position_values();
        this.init_speed_values();
        myVector = new Vector3(this.transform.position[0], this.transform.position[1], this.transform.position[2]);
    }

    // Update is called once per frame
    void Update()
    {
        if (isruning)
        {
            this.update_position_values();
            this.update_speed_values();
            this.transform.position += this.speed * Time.deltaTime;
            this.init_position_values();
        }
        
    }

    public void returned(){
        this.transform.position = this.myVector ;
        this.init_position_values();
        this.init_speed_values();
    }
    public void activate()
    {
        this.isruning = true;
    }
    public void desactivate()
    {
        this.isruning = false;
    }
    public void init_position_values(){
        this.init_p_x.text = this.transform.position[0]+ "";
        this.init_p_y.text = this.transform.position[1]+ "";
        this.init_p_z.text = this.transform.position[2]+ "";
    }

    public void init_speed_values(){
        this.init_v_x.text = this.speed_initial[0]+ "";
        this.init_v_y.text = this.speed_initial[1]+ "";
        this.init_v_z.text = this.speed_initial[2]+ "";
    }

    void update_position_values(){
        this.move(
            new Vector3(
                float.Parse(this.init_p_x.text),
                float.Parse(this.init_p_y.text),
                float.Parse(this.init_p_z.text)            
            )
        );
    }

    void update_speed_values(){
        this.speed_initial = new Vector3(
           float.Parse(this.init_v_x.text),
           float.Parse(this.init_v_y.text),
           float.Parse(this.init_v_z.text)            
        );
    }

    public void move(Vector3 new_position){
        this.transform.position = new_position;
           
    }

    public void simulate(){

    }
}
