using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthController : MonoBehaviour {
    
    const float TIME_TO_RESTART = 0.2f;
    public float LEVEL_1_X = -6f;
    public float LEVEL_1_Y = -2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
            StartCoroutine(FellReload(collision));
    }
    IEnumerator FellReload(Collision2D collision)
    {
        yield return new WaitForSeconds(TIME_TO_RESTART);
        collision.transform.position = new Vector3(LEVEL_1_X, LEVEL_1_Y,-1);
    }
}
