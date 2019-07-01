using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour {
    public string level;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(level=="1")
            SceneManager.LoadScene("Level2");
        if(level=="2")
            SceneManager.LoadScene("EndGame");
    }
}
