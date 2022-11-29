public abstract class CardGameController : IDisposable // TypeDefIndex: 13802
{
	[CompilerGeneratedAttribute] 
	private CardGameController.CardGameState <State>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private CardPlayerData[] <PlayerData>k__BackingField; 
	public const int IDLE_KICK_SECONDS = 600;
	[CompilerGeneratedAttribute] 
	private BaseCardGameEntity <Owner>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private CardGame.RoundResults <resultInfo>k__BackingField; 
	private CardGame.CardList localPlayerCards; 
	protected int activePlayerIndex; 
	public const int STD_RAISE_INCREMENTS = 5;
	private CardGameSounds _sounds; 
	[CompilerGeneratedAttribute] 
	private int <ClientScrapInPot>k__BackingField; 

	public CardGameController.CardGameState State { get; set; }
	public bool HasGameInProgress { get; }
	public bool HasRoundInProgress { get; }
	public CardPlayerData[] PlayerData { get; set; }
	public abstract int MinPlayers { get; }
	public abstract int MinBuyIn { get; }
	public abstract int MaxBuyIn { get; }
	public abstract int MinToPlay { get; }
	public virtual float MaxTurnTime { get; }
	public virtual int TimeBetweenRounds { get; }
	protected virtual float TimeBetweenTurns { get; }
	protected BaseCardGameEntity Owner { get; set; }
	protected int ScrapItemID { get; }
	protected bool IsServer { get; }
	protected bool IsClient { get; }
	public CardGame.RoundResults resultInfo { get; set; }
	private CardGameSounds Sounds { get; }
	public bool GameWon { get; }
	public int ClientScrapInPot { get; set; }


	[CompilerGeneratedAttribute] 
	public CardGameController.CardGameState get_State() { }

	[CompilerGeneratedAttribute] 
	private void set_State(CardGameController.CardGameState value) { }

	public bool get_HasGameInProgress() { }

	public bool get_HasRoundInProgress() { }

	[CompilerGeneratedAttribute] 
	public CardPlayerData[] get_PlayerData() { }

	[CompilerGeneratedAttribute] 
	private void set_PlayerData(CardPlayerData[] value) { }

	public abstract int get_MinPlayers();

	public abstract int get_MinBuyIn();

	public abstract int get_MaxBuyIn();

	public abstract int get_MinToPlay();

	public virtual float get_MaxTurnTime() { }

	public virtual int get_TimeBetweenRounds() { }

	protected virtual float get_TimeBetweenTurns() { }

	[CompilerGeneratedAttribute] 
	protected BaseCardGameEntity get_Owner() { }

	[CompilerGeneratedAttribute] 
	private void set_Owner(BaseCardGameEntity value) { }

	protected int get_ScrapItemID() { }

	protected bool get_IsServer() { }

	protected bool get_IsClient() { }

	[CompilerGeneratedAttribute] 
	public CardGame.RoundResults get_resultInfo() { }

	[CompilerGeneratedAttribute] 
	private void set_resultInfo(CardGame.RoundResults value) { }

	public void .ctor(BaseCardGameEntity owner) { }

	[IteratorStateMachineAttribute] 
	public IEnumerable<CardPlayerData> PlayersInRound() { }

	protected abstract int GetFirstPlayerRelIndex(bool startOfRound);

	public void Dispose() { }

	public int NumPlayersAllowedToPlay(CardPlayerData ignore) { }

	public CardGameController.Playability GetPlayabilityStatus(CardPlayerData cpd) { }

	public bool TryGetActivePlayer(out CardPlayerData activePlayer) { }

	protected bool ToCardPlayerData(int relIndex, bool includeOutOfRound, out CardPlayerData result) { }

	public int RelToAbsIndex(int relIndex, bool includeFolded) { }

	public int GameToRoundIndex(int gameRelIndex) { }

	public int NumPlayersInGame() { }

	public int NumPlayersInCurrentRound() { }

	public int MaxPlayersAtTable() { }

	public bool PlayerIsInGame(BasePlayer player) { }

	public bool IsAtTable(BasePlayer player) { }

	public virtual List<PlayingCard> GetTableCards() { }

	public void StartTurnTimer(CardPlayerData pData, float turnTime) { }

	private bool IsAtTable(ulong userID) { }

	public int GetScrapInPot() { }

	public bool TryGetCardPlayerData(int index, out CardPlayerData cardPlayer) { }

	public bool TryGetCardPlayerData(ulong forPlayer, out CardPlayerData cardPlayer) { }

	public bool TryGetCardPlayerData(BasePlayer forPlayer, out CardPlayerData cardPlayer) { }

	public bool IsAllowedToPlay(CardPlayerData cpd) { }

	protected void ClearResultsInfo() { }

	protected abstract CardPlayerData GetNewCardPlayerData(int mountIndex);

	private CardGameSounds get_Sounds() { }

	public bool get_GameWon() { }

	[CompilerGeneratedAttribute] 
	public int get_ClientScrapInPot() { }

	[CompilerGeneratedAttribute] 
	private void set_ClientScrapInPot(int value) { }

	protected abstract void SubGetAvailableInputs(ref List<CardGameUI.KeycodeWithAction> curAvailableInputs);

	public virtual void Load(CardGame syncData) { }

	public void ReceiveCardsForLocalPlayer(CardGame.CardList cardList) { }

	private void CopyLocalPlayerCardData(bool clearIfNotInGame) { }

	public bool TryGetLocalCardPlayerData(out CardPlayerData cardPlayer) { }

	public bool IsLocalPlayer(CardPlayerData cardPlayer) { }

	public void GetAvailableInputs(CardPlayerData localPlayerData, List<CardGameUI.KeycodeWithAction> targetList) { }

	public void OnResultsDeclared(CardGame.RoundResults rr) { }

	public void ClientPlaySound(CardGameSounds.SoundType type) { }

	public CardGameController.Playability GetLocalPlayerPlayabilityStatus() { }

	protected void OnInputFromUI(int input, int value = 0) { }

}

