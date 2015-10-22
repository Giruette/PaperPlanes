using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	[SerializeField] float speed = 300.0f;
	[SerializeField] GameObject bulletPrefab;
	[SerializeField] GameObject bulletContainer;

	float bulletTime = 0f;
	float bulletInterval = 0.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Controls ();
		GenerateBullet ();
	}

	void Controls() {
		if(Input.GetKey("left")){
			this.transform.Translate(Vector3.left * speed * Time.deltaTime);
		}else if(Input.GetKey("right")){
			this.transform.Translate(Vector3.right * speed * Time.deltaTime);
		}
	}

	void GenerateBullet(){
		bulletTime += Time.deltaTime;
		if (bulletTime >= bulletInterval) {
			GameObject bullet = Instantiate (bulletPrefab) as GameObject;
			bullet.transform.position = this.transform.position;
			bullet.transform.parent = bulletContainer.transform;
			bulletTime = 0f;
		}
	}
}
