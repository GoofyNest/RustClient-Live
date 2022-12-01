public class BlackjackMainScreenUI : FacepunchBehaviour // TypeDefIndex: 12641
{
	[SerializeField]
	private Canvas inGameDisplay;
	[SerializeField]
	private Canvas notInGameDisplay;
	[SerializeField]
	private Sprite faceNeutral;
	[SerializeField]
	private Sprite faceShocked;
	[SerializeField]
	private Sprite faceSad;
	[SerializeField]
	private Sprite faceCool;
	[SerializeField]
	private Sprite faceHappy;
	[SerializeField]
	private Sprite faceLove;
	[SerializeField]
	private Image faceInGame;
	[SerializeField]
	private Image faceNotInGame;
	[SerializeField]
	private Sprite[] faceNeutralVariants;
	[SerializeField]
	private Sprite[] faceHalloweenVariants;
	[SerializeField]
	private RustText cardCountText;
	[SerializeField]
	private RustText payoutText;
	[SerializeField]
	private RustText insuranceText;
	[SerializeField]
	private Canvas placeBetsCanvas;
	[SerializeField]
	private HorizontalLayoutGroup cardsLayout;
	[SerializeField]
	private BlackjackScreenCardUI[] cards;
	[SerializeField]
	private Translate.Phrase phraseBust;
	public BlackjackMachine blackjack;
	public const float LONG_EXPRESSION_TIME = 2;
	public const float SHORT_EXPRESSION_TIME = 0,7;
	private BlackjackController.DealerOpinion targetExpression;
	private bool expressionBit;


	protected void OnEnable() { }

	protected void OnDisable() { }

	public void RefreshVisuals(BlackjackController controller) { }

	private void RefreshInGameDisplay(BlackjackController controller, bool betweenRounds) { }

	private void RefreshNoGameDisplay() { }

	private void ShowInGameDisplay() { }

	private void ShowNotInGameDisplay() { }

	private void ShowGameDisplay(bool inGame) { }

	private void StartAnimatingFace(BlackjackController.DealerOpinion expression) { }

	private void StopAnimatingFace() { }

	private void SetNextFaceExpression() { }

	private Sprite DoHalloweenMode() { }

	private void SetFaceExpression(BlackjackController.DealerOpinion expression) { }

	private void SetFaceExpression(Sprite sprite) { }

	private Sprite GetSpriteFor(BlackjackController.DealerOpinion expression) { }

	private float GreatestCommonDivisor(float a, float b) { }

	public void .ctor() { }

}

