using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject Player;
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;

    void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void Update () {
        float x = Mathf.Clamp(Player.transform.position.x, xMin, xMax);
        float y = Mathf.Clamp(Player.transform.position.y, yMin, yMax);
        gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);
    }
}
