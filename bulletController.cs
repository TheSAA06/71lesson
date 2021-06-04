using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    public GameObject bullet;
    GameObject clone;
    Transform spawn_tr;
    Transform bullet_tr;
    Rigidbody clone_rb;
    void Start()
    {
        spawn_tr = GetComponent<Transform>();
        bullet_tr = bullet.GetComponent<Transform>();
    }


    void Update()
    {
        if(Input.GetKeyDown("space")){
            clone = Instantiate(bullet, spawn_tr.position, Quaternion.Euler(90f, spawn_tr.rotation.eulerAngles.y, 0) );
            clone_rb = clone.GetComponent<Rigidbody>();
            clone_rb.AddForce(spawn_tr.forward * 1000f);
        }
    }
}
