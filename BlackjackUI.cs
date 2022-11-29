public class BlackjackUI : MonoBehaviour, CardGameUI.ICardGameSubUI // TypeDefIndex: 12632
{
	[SerializeField] 
	private Image[] playerCardImages; 
	[SerializeField] 
	private Image[] dealerCardImages; 
	[SerializeField] 
	private Image[] splitCardImages; 
	[SerializeField] 
	private Image[] playerCardBackings; 
	[SerializeField] 
	private Image[] dealerCardBackings; 
	[SerializeField] 
	private Image[] splitCardBackings; 
	[SerializeField] 
	private CardGamePlayerWidget[] playerWidgets; 
	[SerializeField] 
	private GameObject dealerValueObj; 
	[SerializeField] 
	private RustText dealerValueText; 
	[SerializeField] 
	private GameObject yourValueObj; 
	[SerializeField] 
	private RustText yourValueText; 
	[SerializeField] 
	private Translate.Phrase phrasePlaceYourBet; 
	[SerializeField] 
	private Translate.Phrase phraseHit; 
	[SerializeField] 
	private Translate.Phrase phraseStand; 
	[SerializeField] 
	private Translate.Phrase phraseSplit; 
	[SerializeField] 
	private Translate.Phrase phraseDouble; 
	[SerializeField] 
	private Translate.Phrase phraseInsurance; 
	[SerializeField] 
	private Translate.Phrase phraseBust; 
	[SerializeField] 
	private Translate.Phrase phraseBlackjack; 
	[SerializeField] 
	private Translate.Phrase phraseStandoff; 
	[SerializeField] 
	private Translate.Phrase phraseYouWin; 
	[SerializeField] 
	private Translate.Phrase phraseYouLose; 
	[SerializeField] 
	private Translate.Phrase phraseWaitingForOtherPlayers; 
	[SerializeField] 
	private Translate.Phrase phraseHand; 
	[SerializeField] 
	private Translate.Phrase phraseInsurancePaidOut; 
	[SerializeField] 
	private Sprite insuranceIcon; 
	[SerializeField] 
	private Sprite noIcon; 
	[SerializeField] 
	private Color bustTextColour; 
	[CompilerGeneratedAttribute] 
	private int <DynamicBetAmount>k__BackingField; 
	private ulong lastActionId; 

	public int DynamicBetAmount { get; set; }


	[CompilerGeneratedAttribute] 
	public int get_DynamicBetAmount() { }

	[CompilerGeneratedAttribute] 
	private void set_DynamicBetAmount(int value) { }

	public void UpdateInGameUI(CardGameUI ui, CardGameController game) { }

	protected string GetScoreTextFor(BlackjackController blackjack, List<PlayingCard> cards) { }

	public string GetSecondaryInfo(CardGameUI ui, CardGameController game, out CardGameUI.InfoTextUI.Attitude attitude) { }

	private string GetResultText(BlackjackController.BlackjackRoundResult result) { }

	private CardGameUI.InfoTextUI.Attitude GetResultAttitude(BlackjackController.BlackjackRoundResult mainResult, BlackjackController.BlackjackRoundResult splitResult) { }

	public void UpdateInGameUI_NoPlayer(CardGameUI ui) { }

	public void .ctor() { }

}

private sealed class BlackjackUI.<>c // TypeDefIndex: 12633
{
	public static readonly BlackjackUI.<>c <>9; 
	public static Predicate<CardGameUI.KeycodeWithAction> <>9__33_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <UpdateInGameUI>

}

