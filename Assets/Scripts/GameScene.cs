using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    public GameObject instructions;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TurnOffInstructions());
    }

    IEnumerator TurnOffInstructions()
    {
        yield return new WaitForSeconds(1.5f);

        instructions.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
