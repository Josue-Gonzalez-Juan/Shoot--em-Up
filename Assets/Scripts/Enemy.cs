using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject bullet;
    
    public float fireRate;
    
    public Transform shootingOffset;


    void Update()
    {
        if (UnityEngine.Random.Range(0.0f, 1.0f) > fireRate)
        {
            GameObject shot = Instantiate(bullet, shootingOffset.position, Quaternion.identity);
            Destroy(shot, 3f);
        }
    }

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
      GetComponent<Animator>().SetTrigger("Death");
    Destroy(collision.gameObject); // destroy bullet
      Debug.Log("Ouch!");
    }
}
