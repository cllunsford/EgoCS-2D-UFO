using UnityEngine;

public class UISystem : EgoSystem<
	EgoConstraint<Canvas, UI>
> {

	public override void Start () {
		Reset();

		EgoEvents<UpdateScoreUIEvent>.AddHandler( Handle );
		EgoEvents<WinEvent>.AddHandler( Handle );
	}
	
	void Handle( UpdateScoreUIEvent e ) {
		constraint.ForEachGameObject( (ego, canvas, ui) => {
			ui.CountText.text = "Score: " + e.score.ToString();
		});
	}

	void Handle( WinEvent e ) {
		constraint.ForEachGameObject( (ego, canvas, ui) => {
			ui.WinText.text = "You Win!";
		});
	}

	void Reset() {
		constraint.ForEachGameObject( (ego, canvas, ui) => {
			ui.CountText.text = "Score: 0";
			ui.WinText.text = "";
		});
	}
}
