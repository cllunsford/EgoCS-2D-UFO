using UnityEngine;

public class GameController : MonoBehaviour {

	static GameController() {
		EgoSystems.Add(
			new RotationSystem(),
			new VelocitySystem(),
			new PickupSystem(),
			new ScoreSystem(),
			new UISystem()
		);
	}

	void Start() {
		EgoSystems.Start();
	}
	
	void Update() {
		EgoSystems.Update();
	}

	void FixedUpdate() {
		EgoSystems.FixedUpdate();
	}
}
