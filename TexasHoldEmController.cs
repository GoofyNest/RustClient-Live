public class TexasHoldEmController : CardGameController // TypeDefIndex: 13765
{
	public List<PlayingCard> communityCards; 
	public const int SMALL_BLIND = 5;
	public const int BIG_BLIND = 10;
	public const string WON_HAND_STAT = "won_hand_texas_holdem";
	[CompilerGeneratedAttribute] 
	private TexasHoldEmController.PokerInputOption <LastAction>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <LastActionTarget>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <LastActionValue>k__BackingField; 
	public const int RAISE_INCREMENTS = 5;
	[CompilerGeneratedAttribute] 
	private int <BiggestRaiseThisTurn>k__BackingField; 
	private int dealerIndex; 
	private int activePlayerIndex; 

	public override int MinBuyIn { get; }
	public override int MaxBuyIn { get; }
	public override int MinPlayers { get; }
	public TexasHoldEmController.PokerInputOption LastAction { get; set; }
	public ulong LastActionTarget { get; set; }
	public int LastActionValue { get; set; }
	public int BiggestRaiseThisTurn { get; set; }


	public override int get_MinBuyIn() { }

	public override int get_MaxBuyIn() { }

	public override int get_MinPlayers() { }

	public void .ctor(CardTable owner) { }

	[CompilerGeneratedAttribute] 
	public TexasHoldEmController.PokerInputOption get_LastAction() { }

	[CompilerGeneratedAttribute] 
	private void set_LastAction(TexasHoldEmController.PokerInputOption value) { }

	[CompilerGeneratedAttribute] 
	public ulong get_LastActionTarget() { }

	[CompilerGeneratedAttribute] 
	private void set_LastActionTarget(ulong value) { }

	[CompilerGeneratedAttribute] 
	public int get_LastActionValue() { }

	[CompilerGeneratedAttribute] 
	private void set_LastActionValue(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_BiggestRaiseThisTurn() { }

	[CompilerGeneratedAttribute] 
	private void set_BiggestRaiseThisTurn(int value) { }

	public TexasHoldEmController.Playability GetPlayabilityStatus(CardPlayerData cpd) { }

	public int GetCurrentBet() { }

	public override bool IsAllowedToPlay(CardPlayerData cpd) { }

	public bool TryGetActivePlayer(out CardPlayerData activePlayer) { }

	public bool TryGetDealer(out CardPlayerData dealer) { }

	public bool TryGetSmallBlind(out CardPlayerData smallBlind) { }

	public bool TryGetBigBlind(out CardPlayerData bigBlind) { }

	public int GetFirstPlayerRelIndex(bool startOfRound) { }

	private bool ToCardPlayerData(int relIndex, bool includeFolded, out CardPlayerData result) { }

	public static ushort EvaluatePokerHand(List<PlayingCard> cards) { }

	public int GetCurrentMinRaise(CardPlayerData playerData) { }

	public override List<PlayingCard> GetTableCards() { }

	public override void Load(CardTable syncData) { }

	public TexasHoldEmController.Playability GetLocalPlayerPlayabilityStatus() { }

	protected override void SubGetAvailableInputs(ref List<CardTableUI.KeycodeWithAction> curAvailableInputs) { }

	private void OnInputFromUI(TexasHoldEmController.PokerInputOption input, int value = 0) { }

	public int GetCostOfInput(TexasHoldEmController.PokerInputOption option, CardPlayerData data) { }

	public bool IsAPrimaryWinner(ulong playerId) { }

	public bool IsAWinner(ulong playerId) { }

	public bool HasPrimaryWinners() { }

	public int NumPrimaryWinners() { }

	public bool HasSecondaryWinners() { }

	[CompilerGeneratedAttribute] 
	private void <SubGetAvailableInputs>b__46_3() { }

	[CompilerGeneratedAttribute] 
	private void <SubGetAvailableInputs>b__46_0() { }

	[CompilerGeneratedAttribute] 
	private void <SubGetAvailableInputs>b__46_1() { }

	[CompilerGeneratedAttribute] 
	private void <SubGetAvailableInputs>b__46_4() { }

	[CompilerGeneratedAttribute] 
	private void <SubGetAvailableInputs>b__46_5() { }

	[CompilerGeneratedAttribute] 
	private void <SubGetAvailableInputs>b__46_6() { }

	[CompilerGeneratedAttribute] 
	private void <SubGetAvailableInputs>b__46_2() { }

}

public enum TexasHoldEmController.PokerInputOption // TypeDefIndex: 13766
{
	public int value__; 
	public const TexasHoldEmController.PokerInputOption None = 0;
	public const TexasHoldEmController.PokerInputOption Fold = 1;
	public const TexasHoldEmController.PokerInputOption Call = 2;
	public const TexasHoldEmController.PokerInputOption AllIn = 4;
	public const TexasHoldEmController.PokerInputOption Check = 8;
	public const TexasHoldEmController.PokerInputOption Raise = 16;
	public const TexasHoldEmController.PokerInputOption Bet = 32;
	public const TexasHoldEmController.PokerInputOption RevealHand = 64;

}

public enum TexasHoldEmController.Playability // TypeDefIndex: 13767
{
	public int value__; 
	public const TexasHoldEmController.Playability OK = 0;
	public const TexasHoldEmController.Playability NoPlayer = 1;
	public const TexasHoldEmController.Playability NotEnoughBuyIn = 2;
	public const TexasHoldEmController.Playability TooMuchBuyIn = 3;
	public const TexasHoldEmController.Playability RanOutOfScrap = 4;
	public const TexasHoldEmController.Playability Idle = 5;

}

