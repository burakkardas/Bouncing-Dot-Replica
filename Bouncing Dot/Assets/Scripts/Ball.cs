using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private GameManager _gm;
    public SpriteRenderer _sr;
    public Rigidbody2D _rb;
    public Sprite[] _balls;
    public float _jumpPower;
    public string _currentColor;
    void Start()
    {
        _gm = GameObject.FindObjectOfType<GameManager>();
        RandomColorBall(3);
        Tags(3);
    }

    private void RandomColorBall(int _index) {
        switch(_index) {
            case 0: _currentColor = "Red";
                    _sr.sprite = _balls[0];   
                    break;
            case 1: _currentColor = "Blue";
                    _sr.sprite = _balls[1];  
                    break;
            case 2: _currentColor = "Yellow";
                    _sr.sprite = _balls[2];  
                    break;
            case 3: _currentColor = "Purple";
                    _sr.sprite = _balls[3];  
                    break;
            case 4: _currentColor = "Green";
                    _sr.sprite = _balls[4];  
                    break;
            case 5: _currentColor = "Orange";
                    _sr.sprite = _balls[5];  
                    break;
        }
    }

    private void Tags(int _index) {
        switch(_index) {
            case 0: gameObject.tag = "Red";   
                    break;
            case 1: gameObject.tag = "Blue";   
                    break;
            case 2: gameObject.tag = "Yellow";   
                    break;
            case 3: gameObject.tag = "Purple";   
                    break;
            case 4: gameObject.tag = "Green";  
                    break;
            case 5: gameObject.tag = "Orange";   
                    break;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        _rb.velocity = Vector2.up * _jumpPower;
        if(_currentColor != other.gameObject.tag) {
            _gm.RestartGame();
        }
        else{
            _gm._score++;
        }
        int _randomNumb = Random.Range(0, 6);
        RandomColorBall(_randomNumb);
        Tags(_randomNumb);
    }
}
