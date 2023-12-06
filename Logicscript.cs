using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Logicscript : MonoBehaviour
{
    public int score=0;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource scoreSFX;

    [ContextMenu("Increase score")]
    public void addscore()
    { 
     score=score+1;
     scoreText.text = score.ToString();
     scoreSFX.Play();
    }

    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameover()
    {
        gameOverScreen.SetActive(true);
    }
}
