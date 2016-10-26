using UnityEngine;
using System.Collections;

public class SharkController : MonoBehaviour {
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
        //comput new oisition
        _currentPosition -= new Vector2(speed, 0);
        //update new position
        _transform.position = _currentPosition;
        if (_currentPosition.x <= -10f)
        {
            Reset();
        }


    }

    //reset the position
    public void Reset()
    {

        float currentY = Random.Range(-3f, 3f);
        _currentPosition = new Vector2(11, currentY);

        _transform.position = _currentPosition;


    }
}
