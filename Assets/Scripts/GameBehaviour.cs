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
    {
}
