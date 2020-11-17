using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

  public Camera FPCamera;
  public float range = 100f;

  void Update() {
    if (Input.GetButtonDown("Fire1")) {
      Shoot();
    }
  }

  private void Shoot() {
    RaycastHit hit;
    Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range);
    print("HIT: " + hit.transform.name);
  }
}
