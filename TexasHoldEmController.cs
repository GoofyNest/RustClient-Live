public class TexasHoldEmController : CardGameController // TypeDefIndex: 12013
{	public List<PlayingCard> communityCards; // 0x48
	public const int SMALL_BLIND = 5;
	public const int BIG_BLIND = 10;
	public const string WON_HAND_STAT = "won_hand_texas_holdem";
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TexasHoldEmController.PokerInputOption <LastAction>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <LastActionTarget>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <LastActionValue>k__BackingField; // 0x60
	public const int RAISE_INCREMENTS = 5;
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <BiggestRaiseThisTurn>k__BackingField; // 0x64
	private int dealerIndex; // 0x68
	private int activePlayerIndex; // 0x6C

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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public TexasHoldEmController.PokerInputOption get_LastAction() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_LastAction(TexasHoldEmController.PokerInputOption value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ulong get_LastActionTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_LastActionTarget(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_LastActionValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_LastActionValue(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_BiggestRaiseThisTurn() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <SubGetAvailableInputs>b__46_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <SubGetAvailableInputs>b__46_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <SubGetAvailableInputs>b__46_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <SubGetAvailableInputs>b__46_4() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <SubGetAvailableInputs>b__46_5() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <SubGetAvailableInputs>b__46_6() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <SubGetAvailableInputs>b__46_2() { }

}

public enum TexasHoldEmController.PokerInputOption // TypeDefIndex: 12014
{	public int value__; // 0x0
	public const TexasHoldEmController.PokerInputOption None = 0;
	public const TexasHoldEmController.PokerInputOption Fold = 1;
	public const TexasHoldEmController.PokerInputOption Call = 2;
	public const TexasHoldEmController.PokerInputOption AllIn = 4;
	public const TexasHoldEmController.PokerInputOption Check = 8;
	public const TexasHoldEmController.PokerInputOption Raise = 16;
	public const TexasHoldEmController.PokerInputOption Bet = 32;
	public const TexasHoldEmController.PokerInputOption RevealHand = 64;

}

public enum TexasHoldEmController.Playability // TypeDefIndex: 12015
{	public int value__; // 0x0
	public const TexasHoldEmController.Playability OK = 0;
	public const TexasHoldEmController.Playability NoPlayer = 1;
	public const TexasHoldEmController.Playability NotEnoughBuyIn = 2;
	public const TexasHoldEmController.Playability TooMuchBuyIn = 3;
	public const TexasHoldEmController.Playability RanOutOfScrap = 4;
	public const TexasHoldEmController.Playability Idle = 5;

}

