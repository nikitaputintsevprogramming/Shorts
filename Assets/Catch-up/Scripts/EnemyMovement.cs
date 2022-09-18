using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float EnemySpeed;
    private GameObject Player;

    // Start is called before the first frame update
    void Start()
    {        
        EnemySpeed = 0.3f;
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        var step =  EnemySpeed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, step);
    }
}
