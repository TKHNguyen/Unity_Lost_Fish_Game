/**************************************************************************
 * Author: Hoa Nguyen
 * Last Modified by : Hoa Nguyen 
 * Date Modified: 10/27/2016
 * Course: COMP3064-Game Programming
 * 
 **************************************************************************/
using UnityEngine;
using System.Collections;

public class OceanController : MonoBehaviour
{

    public GameObject blood;
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
    void Update()
    {
        //get current position
        _currentPosition = _transform.position;
        //compute the ocean new posion
        _currentPosition -= new Vector2(speed, 0);
        //update the ocean new position
        _transform.position = _currentPosition;
        //reset the ocean if its x less than -13f
        if (_currentPosition.x <= -13f)
        {
            Reset();
        }

    }
    //Reset the ocean position 
    public void Reset()
    {
        _currentPosition = new Vector2(13f, 0.3f);
        _transform.position = _currentPosition;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //If octopus with bullet, reset the octopus
        if (other.gameObject.tag == "Bullet")
        {
            OctopusController octopus = other.gameObject.GetComponent<OctopusController>();
            if (octopus != null)
            {
                GameObject bld = Instantiate(blood);
                bld.transform.position = octopus.transform.position;
                octopus.Reset();
            }

        }
        }
    }
