using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
  public GameManager gm;

  public float speed = 2f;
  public bool facingRight;
  public Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (gm.bindMovement){return;}


      if (Input.GetAxis("Horizontal") > 0.1 ){
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0);
        if (!facingRight){
          facingRight = true;
          transform.localScale = new Vector3(1,1,1);
        }
      } else if (Input.GetAxis("Horizontal") < -0.1){
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0);
          if (facingRight){
            facingRight = false;
            transform.localScale = new Vector3(-1,1,1);
          }
      }

    }
}
