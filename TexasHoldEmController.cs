public class TexasHoldEmController : CardGameController // TypeDefIndex: 13815
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
	[CompilerGeneratedAttribute] 
	private int <BiggestRaiseThisTurn>k__BackingField; 
	private int dealerIndex; 

	public override int MinPlayers { get; }
	public override int MinBuyIn { get; }
	public override int MaxBuyIn { get; }
	public override int MinToPlay { get; }
	public TexasHoldEmController.PokerInputOption LastAction { get; set; }
	public ulong LastActionTarget { get; set; }
	public int LastActionValue { get; set; }
	public int BiggestRaiseThisTurn { get; set; }


	public override int get_MinPlayers() { }

	public override int get_MinBuyIn() { }

	public override int get_MaxBuyIn() { }

	public override int get_MinToPlay() { }

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

	public void .ctor(BaseCardGameEntity owner) { }

	public int GetCurrentBet() { }

	public bool TryGetDealer(out CardPlayerData dealer) { }

	public bool TryGetSmallBlind(out CardPlayerData smallBlind) { }

	public bool TryGetBigBlind(out CardPlayerData bigBlind) { }

	protected override int GetFirstPlayerRelIndex(bool startOfRound) { }

	public static ushort EvaluatePokerHand(List<PlayingCard> cards) { }

	public int GetCurrentMinRaise(CardPlayerData playerData) { }

	public override List<PlayingCard> GetTableCards() { }

	public void InputsToList(int availableInputs, List<TexasHoldEmController.PokerInputOption> result) { }

	protected override CardPlayerData GetNewCardPlayerData(int mountIndex) { }

	public override void Load(CardGame syncData) { }

	protected override void SubGetAvailableInputs(ref List<CardGameUI.KeycodeWithAction> curAvailableInputs) { }

	public int GetCostOfInput(TexasHoldEmController.PokerInputOption option, CardPlayerData data) { }

	public bool IsAWinner(ulong playerId) { }

	public bool IsAPrimaryWinner(ulong playerId) { }

	public bool HasPrimaryWinners() { }

	public int NumPrimaryWinners() { }

	public bool HasSecondaryWinners() { }

	[CompilerGeneratedAttribute] 
	private void <SubGetAvailableInputs>

	[CompilerGeneratedAttribute] 
	private void <SubGetAvailableInputs>

	[CompilerGeneratedAttribute] 
	private void <SubGetAvailableInputs>

	[CompilerGeneratedAttribute] 
	private void <SubGetAvailableInputs>

	[CompilerGeneratedAttribute] 
	private void <SubGetAvailableInputs>

	[CompilerGeneratedAttribute] 
	private void <SubGetAvailableInputs>

	[CompilerGeneratedAttribute] 
	private void <SubGetAvailableInputs>

}

public enum TexasHoldEmController.PokerInputOption // TypeDefIndex: 13816
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

public enum TexasHoldEmController.PokerRoundResult // TypeDefIndex: 13817
{
	public int value__; 
	public const TexasHoldEmController.PokerRoundResult Loss = 0;
	public const TexasHoldEmController.PokerRoundResult PrimaryWinner = 1;
	public const TexasHoldEmController.PokerRoundResult SecondaryWinner = 2;

}

