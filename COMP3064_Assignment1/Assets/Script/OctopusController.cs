/**************************************************************************
 * Author: Hoa Nguyen
 * Last Modified by : Hoa Nguyen 
 * Date Modified: 10/27/2016
 * Course: COMP3064-Game Programming
 * 
 **************************************************************************/
using UnityEngine;
using System.Collections;

public class OctopusController : MonoBehaviour
{

    [SerializeField]
    private float speed;
    private Transform _transform;
    private Vector2 _currentPosition;

    // Use this for initialization
    void Start()
    {
        _transform = gameObject.transform;
        _currentPosition = _transform.position;
        Reset();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //get current position
        _currentPosition = _transform.position;
        //compute new position
        _currentPosition += new Vector2(0, speed);
        //update new position
        _transform.position = _currentPosition;
        //reset position when octopus went out top of camera
        if (_currentPosition.y >= 5f)
        {
            Reset();
        }


    }
    //Reset octopus position
    public void Reset()
    {
        float currentX = Random.Range(-8f, 35f);
        _currentPosition = new Vector2(currentX, -5f);
        _transform.position = _currentPosition;


    }

}
