using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    GameObject platforms;
    public int points;
    public Text PointsText;
    UI UIManager;

    private void Awake()
    {
        UIManager = this.GetComponent<UI>();
        SettingPointText();
    }

    private void Start()
    {
        UIManager.ManageUI(2);
    }

    public void ClickToStartGame()
    {
        StartGame();
    }

    void SettingPointText()
    {
        points = 0;
        PointsText.text = points.ToString();
    }

    void StartGame()
    {
        UIManager.ManageUI(0);
        platforms = this.GetComponent<PrefarbsHolder>().platforms;
        Instantiate(platforms, Vector3.zero, transform.rotation);
    }

    public void AddPoint()
    {
        points++;
        PointsText.text = points.ToString();
    }
    
    public void EndGame()
    {
        UIManager.ManageUI(3);
    }

}
