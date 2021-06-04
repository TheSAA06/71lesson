using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Transform player_tr;
    Rigidbody player_rb;
    float vert;
    float horiz;
    void Start()
    {
        player_tr = GetComponent<Transform>();
        player_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        vert = Input.GetAxis("Vertical") * 5f;
        horiz = Input.GetAxis("Horizontal") * 0.4f;
        player_rb.AddForce(player_tr.forward * vert);
    }
    public void GetRotate(float arg){
        player_tr.rotation = Quaternion.Euler(0,arg,0);
    }
}
