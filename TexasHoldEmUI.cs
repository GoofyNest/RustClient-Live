public class TexasHoldEmUI : MonoBehaviour, CardTableUI.ICardGameSubUI // TypeDefIndex: 12616
{
	[SerializeField] 
	private Image[] holeCardImages; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private Image[] communityCardImages; 
	[SerializeField] 
	private RustText potText; 
	[SerializeField] 
	private TexasHoldEmPlayerWidget[] playerWidgets; 
	[SerializeField] 
	private GameObject raiseRoot; 
	[SerializeField] 
	private Translate.Phrase phraseNotEnoughBuyIn; 
	[SerializeField] 
	private Translate.Phrase phraseTooMuchBuyIn; 
	[SerializeField] 
	private Translate.Phrase phraseYouWinTheRound; 
	[SerializeField] 
	private Translate.Phrase phraseRoundWinner; 
	[SerializeField] 
	private Translate.Phrase phraseRoundWinners; 
	[SerializeField] 
	private Translate.Phrase phraseScrapWon; 
	[SerializeField] 
	private Translate.Phrase phraseScrapReturned; 
	[SerializeField] 
	private Translate.Phrase phraseWinningHand; 
	[SerializeField] 
	private Translate.Phrase phraseRoyalFlush; 
	[SerializeField] 
	private Translate.Phrase phraseStraightFlush; 
	[SerializeField] 
	private Translate.Phrase phraseFourOfAKind; 
	[SerializeField] 
	private Translate.Phrase phraseFullHouse; 
	[SerializeField] 
	private Translate.Phrase phraseFlush; 
	[SerializeField] 
	private Translate.Phrase phraseStraight; 
	[SerializeField] 
	private Translate.Phrase phraseThreeOfAKind; 
	[SerializeField] 
	private Translate.Phrase phraseTwoPair; 
	[SerializeField] 
	private Translate.Phrase phrasePair; 
	[SerializeField] 
	private Translate.Phrase phraseHighCard; 
	[CompilerGeneratedAttribute] 
	private int <DynamicBetAmount>k__BackingField; 
	private ulong lastActionId; 
	private int lastPotUpdate; 
	private List<PlayingCard> localPlayerCards; 

	public int DynamicBetAmount { get; set; }


	[CompilerGeneratedAttribute] 
	public int get_DynamicBetAmount() { }

	[CompilerGeneratedAttribute] 
	private void set_DynamicBetAmount(int value) { }

	public void UpdateInGameUI(CardTableUI ui, CardGameController game) { }

	public string GetSecondaryInfo(CardTableUI ui, CardGameController game, out CardTableUI.InfoTextUI.Attitude attitude) { }

	public void UpdateInGameUI_NoPlayer(CardTableUI ui) { }

	private string GetWinnerNameFromID(ulong playerID) { }

	private void PopulateCards(List<PlayingCard> cards, Image[] slots, CardTableUI ui) { }

	public Translate.Phrase PokerResultToPhrase(PokerLib.PokerResult result) { }

	public void .ctor() { }

}

private sealed class TexasHoldEmUI.<>c // TypeDefIndex: 12617
{
	public static readonly TexasHoldEmUI.<>c <>9; 
	public static Predicate<CardTableUI.KeycodeWithAction> <>9__30_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <UpdateInGameUI>b__30_0(CardTableUI.KeycodeWithAction p) { }

}

