using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerMov : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private Vector2 _input;

    public float Speed;
    public GameObject BulletPrefab;
    public Transform gun;
    public GameObject BloodPrefab;

    [SerializeField] private AudioSource pDeath;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        _input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.up = (mouseLoc.MousePos() - (Vector2)transform.position).normalized;
        _rigidbody.velocity = _input.normalized * Speed;
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    
    private void Shoot()
    {
        Instantiate(BulletPrefab, gun.position, transform.rotation);
    }

    public void Die()
    {
        
        Instantiate(BloodPrefab, transform.position, Quaternion.identity);
        //FindObjectOfType<TMP_Text>().enabled = true;
        Destroy(gameObject);
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        var enemy = other.collider.GetComponent<enemy>();
        if (other.gameObject.tag == "enemy") //TAG CHANGE WHEN BULLET
        {
            pDeath.Play();
            GameOver();
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene(2);
    }
    //public void PDie()
    //{
    //    //Instantiate(BloodPrefab, transform.position, Quaternion.identity);
    //    Destroy(gameObject);
    //}
}
