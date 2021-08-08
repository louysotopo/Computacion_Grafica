using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimulatorManager : MonoBehaviour
{
    public Asteriod asteriod;
    public GameObject form;
    public GameObject point_prefab;
    public Planet[] planets;

    private Vector3 speed, acceleration;
    private bool pause;

    // Start is called before the first frame update
    void Start()
    {
        this.pause=true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.pause){
                   
            float h = Time.deltaTime;
            Vector3 position = this.asteriod.transform.position;
            for (int i=0; i< this.planets.Length; i++){
                Planet planet = this.planets[i];
                float x = position[0] - planet.transform.position[0];
                float y = position[1] - planet.transform.position[1];
                float z = position[2] - planet.transform.position[2];
                float radius = Mathf.Pow(x, 2) + Mathf.Pow(y, 2) + Mathf.Pow(z, 2);
                //Debug.Log(( position[0] - planet.transform.position[0] ) / Mathf.Pow(radius, 1.5f));
                Vector3 diff_acceleration = new Vector3(
                    ( position[0] - planet.transform.position[0] ) / Mathf.Pow(radius, 1.5f),
                    ( position[1] - planet.transform.position[1] ) / Mathf.Pow(radius, 1.5f),
                    ( position[2] - planet.transform.position[2] ) / Mathf.Pow(radius, 1.5f)
                );
                this.acceleration -= diff_acceleration;
            }

            this.speed += h * this.acceleration;
//            Instantiate(this.point_prefab, this.asteriod.transform.position, Quaternion.identity);
            this.asteriod.speed = this.speed;        
        

        }
    }

    public void simulate(){
            this.asteriod.activate();
            this.speed = new Vector3(
            this.asteriod.speed_initial[0],
            this.asteriod.speed_initial[1],
            this.asteriod.speed_initial[2]);
        
            this.acceleration = new Vector3(0f, 0f, 0f);
            this.pause = false;
            this.form.SetActive(false);
            this.asteriod.move(new Vector3(15f, 15f, 15f));      
        
    }
    public void paused()
    {
        this.pause = true;
        this.asteriod.desactivate();
    }
    public void restarted()
    {
        this.pause = false;
        this.asteriod.returned();

    }
}
