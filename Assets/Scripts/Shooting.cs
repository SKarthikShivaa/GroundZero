using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	public Rigidbody projectile;

	public float speed;
	//public bool isActive = false;
	public GameObject target;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {


			if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && target.activeInHierarchy)
		{
			speed = Random.Range(60f,200f);
			Rigidbody instantiatedProjectile = Instantiate(projectile,
				transform.position,
				transform.rotation)
				as Rigidbody;

			instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0,speed));


		}
	}
}
