using UnityEngine;

public class tilting : MonoBehaviour
{
float x = 0f;
float z = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }
    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis ("Vertical")* 4;
        float h = Input.GetAxis ("Horizontal") * -4;

      transform.rotation = Quaternion.Euler(v,0,h);
        
        
    }
}
