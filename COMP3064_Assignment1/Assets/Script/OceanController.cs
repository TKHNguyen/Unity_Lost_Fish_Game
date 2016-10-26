using UnityEngine;
using System.Collections;

public class OceanController : MonoBehaviour
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
}
