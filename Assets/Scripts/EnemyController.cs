using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    float speed = 18f;
    float enemyxlimit = 14.45f;
    bool collidewall = false;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            //for enemy to move to one point and come back to another in a loop
            if (transform.position.x <= enemyxlimit && collidewall == false)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }

            if (transform.position.x >= enemyxlimit)
            {
                collidewall = true;
            }
            if (collidewall == true)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            if (transform.position.x <= -enemyxlimit)
            {
                collidewall = false;
            }
  
    }
 

}
