using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    [Header("Target")]
    public GameObject _target;
    public int _targetCount;
    public int _targetsToSpawn;
    public float xPos;
    public float yPos;

#pragma warning disable IDE0051 // Remove unused private members
    private void Start() => StartCoroutine(TargetDrop2());
#pragma warning restore IDE0051 // Remove unused private members

    IEnumerator TargetDrop2()
    {
        while (_targetCount < _targetsToSpawn)
        {
            xPos = Random.Range(-28f, -12.5f);
            yPos = Random.Range(1f, 2.5f);
            Instantiate(_target, new Vector3(xPos,yPos, -20), Quaternion.Euler(0, 180, 0));
            yield return new WaitForSeconds(0.1f);
            _targetCount += 1;
        }
    }
}

