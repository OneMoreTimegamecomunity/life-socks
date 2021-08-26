using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corap : MonoBehaviour
{
    public GameObject levelcode;
    private GameObject player;
    private Dictionary<double, double[]> sock_places = new Dictionary<double, double[]>(){
            { 0,  new double[]{37.5,-18.99} },
            { 1,  new double[]{-7.4,-6.8 }  },
            { 2,  new double[]{24.7,15.1}   },
            { 3,  new double[]{-22.6,3.3}   },
            { 4,  new double[]{-27.4,-23,2} },
            { 5,  new double[]{5.8,6.7}     },
            { 8,  new double[]{-200,6.7}    },
            { 9,  new double[]{5.8,6.7}     },
            { 10, new double[]{5.8,6.7}     },
            { 11, new double[]{5.8,6.7}     },
            { 12, new double[]{5.8,6.7}     },
            { 13, new double[]{5.8,6.7}     },
            { 14, new double[]{5.8,6.7}     },
            { 15, new double[]{5.8,6.7}     },
            { 16, new double[]{5.8,6.7}     },
            { 17, new double[]{5.8,6.7}     },
            { 18, new double[]{5.8,6.7}     },
            { 19, new double[]{5.8,6.7}     },
            { 20, new double[]{5.8,6.7}     },
            { 21, new double[]{5.8,6.7}     }
        };
    private int  corap_level;
    private int corap_control;
    // Start is called before the first frame update
    void Start()
    {
        corap_level = 0;
        corap_control=0;
        player = GameObject.FindGameObjectWithTag("Player");


    }

    // Update is called once per frame
    void Update()
    {
        //int corap_level = levelcode.GetComponent<GAMELE>().corap_toplama_sayi;

        int oyun_level = levelcode.GetComponent<GAMELE>().gamelevel;
        if (Vector3.Distance(transform.position, player.transform.position) <= 5)
        {
            // GetComponent<SpriteRenderer>().enabled = false;
            double[] xvey = sock_places[corap_level];

            GetComponent<Transform>().position = new Vector3((float)xvey[0], (float)xvey[1]);
            levelcode.GetComponent<GAMELE>().corap_toplama_sayi += 1;
            corap_level += 1;
            corap_control += 1;
            if (corap_control > 2)
            {
                corap_control = 0;
                levelcode.GetComponent<GAMELE>().gamelevel += 1;
                Debug.Log("levelcode artdi");

            }

        }

    }
}
