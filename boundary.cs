using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boundary : MonoBehaviour
{
	[SerializeField ]private int Respawn;
	// Start is called before the first frame update
	private void OnTriggerEnter(Collider collision)
	{
		if (collision.CompareTag("Player"))
		{

			SceneManager.LoadScene(Respawn);
			
			Debug.Log("Dead");
		}
	}

}
