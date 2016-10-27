/**************************************************************************
 * Author: Hoa Nguyen
 * Last Modified by : Hoa Nguyen 
 * Date Modified: 10/27/2016
 * Course: COMP3064-Game Programming
 * 
 **************************************************************************/
using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {

    [SerializeField]
    private float speed;

    private float minx = -8f;
    private float maxx = 8f;
    private float miny = -3f;
    private float maxy = 3f;

    private Transform _transform;
    private Vector2 _currentPosistion;
    // Use this for initialization
    void Start()
    {
        _transform = gameObject.transform;
        _currentPosistion = _transform.position;
        Reset();

    }

    // Update is called once per frame
    void Update()
    {
        //Get current position
        _currentPosistion = _transform.position;
        //compute the coin new position
        _currentPosistion -= new Vector2(speed, 0);
        //update new position
        _transform.position = _currentPosistion;
        //Check if the coin went outside the camera scene, reset its position
        if (_currentPosistion.x <= minx)
        {
            Reset();
        }

    }

    //Reset coin position when it went out the camera scene 
    public void Reset()
    {
        float currentY = Random.Range(miny, maxy);
        _currentPosistion = new Vector2(maxx, currentY);
        _transform.position = _currentPosistion;
    }
}
