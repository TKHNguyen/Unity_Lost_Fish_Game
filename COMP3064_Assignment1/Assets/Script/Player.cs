/**************************************************************************
 * Author: Hoa Nguyen
 * Last Modified by : Hoa Nguyen 
 * Date Modified: 10/27/2016
 * Course: COMP3064-Game Programming
 * 
 **************************************************************************/
using UnityEngine;
using System.Collections;



    public class Player
    {

        private const string key = null;
        private int _points = 0;
        private int _health = 100;
        private int _highScore = 0;
        public HUDController hub;
        private static Player _instance = null;
        public static Player Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Player();
                }
                return _instance;

            }
        }
        private Player()
        {
            if (PlayerPrefs.HasKey(key))
            {
                _highScore = PlayerPrefs.GetInt(key);
            }

        }

        public int Points
        {
            //reurn points
            get { return _points; }
            //set value for points varibale
            set
            {
                _points = value; hub.UpdatePoints();
                if (value > _highScore)
                {
                    PlayerPrefs.SetInt(key, value);
                    _highScore = value;
                }
            }
        }
        public int Health
        {
            //return health value
            get { return _health; }
            //set value for health variable 
            set
            {
                _health = value;
                hub.UpdateHealth();
                if (_health <= 0)
                {
                    hub.GameOver();
                }

            }
        }
        public int HighScore
        {
            //reuturn high score
            get
            {
                return _highScore;
            }



        }
    }
