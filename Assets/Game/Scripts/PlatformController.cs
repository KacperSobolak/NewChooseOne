using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour {

    public GameObject platforms;
    public GameObject PrefarbsHolder;
    public GameObject[] PlatformsChildrens;
    public Color PlatformColor = Color.black;
    int PlatformNumber;
    public GameObject GameControllerGO;


    void Awake () {
        platforms = PrefarbsHolder.GetComponent<PrefarbsHolder>().platforms;
        ChooseGoodPlat();
        GameControllerGO = GameObject.Find("GameControllerGO");
	}

    private void Start()
    {
        SettingPlatforms();
    }

    void ChooseGoodPlat()
    {
        PlatformNumber = Random.Range(0, PlatformsChildrens.Length);
    }

    void SettingPlatforms()
    {
        PlatformsChildrens[PlatformNumber].GetComponent<Platform>().GoodPlat = true;
        PlatformsChildrens[PlatformNumber].GetComponent<Renderer>().material.color = this.gameObject.GetComponent<ColorGenerator>().GoodColor;
        for (int i = 0; i <= 2; i++)
        {
            if (i != PlatformNumber)
            {
                PlatformsChildrens[i].GetComponent<Renderer>().material.color = this.gameObject.GetComponent<ColorGenerator>().BadColor;
            }
        }
    }

    public void DestroyPlatforms()
    {
        for (int i = 0; i <= 2; i++)
        {
            if (i != PlatformNumber)
            {
                Destroy(PlatformsChildrens[i]);
            }
        }
    }

}
