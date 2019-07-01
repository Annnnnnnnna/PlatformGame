using UnityEngine;

public class Coins : MonoBehaviour {
    int playerScore = 0;
    public TextMesh scoreLabel;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            playerScore++; 
            scoreLabel.text = "Score: " + playerScore;
            Destroy(collision.gameObject);
        }
    }
}
