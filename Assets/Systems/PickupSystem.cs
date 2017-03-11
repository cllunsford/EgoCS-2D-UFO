public class PickupSystem : EgoSystem<
	EgoConstraint<Player>
> {

	public override void Start() {
		EgoEvents<TriggerEnter2DEvent>.AddHandler(Handle);
	}
	
	void Handle(TriggerEnter2DEvent e) {
		//Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
		if (e.egoComponent2.gameObject.CompareTag("PickUp")) {
			//... then set the other object we just collided with to inactive.
			e.egoComponent2.gameObject.SetActive(false);

			EgoEvents<IncreaseScoreEvent>.AddEvent( new IncreaseScoreEvent() );
		}
	}
}
