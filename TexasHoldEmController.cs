public class TexasHoldEmController : CardGameController // TypeDefIndex: 12013
{	// Fields
	public List<PlayingCard> communityCards; // 0x48
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

	// Properties
	public override int MinBuyIn { get; }
	public override int MaxBuyIn { get; }
	public override int MinPlayers { get; }
	public TexasHoldEmController.PokerInputOption LastAction { get; set; }
	public ulong LastActionTarget { get; set; }
	public int LastActionValue { get; set; }
	public int BiggestRaiseThisTurn { get; set; }

	// Methods

	// RVA: 0x8C8BA0 Offset: 0x8C7FA0 VA: 0x1808C8BA0 Slot: 6
	public override int get_MinBuyIn() { }

	// RVA: 0x8C8B90 Offset: 0x8C7F90 VA: 0x1808C8B90 Slot: 7
	public override int get_MaxBuyIn() { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 5
	public override int get_MinPlayers() { }

	// RVA: 0x8C8B00 Offset: 0x8C7F00 VA: 0x1808C8B00
	public void .ctor(CardTable owner) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8C8B80 Offset: 0x8C7F80 VA: 0x1808C8B80
	public TexasHoldEmController.PokerInputOption get_LastAction() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8C8BC0 Offset: 0x8C7FC0 VA: 0x1808C8BC0
	private void set_LastAction(TexasHoldEmController.PokerInputOption value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public ulong get_LastActionTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8C8BB0 Offset: 0x8C7FB0 VA: 0x1808C8BB0
	private void set_LastActionTarget(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC10 Offset: 0x58D010 VA: 0x18058DC10
	public int get_LastActionValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DCA0 Offset: 0x58D0A0 VA: 0x18058DCA0
	private void set_LastActionValue(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DBF0 Offset: 0x58CFF0 VA: 0x18058DBF0
	public int get_BiggestRaiseThisTurn() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC80 Offset: 0x58D080 VA: 0x18058DC80
	private void set_BiggestRaiseThisTurn(int value) { }

	// RVA: 0x8C7340 Offset: 0x8C6740 VA: 0x1808C7340
	public TexasHoldEmController.Playability GetPlayabilityStatus(CardPlayerData cpd) { }

	// RVA: 0x8C7030 Offset: 0x8C6430 VA: 0x1808C7030
	public int GetCurrentBet() { }

	// RVA: 0x8C79A0 Offset: 0x8C6DA0 VA: 0x1808C79A0 Slot: 11
	public override bool IsAllowedToPlay(CardPlayerData cpd) { }

	// RVA: 0x8C8730 Offset: 0x8C7B30 VA: 0x1808C8730
	public bool TryGetActivePlayer(out CardPlayerData activePlayer) { }

	// RVA: 0x8C8800 Offset: 0x8C7C00 VA: 0x1808C8800
	public bool TryGetDealer(out CardPlayerData dealer) { }

	// RVA: 0x8C8820 Offset: 0x8C7C20 VA: 0x1808C8820
	public bool TryGetSmallBlind(out CardPlayerData smallBlind) { }

	// RVA: 0x8C8750 Offset: 0x8C7B50 VA: 0x1808C8750
	public bool TryGetBigBlind(out CardPlayerData bigBlind) { }

	// RVA: 0x8C71A0 Offset: 0x8C65A0 VA: 0x1808C71A0
	public int GetFirstPlayerRelIndex(bool startOfRound) { }

	// RVA: 0x8C85E0 Offset: 0x8C79E0 VA: 0x1808C85E0
	private bool ToCardPlayerData(int relIndex, bool includeFolded, out CardPlayerData result) { }

	// RVA: 0x8C6D10 Offset: 0x8C6110 VA: 0x1808C6D10
	public static ushort EvaluatePokerHand(List<PlayingCard> cards) { }

	// RVA: 0x8C7100 Offset: 0x8C6500 VA: 0x1808C7100
	public int GetCurrentMinRaise(CardPlayerData playerData) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0 Slot: 10
	public override List<PlayingCard> GetTableCards() { }

	// RVA: 0x8C79C0 Offset: 0x8C6DC0 VA: 0x1808C79C0 Slot: 12
	public override void Load(CardTable syncData) { }

	// RVA: 0x8C7240 Offset: 0x8C6640 VA: 0x1808C7240
	public TexasHoldEmController.Playability GetLocalPlayerPlayabilityStatus() { }

	// RVA: 0x8C7D60 Offset: 0x8C7160 VA: 0x1808C7D60 Slot: 13
	protected override void SubGetAvailableInputs(ref List<CardTableUI.KeycodeWithAction> curAvailableInputs) { }

	// RVA: 0x8C7D40 Offset: 0x8C7140 VA: 0x1808C7D40
	private void OnInputFromUI(TexasHoldEmController.PokerInputOption input, int value = 0) { }

	// RVA: 0x8C6F10 Offset: 0x8C6310 VA: 0x1808C6F10
	public int GetCostOfInput(TexasHoldEmController.PokerInputOption option, CardPlayerData data) { }

	// RVA: 0x8C76C0 Offset: 0x8C6AC0 VA: 0x1808C76C0
	public bool IsAPrimaryWinner(ulong playerId) { }

	// RVA: 0x8C7830 Offset: 0x8C6C30 VA: 0x1808C7830
	public bool IsAWinner(ulong playerId) { }

	// RVA: 0x8C7400 Offset: 0x8C6800 VA: 0x1808C7400
	public bool HasPrimaryWinners() { }

	// RVA: 0x8C7C10 Offset: 0x8C7010 VA: 0x1808C7C10
	public int NumPrimaryWinners() { }

	// RVA: 0x8C7560 Offset: 0x8C6960 VA: 0x1808C7560
	public bool HasSecondaryWinners() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8C8960 Offset: 0x8C7D60 VA: 0x1808C8960
	private void <SubGetAvailableInputs>b__46_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8C88D0 Offset: 0x8C7CD0 VA: 0x1808C88D0
	private void <SubGetAvailableInputs>b__46_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8C8900 Offset: 0x8C7D00 VA: 0x1808C8900
	private void <SubGetAvailableInputs>b__46_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8C8990 Offset: 0x8C7D90 VA: 0x1808C8990
	private void <SubGetAvailableInputs>b__46_4() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8C8A30 Offset: 0x8C7E30 VA: 0x1808C8A30
	private void <SubGetAvailableInputs>b__46_5() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8C8AD0 Offset: 0x8C7ED0 VA: 0x1808C8AD0
	private void <SubGetAvailableInputs>b__46_6() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8C8930 Offset: 0x8C7D30 VA: 0x1808C8930
	private void <SubGetAvailableInputs>b__46_2() { }

}

public enum TexasHoldEmController.PokerInputOption // TypeDefIndex: 12014
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int value__; // 0x0
	public const TexasHoldEmController.Playability OK = 0;
	public const TexasHoldEmController.Playability NoPlayer = 1;
	public const TexasHoldEmController.Playability NotEnoughBuyIn = 2;
	public const TexasHoldEmController.Playability TooMuchBuyIn = 3;
	public const TexasHoldEmController.Playability RanOutOfScrap = 4;
	public const TexasHoldEmController.Playability Idle = 5;

}

