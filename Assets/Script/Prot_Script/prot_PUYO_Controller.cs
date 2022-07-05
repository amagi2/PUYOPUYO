using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prot_PUYO_Controller : MonoBehaviour
{
    private float time;
    public bool Fall_F;
    public int num;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        Fall_F = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Fall_F == true)
        {
            Fall();
        }
        if (num == 1 && Input.GetKey(KeyCode.Q))
        {
            Fall_F = true;
        }
        if (num == 2 && Input.GetKey(KeyCode.W))
        {
            Fall_F = true;
        }
    }

    void Fall()
    {
        //transform.position += new Vector3(0, -0.75f, 0) * Time.deltaTime;
        //transform.position += new Vector3(0, -0.75f, 0) * Time.deltaTime / 100;
        time += Time.deltaTime;
        if (time > 0.025f)
        {
            transform.position += new Vector3(0, -0.075f, 0);
            time = 0;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Fall_F = false;
    }
}
