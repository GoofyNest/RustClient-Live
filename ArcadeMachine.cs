public class ArcadeMachine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6364
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ArcadeMachine.ScoreEntry> scores; // 0x18
	public int genericInt1; // 0x20
	public int genericInt2; // 0x24
	public int genericInt3; // 0x28
	public int genericInt4; // 0x2C
	public float genericFloat1; // 0x30
	public float genericFloat2; // 0x34
	public float genericFloat3; // 0x38
	public float genericFloat4; // 0x3C

	// Methods

	// RVA: 0x1FEDD50 Offset: 0x1FED150 VA: 0x181FEDD50
	public static void ResetToPool(ArcadeMachine instance) { }

	// RVA: 0x1FEDB10 Offset: 0x1FECF10 VA: 0x181FEDB10
	public void ResetToPool() { }

	// RVA: 0x1FEDA50 Offset: 0x1FECE50 VA: 0x181FEDA50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FEC670 Offset: 0x1FEBA70 VA: 0x181FEC670
	public void CopyTo(ArcadeMachine instance) { }

	// RVA: 0x1FEC860 Offset: 0x1FEBC60 VA: 0x181FEC860
	public ArcadeMachine Copy() { }

	// RVA: 0x1FED5C0 Offset: 0x1FEC9C0 VA: 0x181FED5C0
	public static ArcadeMachine Deserialize(Stream stream) { }

	// RVA: 0x1FECDD0 Offset: 0x1FEC1D0 VA: 0x181FECDD0
	public static ArcadeMachine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FECE50 Offset: 0x1FEC250 VA: 0x181FECE50
	public static ArcadeMachine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FED4A0 Offset: 0x1FEC8A0 VA: 0x181FED4A0
	public static ArcadeMachine Deserialize(byte[] buffer) { }

	// RVA: 0x1FEDAD0 Offset: 0x1FECED0 VA: 0x181FEDAD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FEE960 Offset: 0x1FEDD60 VA: 0x181FEE960 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FEE980 Offset: 0x1FEDD80 VA: 0x181FEE980 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ArcadeMachine previous) { }

	// RVA: 0x1FEDAF0 Offset: 0x1FECEF0 VA: 0x181FEDAF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FED3A0 Offset: 0x1FEC7A0 VA: 0x181FED3A0
	public static ArcadeMachine Deserialize(byte[] buffer, ArcadeMachine instance, bool isDelta = False) { }

	// RVA: 0x1FED640 Offset: 0x1FECA40 VA: 0x181FED640
	public static ArcadeMachine Deserialize(Stream stream, ArcadeMachine instance, bool isDelta) { }

	// RVA: 0x1FEC8E0 Offset: 0x1FEBCE0 VA: 0x181FEC8E0
	public static ArcadeMachine DeserializeLengthDelimited(Stream stream, ArcadeMachine instance, bool isDelta) { }

	// RVA: 0x1FECEE0 Offset: 0x1FEC2E0 VA: 0x181FECEE0
	public static ArcadeMachine DeserializeLength(Stream stream, int length, ArcadeMachine instance, bool isDelta) { }

	// RVA: 0x1FEDF90 Offset: 0x1FED390 VA: 0x181FEDF90
	public static void SerializeDelta(Stream stream, ArcadeMachine instance, ArcadeMachine previous) { }

	// RVA: 0x1FEE620 Offset: 0x1FEDA20 VA: 0x181FEE620
	public static void Serialize(Stream stream, ArcadeMachine instance) { }

	// RVA: 0x1FEE950 Offset: 0x1FEDD50 VA: 0x181FEE950
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FEE960 Offset: 0x1FEDD60 VA: 0x181FEE960
	public void ToProto(Stream stream) { }

	// RVA: 0x1FEE510 Offset: 0x1FED910 VA: 0x181FEE510
	public static byte[] SerializeToBytes(ArcadeMachine instance) { }

	// RVA: 0x1FEE460 Offset: 0x1FED860 VA: 0x181FEE460
	public static void SerializeLengthDelimited(Stream stream, ArcadeMachine instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class ArcadeMachine.ScoreEntry : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6365
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong playerID; // 0x18
	public string displayName; // 0x20
	public int score; // 0x28

	// Methods

	// RVA: 0x20019C0 Offset: 0x2000DC0 VA: 0x1820019C0
	public static void ResetToPool(ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x2001A70 Offset: 0x2000E70 VA: 0x182001A70
	public void ResetToPool() { }

	// RVA: 0x2001760 Offset: 0x2000B60 VA: 0x182001760 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2000770 Offset: 0x1FFFB70 VA: 0x182000770
	public void CopyTo(ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x20007C0 Offset: 0x1FFFBC0 VA: 0x1820007C0
	public ArcadeMachine.ScoreEntry Copy() { }

	// RVA: 0x20012D0 Offset: 0x20006D0 VA: 0x1820012D0
	public static ArcadeMachine.ScoreEntry Deserialize(Stream stream) { }

	// RVA: 0x2000850 Offset: 0x1FFFC50 VA: 0x182000850
	public static ArcadeMachine.ScoreEntry DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2000B60 Offset: 0x1FFFF60 VA: 0x182000B60
	public static ArcadeMachine.ScoreEntry DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2001020 Offset: 0x2000420 VA: 0x182001020
	public static ArcadeMachine.ScoreEntry Deserialize(byte[] buffer) { }

	// RVA: 0x20017E0 Offset: 0x2000BE0 VA: 0x1820017E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2002060 Offset: 0x2001460 VA: 0x182002060 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2002080 Offset: 0x2001480 VA: 0x182002080 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ArcadeMachine.ScoreEntry previous) { }

	// RVA: 0x20019A0 Offset: 0x2000DA0 VA: 0x1820019A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20014D0 Offset: 0x20008D0 VA: 0x1820014D0
	public static ArcadeMachine.ScoreEntry Deserialize(byte[] buffer, ArcadeMachine.ScoreEntry instance, bool isDelta = False) { }

	// RVA: 0x2000E60 Offset: 0x2000260 VA: 0x182000E60
	public static ArcadeMachine.ScoreEntry Deserialize(Stream stream, ArcadeMachine.ScoreEntry instance, bool isDelta) { }

	// RVA: 0x20008D0 Offset: 0x1FFFCD0 VA: 0x1820008D0
	public static ArcadeMachine.ScoreEntry DeserializeLengthDelimited(Stream stream, ArcadeMachine.ScoreEntry instance, bool isDelta) { }

	// RVA: 0x2000BF0 Offset: 0x1FFFFF0 VA: 0x182000BF0
	public static ArcadeMachine.ScoreEntry DeserializeLength(Stream stream, int length, ArcadeMachine.ScoreEntry instance, bool isDelta) { }

	// RVA: 0x2001B20 Offset: 0x2000F20 VA: 0x182001B20
	public static void SerializeDelta(Stream stream, ArcadeMachine.ScoreEntry instance, ArcadeMachine.ScoreEntry previous) { }

	// RVA: 0x2001EC0 Offset: 0x20012C0 VA: 0x182001EC0
	public static void Serialize(Stream stream, ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x2002050 Offset: 0x2001450 VA: 0x182002050
	public byte[] ToProtoBytes() { }

	// RVA: 0x2002060 Offset: 0x2001460 VA: 0x182002060
	public void ToProto(Stream stream) { }

	// RVA: 0x2001DB0 Offset: 0x20011B0 VA: 0x182001DB0
	public static byte[] SerializeToBytes(ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x2001D00 Offset: 0x2001100 VA: 0x182001D00
	public static void SerializeLengthDelimited(Stream stream, ArcadeMachine.ScoreEntry instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

