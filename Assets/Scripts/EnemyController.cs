using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    public float enemySpeed;
    private float moveXDirection=1;
    public bool isDead = false;
    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

	void Update () {
        animator.SetBool("isDead", isDead);
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveXDirection * enemySpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);     
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
            FlipEnemy();

        if (collision.gameObject.tag == "Bomb")
        {
            isDead = true;
            StartCoroutine(EnemyDead(collision));
        }
    }
  
    IEnumerator EnemyDead(Collision2D collision)
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
    void FlipEnemy()
    {
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
        if (moveXDirection > 0)
            moveXDirection = -1;
        else
            moveXDirection = 1;
    }
 }