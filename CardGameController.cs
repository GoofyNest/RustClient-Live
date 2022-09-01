public abstract class CardGameController : IDisposable // TypeDefIndex: 12032
{
	[CompilerGeneratedAttribute] 
	private CardGameController.CardGameState <State>k__BackingField; 
	public const int IDLE_KICK_SECONDS = 600;
	[CompilerGeneratedAttribute] 
	private CardTable <Owner>k__BackingField; 
	protected CardPlayerData[] playerData; 
	[CompilerGeneratedAttribute] 
	private CardTable.WinnerBreakdown <winnerInfo>k__BackingField; 
	protected CardTable.CardList localPlayerCards; 
	private CardGameSounds _sounds; 
	[CompilerGeneratedAttribute] 
	private TimeUntil <TimeUntilTurnEnds>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ClientScrapInPot>k__BackingField; 

	public CardGameController.CardGameState State { get; set; }
	public bool HasGameInProgress { get; }
	public bool HasRoundInProgress { get; }
	public abstract int MinPlayers { get; }
	public abstract int MinBuyIn { get; }
	public abstract int MaxBuyIn { get; }
	public virtual float MaxTurnTime { get; }
	public virtual int TimeBetweenRounds { get; }
	protected CardTable Owner { get; set; }
	protected int ScrapItemID { get; }
	protected bool IsServer { get; }
	protected bool IsClient { get; }
	public CardTable.WinnerBreakdown winnerInfo { get; set; }
	private CardGameSounds Sounds { get; }
	public bool GameWon { get; }
	public TimeUntil TimeUntilTurnEnds { get; set; }
	public int ClientScrapInPot { get; set; }


	[CompilerGeneratedAttribute] 
	public CardGameController.CardGameState get_State() { }

	[CompilerGeneratedAttribute] 
	private void set_State(CardGameController.CardGameState value) { }

	public bool get_HasGameInProgress() { }

	public bool get_HasRoundInProgress() { }

	public abstract int get_MinPlayers();

	public abstract int get_MinBuyIn();

	public abstract int get_MaxBuyIn();

	public virtual float get_MaxTurnTime() { }

	public virtual int get_TimeBetweenRounds() { }

	[CompilerGeneratedAttribute] 
	protected CardTable get_Owner() { }

	[CompilerGeneratedAttribute] 
	private void set_Owner(CardTable value) { }

	protected int get_ScrapItemID() { }

	protected bool get_IsServer() { }

	protected bool get_IsClient() { }

	[CompilerGeneratedAttribute] 
	public CardTable.WinnerBreakdown get_winnerInfo() { }

	[CompilerGeneratedAttribute] 
	private void set_winnerInfo(CardTable.WinnerBreakdown value) { }

	public void .ctor(CardTable owner) { }

	public void Dispose() { }

	public int NumPlayersAllowedToPlay(CardPlayerData ignore) { }

	public int RelToAbsIndex(int relIndex, bool includeFolded) { }

	public int GameToRoundIndex(int gameRelIndex) { }

	public int NumPlayersInGame() { }

	public int NumPlayersInCurrentRound() { }

	public int MaxPlayersAtTable() { }

	public bool PlayerIsInGame(BasePlayer player) { }

	public bool IsAtTable(BasePlayer player) { }

	public virtual List<PlayingCard> GetTableCards() { }

	public void StartTurnTimer(float turnTime) { }

	private bool IsAtTable(ulong userID) { }

	public int GetScrapInPot() { }

	public bool TryGetCardPlayerData(int index, out CardPlayerData cardPlayer) { }

	public bool TryGetCardPlayerData(ulong forPlayer, out CardPlayerData cardPlayer) { }

	public bool TryGetCardPlayerData(BasePlayer forPlayer, out CardPlayerData cardPlayer) { }

	public abstract bool IsAllowedToPlay(CardPlayerData cpd);

	protected void ClearWinnerInfo() { }

	private CardGameSounds get_Sounds() { }

	public bool get_GameWon() { }

	[CompilerGeneratedAttribute] 
	public TimeUntil get_TimeUntilTurnEnds() { }

	[CompilerGeneratedAttribute] 
	private void set_TimeUntilTurnEnds(TimeUntil value) { }

	[CompilerGeneratedAttribute] 
	public int get_ClientScrapInPot() { }

	[CompilerGeneratedAttribute] 
	private void set_ClientScrapInPot(int value) { }

	public virtual void Load(CardTable syncData) { }

	public void ReceiveCardsForLocalPlayer(CardTable.CardList cardList) { }

	private void CopyLocalPlayerCardData(bool clearIfNotInGame) { }

	public bool TryGetLocalCardPlayerData(out CardPlayerData cardPlayer) { }

	public bool IsLocalPlayer(CardPlayerData cardPlayer) { }

	public void GetAvailableInputs(CardPlayerData localPlayerData, List<CardTableUI.KeycodeWithAction> targetList) { }

	protected abstract void SubGetAvailableInputs(ref List<CardTableUI.KeycodeWithAction> curAvailableInputs);

	public void OnWinnersDeclared(CardTable.WinnerBreakdown wi) { }

	public void ClientPlaySound(CardGameSounds.SoundType type) { }

}

public enum CardGameController.CardGameState // TypeDefIndex: 12033
{
	public int value__; 
	public const CardGameController.CardGameState NotPlaying = 0;
	public const CardGameController.CardGameState InGameBetweenRounds = 1;
	public const CardGameController.CardGameState InGameRound = 2;

}

private sealed class CardGameController.<>c__DisplayClass44_0 // TypeDefIndex: 12034
{
	public BasePlayer player; 


	public void .ctor() { }

	internal bool <PlayerIsInGame>b__0(CardPlayerData data) { }

}

private sealed class CardGameController.<>c__DisplayClass48_0 // TypeDefIndex: 12035
{
	public ulong userID; 


	public void .ctor() { }

	internal bool <IsAtTable>b__0(CardPlayerData data) { }

}

