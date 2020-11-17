﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour {

  public Transform target;
  NavMeshAgent navMeshAgent;

  void Start() {
    navMeshAgent = GetComponent<NavMeshAgent>();
  }

  void Update() {
    navMeshAgent.SetDestination(target.position);
  }
}
