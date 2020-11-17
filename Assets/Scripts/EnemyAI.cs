using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour {

  public Transform target;
  public float chaseRange = 5f;

  NavMeshAgent navMeshAgent;
  float distanceToTarget = Mathf.Infinity;

  void OnDrawGizmosSelected() {
    Gizmos.color = new Color(1, 0, 0, 0.8F);
    // Gizmos.DrawSphere(transform.position, chaseRange);
    Gizmos.DrawWireSphere(transform.position, chaseRange);
  }

  void Start() {
    navMeshAgent = GetComponent<NavMeshAgent>();
  }

  void Update() {
    distanceToTarget = Vector3.Distance(target.position, transform.position);
    if (distanceToTarget <= chaseRange) {
      navMeshAgent.SetDestination(target.position);
    }
  }
}
