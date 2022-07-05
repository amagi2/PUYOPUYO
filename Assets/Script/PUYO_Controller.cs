using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUYO_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PUYO_Count = 0;
        Count_Bool = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(PUYO_Count);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Fall_Bool = true;
        }
        Fall_PUYO();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == this.gameObject.tag && Count_Bool == true)
        {
            Add_PUYO_Count();
            Debug.Log(PUYO_Count);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Fall_Bool = false;
        Count_Bool = true;
        Debug.Log("Hit");
    }

    private int PUYO_Count;
    private bool Count_Bool;
    private bool Fall_Bool;
    private int Fall;

    private void Add_PUYO_Count()
    {
        PUYO_Count += 1;
    }
    private void Reset_PUYO_Count()
    {
        PUYO_Count = 0;
    }
    private void Delet_PUYO()
    {

    }
    private void Fall_PUYO()
    {
        if (Fall > 0)
        {
            transform.position += new Vector3(0, -0.015f, 0);
            Fall--;
        }
        else if (Fall_Bool == true)
        {
            Fall += 50;
        }
    }
}
