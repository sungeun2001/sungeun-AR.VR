using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{

  public GameObject bulletPrefab;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if(Input.GetMouseButtonDown(0))
    {
      GameObject Bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
      Bullet.GetComponent<BulletController>().Shoot(new Vector3(0,0,-500));
    }    
  }
}

