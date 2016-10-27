/**************************************************************************
 * Author: Hoa Nguyen
 * Last Modified by : Hoa Nguyen 
 * Date Modified: 10/27/2016
 * Course: COMP3064-Game Programming
 * 
 **************************************************************************/

using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

    float speed;
    public GameObject Blood;
    // Use this for initialization
    void Start()
    {
        speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        //get the bullet current position
        Vector2 _currentposition = transform.position;

        //complete the bullet new position
        _currentposition = new Vector2(_currentposition.x - speed * Time.deltaTime, _currentposition.y);

        //update bullet position
        transform.position = _currentposition;
        //Check if the bullet went outside camera scene, destroy it
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
    //Destroy this bullet 
    public void destroy()
    {
        Destroy(gameObject);
    }
}
