using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoShoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(ShootingSenquence());
	}
	
	IEnumerator ShootingSenquence(){
		while(true){
			print("Shooting");
			yield return null;
		}

	}
}
