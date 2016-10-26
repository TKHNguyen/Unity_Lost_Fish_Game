using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float speed;
    private Transform _transform;
    private Vector2 _currentPosition;
    private float _playerInputX;
    private float _playerInputY;

    // Use this for initialization
    void Start()
    {
        _transform = gameObject.transform;
        _currentPosition = _transform.position;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Get user input
        _playerInputY = Input.GetAxis("Vertical");
        _playerInputX = Input.GetAxis("Horizontal");
        _currentPosition = _transform.position;
       
        //if up arrow key is pressed, fish swims up
        if (_playerInputY > 0)
        {
            _currentPosition += new Vector2(0, speed);
        }
        //if down arrow key is pressed, fish swims down
        if (_playerInputY < 0)
        {
            _currentPosition -= new Vector2(0, speed);
        }
        //if right arrow key is pressed, fish swims to the right
        if (_playerInputX > 0)
        {
            _currentPosition += new Vector2(speed, 0);
        }
        //if left arrow key is pressed, fish swims to the left
        if (_playerInputX < 0)
        {
            _currentPosition -= new Vector2(speed, 0);
            
        }
        checkBound();
        _transform.position = _currentPosition;
    }
    //make sure the fish  is allways inside camera scene
    private void checkBound()
    {
        if (_currentPosition.x < -7f)
        {
            _currentPosition.x = -7f;
        }
        if (_currentPosition.x > 7f)
        {
            _currentPosition.x = 7f;
        }
        if (_currentPosition.y < -3f)
        {
            _currentPosition.y = -3f;
        }
        if (_currentPosition.y > 3f)
        {
            _currentPosition.y = 3f;
        }
    }
}
