using UnityEngine;
using System.Collections;

public class SubmarineController : MonoBehaviour {

    [SerializeField]
    private float speed;
    private Transform _transform;
    private Vector2 _currentPosition;
    public GameObject BulletSpawn;
    public GameObject Bullet;

    // Use this for initialization
    void Start()
    {
        _transform = gameObject.transform;
        _currentPosition = _transform.position;
        //generate bullet every 0.5 sencond
        InvokeRepeating("fireBullet", 0f, 0.5f);
        Reset();

    }

    // Update is called once per frame
    void Update()
    {
        _currentPosition = _transform.position;
        _currentPosition -= new Vector2(speed, 0);
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

    //generate new bullet
    public void fireBullet()
    {

        
            GameObject bullet = (GameObject)Instantiate(Bullet);
            bullet.transform.position = BulletSpawn.transform.position;
        
    }
}
