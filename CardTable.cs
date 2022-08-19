public class CardTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6407
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<CardTable.CardPlayer> players; // 0x18
	public int pot; // 0x20
	public CardTable.TexasHoldEm texasHoldEm; // 0x28
	public int lastActionId; // 0x30
	public ulong lastActionTarget; // 0x38
	public int lastActionValue; // 0x40
	public uint potRef; // 0x44

	// Methods

	// RVA: 0x1F75BD0 Offset: 0x1F74FD0 VA: 0x181F75BD0
	public static void ResetToPool(CardTable instance) { }

	// RVA: 0x1F75E20 Offset: 0x1F75220 VA: 0x181F75E20
	public void ResetToPool() { }

	// RVA: 0x1F75790 Offset: 0x1F74B90 VA: 0x181F75790 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F73A00 Offset: 0x1F72E00 VA: 0x181F73A00
	public void CopyTo(CardTable instance) { }

	// RVA: 0x1F73D90 Offset: 0x1F73190 VA: 0x181F73D90
	public CardTable Copy() { }

	// RVA: 0x1F74B70 Offset: 0x1F73F70 VA: 0x181F74B70
	public static CardTable Deserialize(Stream stream) { }

	// RVA: 0x1F73E10 Offset: 0x1F73210 VA: 0x181F73E10
	public static CardTable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F74300 Offset: 0x1F73700 VA: 0x181F74300
	public static CardTable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F75370 Offset: 0x1F74770 VA: 0x181F75370
	public static CardTable Deserialize(byte[] buffer) { }

	// RVA: 0x1F75810 Offset: 0x1F74C10 VA: 0x181F75810
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F76A90 Offset: 0x1F75E90 VA: 0x181F76A90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F76AB0 Offset: 0x1F75EB0 VA: 0x181F76AB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable previous) { }

	// RVA: 0x1F75BB0 Offset: 0x1F74FB0 VA: 0x181F75BB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F74F00 Offset: 0x1F74300 VA: 0x181F74F00
	public static CardTable Deserialize(byte[] buffer, CardTable instance, bool isDelta = False) { }

	// RVA: 0x1F747D0 Offset: 0x1F73BD0 VA: 0x181F747D0
	public static CardTable Deserialize(Stream stream, CardTable instance, bool isDelta) { }

	// RVA: 0x1F73E90 Offset: 0x1F73290 VA: 0x181F73E90
	public static CardTable DeserializeLengthDelimited(Stream stream, CardTable instance, bool isDelta) { }

	// RVA: 0x1F74390 Offset: 0x1F73790 VA: 0x181F74390
	public static CardTable DeserializeLength(Stream stream, int length, CardTable instance, bool isDelta) { }

	// RVA: 0x1F76070 Offset: 0x1F75470 VA: 0x181F76070
	public static void SerializeDelta(Stream stream, CardTable instance, CardTable previous) { }

	// RVA: 0x1F766C0 Offset: 0x1F75AC0 VA: 0x181F766C0
	public static void Serialize(Stream stream, CardTable instance) { }

	// RVA: 0x1F76A80 Offset: 0x1F75E80 VA: 0x181F76A80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F76A90 Offset: 0x1F75E90 VA: 0x181F76A90
	public void ToProto(Stream stream) { }

	// RVA: 0x1F765B0 Offset: 0x1F759B0 VA: 0x181F765B0
	public static byte[] SerializeToBytes(CardTable instance) { }

	// RVA: 0x1F76500 Offset: 0x1F75900 VA: 0x181F76500
	public static void SerializeLengthDelimited(Stream stream, CardTable instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class CardTable.CardPlayer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6408
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong userid; // 0x18
	public List<int> cards; // 0x20
	public int scrap; // 0x28
	public int state; // 0x2C
	public int availableInputs; // 0x30
	public int betThisRound; // 0x34
	public int betThisTurn; // 0x38
	public int trueCardCount; // 0x3C
	public bool leftRoundEarly; // 0x40
	public bool sendCardDetails; // 0x41

	// Methods

	// RVA: 0x1F72E20 Offset: 0x1F72220 VA: 0x181F72E20
	public static void ResetToPool(CardTable.CardPlayer instance) { }

	// RVA: 0x1F72F80 Offset: 0x1F72380 VA: 0x181F72F80
	public void ResetToPool() { }

	// RVA: 0x1F72D60 Offset: 0x1F72160 VA: 0x181F72D60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F71900 Offset: 0x1F70D00 VA: 0x181F71900
	public void CopyTo(CardTable.CardPlayer instance) { }

	// RVA: 0x1F71A60 Offset: 0x1F70E60 VA: 0x181F71A60
	public CardTable.CardPlayer Copy() { }

	// RVA: 0x1F728D0 Offset: 0x1F71CD0 VA: 0x181F728D0
	public static CardTable.CardPlayer Deserialize(Stream stream) { }

	// RVA: 0x1F71C00 Offset: 0x1F71000 VA: 0x181F71C00
	public static CardTable.CardPlayer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F72160 Offset: 0x1F71560 VA: 0x181F72160
	public static CardTable.CardPlayer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F727B0 Offset: 0x1F71BB0 VA: 0x181F727B0
	public static CardTable.CardPlayer Deserialize(byte[] buffer) { }

	// RVA: 0x1F72DE0 Offset: 0x1F721E0 VA: 0x181F72DE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F739C0 Offset: 0x1F72DC0 VA: 0x181F739C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F739E0 Offset: 0x1F72DE0 VA: 0x181F739E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.CardPlayer previous) { }

	// RVA: 0x1F72E00 Offset: 0x1F72200 VA: 0x181F72E00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F726B0 Offset: 0x1F71AB0 VA: 0x181F726B0
	public static CardTable.CardPlayer Deserialize(byte[] buffer, CardTable.CardPlayer instance, bool isDelta = False) { }

	// RVA: 0x1F72950 Offset: 0x1F71D50 VA: 0x181F72950
	public static CardTable.CardPlayer Deserialize(Stream stream, CardTable.CardPlayer instance, bool isDelta) { }

	// RVA: 0x1F71C80 Offset: 0x1F71080 VA: 0x181F71C80
	public static CardTable.CardPlayer DeserializeLengthDelimited(Stream stream, CardTable.CardPlayer instance, bool isDelta) { }

	// RVA: 0x1F721F0 Offset: 0x1F715F0 VA: 0x181F721F0
	public static CardTable.CardPlayer DeserializeLength(Stream stream, int length, CardTable.CardPlayer instance, bool isDelta) { }

	// RVA: 0x1F730E0 Offset: 0x1F724E0 VA: 0x181F730E0
	public static void SerializeDelta(Stream stream, CardTable.CardPlayer instance, CardTable.CardPlayer previous) { }

	// RVA: 0x1F736E0 Offset: 0x1F72AE0 VA: 0x181F736E0
	public static void Serialize(Stream stream, CardTable.CardPlayer instance) { }

	// RVA: 0x1F739B0 Offset: 0x1F72DB0 VA: 0x181F739B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F739C0 Offset: 0x1F72DC0 VA: 0x181F739C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F735D0 Offset: 0x1F729D0 VA: 0x181F735D0
	public static byte[] SerializeToBytes(CardTable.CardPlayer instance) { }

	// RVA: 0x1F73520 Offset: 0x1F72920 VA: 0x181F73520
	public static void SerializeLengthDelimited(Stream stream, CardTable.CardPlayer instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class CardTable.TexasHoldEm : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6409
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int dealerIndex; // 0x14
	public List<int> communityCards; // 0x18
	public int activePlayerIndex; // 0x20
	public int biggestRaiseThisTurn; // 0x24

	// Methods

	// RVA: 0x1F79980 Offset: 0x1F78D80 VA: 0x181F79980
	public static void ResetToPool(CardTable.TexasHoldEm instance) { }

	// RVA: 0x1F79880 Offset: 0x1F78C80 VA: 0x181F79880
	public void ResetToPool() { }

	// RVA: 0x1F79560 Offset: 0x1F78960 VA: 0x181F79560 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F78070 Offset: 0x1F77470 VA: 0x181F78070
	public void CopyTo(CardTable.TexasHoldEm instance) { }

	// RVA: 0x1F781A0 Offset: 0x1F775A0 VA: 0x181F781A0
	public CardTable.TexasHoldEm Copy() { }

	// RVA: 0x1F789B0 Offset: 0x1F77DB0 VA: 0x181F789B0
	public static CardTable.TexasHoldEm Deserialize(Stream stream) { }

	// RVA: 0x1F78570 Offset: 0x1F77970 VA: 0x181F78570
	public static CardTable.TexasHoldEm DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F785F0 Offset: 0x1F779F0 VA: 0x181F785F0
	public static CardTable.TexasHoldEm DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F78FA0 Offset: 0x1F783A0 VA: 0x181F78FA0
	public static CardTable.TexasHoldEm Deserialize(byte[] buffer) { }

	// RVA: 0x1F795E0 Offset: 0x1F789E0 VA: 0x181F795E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F7A0B0 Offset: 0x1F794B0 VA: 0x181F7A0B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F7A0D0 Offset: 0x1F794D0 VA: 0x181F7A0D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.TexasHoldEm previous) { }

	// RVA: 0x1F79860 Offset: 0x1F78C60 VA: 0x181F79860 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F78C50 Offset: 0x1F78050 VA: 0x181F78C50
	public static CardTable.TexasHoldEm Deserialize(byte[] buffer, CardTable.TexasHoldEm instance, bool isDelta = False) { }

	// RVA: 0x1F792E0 Offset: 0x1F786E0 VA: 0x181F792E0
	public static CardTable.TexasHoldEm Deserialize(Stream stream, CardTable.TexasHoldEm instance, bool isDelta) { }

	// RVA: 0x1F78220 Offset: 0x1F77620 VA: 0x181F78220
	public static CardTable.TexasHoldEm DeserializeLengthDelimited(Stream stream, CardTable.TexasHoldEm instance, bool isDelta) { }

	// RVA: 0x1F78680 Offset: 0x1F77A80 VA: 0x181F78680
	public static CardTable.TexasHoldEm DeserializeLength(Stream stream, int length, CardTable.TexasHoldEm instance, bool isDelta) { }

	// RVA: 0x1F79A80 Offset: 0x1F78E80 VA: 0x181F79A80
	public static void SerializeDelta(Stream stream, CardTable.TexasHoldEm instance, CardTable.TexasHoldEm previous) { }

	// RVA: 0x1F79EB0 Offset: 0x1F792B0 VA: 0x181F79EB0
	public static void Serialize(Stream stream, CardTable.TexasHoldEm instance) { }

	// RVA: 0x1F7A0A0 Offset: 0x1F794A0 VA: 0x181F7A0A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F7A0B0 Offset: 0x1F794B0 VA: 0x181F7A0B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F79DA0 Offset: 0x1F791A0 VA: 0x181F79DA0
	public static byte[] SerializeToBytes(CardTable.TexasHoldEm instance) { }

	// RVA: 0x1F79CF0 Offset: 0x1F790F0 VA: 0x181F79CF0
	public static void SerializeLengthDelimited(Stream stream, CardTable.TexasHoldEm instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class CardTable.WinnerBreakdown : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6410
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<CardTable.WinnerBreakdown.Winner> winners; // 0x18
	public int winningScore; // 0x20

	// Methods

	// RVA: 0x1F7B210 Offset: 0x1F7A610 VA: 0x181F7B210
	public static void ResetToPool(CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1F7B3F0 Offset: 0x1F7A7F0 VA: 0x181F7B3F0
	public void ResetToPool() { }

	// RVA: 0x1F7B150 Offset: 0x1F7A550 VA: 0x181F7B150 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F7A0F0 Offset: 0x1F794F0 VA: 0x181F7A0F0
	public void CopyTo(CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1F7A220 Offset: 0x1F79620 VA: 0x181F7A220
	public CardTable.WinnerBreakdown Copy() { }

	// RVA: 0x1F7ABB0 Offset: 0x1F79FB0 VA: 0x181F7ABB0
	public static CardTable.WinnerBreakdown Deserialize(Stream stream) { }

	// RVA: 0x1F7A3A0 Offset: 0x1F797A0 VA: 0x181F7A3A0
	public static CardTable.WinnerBreakdown DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F7A6C0 Offset: 0x1F79AC0 VA: 0x181F7A6C0
	public static CardTable.WinnerBreakdown DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F7ADB0 Offset: 0x1F7A1B0 VA: 0x181F7ADB0
	public static CardTable.WinnerBreakdown Deserialize(byte[] buffer) { }

	// RVA: 0x1F7B1D0 Offset: 0x1F7A5D0 VA: 0x181F7B1D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F7BC20 Offset: 0x1F7B020 VA: 0x181F7BC20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F7BC40 Offset: 0x1F7B040 VA: 0x181F7BC40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.WinnerBreakdown previous) { }

	// RVA: 0x1F7B1F0 Offset: 0x1F7A5F0 VA: 0x181F7B1F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F7B050 Offset: 0x1F7A450 VA: 0x181F7B050
	public static CardTable.WinnerBreakdown Deserialize(byte[] buffer, CardTable.WinnerBreakdown instance, bool isDelta = False) { }

	// RVA: 0x1F7A9E0 Offset: 0x1F79DE0 VA: 0x181F7A9E0
	public static CardTable.WinnerBreakdown Deserialize(Stream stream, CardTable.WinnerBreakdown instance, bool isDelta) { }

	// RVA: 0x1F7A420 Offset: 0x1F79820 VA: 0x181F7A420
	public static CardTable.WinnerBreakdown DeserializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown instance, bool isDelta) { }

	// RVA: 0x1F7A750 Offset: 0x1F79B50 VA: 0x181F7A750
	public static CardTable.WinnerBreakdown DeserializeLength(Stream stream, int length, CardTable.WinnerBreakdown instance, bool isDelta) { }

	// RVA: 0x1F7B5D0 Offset: 0x1F7A9D0 VA: 0x181F7B5D0
	public static void SerializeDelta(Stream stream, CardTable.WinnerBreakdown instance, CardTable.WinnerBreakdown previous) { }

	// RVA: 0x1F7B9E0 Offset: 0x1F7ADE0 VA: 0x181F7B9E0
	public static void Serialize(Stream stream, CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1F7BC10 Offset: 0x1F7B010 VA: 0x181F7BC10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F7BC20 Offset: 0x1F7B020 VA: 0x181F7BC20
	public void ToProto(Stream stream) { }

	// RVA: 0x1F7B8D0 Offset: 0x1F7ACD0 VA: 0x181F7B8D0
	public static byte[] SerializeToBytes(CardTable.WinnerBreakdown instance) { }

	// RVA: 0x1F7B820 Offset: 0x1F7AC20 VA: 0x181F7B820
	public static void SerializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class CardTable.WinnerBreakdown.Winner : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6411
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong ID; // 0x18
	public int winnings; // 0x20
	public bool primaryWinner; // 0x24

	// Methods

	// RVA: 0x20BAAD0 Offset: 0x20B9ED0 VA: 0x1820BAAD0
	public static void ResetToPool(CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x20BAA40 Offset: 0x20B9E40 VA: 0x1820BAA40
	public void ResetToPool() { }

	// RVA: 0x20BA760 Offset: 0x20B9B60 VA: 0x1820BA760 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20B97E0 Offset: 0x20B8BE0 VA: 0x1820B97E0
	public void CopyTo(CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x20B9810 Offset: 0x20B8C10 VA: 0x1820B9810
	public CardTable.WinnerBreakdown.Winner Copy() { }

	// RVA: 0x20BA3C0 Offset: 0x20B97C0 VA: 0x1820BA3C0
	public static CardTable.WinnerBreakdown.Winner Deserialize(Stream stream) { }

	// RVA: 0x20B9B10 Offset: 0x20B8F10 VA: 0x1820B9B10
	public static CardTable.WinnerBreakdown.Winner DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B9DF0 Offset: 0x20B91F0 VA: 0x1820B9DF0
	public static CardTable.WinnerBreakdown.Winner DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B9E80 Offset: 0x20B9280 VA: 0x1820B9E80
	public static CardTable.WinnerBreakdown.Winner Deserialize(byte[] buffer) { }

	// RVA: 0x20BA870 Offset: 0x20B9C70 VA: 0x1820BA870
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20BB010 Offset: 0x20BA410 VA: 0x1820BB010 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20BB030 Offset: 0x20BA430 VA: 0x1820BB030 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.WinnerBreakdown.Winner previous) { }

	// RVA: 0x20BAA20 Offset: 0x20B9E20 VA: 0x1820BAA20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20BA130 Offset: 0x20B9530 VA: 0x1820BA130
	public static CardTable.WinnerBreakdown.Winner Deserialize(byte[] buffer, CardTable.WinnerBreakdown.Winner instance, bool isDelta = False) { }

	// RVA: 0x20BA5B0 Offset: 0x20B99B0 VA: 0x1820BA5B0
	public static CardTable.WinnerBreakdown.Winner Deserialize(Stream stream, CardTable.WinnerBreakdown.Winner instance, bool isDelta) { }

	// RVA: 0x20B9890 Offset: 0x20B8C90 VA: 0x1820B9890
	public static CardTable.WinnerBreakdown.Winner DeserializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown.Winner instance, bool isDelta) { }

	// RVA: 0x20B9B90 Offset: 0x20B8F90 VA: 0x1820B9B90
	public static CardTable.WinnerBreakdown.Winner DeserializeLength(Stream stream, int length, CardTable.WinnerBreakdown.Winner instance, bool isDelta) { }

	// RVA: 0x20BAB60 Offset: 0x20B9F60 VA: 0x1820BAB60
	public static void SerializeDelta(Stream stream, CardTable.WinnerBreakdown.Winner instance, CardTable.WinnerBreakdown.Winner previous) { }

	// RVA: 0x20BAEE0 Offset: 0x20BA2E0 VA: 0x1820BAEE0
	public static void Serialize(Stream stream, CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x20BB000 Offset: 0x20BA400 VA: 0x1820BB000
	public byte[] ToProtoBytes() { }

	// RVA: 0x20BB010 Offset: 0x20BA410 VA: 0x1820BB010
	public void ToProto(Stream stream) { }

	// RVA: 0x20BADD0 Offset: 0x20BA1D0 VA: 0x1820BADD0
	public static byte[] SerializeToBytes(CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x20BAD20 Offset: 0x20BA120 VA: 0x1820BAD20
	public static void SerializeLengthDelimited(Stream stream, CardTable.WinnerBreakdown.Winner instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class CardTable.CardList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6412
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> cards; // 0x18

	// Methods

	// RVA: 0x1F71230 Offset: 0x1F70630 VA: 0x181F71230
	public static void ResetToPool(CardTable.CardList instance) { }

	// RVA: 0x1F71150 Offset: 0x1F70550 VA: 0x181F71150
	public void ResetToPool() { }

	// RVA: 0x1F70FC0 Offset: 0x1F703C0 VA: 0x181F70FC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F702D0 Offset: 0x1F6F6D0 VA: 0x181F702D0
	public void CopyTo(CardTable.CardList instance) { }

	// RVA: 0x1F703F0 Offset: 0x1F6F7F0 VA: 0x181F703F0
	public CardTable.CardList Copy() { }

	// RVA: 0x1F70E20 Offset: 0x1F70220 VA: 0x181F70E20
	public static CardTable.CardList Deserialize(Stream stream) { }

	// RVA: 0x1F707E0 Offset: 0x1F6FBE0 VA: 0x181F707E0
	public static CardTable.CardList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F70AD0 Offset: 0x1F6FED0 VA: 0x181F70AD0
	public static CardTable.CardList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F70EA0 Offset: 0x1F702A0 VA: 0x181F70EA0
	public static CardTable.CardList Deserialize(byte[] buffer) { }

	// RVA: 0x1F71110 Offset: 0x1F70510 VA: 0x181F71110
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F71780 Offset: 0x1F70B80 VA: 0x181F71780 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F717A0 Offset: 0x1F70BA0 VA: 0x181F717A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CardTable.CardList previous) { }

	// RVA: 0x1F71130 Offset: 0x1F70530 VA: 0x181F71130 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F70D20 Offset: 0x1F70120 VA: 0x181F70D20
	public static CardTable.CardList Deserialize(byte[] buffer, CardTable.CardList instance, bool isDelta = False) { }

	// RVA: 0x1F70B60 Offset: 0x1F6FF60 VA: 0x181F70B60
	public static CardTable.CardList Deserialize(Stream stream, CardTable.CardList instance, bool isDelta) { }

	// RVA: 0x1F70550 Offset: 0x1F6F950 VA: 0x181F70550
	public static CardTable.CardList DeserializeLengthDelimited(Stream stream, CardTable.CardList instance, bool isDelta) { }

	// RVA: 0x1F70860 Offset: 0x1F6FC60 VA: 0x181F70860
	public static CardTable.CardList DeserializeLength(Stream stream, int length, CardTable.CardList instance, bool isDelta) { }

	// RVA: 0x1F71310 Offset: 0x1F70710 VA: 0x181F71310
	public static void SerializeDelta(Stream stream, CardTable.CardList instance, CardTable.CardList previous) { }

	// RVA: 0x1F71620 Offset: 0x1F70A20 VA: 0x181F71620
	public static void Serialize(Stream stream, CardTable.CardList instance) { }

	// RVA: 0x1F71770 Offset: 0x1F70B70 VA: 0x181F71770
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F71780 Offset: 0x1F70B80 VA: 0x181F71780
	public void ToProto(Stream stream) { }

	// RVA: 0x1F71510 Offset: 0x1F70910 VA: 0x181F71510
	public static byte[] SerializeToBytes(CardTable.CardList instance) { }

	// RVA: 0x1F71460 Offset: 0x1F70860 VA: 0x181F71460
	public static void SerializeLengthDelimited(Stream stream, CardTable.CardList instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class CardTable : BaseVehicle // TypeDefIndex: 8367
{	// Fields
	private Option __menuOption_Menu_Open; // 0x3B8
	private Option __menuOption_Menu_Play; // 0x410
	public static CardTableUI clientUI; // 0x0
	private TimeSince showWinningsTipFor; // 0x468
	private Nullable<bool> localWasHoldingCards; // 0x46C
	private int lastVisualScrap; // 0x470
	private static Dictionary<int, Sprite> tableCardImageDict; // 0x8
	private static Sprite blankCardStatic; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <recentlyLeftPlayerName>k__BackingField; // 0x478
	[HeaderAttribute] // RVA: 0x80F00 Offset: 0x80300 VA: 0x180080F00
	[SerializeField] // RVA: 0x80F00 Offset: 0x80300 VA: 0x180080F00
	private GameObjectRef uiPrefab; // 0x480
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef playerStoragePrefab; // 0x488
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef potPrefab; // 0x490
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ViewModel viewModel; // 0x498
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CardTableUI.PlayingCardImage[] tableCards; // 0x4A0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Renderer[] tableCardBackings; // 0x4A8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Canvas cardUICanvas; // 0x4B0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Image[] tableCardImages; // 0x4B8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Sprite blankCard; // 0x4C0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform chipStacksParent; // 0x4C8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CardTable.ChipStack[] chipStacks; // 0x4D0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CardTable.ChipStack[] fillerStacks; // 0x4D8
	public ItemDefinition scrapItemDef; // 0x4E0
	public CardTable.PlayerStorageInfo[] playerStoragePoints; // 0x4E8
	public CardTable.CardGameOption gameOption; // 0x4F0
	private CardGameController _gameCont; // 0x4F8
	private const float MAX_STORAGE_INTERACTION_DIST = 1;

	// Properties
	public override bool HasMenuOptions { get; }
	public static bool LocalPlayerInCardsUI { get; }
	public bool ShowTakeWinningsTip { get; }
	public string recentlyLeftPlayerName { get; set; }
	public int ScrapItemID { get; }
	public CardGameController GameController { get; }

	// Methods

	// RVA: 0x71B830 Offset: 0x71AC30 VA: 0x18071B830 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x71E410 Offset: 0x71D810 VA: 0x18071E410 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x71C440 Offset: 0x71B840 VA: 0x18071C440 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x71E560 Offset: 0x71D960 VA: 0x18071E560
	public static bool get_LocalPlayerInCardsUI() { }

	// RVA: 0x71E610 Offset: 0x71DA10 VA: 0x18071E610
	public bool get_ShowTakeWinningsTip() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x71E640 Offset: 0x71DA40 VA: 0x18071E640
	public string get_recentlyLeftPlayerName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x71E650 Offset: 0x71DA50 VA: 0x18071E650
	private void set_recentlyLeftPlayerName(string value) { }

	// RVA: 0x71B070 Offset: 0x71A470 VA: 0x18071B070 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x71D940 Offset: 0x71CD40 VA: 0x18071D940
	public void RefreshLocalPlayer(CardPlayerData localPlayerData) { }

	// RVA: 0x71E270 Offset: 0x71D670 VA: 0x18071E270
	public void UIClosed() { }

	// RVA: 0x71BD90 Offset: 0x71B190 VA: 0x18071BD90
	public CardTableUI.UIState GetUIGameState(CardPlayerData localPlayerData) { }

	// RVA: 0x71B6A0 Offset: 0x71AAA0 VA: 0x18071B6A0
	public void GetAvailableInputs(CardPlayerData localPlayerData, List<CardTableUI.KeycodeWithAction> targetList) { }

	[BaseEntity.Menu] // RVA: 0xD0D80 Offset: 0xD0180 VA: 0x1800D0D80
	[BaseEntity.Menu.Description] // RVA: 0xD0D80 Offset: 0xD0180 VA: 0x1800D0D80
	[BaseEntity.Menu.Icon] // RVA: 0xD0D80 Offset: 0xD0180 VA: 0x1800D0D80
	[BaseEntity.Menu.ShowIf] // RVA: 0xD0D80 Offset: 0xD0180 VA: 0x1800D0D80
	// RVA: 0x71C400 Offset: 0x71B800 VA: 0x18071C400
	public void Menu_Play(BasePlayer player) { }

	// RVA: 0x71C350 Offset: 0x71B750 VA: 0x18071C350
	public bool Menu_Play_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	[BaseEntity.Menu.Description] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	[BaseEntity.Menu.Icon] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	[BaseEntity.Menu.ShowIf] // RVA: 0x8DF10 Offset: 0x8D310 VA: 0x18008DF10
	// RVA: 0x71C310 Offset: 0x71B710 VA: 0x18071C310
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x71C170 Offset: 0x71B570 VA: 0x18071C170
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0x71D770 Offset: 0x71CB70 VA: 0x18071D770
	public void PlayerClosedUI(BasePlayer player) { }

	// RVA: 0x71B540 Offset: 0x71A940 VA: 0x18071B540
	private void DelayedViewModelDeploy(float timeDelay) { }

	// RVA: 0x71B5E0 Offset: 0x71A9E0 VA: 0x18071B5E0
	private void DeployViewModel() { }

	// RVA: 0x71BFC0 Offset: 0x71B3C0 VA: 0x18071BFC0
	private void HolsterViewmodel() { }

	// RVA: 0x71DD00 Offset: 0x71D100 VA: 0x18071DD00
	public bool RefreshPlayerCards() { }

	// RVA: 0x71DE50 Offset: 0x71D250 VA: 0x18071DE50
	private void RefreshTableVisuals(List<PlayingCard> cards, int scrap) { }

	// RVA: 0x71B740 Offset: 0x71AB40 VA: 0x18071B740
	private static Sprite GetImage(int cardIndex) { }

	// RVA: 0x71E130 Offset: 0x71D530 VA: 0x18071E130
	private void ShowStack(CardTable.ChipStack stack, ref int remainingScrap) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x71D670 Offset: 0x71CA70 VA: 0x18071D670
	private void OnWinnersDeclared(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x71D7B0 Offset: 0x71CBB0 VA: 0x18071D7B0
	private void ReceiveCardsForPlayer(BaseEntity.RPCMessage msg) { }

	// RVA: 0x71B2C0 Offset: 0x71A6C0 VA: 0x18071B2C0
	public void ClientInput(int inputType, int inputValue = 0) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x71B480 Offset: 0x71A880 VA: 0x18071B480
	private void ClientPlaySound(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x71B4E0 Offset: 0x71A8E0 VA: 0x18071B4E0
	private void ClientStartTurnTimer(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x71B330 Offset: 0x71A730 VA: 0x18071B330
	private void ClientOnPlayerLeft(BaseEntity.RPCMessage msg) { }

	// RVA: 0x71B020 Offset: 0x71A420 VA: 0x18071B020
	private void ClearRecentlyLeftPlayer() { }

	// RVA: 0x71E5F0 Offset: 0x71D9F0 VA: 0x18071E5F0
	public int get_ScrapItemID() { }

	// RVA: 0x71E370 Offset: 0x71D770 VA: 0x18071E370
	public CardGameController get_GameController() { }

	// RVA: 0x71B660 Offset: 0x71AA60 VA: 0x18071B660 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x71B6E0 Offset: 0x71AAE0 VA: 0x18071B6E0
	private CardGameController GetGameController() { }

	// RVA: 0x71C0A0 Offset: 0x71B4A0 VA: 0x18071C0A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x71E360 Offset: 0x71D760 VA: 0x18071E360
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public class CardTable.ChipStack : IComparable<CardTable.ChipStack> // TypeDefIndex: 8368
{	// Fields
	public int chipValue; // 0x10
	public GameObject[] chips; // 0x18

	// Methods

	// RVA: 0x71E660 Offset: 0x71DA60 VA: 0x18071E660 Slot: 4
	public int CompareTo(CardTable.ChipStack other) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public enum CardTable.CardGameOption // TypeDefIndex: 8369
{	// Fields
	public int value__; // 0x0
	public const CardTable.CardGameOption TexasHoldEm = 0;

}

public class CardTable.PlayerStorageInfo // TypeDefIndex: 8370
{	// Fields
	public Transform storagePos; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

