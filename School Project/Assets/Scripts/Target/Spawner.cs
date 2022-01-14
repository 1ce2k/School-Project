using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Target")]
    public GameObject _target;
    public int _targetCount;
    public int _targetsToSpawn;
    public float zPos;
    public float yPos;

#pragma warning disable IDE0051 // Remove unused private members
    private void Start() => StartCoroutine(TargetDrop1());
#pragma warning restore IDE0051 // Remove unused private members

    IEnumerator TargetDrop1()
    {
        while (_targetCount < _targetsToSpawn)
        {
            zPos = Random.Range(-15.85f, -8.55f);
            yPos = Random.Range(1f, 2.5f);
            Instantiate(_target, new Vector3(-30, yPos, zPos), Quaternion.Euler(0, 90,0));
            yield return new WaitForSeconds(0.1f);
            _targetCount += 1;
        }
    }
}
