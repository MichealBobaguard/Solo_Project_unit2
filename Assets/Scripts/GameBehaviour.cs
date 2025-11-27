using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameBehaviour : MonoBehaviour
{

    public static GameBehaviour instance;

    private void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }   
        
    



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Inside()
    {
        SceneManager.LoadScene("InsideCave");

    }

    public void Outside()
    {
        SceneManager.LoadScene("OutsideCave");

    }

    public void TitleScreen()
    {
        SceneManager.LoadScene("TitleScreen");

    }

    public void Title()
    {
        SceneManager.LoadScene("TitleScreen");

    }
}
