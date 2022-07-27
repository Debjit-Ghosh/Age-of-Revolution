using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private playerMov _player;
    private float _speed;
    

    public float BaseSpeed;
    //public float range;
    private Transform player;
    //public GameObject gun;
    //public GameObject bullet;
    public GameObject BloodPrefab;

    [SerializeField] private AudioSource eDeath;


    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _speed = BaseSpeed * (1 + Random.Range(-0.2f, 0.25f));
        _player = FindObjectOfType<playerMov>();

    }

    void Update()
    {
        if (_player != null)
        {
            transform.up = (_player.transform.position - transform.position);
            _rigidbody.velocity = transform.up * _speed;
        }

        float distToplayer = Vector2.Distance(_player.transform.position, transform.position);
        //if(distToplayer < range)
        //{
        //    Instantiate(bullet, gun.transform.position, Quaternion.identity);
        //}
        
    }

    public void Die()
    {
        eDeath.Play();
        score.scoreTotal++;
        Instantiate(BloodPrefab, transform.position, Quaternion.identity);  

        Destroy(gameObject);
    }
}
