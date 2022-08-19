public class ReclaimTerminal : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6405
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int itemCount; // 0x14

	// Methods

	// RVA: 0x1DFA580 Offset: 0x1DF9980 VA: 0x181DFA580
	public static void ResetToPool(ReclaimTerminal instance) { }

	// RVA: 0x1DFA500 Offset: 0x1DF9900 VA: 0x181DFA500
	public void ResetToPool() { }

	// RVA: 0x1DFA3D0 Offset: 0x1DF97D0 VA: 0x181DFA3D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(ReclaimTerminal instance) { }

	// RVA: 0x1DF9A50 Offset: 0x1DF8E50 VA: 0x181DF9A50
	public ReclaimTerminal Copy() { }

	// RVA: 0x1DFA350 Offset: 0x1DF9750 VA: 0x181DFA350
	public static ReclaimTerminal Deserialize(Stream stream) { }

	// RVA: 0x1DF9AC0 Offset: 0x1DF8EC0 VA: 0x181DF9AC0
	public static ReclaimTerminal DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DF9D60 Offset: 0x1DF9160 VA: 0x181DF9D60
	public static ReclaimTerminal DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DFA230 Offset: 0x1DF9630 VA: 0x181DFA230
	public static ReclaimTerminal Deserialize(byte[] buffer) { }

	// RVA: 0x1DFA4C0 Offset: 0x1DF98C0 VA: 0x181DFA4C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DFAA50 Offset: 0x1DF9E50 VA: 0x181DFAA50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DFAB20 Offset: 0x1DF9F20 VA: 0x181DFAB20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ReclaimTerminal previous) { }

	// RVA: 0x1DFA4E0 Offset: 0x1DF98E0 VA: 0x181DFA4E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DF9FF0 Offset: 0x1DF93F0 VA: 0x181DF9FF0
	public static ReclaimTerminal Deserialize(byte[] buffer, ReclaimTerminal instance, bool isDelta = False) { }

	// RVA: 0x1DFA0F0 Offset: 0x1DF94F0 VA: 0x181DFA0F0
	public static ReclaimTerminal Deserialize(Stream stream, ReclaimTerminal instance, bool isDelta) { }

	// RVA: 0x1DF9B40 Offset: 0x1DF8F40 VA: 0x181DF9B40
	public static ReclaimTerminal DeserializeLengthDelimited(Stream stream, ReclaimTerminal instance, bool isDelta) { }

	// RVA: 0x1DF9DF0 Offset: 0x1DF91F0 VA: 0x181DF9DF0
	public static ReclaimTerminal DeserializeLength(Stream stream, int length, ReclaimTerminal instance, bool isDelta) { }

	// RVA: 0x1DFA600 Offset: 0x1DF9A00 VA: 0x181DFA600
	public static void SerializeDelta(Stream stream, ReclaimTerminal instance, ReclaimTerminal previous) { }

	// RVA: 0x1DFA970 Offset: 0x1DF9D70 VA: 0x181DFA970
	public static void Serialize(Stream stream, ReclaimTerminal instance) { }

	// RVA: 0x1DFAA40 Offset: 0x1DF9E40 VA: 0x181DFAA40
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DFAA50 Offset: 0x1DF9E50 VA: 0x181DFAA50
	public void ToProto(Stream stream) { }

	// RVA: 0x1DFA7C0 Offset: 0x1DF9BC0 VA: 0x181DFA7C0
	public static byte[] SerializeToBytes(ReclaimTerminal instance) { }

	// RVA: 0x1DFA710 Offset: 0x1DF9B10 VA: 0x181DFA710
	public static void SerializeLengthDelimited(Stream stream, ReclaimTerminal instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class ReclaimTerminal : StorageContainer // TypeDefIndex: 8626
{	// Fields
	public int itemCount; // 0x3D0
	public static readonly Translate.Phrase DespawnToast; // 0x0

	// Methods

	// RVA: 0x6ABC40 Offset: 0x6AB040 VA: 0x1806ABC40 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6ABBD0 Offset: 0x6AAFD0 VA: 0x1806ABBD0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x6ABDA0 Offset: 0x6AB1A0 VA: 0x1806ABDA0
	public void .ctor() { }

	// RVA: 0x6ABD30 Offset: 0x6AB130 VA: 0x1806ABD30
	private static void .cctor() { }

}

