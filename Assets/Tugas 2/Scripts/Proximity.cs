using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Proximity : MonoBehaviour
{
    public string newTitle;
    public string newDesc;
    private Transform other;
    private Text myTitle;
    private Text myDesc;
    private float dist;
    private GameObject player;
    private GameObject message1;
    private GameObject message2;
    private GameObject message3;
    private bool check;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        other = player.GetComponent<Transform>();
        message1 = GameObject.FindWithTag("hobi");
        message3 = GameObject.FindWithTag("desc");
        myTitle = message1.GetComponent<Text>();
        myTitle.text = "";
        myDesc = message3.GetComponent<Text>();
        myDesc.text = "";
        check = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (other)
        {
            dist = Vector3.Distance(transform.position, other.position);
            print("Distance to player: " + dist);
            if (dist < 3)
            {
                myTitle.text = newTitle;
                myDesc.text = newDesc;
                check = true;
            }
            if (dist > 3 && check == true)
            {
                Start();
            }
        }
    }
}