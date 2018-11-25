using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    public bool GoodPlat;

    private void Awake()
    {
        GoodPlat = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        PlatformController pc = GetComponentInParent<PlatformController>();
        if (GoodPlat == true)
        {
            Instantiate(pc.platforms, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), transform.rotation);
            pc.DestroyPlatforms();
            pc.GameControllerGO.GetComponent<GameController>().AddPoint();
        }
        else
        {
            pc.GameControllerGO.GetComponent<GameController>().EndGame();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(GoodPlat == true)
        {
            Destroy(this.gameObject);
        }
    }
}
