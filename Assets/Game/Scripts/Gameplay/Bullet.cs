using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	[SerializeField] float speed = 1000.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * speed * Time.deltaTime);
		if (transform.position.y > 500.0f) {
			Destroy(this.gameObject);
		}
	}
}
