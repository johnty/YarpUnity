using UnityEngine;
using System.Collections;

public class myScript : MonoBehaviour {

	BufferedPortBottle p;
	// Use this for initialization
	void Start () {
		Network.init();
		p = new BufferedPortBottle();
		p.open ("/unityYarp");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			gameObject.renderer.material.color = Color.red;
				}
		if (Input.GetKeyDown (KeyCode.G)) {
			gameObject.renderer.material.color = Color.green;
		}
		if (Input.GetKeyDown (KeyCode.B)) {
			gameObject.renderer.material.color = Color.blue;
		}

		if (p.getPendingReads () > 0) {
			gameObject.renderer.material.color = Color.cyan;
			Bottle bot = p.read();
			if (bot.size() == 3) {
				float r = (float) ( (float)bot.get (0).asInt() / 255.0 );
				float g = (float) ( (float)bot.get (1).asInt() / 255.0 );
				float b = (float) ( (float)bot.get (2).asInt() / 255.0 );
				gameObject.renderer.material.color= new Color(r, g, b);
			}
			if (bot.size () == 1) {
				transform.Translate(0, 5, 0);
			}
		}

	}
}
