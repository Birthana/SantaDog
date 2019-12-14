using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Present : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < -6)
        {
            Destroy(this.gameObject);
        }
        this.GetComponent<Transform>().position -= new Vector3(0, speed * Time.deltaTime, 0);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("DropZone"))
        {
            GameObject timer = GameObject.FindGameObjectWithTag("Timer");
            timer.GetComponent<Timer>().increaseTimer(3.0f);
            Destroy(this.gameObject);
        }
    }
}
