using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fruits_tester : MonoBehaviour {

	public float wait_time = 5;

	public GameObject[] fruits;
	// Use this for initialization
	void Start () 
	{
		StartCoroutine(wait_for_intro());
	}

	IEnumerator wait_for_intro()
	{
		yield return new WaitForSeconds(wait_time);
		SceneManager.LoadScene(1);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		fruits[0].transform.RotateAround (Vector3.up, Time.deltaTime);
		fruits[1].transform.RotateAround (Vector3.up, -Time.deltaTime);
		fruits[2].transform.RotateAround (Vector3.up, Time.deltaTime);
		fruits[3].transform.RotateAround (Vector3.up, -Time.deltaTime);
		fruits[4].transform.RotateAround (Vector3.up, Time.deltaTime);
		fruits[5].transform.RotateAround (Vector3.up, -Time.deltaTime);
		fruits[6].transform.RotateAround (Vector3.up, Time.deltaTime);
		fruits[7].transform.RotateAround (Vector3.up, -Time.deltaTime);
		fruits[8].transform.RotateAround (Vector3.up, Time.deltaTime);
		fruits[9].transform.RotateAround (Vector3.up, -Time.deltaTime);
	
	}
}
