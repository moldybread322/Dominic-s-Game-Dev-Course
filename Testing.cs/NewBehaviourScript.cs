using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public int playerHeath;
    // Start is called before the first frame update
    void Start()
    {
        Debug.log ("Hello, I am being"); // this is just the begining of the game, I think that this is the same as void awake but im not sure, I think this is to run the actual game software.
    }

    // Update is called once per frame
    void Update()
    {
        // this is for every second the game runs, the heart beat as I was told, so basically the change in map and what not
    }
    
    void Awake()
    {
    playersHealth = 20; //this is for the stuff that is at the start of the game, like the health the time of day, the text lines that you want to start the game off with, I belive.
    }

    void FixedUpdate()
    {
        // Physics related code, this is for speed, jumping, bumping into things, etc
    }

}
