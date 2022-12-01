public class CardGame : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6416
{
	public bool ShouldPool;
	private bool _disposed;
	public List<CardGame.CardPlayer> players;
	public int state;
	public int activePlayerIndex;
	public int pot;
	public int lastActionId;
	public ulong lastActionTarget;
	public int lastActionValue;
	public uint potRef;
	public CardGame.TexasHoldEm texasHoldEm;
	public CardGame.Blackjack blackjack;


	public static void ResetToPool(CardGame instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(CardGame instance) { }

	public CardGame Copy() { }

	public static CardGame Deserialize(Stream stream) { }

	public static CardGame DeserializeLengthDelimited(Stream stream) { }

	public static CardGame DeserializeLength(Stream stream, int length) { }

	public static CardGame Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, CardGame previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static CardGame Deserialize(byte[] buffer, CardGame instance, bool isDelta = False) { }

	public static CardGame Deserialize(Stream stream, CardGame instance, bool isDelta) { }

	public static CardGame DeserializeLengthDelimited(Stream stream, CardGame instance, bool isDelta) { }

	public static CardGame DeserializeLength(Stream stream, int length, CardGame instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, CardGame instance, CardGame previous) { }

	public static void Serialize(Stream stream, CardGame instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(CardGame instance) { }

	public static void SerializeLengthDelimited(Stream stream, CardGame instance) { }

	public void .ctor() { }

}

public class CardGame.CardPlayer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6417
{
	public bool ShouldPool;
	private bool _disposed;
	public ulong userid;
	public List<int> cards;
	public int scrap;
	public int state;
	public int availableInputs;
	public int betThisRound;
	public int betThisTurn;
	public bool leftRoundEarly;
	public bool sendCardDetails;


	public static void ResetToPool(CardGame.CardPlayer instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(CardGame.CardPlayer instance) { }

	public CardGame.CardPlayer Copy() { }

	public static CardGame.CardPlayer Deserialize(Stream stream) { }

	public static CardGame.CardPlayer DeserializeLengthDelimited(Stream stream) { }

	public static CardGame.CardPlayer DeserializeLength(Stream stream, int length) { }

	public static CardGame.CardPlayer Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, CardGame.CardPlayer previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static CardGame.CardPlayer Deserialize(byte[] buffer, CardGame.CardPlayer instance, bool isDelta = False) { }

	public static CardGame.CardPlayer Deserialize(Stream stream, CardGame.CardPlayer instance, bool isDelta) { }

	public static CardGame.CardPlayer DeserializeLengthDelimited(Stream stream, CardGame.CardPlayer instance, bool isDelta) { }

	public static CardGame.CardPlayer DeserializeLength(Stream stream, int length, CardGame.CardPlayer instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, CardGame.CardPlayer instance, CardGame.CardPlayer previous) { }

	public static void Serialize(Stream stream, CardGame.CardPlayer instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(CardGame.CardPlayer instance) { }

	public static void SerializeLengthDelimited(Stream stream, CardGame.CardPlayer instance) { }

	public void .ctor() { }

}

public class CardGame.TexasHoldEm : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6418
{
	public bool ShouldPool;
	private bool _disposed;
	public int dealerIndex;
	public List<int> communityCards;
	public int biggestRaiseThisTurn;


	public static void ResetToPool(CardGame.TexasHoldEm instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(CardGame.TexasHoldEm instance) { }

	public CardGame.TexasHoldEm Copy() { }

	public static CardGame.TexasHoldEm Deserialize(Stream stream) { }

	public static CardGame.TexasHoldEm DeserializeLengthDelimited(Stream stream) { }

	public static CardGame.TexasHoldEm DeserializeLength(Stream stream, int length) { }

	public static CardGame.TexasHoldEm Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, CardGame.TexasHoldEm previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static CardGame.TexasHoldEm Deserialize(byte[] buffer, CardGame.TexasHoldEm instance, bool isDelta = False) { }

	public static CardGame.TexasHoldEm Deserialize(Stream stream, CardGame.TexasHoldEm instance, bool isDelta) { }

	public static CardGame.TexasHoldEm DeserializeLengthDelimited(Stream stream, CardGame.TexasHoldEm instance, bool isDelta) { }

	public static CardGame.TexasHoldEm DeserializeLength(Stream stream, int length, CardGame.TexasHoldEm instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, CardGame.TexasHoldEm instance, CardGame.TexasHoldEm previous) { }

	public static void Serialize(Stream stream, CardGame.TexasHoldEm instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(CardGame.TexasHoldEm instance) { }

	public static void SerializeLengthDelimited(Stream stream, CardGame.TexasHoldEm instance) { }

	public void .ctor() { }

}

public class CardGame.RoundResults : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6419
{
	public bool ShouldPool;
	private bool _disposed;
	public List<CardGame.RoundResults.Result> results;
	public int winningScore;


	public static void ResetToPool(CardGame.RoundResults instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(CardGame.RoundResults instance) { }

	public CardGame.RoundResults Copy() { }

	public static CardGame.RoundResults Deserialize(Stream stream) { }

	public static CardGame.RoundResults DeserializeLengthDelimited(Stream stream) { }

	public static CardGame.RoundResults DeserializeLength(Stream stream, int length) { }

	public static CardGame.RoundResults Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, CardGame.RoundResults previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static CardGame.RoundResults Deserialize(byte[] buffer, CardGame.RoundResults instance, bool isDelta = False) { }

	public static CardGame.RoundResults Deserialize(Stream stream, CardGame.RoundResults instance, bool isDelta) { }

	public static CardGame.RoundResults DeserializeLengthDelimited(Stream stream, CardGame.RoundResults instance, bool isDelta) { }

	public static CardGame.RoundResults DeserializeLength(Stream stream, int length, CardGame.RoundResults instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, CardGame.RoundResults instance, CardGame.RoundResults previous) { }

	public static void Serialize(Stream stream, CardGame.RoundResults instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(CardGame.RoundResults instance) { }

	public static void SerializeLengthDelimited(Stream stream, CardGame.RoundResults instance) { }

	public void .ctor() { }

}

public class CardGame.RoundResults.Result : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6420
{
	public bool ShouldPool;
	private bool _disposed;
	public ulong ID;
	public int winnings;
	public int resultCode;


	public static void ResetToPool(CardGame.RoundResults.Result instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(CardGame.RoundResults.Result instance) { }

	public CardGame.RoundResults.Result Copy() { }

	public static CardGame.RoundResults.Result Deserialize(Stream stream) { }

	public static CardGame.RoundResults.Result DeserializeLengthDelimited(Stream stream) { }

	public static CardGame.RoundResults.Result DeserializeLength(Stream stream, int length) { }

	public static CardGame.RoundResults.Result Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, CardGame.RoundResults.Result previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static CardGame.RoundResults.Result Deserialize(byte[] buffer, CardGame.RoundResults.Result instance, bool isDelta = False) { }

	public static CardGame.RoundResults.Result Deserialize(Stream stream, CardGame.RoundResults.Result instance, bool isDelta) { }

	public static CardGame.RoundResults.Result DeserializeLengthDelimited(Stream stream, CardGame.RoundResults.Result instance, bool isDelta) { }

	public static CardGame.RoundResults.Result DeserializeLength(Stream stream, int length, CardGame.RoundResults.Result instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, CardGame.RoundResults.Result instance, CardGame.RoundResults.Result previous) { }

	public static void Serialize(Stream stream, CardGame.RoundResults.Result instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(CardGame.RoundResults.Result instance) { }

	public static void SerializeLengthDelimited(Stream stream, CardGame.RoundResults.Result instance) { }

	public void .ctor() { }

}

public class CardGame.Blackjack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6421
{
	public bool ShouldPool;
	private bool _disposed;
	public List<int> dealerCards;
	public List<CardGame.BlackjackCardPlayer> players;


	public static void ResetToPool(CardGame.Blackjack instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(CardGame.Blackjack instance) { }

	public CardGame.Blackjack Copy() { }

	public static CardGame.Blackjack Deserialize(Stream stream) { }

	public static CardGame.Blackjack DeserializeLengthDelimited(Stream stream) { }

	public static CardGame.Blackjack DeserializeLength(Stream stream, int length) { }

	public static CardGame.Blackjack Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, CardGame.Blackjack previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static CardGame.Blackjack Deserialize(byte[] buffer, CardGame.Blackjack instance, bool isDelta = False) { }

	public static CardGame.Blackjack Deserialize(Stream stream, CardGame.Blackjack instance, bool isDelta) { }

	public static CardGame.Blackjack DeserializeLengthDelimited(Stream stream, CardGame.Blackjack instance, bool isDelta) { }

	public static CardGame.Blackjack DeserializeLength(Stream stream, int length, CardGame.Blackjack instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, CardGame.Blackjack instance, CardGame.Blackjack previous) { }

	public static void Serialize(Stream stream, CardGame.Blackjack instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(CardGame.Blackjack instance) { }

	public static void SerializeLengthDelimited(Stream stream, CardGame.Blackjack instance) { }

	public void .ctor() { }

}

public class CardGame.BlackjackCardPlayer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6422
{
	public bool ShouldPool;
	private bool _disposed;
	public List<int> splitCards;
	public int splitBetThisRound;
	public int insuranceBetThisRound;
	public bool playingSplitCards;


	public static void ResetToPool(CardGame.BlackjackCardPlayer instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(CardGame.BlackjackCardPlayer instance) { }

	public CardGame.BlackjackCardPlayer Copy() { }

	public static CardGame.BlackjackCardPlayer Deserialize(Stream stream) { }

	public static CardGame.BlackjackCardPlayer DeserializeLengthDelimited(Stream stream) { }

	public static CardGame.BlackjackCardPlayer DeserializeLength(Stream stream, int length) { }

	public static CardGame.BlackjackCardPlayer Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, CardGame.BlackjackCardPlayer previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static CardGame.BlackjackCardPlayer Deserialize(byte[] buffer, CardGame.BlackjackCardPlayer instance, bool isDelta = False) { }

	public static CardGame.BlackjackCardPlayer Deserialize(Stream stream, CardGame.BlackjackCardPlayer instance, bool isDelta) { }

	public static CardGame.BlackjackCardPlayer DeserializeLengthDelimited(Stream stream, CardGame.BlackjackCardPlayer instance, bool isDelta) { }

	public static CardGame.BlackjackCardPlayer DeserializeLength(Stream stream, int length, CardGame.BlackjackCardPlayer instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, CardGame.BlackjackCardPlayer instance, CardGame.BlackjackCardPlayer previous) { }

	public static void Serialize(Stream stream, CardGame.BlackjackCardPlayer instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(CardGame.BlackjackCardPlayer instance) { }

	public static void SerializeLengthDelimited(Stream stream, CardGame.BlackjackCardPlayer instance) { }

	public void .ctor() { }

}

public class CardGame.CardList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6423
{
	public bool ShouldPool;
	private bool _disposed;
	public List<int> cards;


	public static void ResetToPool(CardGame.CardList instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(CardGame.CardList instance) { }

	public CardGame.CardList Copy() { }

	public static CardGame.CardList Deserialize(Stream stream) { }

	public static CardGame.CardList DeserializeLengthDelimited(Stream stream) { }

	public static CardGame.CardList DeserializeLength(Stream stream, int length) { }

	public static CardGame.CardList Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, CardGame.CardList previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static CardGame.CardList Deserialize(byte[] buffer, CardGame.CardList instance, bool isDelta = False) { }

	public static CardGame.CardList Deserialize(Stream stream, CardGame.CardList instance, bool isDelta) { }

	public static CardGame.CardList DeserializeLengthDelimited(Stream stream, CardGame.CardList instance, bool isDelta) { }

	public static CardGame.CardList DeserializeLength(Stream stream, int length, CardGame.CardList instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, CardGame.CardList instance, CardGame.CardList previous) { }

	public static void Serialize(Stream stream, CardGame.CardList instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(CardGame.CardList instance) { }

	public static void SerializeLengthDelimited(Stream stream, CardGame.CardList instance) { }

	public void .ctor() { }

}

