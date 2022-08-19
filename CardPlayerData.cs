public class CardPlayerData : IDisposable // TypeDefIndex: 12008
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <UserID>k__BackingField; // 0x10
	public List<PlayingCard> Cards; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CardPlayerData.CardPlayerState <State>k__BackingField; // 0x20
	public readonly int mountIndex; // 0x24
	private readonly bool isServer; // 0x28
	public int availableInputs; // 0x2C
	public int betThisRound; // 0x30
	public int betThisTurn; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <LeftRoundEarly>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <SendCardDetails>k__BackingField; // 0x39
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <TrueCardCount>k__BackingField; // 0x3C
	private int clientScrap; // 0x40

	// Properties
	public ulong UserID { get; set; }
	public CardPlayerData.CardPlayerState State { get; set; }
	public bool HasUser { get; }
	public bool HasUserInGame { get; }
	public bool HasUserInCurrentRound { get; }
	public bool HasAvailableInputs { get; }
	private bool IsClient { get; }
	public bool LeftRoundEarly { get; set; }
	public bool SendCardDetails { get; set; }
	public int TrueCardCount { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public ulong get_UserID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B1160 Offset: 0x8B0560 VA: 0x1808B1160
	private void set_UserID(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public CardPlayerData.CardPlayerState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x69CC40 Offset: 0x69C040 VA: 0x18069CC40
	private void set_State(CardPlayerData.CardPlayerState value) { }

	// RVA: 0x8B1100 Offset: 0x8B0500 VA: 0x1808B1100
	public bool get_HasUser() { }

	// RVA: 0x8B10F0 Offset: 0x8B04F0 VA: 0x1808B10F0
	public bool get_HasUserInGame() { }

	// RVA: 0x8B10E0 Offset: 0x8B04E0 VA: 0x1808B10E0
	public bool get_HasUserInCurrentRound() { }

	// RVA: 0x8B10D0 Offset: 0x8B04D0 VA: 0x1808B10D0
	public bool get_HasAvailableInputs() { }

	// RVA: 0x8B1110 Offset: 0x8B0510 VA: 0x1808B1110
	private bool get_IsClient() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B1120 Offset: 0x8B0520 VA: 0x1808B1120
	public bool get_LeftRoundEarly() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x78BED0 Offset: 0x78B2D0 VA: 0x18078BED0
	private void set_LeftRoundEarly(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B1130 Offset: 0x8B0530 VA: 0x1808B1130
	public bool get_SendCardDetails() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B1140 Offset: 0x8B0540 VA: 0x1808B1140
	private void set_SendCardDetails(bool value) { }

	// RVA: 0x8B1040 Offset: 0x8B0440 VA: 0x1808B1040
	public void .ctor(int mountIndex, bool isServer) { }

	// RVA: 0x8B0DF0 Offset: 0x8B01F0 VA: 0x1808B0DF0 Slot: 4
	public void Dispose() { }

	// RVA: 0x8B0E50 Offset: 0x8B0250 VA: 0x1808B0E50
	public int GetScrapAmount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5FC790 Offset: 0x5FBB90 VA: 0x1805FC790
	public int get_TrueCardCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B1150 Offset: 0x8B0550 VA: 0x1808B1150
	private void set_TrueCardCount(int value) { }

	// RVA: 0x8B0E70 Offset: 0x8B0270 VA: 0x1808B0E70
	public void Load(CardTable.CardPlayer msg) { }

}

public enum CardPlayerData.CardPlayerState // TypeDefIndex: 12009
{	// Fields
	public int value__; // 0x0
	public const CardPlayerData.CardPlayerState None = 0;
	public const CardPlayerData.CardPlayerState WantsToPlay = 1;
	public const CardPlayerData.CardPlayerState InGame = 2;
	public const CardPlayerData.CardPlayerState InCurrentRound = 3;

}

