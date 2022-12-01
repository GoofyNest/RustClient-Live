public class CardPlayerData : IDisposable // TypeDefIndex: 13825
{
	[CompilerGeneratedAttribute]
	private ulong <UserID>k__BackingField;
	public List<PlayingCard> Cards;
	[CompilerGeneratedAttribute]
	private CardPlayerData.CardPlayerState <State>k__BackingField;
	public readonly int mountIndex;
	private readonly bool isServer;
	public int availableInputs;
	public int betThisRound;
	public int betThisTurn;
	[CompilerGeneratedAttribute]
	private bool <LeftRoundEarly>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <SendCardDetails>k__BackingField;
	public TimeUntil ClientTimeUntilTurnEnds;
	private int clientScrap;

	public ulong UserID { get; set; }
	public CardPlayerData.CardPlayerState State { get; set; }
	public bool HasUser { get; }
	public bool HasUserInGame { get; }
	public bool HasUserInCurrentRound { get; }
	public bool HasAvailableInputs { get; }
	private bool IsClient { get; }
	public bool LeftRoundEarly { get; set; }
	public bool SendCardDetails { get; set; }


	[CompilerGeneratedAttribute]
	public ulong get_UserID() { }

	[CompilerGeneratedAttribute]
	private void set_UserID(ulong value) { }

	[CompilerGeneratedAttribute]
	public CardPlayerData.CardPlayerState get_State() { }

	[CompilerGeneratedAttribute]
	private void set_State(CardPlayerData.CardPlayerState value) { }

	public bool get_HasUser() { }

	public bool get_HasUserInGame() { }

	public bool get_HasUserInCurrentRound() { }

	public bool get_HasAvailableInputs() { }

	private bool get_IsClient() { }

	[CompilerGeneratedAttribute]
	public bool get_LeftRoundEarly() { }

	[CompilerGeneratedAttribute]
	private void set_LeftRoundEarly(bool value) { }

	[CompilerGeneratedAttribute]
	public bool get_SendCardDetails() { }

	[CompilerGeneratedAttribute]
	private void set_SendCardDetails(bool value) { }

	public void .ctor(int mountIndex, bool isServer) { }

	public virtual void Dispose() { }

	public int GetScrapAmount() { }

	public virtual int GetTotalBetThisRound() { }

	public virtual List<PlayingCard> GetMainCards() { }

	public virtual List<PlayingCard> GetSecondaryCards() { }

	public virtual void Load(CardGame msg) { }

}

public enum CardPlayerData.CardPlayerState // TypeDefIndex: 13826
{
	public int value__;
	public const CardPlayerData.CardPlayerState None = 0;
	public const CardPlayerData.CardPlayerState WantsToPlay = 1;
	public const CardPlayerData.CardPlayerState InGame = 2;
	public const CardPlayerData.CardPlayerState InCurrentRound = 3;

}

