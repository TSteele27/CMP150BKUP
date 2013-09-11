using UnityEngine;
using System.Collections;
using System;


[Serializable]
public class CharacterControls
{
    public Control MoveForward;
    public Control MoveRight;
    public Control MoveLeft;
    public Control MoveUp;
    public Control MoveBack;
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
public class Movement : MyDerivedMono {
    public Control ControllerInput;


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
        
        if (controls.MoveForward.IsActive)
        {
            transform.Translate(transform.forward * (MoveSpeed * Time.deltaTime));

        }
        if (controls.MoveUp.IsActive)
        {
          
        }
        
        if (controls.MoveRight.IsActive)
        {
            transform.Translate(transform.right * (MoveSpeed * Time.deltaTime));
        }

        if (controls.MoveLeft.IsActive)
        {
            transform.Translate(-1 * transform.right * (MoveSpeed * Time.deltaTime));
        }
        if (controls.MoveBack.IsActive)
        {
            transform.Translate(-1 * transform.forward * (MoveSpeed * Time.deltaTime));
        }

	
	}
}
