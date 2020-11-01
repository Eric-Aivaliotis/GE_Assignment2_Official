using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public float player_speed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-player_speed * Input.GetAxis("Vertical") * Time.deltaTime, 0f, player_speed * Input.GetAxis("Horizontal") * Time.deltaTime);
    }
}
