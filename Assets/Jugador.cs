﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{
    public Rigidbody2D cuerpo;
    public float velocidad;
    public float altura;
    public GameObject RecArrib;
    public GameObject RecAbbj;

    // Start is called before the first frame update
    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
        ConstruirNivel();
    }

    public void ConstruirNivel()
    {
        Instantiate(RecArrib, new Vector3(10, 8), transform.rotation);
        Instantiate(RecAbbj, new Vector3(10, -8), transform.rotation);

        Instantiate(RecArrib, new Vector3(17, 6), transform.rotation);
        Instantiate(RecAbbj, new Vector3(17, -10), transform.rotation);

        Instantiate(RecArrib, new Vector3(24, 10), transform.rotation);
        Instantiate(RecAbbj, new Vector3(24, -8), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        cuerpo.velocity = new Vector2(velocidad, cuerpo.velocity.y);
        if (Input.GetMouseButtonDown(0))
        {
            cuerpo.velocity = new Vector2(cuerpo.velocity.x, altura);
        }

        if(transform.position.y > 13 || transform.position.y < -13)
        {
            Reinicio();
        }
    }

    public void Reinicio()
    {
        SSTools.ShowMessage("YOU DIED", SSTools.Position.bottom, SSTools.Time.threeSecond);
        SceneManager.LoadScene("SampleScene");
    }
}
