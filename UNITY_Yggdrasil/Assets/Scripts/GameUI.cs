using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUI : MonoBehaviour
{

    public GameManager gm;
    public GameObject ScoreGO;
    public GameObject Life1;
    public GameObject Life2;
    public GameObject Life3;

    // Start is called before the first frame update
    void Start()
    {
      ScoreGO.GetComponent<TMP_Text>().text = "0";
    }

    public void UpdateScore(){
      ScoreGO.GetComponent<TMP_Text>().text = gm.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
