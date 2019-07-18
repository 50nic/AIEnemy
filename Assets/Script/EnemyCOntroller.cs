using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCOntroller : MonoBehaviour
{

    public float speed;
    public float atWhatDistanceNeedToStop;
    public float atWhatDistanceNeedToRetreat;
    private float timeBetweenShooting;
    public float startTimrBetweenShooting;
    private Transform player;
    public GameObject projectile;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        timeBetweenShooting = startTimrBetweenShooting;
    }

    // Update is called once per frame
    void Update()
    {
              if (Vector2.Distance(transform.position, player.position) > atWhatDistanceNeedToStop)
              {

                  transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
              }
              else if (Vector2.Distance(transform.position, player.position) < atWhatDistanceNeedToStop && Vector2.Distance(transform.position, player.position) > atWhatDistanceNeedToRetreat)
              {
                  transform.position = this.transform.position;
              }
              else {
                  transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);

              }

        if (timeBetweenShooting <= 0) {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBetweenShooting = startTimrBetweenShooting;
        } else {
            timeBetweenShooting -= Time.deltaTime;
        }

    }
}
