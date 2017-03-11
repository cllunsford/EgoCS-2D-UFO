public class UpdateScoreUIEvent : EgoEvent {
	public readonly int score;

	public UpdateScoreUIEvent(int newScore) {
		score = newScore;
	}
}