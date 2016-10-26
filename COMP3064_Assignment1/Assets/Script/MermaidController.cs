using UnityEngine;
using System.Collections;

public class MermaidController : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Transform _transform;
    private Vector2 _currentPosition;
    public GameObject PowerCoin;
    public GameObject PowerCoinSpawn;


    // Use this for initialization
    void Start()
    {
        _transform = gameObject.transform;
        _currentPosition = _transform.position;
      //generate new powerCoins every second
        InvokeRepeating("dropPowerCoin", 0f, 1f);
        Reset();

    }

    // Update is called once per frame
    void Update()
    {
        //get current position
        _currentPosition = _transform.position;
        //compute new position
        _currentPosition -= new Vector2(speed, 0);
        //update new position
        _transform.position = _currentPosition;
        //check if it went outside camera scene, reset it
        if (_currentPosition.x <= -10f)
        {
            Reset();
        }
    }

    //reset the position
    public void Reset()
    {
        _currentPosition = new Vector2(11, 3.10f);
        _transform.position = _currentPosition;
    }

    //generate new coins
    public void dropPowerCoin()
    {
        GameObject powerCoin = (GameObject)Instantiate(PowerCoin);
        powerCoin.transform.position = PowerCoinSpawn.transform.position;
    }
}
