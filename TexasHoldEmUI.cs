public class TexasHoldEmUI : MonoBehaviour, CardGameUI.ICardGameSubUI // TypeDefIndex: 12659
{
	[SerializeField]
	private Image[] holeCardImages;
	[SerializeField]
	private Image[] holeCardBackings;
	[FormerlySerializedAsAttribute]
	[SerializeField]
	private Image[] communityCardImages;
	[SerializeField]
	private Image[] communityCardBackings;
	[SerializeField]
	private RustText potText;
	[SerializeField]
	private CardGamePlayerWidget[] playerWidgets;
	[SerializeField]
	private Translate.Phrase phraseWinningHand;
	[SerializeField]
	private Translate.Phrase foldPhrase;
	[SerializeField]
	private Translate.Phrase raisePhrase;
	[SerializeField]
	private Translate.Phrase checkPhrase;
	[SerializeField]
	private Translate.Phrase callPhrase;
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
	[SerializeField]
	private Translate.Phrase phraseRaiseAmount;
	[SerializeField]
	private Sprite dealerChip;
	[SerializeField]
	private Sprite smallBlindChip;
	[SerializeField]
	private Sprite bigBlindChip;
	[SerializeField]
	private Sprite noIcon;
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

	public void UpdateInGameUI(CardGameUI ui, CardGameController game) { }

	public string GetSecondaryInfo(CardGameUI ui, CardGameController game, out CardGameUI.InfoTextUI.Attitude attitude) { }

	public void UpdateInGameUI_NoPlayer(CardGameUI ui) { }

	public Translate.Phrase ResultToPhrase(PokerLib.PokerResult result) { }

	public void .ctor() { }

}

private enum TexasHoldEmUI.PlayerChipState // TypeDefIndex: 12660
{
	public int value__;
	public const TexasHoldEmUI.PlayerChipState None = 0;
	public const TexasHoldEmUI.PlayerChipState Dealer = 1;
	public const TexasHoldEmUI.PlayerChipState SmallBlind = 2;
	public const TexasHoldEmUI.PlayerChipState BigBlind = 3;

}

private sealed class TexasHoldEmUI.<>c // TypeDefIndex: 12661
{
	public static readonly TexasHoldEmUI.<>c <>9;
	public static Predicate<CardGameUI.KeycodeWithAction> <>9__34_0;
	public static Predicate<CardGameUI.KeycodeWithAction> <>9__34_1;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <UpdateInGameUI>

	internal bool <UpdateInGameUI>

}

