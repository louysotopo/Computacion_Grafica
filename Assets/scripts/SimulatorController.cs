using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulatorController : MonoBehaviour
{
    public GameObject object_simulation;
    public Camera camera;
    public float distance;
    public Vector3 force;
    public Vector3 wind;
    public float gravity = 9.807f;
    private bool pause = false; 
    public GameObject point_prefab;
    private Vector3 total_force;
    private Vector3 aceleration;

    // Start is called before the first frame update
    void Start()
    {
        this.pause = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.pause){
            float reason = Time.deltaTime;
            Instantiate(this.point_prefab, this.object_simulation.transform.position, Quaternion.identity);
            this.total_force = total_force + reason * this.aceleration;
            this.object_simulation.transform.position = this.object_simulation.transform.position + reason * total_force;
            if(this.object_simulation.transform.position.y <=0f){
                this.pause = true;
            }
        }
    }

    public void Simulate(Vector3 initial_position, Vector3 force, Vector3 wind, float gravity){
        this.object_simulation.transform.position = initial_position;
        this.camera.transform.position = initial_position + (new Vector3(0, 0, -distance));
        this.force = force;
        this.wind = wind;
        this.gravity = gravity;
        this.total_force = this.force + this.wind;
        this.aceleration = new Vector3(0f,-this.gravity ,0f);
        this.pause = false;
    }
}
