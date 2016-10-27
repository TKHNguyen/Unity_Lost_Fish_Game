/**************************************************************************
 * Author: Hoa Nguyen
 * Last Modified by : Hoa Nguyen 
 * Date Modified: 10/27/2016
 * Course: COMP3064-Game Programming
 * 
 **************************************************************************/
using UnityEngine;
using System.Collections;

public class Collider : MonoBehaviour {

    [SerializeField]
    GameObject blood = null;
    [SerializeField]
    GameObject star = null;
    [SerializeField]
    GameObject sword = null;
    void OnTriggerEnter2D(Collider2D other)
    {
        //If player collided with coin, increase the instance point by 10
        if (other.gameObject.tag == "Coin")
        {
            Player.Instance.Points += 10;
            Debug.Log("Collision with" + other.gameObject.tag);
            CoinController coin = other.gameObject.GetComponent<CoinController>();
            if (coin != null)
            {
                GameObject st = Instantiate(star);
                st.transform.position = coin.transform.position;
                coin.Reset();
            }
            

        }

        //If player collided with PowerCoin, increase the instance health by 10
        if (other.gameObject.tag == "PowerCoin")
        {
            Player.Instance.Health += 10;
            Debug.Log("Collision with" + other.gameObject.tag);
            PowerCoinController powerCoin = other.gameObject.GetComponent<PowerCoinController>();
            if (powerCoin != null)
            {
                GameObject sw = Instantiate(sword);
                sw.transform.position = powerCoin.transform.position;
                powerCoin.destroy();
            }
          


        }

        //If player collided with shark, game over
        if (other.gameObject.tag == "Shark")
        {
            Player.Instance.Health -= 20;
            Debug.Log("Collision with" + other.gameObject.tag);
            SharkController shark = other.gameObject.GetComponent<SharkController>();
            if (shark != null)
            {
                GameObject bl = Instantiate(blood);
                bl.transform.position = shark.transform.position;
                
            }
           


        }

        //If player collided with octopus, decrease the instance health by 10
        else if (other.gameObject.tag == "Octopus")
        {
            Debug.Log("Collision with" + other.gameObject.tag);
            Player.Instance.Health -= 10;
            OctopusController octopus = other.gameObject.GetComponent<OctopusController>();
            if (octopus != null)
            {
                GameObject bl = Instantiate(blood);
                bl.transform.position = octopus.transform.position;
                octopus.Reset();
            }
           
        }

        //If player collided with submarine, game over
        else if (other.gameObject.tag == "Submarine")
        {
            Debug.Log("Collision with" + other.gameObject.tag);
            Player.Instance.Health -= 30;
            SubmarineController submarine = other.gameObject.GetComponent<SubmarineController>();
            if (submarine != null)
            {
                GameObject bl = Instantiate(blood);
                bl.transform.position = submarine.transform.position;
               
            }
           
        }

        //If player collided with submarine, game end
        else if (other.gameObject.tag == "Bullet")
        {
            Debug.Log("Collision with" + other.gameObject.tag);
            Player.Instance.Health = 0;
            BulletController bullet = other.gameObject.GetComponent<BulletController>();
            if (bullet != null)
            {
                GameObject bl = Instantiate(blood);
                bl.transform.position = bullet.transform.position;
                bullet.destroy();
               
            }
           
        }

    }
}
