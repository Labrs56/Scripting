using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{   // NPC health
    public int health = 5;
    // NPC level
    public int level = 2;
    //NPC speed
    public float speed = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        //Actualizamos la vida y la mostramos por patalla
        health += level;
        print("Nº de vidas:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
