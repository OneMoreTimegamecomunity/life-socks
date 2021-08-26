using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAMELE : MonoBehaviour
{
    public int gamelevel;
    public int corap_toplama_sayi;
    #region
    public Dictionary<double, double[]> sock_places = new Dictionary<double, double[]>(){
            { 0,  new double[]{37.5,-18.99} },
            { 1,  new double[]{-7.4,-6.8 } },
            { 3,  new double[]{24.7,15.1} },
            { 4,  new double[]{-22.6,3.3} },
            { 5,  new double[]{-27.4,-23,2} },
            { 6,  new double[]{5.8,6.7} },
            { 7,  new double[]{5.8,6.7} },
            { 8,  new double[]{5.8,6.7} },
            { 9,  new double[]{5.8,6.7} },
            { 10,  new double[]{5.8,6.7} },
        };

    #endregion
    void Start()
    {
        gamelevel = 0;
        corap_toplama_sayi = 0;
    }

    // Update is called once per frame
    void Update() 
    { 
        if (gamelevel == 0) 
        {

        }//elma ya?muru
        if (gamelevel == 1)
        {
        }//uzayl?
        if (gamelevel == 2) 
        {
        }//zombi 
        if (gamelevel == 3)
        {
        }//bomba
        if (gamelevel == 4) 
        {
        }//yer?ekimi 
        if (gamelevel == 5)
        {
        }//u?an kedi
        if (gamelevel == 6)
        { 
        }//?i?ek ya?muru
        if (gamelevel == 7)
        {
        }//final-?orap istilas? 


    }
}
