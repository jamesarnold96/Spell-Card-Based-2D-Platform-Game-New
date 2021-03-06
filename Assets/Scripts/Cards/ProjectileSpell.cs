/* Class for spells which fire some sort of projectile
, such as fireballs, etc. This class contains a single static
method, which should be called within a spell card object*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProjectileSpell:MonoBehaviour {
	
	public static void Fire(GameObject prefab,
		Transform projectileSpawn, float speed)
	{
		//Create the fireball
		var projectile = (GameObject)Instantiate (
			prefab,
			projectileSpawn.position,
			projectileSpawn.rotation);

		//Add velocity to the projectile
		projectile.GetComponent<Rigidbody2D>().velocity = 
			new Vector3 (speed,0,0);


	}
}
