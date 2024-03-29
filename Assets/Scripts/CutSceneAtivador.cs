﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Events;

public class CutSceneAtivador : MonoBehaviour
{

    public PlayableDirector cutScene;
    public bool playerOnTrigger;
    private bool playerIsTrigger;

    public GameObject Destruir;

    public GameObject canvas;

    void Update()
    {

        if (playerIsTrigger) {

            if (Input.GetKey(KeyCode.E)){
                StartCutScene();
                BarraVida.vidaAtual += 30f;
                Destruir.SetActive(false);
                if (canvas != null)
                {
                    canvas.SetActive(false);
                }
            }
        }
    }
 
    void StartCutScene() {

        cutScene.Play();
  
    }
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {

            playerIsTrigger = true;

            if (canvas != null) {
                canvas.SetActive(true); 
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            if (canvas != null)
            {
                canvas.SetActive(false);
            }

            playerIsTrigger = false;
        
        }
    }
}
