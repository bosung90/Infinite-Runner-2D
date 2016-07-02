using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Access GameManager's variable or functions through the instance from another class
	// ex. GameManagger.instance.xyz
	public static GameManager instance;

	// Chang TODO: Create a private variable that holds player's health

	void Awake() {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (this.gameObject);
		}

		DontDestroyOnLoad (this.gameObject);
	}

	public int GetPlayerHealth() {
		// Chang TODO: return player's health
		return 0;
	}

	public void DamagePlayer(int damage) {
		// Chang TODO: Decrease Player's health

		// Chang TODO: When player's health is below 0, then restart the game.
	}
}
