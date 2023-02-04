using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropMagicScript : MonoBehaviour
{
  public GameManager gm;
  public GameObject magic;
  public float cooldownTime = 2f;
  public bool cooldown = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    void DropMagic(){

    }

    IEnumerator CooldownWait(){
       yield return new WaitForSeconds(cooldownTime);
       cooldown = false;
   }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey(KeyCode.Space) && (cooldown == false)){
          DropMagic();
          GameObject spawnMagic = Instantiate(magic, gm.pms.gameObject.transform.position, gm.pms.gameObject.transform.rotation);
          cooldown = true;
          StartCoroutine(CooldownWait());
      }

    }
}
