﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuEffects : MonoBehaviour
{
    public float speed = 30f;
    public bool monte = false;
    public float maxSize = 1.2f;
    public float minSize = 0.7f;
    public float vitesseChangingSize = 0.1f;

    //TO CHANGE MODE IN EDITOR
    public bool ActivateChangingSize;
    public bool ActivateRotate;
    public bool ActivateCreditsMode;
    void Start()
    {
         
    }
    void Update()
    {
        if (ActivateChangingSize)
            ChangingSize();
        else
            transform.localScale = new Vector3(1, 1, 1);

        if (ActivateRotate)
            Rotate();
        else
            transform.rotation = new Quaternion(0,0,0,0);

        if (ActivateCreditsMode)
            CreditsMode();
        else
            transform.rotation = new Quaternion(0, 0, 0, 0);
    }
    
    void Rotate()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }

    void ChangingSize()
    {
        if (transform.localScale.x > maxSize)
            monte = false;
        if (transform.localScale.x < minSize)
            monte = true;

        if (monte)
            transform.localScale += new Vector3(vitesseChangingSize * Time.deltaTime, vitesseChangingSize * Time.deltaTime, vitesseChangingSize * Time.deltaTime);
        else
            transform.localScale -= new Vector3(vitesseChangingSize * Time.deltaTime, vitesseChangingSize * Time.deltaTime, vitesseChangingSize * Time.deltaTime);
    }

    void CreditsMode()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 25);
        if (transform.position.y > 1600)
            transform.position = new Vector3(800, -50, 0);
    }
}
