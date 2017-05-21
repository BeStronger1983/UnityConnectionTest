using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(DoRequest());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator DoRequest()
	{
		var request = UnityWebRequest.Get("https://raw.githubusercontent.com/BeStronger1983/UnityConnectionTest/master/http_get_test");

		yield return request.Send();

		if (request.isError)
		{
			Debug.Log(request.error);
			yield break;
		}

		var html = request.downloadHandler.text;
		Debug.Log(html);
	}
}
