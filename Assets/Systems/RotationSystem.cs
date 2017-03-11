using UnityEngine;

public class RotationSystem : EgoSystem<
	EgoConstraint<Transform, Rotate>
> {

	public override void Start() {
		// Randomize the starting rotation of each Pickup
		constraint.ForEachGameObject( (ego, transform, rotate) => {
			transform.Rotate (new Vector3 (0, 0, Random.Range(0, 360)));
		});
	}

	public override void Update () {
		constraint.ForEachGameObject( (ego, transform, rotate) => {
			transform.Rotate (new Vector3 (0, 0, rotate.degrees) * Time.deltaTime);
		});
	}
}
