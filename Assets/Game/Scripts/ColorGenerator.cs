using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGenerator : MonoBehaviour {

    public Color GoodColor;
    public Color BadColor;
    public float[] rgb;

    private void Awake()
    {
        GenerateColor();
    }

    void GenerateColor()
    {
        float max, min;
        int points = this.gameObject.GetComponent<PlatformController>().GameControllerGO.GetComponent<GameController>().points;
        if (points > 80)
        {
            min = 10;
            max = 245;
        }
        else
        {
            min = 50 - Mathf.Round(points / 2);
            max = 205 + Mathf.Round(points / 2);
        }
        for (int i = 0; i < rgb.Length; i++)
        {
            rgb[i] = Random.Range(min, max);
        }
        GoodColor = new Color(rgb[0]/255, rgb[1]/255, rgb[2]/255);
        float nbmax = 40;
        float nbmin = 35;
        if(points > 60)
        {
            nbmax = 10;
            nbmin = 5;
        }
        else
        {
            nbmax = 40 - Mathf.Round(points / 2);
            nbmin = 35 - Mathf.Round(points / 2);
        }     
        if (Random.Range(1, 3) == 1)
        {
            rgb[Random.Range(1, 3)] -= Mathf.Round(Random.Range(nbmin, nbmax + 1));
        }
        else
        {
            rgb[Random.Range(1, 3)] += Mathf.Round(Random.Range(nbmin, nbmax + 1));
        }
        BadColor = new Color(rgb[0] / 255, (rgb[1]) / 255, rgb[2] / 255);
    }
}
