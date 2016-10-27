/**************************************************************************
 * Author: Hoa Nguyen
 * Last Modified by : Hoa Nguyen 
 * Date Modified: 10/27/2016
 * Course: COMP3064-Game Programming
 * 
 **************************************************************************/
using UnityEngine;
using System.Collections;

public class PowerCoinController : MonoBehaviour {
    float speed;
    // Use this for initialization
    void Start()
    {
        speed = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        //get the coin current position
        Vector2 _currentposition = transform.position;

        //complete the coin new position
        _currentposition = new Vector2(_currentposition.x , _currentposition.y - speed * Time.deltaTime);

        //update coin position
        transform.position = _currentposition;
        if (transform.position.y < -4f)
        {
            Destroy(gameObject);
        }
    }
    //destroy this game object
    public void destroy()
    {
        Destroy(gameObject);
    }
}
