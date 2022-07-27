using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullet : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.velocity = (Vector2)(transform.up * speed);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        var enemy = other.collider.GetComponent<enemy>();
        if (enemy != null)
        {
            enemy.Die();
        }
    
        if(other.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }

    }
}
