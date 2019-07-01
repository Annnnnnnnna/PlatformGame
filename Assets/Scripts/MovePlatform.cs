using UnityEngine;

public class MovePlatform : MonoBehaviour {
    public float min;
    public float max;
    public string direction;
  
    void Update()
    {
      if(direction=="horizontal")
            transform.position = new Vector3( Mathf.PingPong(Time.time, max-min)+min, transform.position.y, transform.position.z);
       
      if (direction=="vertical")
            transform.position = new Vector3(transform.position.x,Mathf.PingPong(Time.time, max - min) + min, transform.position.z);
    }
}
