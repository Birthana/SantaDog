using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public bool onCooldown;
    public int cooldownTime;

    public Sprite[] presents;
    public GameObject present;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        Vector2 tempVect = new Vector2(0, v);
        tempVect = tempVect.normalized * speed * Time.deltaTime;
        rb.MovePosition(rb.position + tempVect * speed);

        if (this.transform.position.y < -1)
        {
            this.transform.position = new Vector3(this.transform.position.x, -1, 0);
        }

        if (Input.GetKey(KeyCode.Space) && !onCooldown)
        {
            StartCoroutine(DropPresent());
        }
    }

    IEnumerator DropPresent()
    {
        onCooldown = true;
        GameObject tempObject = Instantiate(present, this.transform.position + new Vector3(-1.5f, -1.5f, 0), Quaternion.identity);
        tempObject.GetComponent<SpriteRenderer>().sprite = presents[Random.Range(0, presents.Length)];
        yield return new WaitForSeconds(cooldownTime);
        onCooldown = false;
    }
}
