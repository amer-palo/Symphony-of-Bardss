using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    public float beatTempo;
    public float speed;

    bool switc = true;
    public bool hasStarted;
    void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            if (Input.anyKeyDown)
            {
                hasStarted = true;
            }
        }
        else
        {
         if(switc)
         {
                moveblockright();
         }
         if(!switc)
            {
                moveblockleft();
            }

         if(transform.position.x >= 4.52f)
            {
                switc = false;
            }
         if(transform.position.x <= -0.42f)
            {
                switc=true;
            }
            //transform.position -= new Vector3(-beatTempo * Time.deltaTime, 0f , 0f);
        }

    }
    
    void moveblockright()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    void moveblockleft()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
