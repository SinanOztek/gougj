using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemymovement: MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent enemy;
    public Transform PlayerTarget;

    void Start()
    {
        enemy = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(PlayerTarget.position);
    }
}
