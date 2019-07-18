using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PertorlEnemyController : MonoBehaviour
{
    public float speed;
    private int randomSport;

    public float moveTime;
    private float waitTime;

    // Uncomment these line to use spcific position petrol scrpit
    //public Transform[] moveSport;
    // Uncomment these lines to use any random position petrol scrpit
    public Transform randomMoveSport;
    public float minX;
    public float minY;
    public float maxX;
    public float maxY;




    // Start is called before the first frame update
    void Start()
    {
        // Uncomment these line to use spcific position petrol scrpit
        //randomSport = Random.Range(0, moveSport.Length);

        // Uncomment these line to use any random position petrol scrpit
        randomMoveSport.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));

        waitTime = moveTime;
    }

    // Update is called once per frame
    void Update()
    {
        // Uncomment these line to use spcific position petrol scrpit
        //transform.position = Vector2.MoveTowards(transform.position, moveSport[randomSport].transform.position, speed * Time.deltaTime);

        // Uncomment these line to use any random position petrol scrpit
        transform.position = Vector2.MoveTowards(transform.position, randomMoveSport.position, speed * Time.deltaTime);


    }

    private void LateUpdate()
    {
        // Uncomment these line to use spcific position petrol scrpit
        //if (transform.position == moveSport[randomSport].transform.position) {
        
        // Uncomment these line to use any random position petrol scrpit
        if (transform.position == randomMoveSport.position)
        {

            if (waitTime <= 0)
            {
                // Uncomment these line to use spcific position petrol scrpit
                //randomSport = Random.Range(0, moveSport.Length);

                // Uncomment these line to use any random position petrol scrpit
                randomMoveSport.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));

                waitTime = moveTime;
            }
            else {
                waitTime -= Time.deltaTime;
            }
        }
    }
}
