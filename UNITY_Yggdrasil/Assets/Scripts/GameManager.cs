using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerMovementScript pms;
    public DropMagicScript dms;
    public GameUI gUI;

    public bool bindMovement;

    public int health = 3;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
      bindMovement = false;
      health = 3;
      score = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SubtractLife(){
      health --;

      if (health == 2){
        gUI.Life1.SetActive(false);
      } else if (health == 1){
        gUI.Life2.SetActive(false);
      }  else if (health == 0){
        gUI.Life3.SetActive(false);
        GameOver();
      }
    }

    void GameOver(){
      bindMovement = true;
    }

    public void AddPoints(){
      score += 100;
      gUI.UpdateScore();
    }



}
