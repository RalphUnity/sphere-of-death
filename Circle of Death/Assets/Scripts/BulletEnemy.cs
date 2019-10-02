﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    //Variables
    public float speed;
    public float maxDistance;
    public float damage;

    private GameObject triggeringEnemy;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        maxDistance += 1 * Time.deltaTime;

    }

    private void OnEnable()
    {

        Invoke("hideBullet", 2.0f);
    }

    void hideBullet()
    {
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }


    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            gameObject.SetActive(false);
        }

        if (other.tag == "Player")
        {
            player.GetComponent<Player>().health -= 20;
            player.GetComponent<PlayerTest>().health -= 20;
            gameObject.SetActive(false);
        }

        if (other.tag == "ForceField")
        {
            gameObject.SetActive(false);
        }

    }
}
