using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	 float life;
	public GameObject testimage;
	public ParticleSystem explosion;
	public Transform FT;

	void Awake()
	{

		transform.forward = FT.forward;
		explosion = transform.Find("ExplSystem").GetComponent<ParticleSystem>();
	}

	// Use this for initialization
	void Start () {
		testimage.SetActive(false);
		life = Time.time+5f;
		transform.parent = null;
		testimage = GameObject.Find("Canvas").transform.Find("Fire").gameObject;
	}

	void OnCollisionEnter(Collision other)
	{

		if(other.gameObject.tag == "Target")
		{
		
			explosion.gameObject.SetActive(true);
			explosion.transform.parent = other.transform;
			explosion.transform.position = new Vector3(transform.position.x,transform.position.y+10f,transform.position.z);
			Destroy (explosion,5f);
			Destroy(gameObject,4f);
		}
	}

	// Update is called once per frame
	void Update () {

		if(Time.time>life)
			Destroy(gameObject);
	
	}
}
