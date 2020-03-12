using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShootProfile", menuName = "Shooting Profile", order = 1)]

public class ShootProfile : ScriptableObject {

	public float speed, damage, fireRate, interval, destroRate, spreed ;
	public int amount;
}
