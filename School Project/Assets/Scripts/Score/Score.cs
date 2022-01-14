using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int _score;
    public Text _scoreValue;
    public int _timeToWait = 5;
    public GameObject _winDialog;

    public void Update()
    {
        Win1();
    }

    public void Win1()
    {
        if (_score == 15)
        {
            _winDialog.SetActive(true);
        }
    }

    public void AddScore()
    {
        _score++;
        _scoreValue.text = _score.ToString();
    }
}
