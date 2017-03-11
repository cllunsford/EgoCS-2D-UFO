public class ScoreSystem : EgoSystem<EgoConstraint<Score>> {

	public override void Start () {
		EgoEvents<IncreaseScoreEvent>.AddHandler(Handle);
	}
	
	void Handle(IncreaseScoreEvent e) {
		constraint.ForEachGameObject((ego, score) => {
			score.value += 1;
			EgoEvents<UpdateScoreUIEvent>.AddEvent( new UpdateScoreUIEvent(score.value) );

			if (score.value >= 12) {
				EgoEvents<WinEvent>.AddEvent( new WinEvent() );
			}
		});
	}
}