public enum CardGameController.CardGameState // TypeDefIndex: 13803
{
	public int value__; 
	public const CardGameController.CardGameState NotPlaying = 0;
	public const CardGameController.CardGameState InGameBetweenRounds = 1;
	public const CardGameController.CardGameState InGameRound = 2;

}

public enum CardGameController.Playability // TypeDefIndex: 13804
{
	public int value__; 
	public const CardGameController.Playability OK = 0;
	public const CardGameController.Playability NoPlayer = 1;
	public const CardGameController.Playability NotEnoughBuyIn = 2;
	public const CardGameController.Playability TooMuchBuyIn = 3;
	public const CardGameController.Playability RanOutOfScrap = 4;
	public const CardGameController.Playability Idle = 5;

}

private sealed class CardGameController.<PlayersInRound>d__47 : IEnumerable<CardPlayerData>, IEnumerable, IEnumerator<CardPlayerData>, IEnumerator, IDisposable // TypeDefIndex: 13805
{
	private int <>1__state; 
	private CardPlayerData <>2__current; 
	private int <>l__initialThreadId; 
	public CardGameController <>4__this; 
	private CardPlayerData[] <>7__wrap1; 
	private int <>7__wrap2; 

	private CardPlayerData System.Collections.Generic.IEnumerator<Facepunch.CardGames.CardPlayerData>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private CardPlayerData System.Collections.Generic.IEnumerator<Facepunch.CardGames.CardPlayerData>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] 
	private IEnumerator<CardPlayerData> System.Collections.Generic.IEnumerable<Facepunch.CardGames.CardPlayerData>.GetEnumerator() { }

	[DebuggerHiddenAttribute] 
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

private sealed class CardGameController.<>c__DisplayClass59_0 // TypeDefIndex: 13806
{
	public BasePlayer player; 


	public void .ctor() { }

	internal bool <PlayerIsInGame>

}

private sealed class CardGameController.<>c__DisplayClass63_0 // TypeDefIndex: 13807
{
	public ulong userID; 


	public void .ctor() { }

	internal bool <IsAtTable>

}

private sealed class CardGameController.<>c // TypeDefIndex: 13808
{
	public static readonly CardGameController.<>c <>9; 
	public static Func<PlayingCard, bool> <>9__81_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <Load>

}

