public class ArcadeGame : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6500
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ArcadeGame.arcadeEnt> arcadeEnts; // 0x18

	// Methods

	// RVA: 0x1FEBEF0 Offset: 0x1FEB2F0 VA: 0x181FEBEF0
	public static void ResetToPool(ArcadeGame instance) { }

	// RVA: 0x1FEBD40 Offset: 0x1FEB140 VA: 0x181FEBD40
	public void ResetToPool() { }

	// RVA: 0x1FEBAC0 Offset: 0x1FEAEC0 VA: 0x181FEBAC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FEAD20 Offset: 0x1FEA120 VA: 0x181FEAD20
	public void CopyTo(ArcadeGame instance) { }

	// RVA: 0x1FEAF30 Offset: 0x1FEA330 VA: 0x181FEAF30
	public ArcadeGame Copy() { }

	// RVA: 0x1FEB630 Offset: 0x1FEAA30 VA: 0x181FEB630
	public static ArcadeGame Deserialize(Stream stream) { }

	// RVA: 0x1FEB280 Offset: 0x1FEA680 VA: 0x181FEB280
	public static ArcadeGame DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FEB5A0 Offset: 0x1FEA9A0 VA: 0x181FEB5A0
	public static ArcadeGame DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FEB8A0 Offset: 0x1FEACA0 VA: 0x181FEB8A0
	public static ArcadeGame Deserialize(byte[] buffer) { }

	// RVA: 0x1FEBD00 Offset: 0x1FEB100 VA: 0x181FEBD00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FEC630 Offset: 0x1FEBA30 VA: 0x181FEC630 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FEC650 Offset: 0x1FEBA50 VA: 0x181FEC650 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ArcadeGame previous) { }

	// RVA: 0x1FEBD20 Offset: 0x1FEB120 VA: 0x181FEBD20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FEB9C0 Offset: 0x1FEADC0 VA: 0x181FEB9C0
	public static ArcadeGame Deserialize(byte[] buffer, ArcadeGame instance, bool isDelta = False) { }

	// RVA: 0x1FEB6B0 Offset: 0x1FEAAB0 VA: 0x181FEB6B0
	public static ArcadeGame Deserialize(Stream stream, ArcadeGame instance, bool isDelta) { }

	// RVA: 0x1FEAFB0 Offset: 0x1FEA3B0 VA: 0x181FEAFB0
	public static ArcadeGame DeserializeLengthDelimited(Stream stream, ArcadeGame instance, bool isDelta) { }

	// RVA: 0x1FEB300 Offset: 0x1FEA700 VA: 0x181FEB300
	public static ArcadeGame DeserializeLength(Stream stream, int length, ArcadeGame instance, bool isDelta) { }

	// RVA: 0x1FEC0A0 Offset: 0x1FEB4A0 VA: 0x181FEC0A0
	public static void SerializeDelta(Stream stream, ArcadeGame instance, ArcadeGame previous) { }

	// RVA: 0x1FEC440 Offset: 0x1FEB840 VA: 0x181FEC440
	public static void Serialize(Stream stream, ArcadeGame instance) { }

	// RVA: 0x1FEC620 Offset: 0x1FEBA20 VA: 0x181FEC620
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FEC630 Offset: 0x1FEBA30 VA: 0x181FEC630
	public void ToProto(Stream stream) { }

	// RVA: 0x1FEC330 Offset: 0x1FEB730 VA: 0x181FEC330
	public static byte[] SerializeToBytes(ArcadeGame instance) { }

	// RVA: 0x1FEC280 Offset: 0x1FEB680 VA: 0x181FEC280
	public static void SerializeLengthDelimited(Stream stream, ArcadeGame instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class ArcadeGame.arcadeEnt : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6501
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint id; // 0x14
	public string name; // 0x18
	public uint spriteID; // 0x20
	public uint soundID; // 0x24
	public bool visible; // 0x28
	public Vector3 position; // 0x2C
	public Vector3 heading; // 0x38
	public bool enabled; // 0x44
	public Vector3 scale; // 0x48
	public Vector3 colliderScale; // 0x54
	public float alpha; // 0x60
	public uint prefabID; // 0x64
	public uint parentID; // 0x68

	// Methods

	// RVA: 0x2003530 Offset: 0x2002930 VA: 0x182003530
	public static void ResetToPool(ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x20036A0 Offset: 0x2002AA0 VA: 0x1820036A0
	public void ResetToPool() { }

	// RVA: 0x2003470 Offset: 0x2002870 VA: 0x182003470 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20020A0 Offset: 0x20014A0 VA: 0x1820020A0
	public void CopyTo(ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x2002150 Offset: 0x2001550 VA: 0x182002150
	public ArcadeGame.arcadeEnt Copy() { }

	// RVA: 0x2002D80 Offset: 0x2002180 VA: 0x182002D80
	public static ArcadeGame.arcadeEnt Deserialize(Stream stream) { }

	// RVA: 0x2002770 Offset: 0x2001B70 VA: 0x182002770
	public static ArcadeGame.arcadeEnt DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2002CF0 Offset: 0x20020F0 VA: 0x182002CF0
	public static ArcadeGame.arcadeEnt DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2002E00 Offset: 0x2002200 VA: 0x182002E00
	public static ArcadeGame.arcadeEnt Deserialize(byte[] buffer) { }

	// RVA: 0x20034F0 Offset: 0x20028F0 VA: 0x1820034F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20048C0 Offset: 0x2003CC0 VA: 0x1820048C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20048E0 Offset: 0x2003CE0 VA: 0x1820048E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ArcadeGame.arcadeEnt previous) { }

	// RVA: 0x2003510 Offset: 0x2002910 VA: 0x182003510 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2003370 Offset: 0x2002770 VA: 0x182003370
	public static ArcadeGame.arcadeEnt Deserialize(byte[] buffer, ArcadeGame.arcadeEnt instance, bool isDelta = False) { }

	// RVA: 0x2002F20 Offset: 0x2002320 VA: 0x182002F20
	public static ArcadeGame.arcadeEnt Deserialize(Stream stream, ArcadeGame.arcadeEnt instance, bool isDelta) { }

	// RVA: 0x2002250 Offset: 0x2001650 VA: 0x182002250
	public static ArcadeGame.arcadeEnt DeserializeLengthDelimited(Stream stream, ArcadeGame.arcadeEnt instance, bool isDelta) { }

	// RVA: 0x20027F0 Offset: 0x2001BF0 VA: 0x1820027F0
	public static ArcadeGame.arcadeEnt DeserializeLength(Stream stream, int length, ArcadeGame.arcadeEnt instance, bool isDelta) { }

	// RVA: 0x2003810 Offset: 0x2002C10 VA: 0x182003810
	public static void SerializeDelta(Stream stream, ArcadeGame.arcadeEnt instance, ArcadeGame.arcadeEnt previous) { }

	// RVA: 0x2004320 Offset: 0x2003720 VA: 0x182004320
	public static void Serialize(Stream stream, ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x20048B0 Offset: 0x2003CB0 VA: 0x1820048B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20048C0 Offset: 0x2003CC0 VA: 0x1820048C0
	public void ToProto(Stream stream) { }

	// RVA: 0x2004210 Offset: 0x2003610 VA: 0x182004210
	public static byte[] SerializeToBytes(ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x2004160 Offset: 0x2003560 VA: 0x182004160
	public static void SerializeLengthDelimited(Stream stream, ArcadeGame.arcadeEnt instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

