using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveLeft : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x < -16)
        {
            Destroy(this.gameObject);
        }
        this.GetComponent<Transform>().position -= new Vector3(speed * Time.deltaTime, 0, 0);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            collision.gameObject.transform.position = new Vector3(-8, 0, 0);
            //GameObject temp = GameObject.FindGameObjectWithTag("UI");
            //temp.SetActive(false);
            SceneManager.LoadScene(2);
            Destroy(this.gameObject);
        }
    }
}
