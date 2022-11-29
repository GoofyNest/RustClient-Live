public class BlackjackController : CardGameController // TypeDefIndex: 13797
{
	public List<PlayingCard> dealerCards; 
	public const float BLACKJACK_PAYOUT_RATIO = 1,5;
	public const float INSURANCE_PAYOUT_RATIO = 2;
	[CompilerGeneratedAttribute] 
	private BlackjackController.BlackjackInputOption <LastAction>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <LastActionTarget>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <LastActionValue>k__BackingField; 
	public BlackjackController.DealerOpinion dealerRoundOpinion; 

	public override int MinPlayers { get; }
	public override int MinBuyIn { get; }
	public override int MaxBuyIn { get; }
	public override int MinToPlay { get; }
	public override int TimeBetweenRounds { get; }
	public BlackjackController.BlackjackInputOption LastAction { get; set; }
	public ulong LastActionTarget { get; set; }
	public int LastActionValue { get; set; }
	public bool AllBetsPlaced { get; }


	public void .ctor(BaseCardGameEntity owner) { }

	public override int get_MinPlayers() { }

	public override int get_MinBuyIn() { }

	public override int get_MaxBuyIn() { }

	public override int get_MinToPlay() { }

	public override int get_TimeBetweenRounds() { }

	[CompilerGeneratedAttribute] 
	public BlackjackController.BlackjackInputOption get_LastAction() { }

	[CompilerGeneratedAttribute] 
	private void set_LastAction(BlackjackController.BlackjackInputOption value) { }

	[CompilerGeneratedAttribute] 
	public ulong get_LastActionTarget() { }

	[CompilerGeneratedAttribute] 
	private void set_LastActionTarget(ulong value) { }

	[CompilerGeneratedAttribute] 
	public int get_LastActionValue() { }

	[CompilerGeneratedAttribute] 
	private void set_LastActionValue(int value) { }

	public bool get_AllBetsPlaced() { }

	protected override int GetFirstPlayerRelIndex(bool startOfRound) { }

	public override List<PlayingCard> GetTableCards() { }

	public void InputsToList(int availableInputs, List<BlackjackController.BlackjackInputOption> result) { }

	public bool WaitingForOtherPlayers(CardPlayerData pData) { }

	public int GetCardsValue(List<PlayingCard> cards, BlackjackController.CardsValueMode mode) { }

	public int GetOptimalCardsValue(List<PlayingCard> cards) { }

	public int GetCardValue(PlayingCard card, BlackjackController.CardsValueMode mode) { }

	public bool Has21(List<PlayingCard> cards) { }

	public bool HasBlackjack(List<PlayingCard> cards) { }

	public bool HasBusted(List<PlayingCard> cards) { }

	private bool CanSplit(CardPlayerDataBlackjack pData) { }

	private bool HasAnyAces(List<PlayingCard> cards) { }

	private bool CanDoubleDown(CardPlayerDataBlackjack pData) { }

	private bool CanTakeInsurance(CardPlayerDataBlackjack pData) { }

	private bool HasSplit(CardPlayerDataBlackjack pData) { }

	protected override CardPlayerData GetNewCardPlayerData(int mountIndex) { }

	public bool TryGetCardPlayerDataBlackjack(int index, out CardPlayerDataBlackjack cpBlackjack) { }

	public int ResultsToInt(BlackjackController.BlackjackRoundResult mainResult, BlackjackController.BlackjackRoundResult splitResult, int insurancePayout) { }

	public void ResultsFromInt(int result, out BlackjackController.BlackjackRoundResult mainResult, out BlackjackController.BlackjackRoundResult splitResult, out int insurancePayout) { }

	public override void Load(CardGame syncData) { }

	protected override void SubGetAvailableInputs(ref List<CardGameUI.KeycodeWithAction> curAvailableInputs) { }

	public void GetRoundResultsFor(ulong playerId, out BlackjackController.BlackjackRoundResult mainResult, out BlackjackController.BlackjackRoundResult splitResult, out int insurancePayout) { }

	public int GetScrapWonFor(ulong playerId) { }

	private BlackjackController.DealerOpinion GetDealerResultOpinion(List<CardGame.RoundResults.Result> results, List<PlayingCard> dCrds) { }

	public void PlayDealerOpinionSound() { }

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

public enum BlackjackController.BlackjackInputOption // TypeDefIndex: 13798
{
	public int value__; 
	public const BlackjackController.BlackjackInputOption None = 0;
	public const BlackjackController.BlackjackInputOption SubmitBet = 1;
	public const BlackjackController.BlackjackInputOption Hit = 2;
	public const BlackjackController.BlackjackInputOption Stand = 4;
	public const BlackjackController.BlackjackInputOption Split = 8;
	public const BlackjackController.BlackjackInputOption DoubleDown = 16;
	public const BlackjackController.BlackjackInputOption Insurance = 32;
	public const BlackjackController.BlackjackInputOption MaxBet = 64;
	public const BlackjackController.BlackjackInputOption Abandon = 128;

}

public enum BlackjackController.BlackjackRoundResult // TypeDefIndex: 13799
{
	public int value__; 
	public const BlackjackController.BlackjackRoundResult None = 0;
	public const BlackjackController.BlackjackRoundResult Bust = 1;
	public const BlackjackController.BlackjackRoundResult Loss = 2;
	public const BlackjackController.BlackjackRoundResult Standoff = 3;
	public const BlackjackController.BlackjackRoundResult Win = 4;
	public const BlackjackController.BlackjackRoundResult BlackjackWin = 5;

}

public enum BlackjackController.CardsValueMode // TypeDefIndex: 13800
{
	public int value__; 
	public const BlackjackController.CardsValueMode Low = 0;
	public const BlackjackController.CardsValueMode High = 1;

}

public enum BlackjackController.DealerOpinion // TypeDefIndex: 13801
{
	public int value__; 
	public const BlackjackController.DealerOpinion Neutral = 0;
	public const BlackjackController.DealerOpinion Shocked = 1;
	public const BlackjackController.DealerOpinion Sad = 2;
	public const BlackjackController.DealerOpinion Cool = 3;
	public const BlackjackController.DealerOpinion Happy = 4;
	public const BlackjackController.DealerOpinion Love = 5;

}

