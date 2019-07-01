using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthAndGameManager : MonoBehaviour {
    public GameObject[] hearts;
    public GameObject panel;
    private int health;
    public string level;
  
    void Start()
    {
        health = hearts.Length;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "Enemy")
        {
            health--;
            hearts[health].SetActive(false);
        }
        if (health == 0)
            panel.SetActive(true);
    }
    public void LoadOnClick(int nrAction)
    {
        switch (nrAction)
        {
            case (0):
                if(level=="1")
                    SceneManager.LoadScene("Level1");
                if (level == "2")
                    SceneManager.LoadScene("Level2");
                break;
            case (1):
                Application.Quit();
                break;
            default:
                break;
        }  
    }
}
