using UnityEngine;

public class EnemyVersion2Controller : MonoBehaviour {
    public float min, max;
	
	void Update () {
      
        transform.position = new Vector3(Mathf.PingPong(Time.time, max - min) + min, transform.position.y, transform.position.z);
    } 
}