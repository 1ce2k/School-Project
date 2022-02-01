using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int _score;
    public Text _scoreValue;
    public int _hits;

    public GameObject _gun;
    public GameObject _win1;
    public GameObject _win2;
    public Text _finalScore;

    public float time = 0f;
    public float timeToWait = 10f;
    public float timer = 0f;

    public GameObject player;

    #region(Questions)
    [Header("Questions")]
    public GameObject _questostart;
    public GameObject _quest1;
    public GameObject _quest2;
    public GameObject _quest3;
    public GameObject _quest4;
    public GameObject _quest5;
    public GameObject _quest6;
    public GameObject _quest7;
    public GameObject _quest8;
    public GameObject _quest9;
    public GameObject _quest10;
    public GameObject _quest11;
    public GameObject _quest12;
    public GameObject _quest13;
    public GameObject _quest14;
    public GameObject _quest15;
    public GameObject _quest16;
    public GameObject _quest17;
    public GameObject _quest18;
    public GameObject _quest19;
    public GameObject _quest20;
    #endregion

    #region(spawners)
    [Header("Spawners")]
    public GameObject _spawner1;
    public GameObject _spawner2;
    public GameObject _spawner3;
    public GameObject _spawner4;
    public GameObject _spawner5;
    public GameObject _spawner6;
    public GameObject _spawner7;
    public GameObject _spawner8;
    public GameObject _spawner9;
    public GameObject _spawner10;
    public GameObject _spawner11;
    public GameObject _spawner12;
    public GameObject _spawner13;
    public GameObject _spawner14;
    public GameObject _spawner15;
    public GameObject _spawner16;
    public GameObject _spawner17;
    public GameObject _spawner18;
    public GameObject _spawner19;
    public GameObject _spawner20;
    #endregion

    void Start()
    {
        player.GetComponent<DoorRaycast2>().enabled = false;
        
    }

    public void Update()
    {
        #region(CheckHits)
        if (_hits == 10)
        {
            _quest2.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _spawner1.SetActive(false);
            _hits++;
        }

        if (_hits == 21)
        {
            _quest3.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _hits++;
        }

        if (_hits == 32)
        {
            _quest4.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _hits++;
        }

        if (_hits == 43)
        {
            _quest5.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _hits++;
        }

        if (_hits == 54)
        {
            _quest6.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _hits++;
        }

        if (_hits == 65)
        {
            _quest7.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _hits++;
        }

        if (_hits == 76)
        {
            _quest8.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _hits++;
        }

        if (_hits == 87)
        {
            _quest9.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _hits++;
        }

        if (_hits == 98)
        {
            _quest10.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _hits++;
        }

        if (_hits == 108)
        {
            Debug.Log(_hits);
        }

        if (_hits == 109)
        {
            player.GetComponent<DoorRaycast2>().enabled = true;
            _gun.SetActive(false);
            _hits++;
        }
        
        if (_hits == 125)
        {
            _quest12.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _hits++;
        }

        if (_hits == 131)
        {
            _quest13.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _hits++;
        }

        if (_hits == 142)
        {
            _quest14.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _hits++;
        }

        if (_hits == 153)
        {
            _quest15.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _hits++;
        }

        if (_hits == 164)
        {
            _quest15.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _hits++;
        }

        if (_hits == 175)
        {
            _quest17.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _hits++;
        }

        if (_hits == 186)
        {
            _quest18.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _hits++;
        }

        if (_hits == 197)
        {
            _quest19.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _hits++;
        }

        if (_hits == 208)
        {
            _quest20.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _hits++;
        }
        #endregion

        
    }

    public void AddScore()
    {
        _score++;
        _scoreValue.text = _score.ToString();
        _hits++;
    }

    public void CorrectAns()
    {
        _score += 15;
        _scoreValue.text = _score.ToString();

    }

    public void InCorrectAns()
    {
        _score -= 5;
        _scoreValue.text = _score.ToString();
    }
    public void CursorLocked()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    #region(QuestionFunctions)
    public void Question1_1()
    {
        _quest1.SetActive(false);
        CursorLocked();
        _spawner1.SetActive(true);
        _gun.SetActive(true);
    }
    public void Question1_2()
    {
        _quest2.SetActive(false);
        CursorLocked();
        _spawner2.SetActive(true);
        _gun.SetActive(true);
    }
    public void Question1_3()
    {
        _quest3.SetActive(false);
        CursorLocked();
        _spawner3.SetActive(true);
        _gun.SetActive(true);
    }
    public void Question1_4()
    {
        _quest4.SetActive(false);
        CursorLocked();
        _spawner4.SetActive(true);
        _gun.SetActive(true);
    }
    public void Question1_5()
    {
        _quest5.SetActive(false);
        CursorLocked();
        _spawner5.SetActive(true);
        _gun.SetActive(true);
    }
    public void Question1_6()
    {
        _quest6.SetActive(false);
        CursorLocked();
        _spawner6.SetActive(true);
        _gun.SetActive(true);
    }
    public void Question1_7()
    {
        _quest7.SetActive(false);
        CursorLocked();
        _spawner7.SetActive(true);
        _gun.SetActive(true);
    }
    public void Question1_8()
    {
        _quest8.SetActive(false);
        CursorLocked();
        _spawner8.SetActive(true);
        _gun.SetActive(true);
    }
    public void Question1_9()
    {
        _quest9.SetActive(false);
        CursorLocked();
        _spawner9.SetActive(true);
        _gun.SetActive(true);
    }
    public void Question1_10()
    {
        _quest10.SetActive(false);
        CursorLocked();
        _spawner10.SetActive(true);
        _gun.SetActive(true);
    }
    public void Question1_11()
    {
        _quest11.SetActive(false);
        CursorLocked();
        _spawner11.SetActive(true);
        _gun.SetActive(true);
    }
    public void Question1_12()
    {
        _quest12.SetActive(false);
        CursorLocked();
        _spawner12.SetActive(true);
        _gun.SetActive(true);
    }
    public void Question1_13()
    {
        _quest13.SetActive(false);
        CursorLocked();
        _spawner13.SetActive(true);
        _gun.SetActive(true);
    }
    public void Question1_14()
    {
        _quest14.SetActive(false);
        CursorLocked();
        _spawner14.SetActive(true);
        _gun.SetActive(true);
    }
    public void Question1_15()
    {
        _quest15.SetActive(false);
        CursorLocked();
        _spawner15.SetActive(true);
        _gun.SetActive(true);
    }
    public void Question1_16()
    {
        _quest16.SetActive(false);
        CursorLocked();
        _spawner16.SetActive(true);
        _gun.SetActive(true);
    }
    public void Question1_17()
    {
        _quest17.SetActive(false);
        CursorLocked();
        _spawner17.SetActive(true);
        _gun.SetActive(true);
    }
    public void Question1_18()
    {
        _quest18.SetActive(false);
        CursorLocked();
        _spawner18.SetActive(true);
        _gun.SetActive(true);
    }
    public void Question1_19()
    {
        _quest19.SetActive(false);
        CursorLocked();
        _spawner19.SetActive(true);
        _gun.SetActive(true);
    }
    public void Question1_20()
    {
        _quest20.SetActive(false);
        CursorLocked();
        _spawner20.SetActive(true);
        _gun.SetActive(true);
    }
    #endregion
}
