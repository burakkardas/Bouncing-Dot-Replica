using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text _scoreText;
    public int _score;
    void Update()
    {
        _scoreText.text = _score.ToString();
        if(_score > PlayerPrefs.GetInt("_highScore")) {
            PlayerPrefs.SetInt("_highScore", _score);
        }
    }
    
    public void RestartGame() {
        SceneManager.LoadScene(0);
    }
}
