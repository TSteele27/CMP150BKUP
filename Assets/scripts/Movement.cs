using UnityEngine;
using System.Collections;
using System;


[Serializable]
public class CharacterControls
{
    public KeyCode MoveForward = KeyCode.W;
    public KeyCode MoveRight = KeyCode.D;
    public KeyCode MoveLeft = KeyCode.A;
    public KeyCode MoveUp = KeyCode.Space;
    public KeyCode MoveBack = KeyCode.S;
}

public class MyDerivedMono : MonoBehaviour
{
    public float XPos
    {
        get { return transform.position.x; }
        set 
        {Vector3 myPos = transform.position;
            myPos.x = value;
            transform.position = myPos;
        }
    }
}
public class Movement : MyDerivedMono
{

    public float MoveSpeed = 5f;

    public CharacterControls controls = new CharacterControls();
    

    private float trueSpeed
    {
        get { return MoveSpeed * Time.deltaTime; }
    }
    
    // Use this for initialization
	void Start () 
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        XPos = 100f;
        if (Input.GetKey(controls.MoveForward))
        {
            transform.Translate(transform.forward * (MoveSpeed * Time.deltaTime));

        }
        if (Input.GetKey(controls.MoveUp))
        {
            transform.Translate(transform.up * (MoveSpeed * Time.deltaTime));
        }

        if (Input.GetKey(controls.MoveRight))
        {
            transform.Translate(transform.right * (MoveSpeed * Time.deltaTime));
        }

        if (Input.GetKey(controls.MoveLeft))
        {
            transform.Translate(-1 * transform.right * (MoveSpeed * Time.deltaTime));
        }
        if (Input.GetKey(controls.MoveBack))
        {
            transform.Translate(-1 * transform.forward * (MoveSpeed * Time.deltaTime));
        }
	
	}
}
