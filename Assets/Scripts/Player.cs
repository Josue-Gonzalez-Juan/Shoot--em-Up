using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
  public GameObject bullet;
  private Animator playerAnimator;

  public Transform shottingOffset;

  void Start()
  {
    playerAnimator = GetComponent<Animator>();
  }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {

        playerAnimator.SetTrigger("Shoot");
        GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
        Debug.Log("Bang!");

        Destroy(shot, 3f);

      }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        playerAnimator.SetTrigger("Death");
        Destroy(collision.gameObject); // destroy bullet
        Debug.Log("Player Ouch!");
        StartCoroutine(GoToCredits());
    }

    IEnumerator GoToCredits()
    {
        yield return new WaitForSeconds(2.5f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
