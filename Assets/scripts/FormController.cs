using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FormController : MonoBehaviour
{

    // Start is called before the first frame update
    public Canvas canvas;
    public InputField [] initial_position = {null, null, null};
    public InputField [] force = {null, null, null};
    public InputField [] wind = {null, null, null};
    public SimulatorController simulator;
    public InputField gravity;

    void Start()
    {
        this.default_data();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Simulate()
    {
        Vector3 initial_position_vector = new Vector3(float.Parse(this.initial_position[0].text), float.Parse(this.initial_position[1].text), float.Parse(this.initial_position[2].text));
        Vector3 force_vector = new Vector3(float.Parse(this.force[0].text), float.Parse(this.force[1].text), float.Parse(this.force[2].text));
        Vector3 wind_vector = new Vector3(float.Parse(this.wind[0].text), float.Parse(this.wind[1].text), float.Parse(this.wind[2].text));
        float gravity_value = float.Parse(this.gravity.text);
        this.simulator.Simulate(initial_position_vector, force_vector, wind_vector, gravity_value);
        this.canvas.enabled = false;

    }

    void default_data(){
        this.initial_position[0].text = this.simulator.object_simulation.transform.position.x +"";
        this.initial_position[1].text = this.simulator.object_simulation.transform.position.y +"";
        this.initial_position[2].text = this.simulator.object_simulation.transform.position.z +"";

        this.force[0].text = this.simulator.force.x +"";
        this.force[1].text = this.simulator.force.y +"";
        this.force[2].text = this.simulator.force.z +"";

        this.wind[0].text = this.simulator.wind.x +"";
        this.wind[1].text = this.simulator.wind.y +"";
        this.wind[2].text = this.simulator.wind.z +"";
        this.gravity.text = this.simulator.gravity + "";
    }
}
