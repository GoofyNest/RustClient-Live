public abstract class CardGameController : IDisposable // TypeDefIndex: 12004
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CardGameController.CardGameState <State>k__BackingField; // 0x10
	public const int IDLE_KICK_SECONDS = 600;
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CardTable <Owner>k__BackingField; // 0x18
	protected CardPlayerData[] playerData; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CardTable.WinnerBreakdown <winnerInfo>k__BackingField; // 0x28
	protected CardTable.CardList localPlayerCards; // 0x30
	private CardGameSounds _sounds; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TimeUntil <TimeUntilTurnEnds>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ClientScrapInPot>k__BackingField; // 0x44

	// Properties
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

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public CardGameController.CardGameState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596240 Offset: 0x595640 VA: 0x180596240
	private void set_State(CardGameController.CardGameState value) { }

	// RVA: 0x8B0CA0 Offset: 0x8B00A0 VA: 0x1808B0CA0
	public bool get_HasGameInProgress() { }

	// RVA: 0x8B0CB0 Offset: 0x8B00B0 VA: 0x1808B0CB0
	public bool get_HasRoundInProgress() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_MinPlayers();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_MinBuyIn();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_MaxBuyIn();

	// RVA: 0x8B0CC0 Offset: 0x8B00C0 VA: 0x1808B0CC0 Slot: 8
	public virtual float get_MaxTurnTime() { }

	// RVA: 0x8B0DD0 Offset: 0x8B01D0 VA: 0x1808B0DD0 Slot: 9
	public virtual int get_TimeBetweenRounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	protected CardTable get_Owner() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	private void set_Owner(CardTable value) { }

	// RVA: 0x8B0CD0 Offset: 0x8B00D0 VA: 0x1808B0CD0
	protected int get_ScrapItemID() { }

	// RVA: 0x7A67E0 Offset: 0x7A5BE0 VA: 0x1807A67E0
	protected bool get_IsServer() { }

	// RVA: 0x7A67C0 Offset: 0x7A5BC0 VA: 0x1807A67C0
	protected bool get_IsClient() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public CardTable.WinnerBreakdown get_winnerInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	private void set_winnerInfo(CardTable.WinnerBreakdown value) { }

	// RVA: 0x8B09A0 Offset: 0x8AFDA0 VA: 0x1808B09A0
	public void .ctor(CardTable owner) { }

	// RVA: 0x8AF690 Offset: 0x8AEA90 VA: 0x1808AF690 Slot: 4
	public void Dispose() { }

	// RVA: 0x8AFF20 Offset: 0x8AF320 VA: 0x1808AFF20
	public int NumPlayersAllowedToPlay(CardPlayerData ignore) { }

	// RVA: 0x8B0440 Offset: 0x8AF840 VA: 0x1808B0440
	public int RelToAbsIndex(int relIndex, bool includeFolded) { }

	// RVA: 0x8AF7B0 Offset: 0x8AEBB0 VA: 0x1808AF7B0
	public int GameToRoundIndex(int gameRelIndex) { }

	// RVA: 0x8B0030 Offset: 0x8AF430 VA: 0x1808B0030
	public int NumPlayersInGame() { }

	// RVA: 0x8AFFC0 Offset: 0x8AF3C0 VA: 0x1808AFFC0
	public int NumPlayersInCurrentRound() { }

	// RVA: 0x8AFED0 Offset: 0x8AF2D0 VA: 0x1808AFED0
	public int MaxPlayersAtTable() { }

	// RVA: 0x8B0300 Offset: 0x8AF700 VA: 0x1808B0300
	public bool PlayerIsInGame(BasePlayer player) { }

	// RVA: 0x8AF9E0 Offset: 0x8AEDE0 VA: 0x1808AF9E0
	public bool IsAtTable(BasePlayer player) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 10
	public virtual List<PlayingCard> GetTableCards() { }

	// RVA: 0x8B0620 Offset: 0x8AFA20 VA: 0x1808B0620
	public void StartTurnTimer(float turnTime) { }

	// RVA: 0x8AFAA0 Offset: 0x8AEEA0 VA: 0x1808AFAA0
	private bool IsAtTable(ulong userID) { }

	// RVA: 0x8AF9A0 Offset: 0x8AEDA0 VA: 0x1808AF9A0
	public int GetScrapInPot() { }

	// RVA: 0x8B06F0 Offset: 0x8AFAF0 VA: 0x1808B06F0
	public bool TryGetCardPlayerData(int index, out CardPlayerData cardPlayer) { }

	// RVA: 0x8B0670 Offset: 0x8AFA70 VA: 0x1808B0670
	public bool TryGetCardPlayerData(ulong forPlayer, out CardPlayerData cardPlayer) { }

	// RVA: 0x8B0750 Offset: 0x8AFB50 VA: 0x1808B0750
	public bool TryGetCardPlayerData(BasePlayer forPlayer, out CardPlayerData cardPlayer) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool IsAllowedToPlay(CardPlayerData cpd);

	// RVA: 0x8AF1F0 Offset: 0x8AE5F0 VA: 0x1808AF1F0
	protected void ClearWinnerInfo() { }

	// RVA: 0x8B0CF0 Offset: 0x8B00F0 VA: 0x1808B0CF0
	private CardGameSounds get_Sounds() { }

	// RVA: 0x8B0C50 Offset: 0x8B0050 VA: 0x1808B0C50
	public bool get_GameWon() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5F7C80 Offset: 0x5F7080 VA: 0x1805F7C80
	public TimeUntil get_TimeUntilTurnEnds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x6B9860 Offset: 0x6B8C60 VA: 0x1806B9860
	private void set_TimeUntilTurnEnds(TimeUntil value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5F7C90 Offset: 0x5F7090 VA: 0x1805F7C90
	public int get_ClientScrapInPot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B0DE0 Offset: 0x8B01E0 VA: 0x1808B0DE0
	private void set_ClientScrapInPot(int value) { }

	// RVA: 0x8AFCA0 Offset: 0x8AF0A0 VA: 0x1808AFCA0 Slot: 12
	public virtual void Load(CardTable syncData) { }

	// RVA: 0x8B03B0 Offset: 0x8AF7B0 VA: 0x1808B03B0
	public void ReceiveCardsForLocalPlayer(CardTable.CardList cardList) { }

	// RVA: 0x8AF460 Offset: 0x8AE860 VA: 0x1808AF460
	private void CopyLocalPlayerCardData(bool clearIfNotInGame) { }

	// RVA: 0x8B07E0 Offset: 0x8AFBE0 VA: 0x1808B07E0
	public bool TryGetLocalCardPlayerData(out CardPlayerData cardPlayer) { }

	// RVA: 0x8AFB50 Offset: 0x8AEF50 VA: 0x1808AFB50
	public bool IsLocalPlayer(CardPlayerData cardPlayer) { }

	// RVA: 0x8AF970 Offset: 0x8AED70 VA: 0x1808AF970
	public void GetAvailableInputs(CardPlayerData localPlayerData, List<CardTableUI.KeycodeWithAction> targetList) { }

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void SubGetAvailableInputs(ref List<CardTableUI.KeycodeWithAction> curAvailableInputs);

	// RVA: 0x8B00A0 Offset: 0x8AF4A0 VA: 0x1808B00A0
	public void OnWinnersDeclared(CardTable.WinnerBreakdown wi) { }

	// RVA: 0x8AF350 Offset: 0x8AE750 VA: 0x1808AF350
	public void ClientPlaySound(CardGameSounds.SoundType type) { }

}

public enum CardGameController.CardGameState // TypeDefIndex: 12005
{	// Fields
	public int value__; // 0x0
	public const CardGameController.CardGameState NotPlaying = 0;
	public const CardGameController.CardGameState InGameBetweenRounds = 1;
	public const CardGameController.CardGameState InGameRound = 2;

}

private sealed class CardGameController.<>c__DisplayClass44_0 // TypeDefIndex: 12006
{	// Fields
	public BasePlayer player; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x8C9530 Offset: 0x8C8930 VA: 0x1808C9530
	internal bool <PlayerIsInGame>b__0(CardPlayerData data) { }

}

private sealed class CardGameController.<>c__DisplayClass48_0 // TypeDefIndex: 12007
{	// Fields
	public ulong userID; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x8C9570 Offset: 0x8C8970 VA: 0x1808C9570
	internal bool <IsAtTable>b__0(CardPlayerData data) { }

}

