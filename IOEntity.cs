public class IOEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6354
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<IOEntity.IOConnection> inputs; // 0x18
	public List<IOEntity.IOConnection> outputs; // 0x20
	public uint genericEntRef1; // 0x28
	public uint genericEntRef2; // 0x2C
	public uint genericEntRef3; // 0x30
	public int genericInt1; // 0x34
	public int genericInt2; // 0x38
	public float genericFloat1; // 0x3C
	public float genericFloat2; // 0x40
	public int genericInt3; // 0x44

	// Methods

	// RVA: 0x1BFEBD0 Offset: 0x1BFDFD0 VA: 0x181BFEBD0
	public static void ResetToPool(IOEntity instance) { }

	// RVA: 0x1BFE860 Offset: 0x1BFDC60 VA: 0x181BFE860
	public void ResetToPool() { }

	// RVA: 0x1BFE7A0 Offset: 0x1BFDBA0 VA: 0x181BFE7A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFD100 Offset: 0x1BFC500 VA: 0x181BFD100
	public void CopyTo(IOEntity instance) { }

	// RVA: 0x1BFD410 Offset: 0x1BFC810 VA: 0x181BFD410
	public IOEntity Copy() { }

	// RVA: 0x1BFE180 Offset: 0x1BFD580 VA: 0x181BFE180
	public static IOEntity Deserialize(Stream stream) { }

	// RVA: 0x1BFD490 Offset: 0x1BFC890 VA: 0x181BFD490
	public static IOEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BFDA80 Offset: 0x1BFCE80 VA: 0x181BFDA80
	public static IOEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1BFE060 Offset: 0x1BFD460 VA: 0x181BFE060
	public static IOEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1BFE820 Offset: 0x1BFDC20 VA: 0x181BFE820
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1BFFB80 Offset: 0x1BFEF80 VA: 0x181BFFB80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1BFFBA0 Offset: 0x1BFEFA0 VA: 0x181BFFBA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, IOEntity previous) { }

	// RVA: 0x1BFE840 Offset: 0x1BFDC40 VA: 0x181BFE840 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1BFE6A0 Offset: 0x1BFDAA0 VA: 0x181BFE6A0
	public static IOEntity Deserialize(byte[] buffer, IOEntity instance, bool isDelta = False) { }

	// RVA: 0x1BFE200 Offset: 0x1BFD600 VA: 0x181BFE200
	public static IOEntity Deserialize(Stream stream, IOEntity instance, bool isDelta) { }

	// RVA: 0x1BFD510 Offset: 0x1BFC910 VA: 0x181BFD510
	public static IOEntity DeserializeLengthDelimited(Stream stream, IOEntity instance, bool isDelta) { }

	// RVA: 0x1BFDB10 Offset: 0x1BFCF10 VA: 0x181BFDB10
	public static IOEntity DeserializeLength(Stream stream, int length, IOEntity instance, bool isDelta) { }

	// RVA: 0x1BFEF40 Offset: 0x1BFE340 VA: 0x181BFEF40
	public static void SerializeDelta(Stream stream, IOEntity instance, IOEntity previous) { }

	// RVA: 0x1BFF710 Offset: 0x1BFEB10 VA: 0x181BFF710
	public static void Serialize(Stream stream, IOEntity instance) { }

	// RVA: 0x1BFFB70 Offset: 0x1BFEF70 VA: 0x181BFFB70
	public byte[] ToProtoBytes() { }

	// RVA: 0x1BFFB80 Offset: 0x1BFEF80 VA: 0x181BFFB80
	public void ToProto(Stream stream) { }

	// RVA: 0x1BFF600 Offset: 0x1BFEA00 VA: 0x181BFF600
	public static byte[] SerializeToBytes(IOEntity instance) { }

	// RVA: 0x1BFF550 Offset: 0x1BFE950 VA: 0x181BFF550
	public static void SerializeLengthDelimited(Stream stream, IOEntity instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class IOEntity.IOConnection : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6355
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string niceName; // 0x18
	public int type; // 0x20
	public uint connectedID; // 0x24
	public int connectedToSlot; // 0x28
	public bool inUse; // 0x2C
	public List<IOEntity.IOConnection.LineVec> linePointList; // 0x30
	public int colour; // 0x38

	// Methods

	// RVA: 0x1BFC340 Offset: 0x1BFB740 VA: 0x181BFC340
	public static void ResetToPool(IOEntity.IOConnection instance) { }

	// RVA: 0x1BFC580 Offset: 0x1BFB980 VA: 0x181BFC580
	public void ResetToPool() { }

	// RVA: 0x1BFBF10 Offset: 0x1BFB310 VA: 0x181BFBF10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFA360 Offset: 0x1BF9760 VA: 0x181BFA360
	public void CopyTo(IOEntity.IOConnection instance) { }

	// RVA: 0x1BFA510 Offset: 0x1BF9910 VA: 0x181BFA510
	public IOEntity.IOConnection Copy() { }

	// RVA: 0x1BFB750 Offset: 0x1BFAB50 VA: 0x181BFB750
	public static IOEntity.IOConnection Deserialize(Stream stream) { }

	// RVA: 0x1BFAA00 Offset: 0x1BF9E00 VA: 0x181BFAA00
	public static IOEntity.IOConnection DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BFAA80 Offset: 0x1BF9E80 VA: 0x181BFAA80
	public static IOEntity.IOConnection DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1BFBAE0 Offset: 0x1BFAEE0 VA: 0x181BFBAE0
	public static IOEntity.IOConnection Deserialize(byte[] buffer) { }

	// RVA: 0x1BFBF90 Offset: 0x1BFB390 VA: 0x181BFBF90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1BFD0C0 Offset: 0x1BFC4C0 VA: 0x181BFD0C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1BFD0E0 Offset: 0x1BFC4E0 VA: 0x181BFD0E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, IOEntity.IOConnection previous) { }

	// RVA: 0x1BFC320 Offset: 0x1BFB720 VA: 0x181BFC320 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1BFAF50 Offset: 0x1BFA350 VA: 0x181BFAF50
	public static IOEntity.IOConnection Deserialize(byte[] buffer, IOEntity.IOConnection instance, bool isDelta = False) { }

	// RVA: 0x1BFB3C0 Offset: 0x1BFA7C0 VA: 0x181BFB3C0
	public static IOEntity.IOConnection Deserialize(Stream stream, IOEntity.IOConnection instance, bool isDelta) { }

	// RVA: 0x1BFA590 Offset: 0x1BF9990 VA: 0x181BFA590
	public static IOEntity.IOConnection DeserializeLengthDelimited(Stream stream, IOEntity.IOConnection instance, bool isDelta) { }

	// RVA: 0x1BFAB10 Offset: 0x1BF9F10 VA: 0x181BFAB10
	public static IOEntity.IOConnection DeserializeLength(Stream stream, int length, IOEntity.IOConnection instance, bool isDelta) { }

	// RVA: 0x1BFC7C0 Offset: 0x1BFBBC0 VA: 0x181BFC7C0
	public static void SerializeDelta(Stream stream, IOEntity.IOConnection instance, IOEntity.IOConnection previous) { }

	// RVA: 0x1BFCD80 Offset: 0x1BFC180 VA: 0x181BFCD80
	public static void Serialize(Stream stream, IOEntity.IOConnection instance) { }

	// RVA: 0x1BFD0B0 Offset: 0x1BFC4B0 VA: 0x181BFD0B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1BFD0C0 Offset: 0x1BFC4C0 VA: 0x181BFD0C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1BFCC70 Offset: 0x1BFC070 VA: 0x181BFCC70
	public static byte[] SerializeToBytes(IOEntity.IOConnection instance) { }

	// RVA: 0x1BFCBC0 Offset: 0x1BFBFC0 VA: 0x181BFCBC0
	public static void SerializeLengthDelimited(Stream stream, IOEntity.IOConnection instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class IOEntity.IOConnection.LineVec : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6356
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector4 vec; // 0x14

	// Methods

	// RVA: 0x1C101B0 Offset: 0x1C0F5B0 VA: 0x181C101B0
	public static void ResetToPool(IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1C10130 Offset: 0x1C0F530 VA: 0x181C10130
	public void ResetToPool() { }

	// RVA: 0x1C10070 Offset: 0x1C0F470 VA: 0x181C10070 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C0F6D0 Offset: 0x1C0EAD0 VA: 0x181C0F6D0
	public void CopyTo(IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1C0F6F0 Offset: 0x1C0EAF0 VA: 0x181C0F6F0
	public IOEntity.IOConnection.LineVec Copy() { }

	// RVA: 0x1C0FC80 Offset: 0x1C0F080 VA: 0x181C0FC80
	public static IOEntity.IOConnection.LineVec Deserialize(Stream stream) { }

	// RVA: 0x1C0F980 Offset: 0x1C0ED80 VA: 0x181C0F980
	public static IOEntity.IOConnection.LineVec DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C0FA00 Offset: 0x1C0EE00 VA: 0x181C0FA00
	public static IOEntity.IOConnection.LineVec DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C0FF50 Offset: 0x1C0F350 VA: 0x181C0FF50
	public static IOEntity.IOConnection.LineVec Deserialize(byte[] buffer) { }

	// RVA: 0x1C100F0 Offset: 0x1C0F4F0 VA: 0x181C100F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C10790 Offset: 0x1C0FB90 VA: 0x181C10790 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C107B0 Offset: 0x1C0FBB0 VA: 0x181C107B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, IOEntity.IOConnection.LineVec previous) { }

	// RVA: 0x1C10110 Offset: 0x1C0F510 VA: 0x181C10110 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C0FD00 Offset: 0x1C0F100 VA: 0x181C0FD00
	public static IOEntity.IOConnection.LineVec Deserialize(byte[] buffer, IOEntity.IOConnection.LineVec instance, bool isDelta = False) { }

	// RVA: 0x1C0FE00 Offset: 0x1C0F200 VA: 0x181C0FE00
	public static IOEntity.IOConnection.LineVec Deserialize(Stream stream, IOEntity.IOConnection.LineVec instance, bool isDelta) { }

	// RVA: 0x1C0F760 Offset: 0x1C0EB60 VA: 0x181C0F760
	public static IOEntity.IOConnection.LineVec DeserializeLengthDelimited(Stream stream, IOEntity.IOConnection.LineVec instance, bool isDelta) { }

	// RVA: 0x1C0FA90 Offset: 0x1C0EE90 VA: 0x181C0FA90
	public static IOEntity.IOConnection.LineVec DeserializeLength(Stream stream, int length, IOEntity.IOConnection.LineVec instance, bool isDelta) { }

	// RVA: 0x1C10230 Offset: 0x1C0F630 VA: 0x181C10230
	public static void SerializeDelta(Stream stream, IOEntity.IOConnection.LineVec instance, IOEntity.IOConnection.LineVec previous) { }

	// RVA: 0x1C10610 Offset: 0x1C0FA10 VA: 0x181C10610
	public static void Serialize(Stream stream, IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1C10780 Offset: 0x1C0FB80 VA: 0x181C10780
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C10790 Offset: 0x1C0FB90 VA: 0x181C10790
	public void ToProto(Stream stream) { }

	// RVA: 0x1C10500 Offset: 0x1C0F900 VA: 0x181C10500
	public static byte[] SerializeToBytes(IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x1C10450 Offset: 0x1C0F850 VA: 0x181C10450
	public static void SerializeLengthDelimited(Stream stream, IOEntity.IOConnection.LineVec instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class IOEntity.IOConnection.LinePointList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6357
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector4 a; // 0x14
	public Vector4 b; // 0x24
	public Vector4 c; // 0x34
	public Vector4 d; // 0x44
	public Vector4 e; // 0x54
	public Vector4 f; // 0x64
	public Vector4 g; // 0x74
	public Vector4 h; // 0x84

	// Methods

	// RVA: 0x1C0E2D0 Offset: 0x1C0D6D0 VA: 0x181C0E2D0
	public static void ResetToPool(IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1C0E1E0 Offset: 0x1C0D5E0 VA: 0x181C0E1E0
	public void ResetToPool() { }

	// RVA: 0x1C0DA20 Offset: 0x1C0CE20 VA: 0x181C0DA20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C0BD70 Offset: 0x1C0B170 VA: 0x181C0BD70
	public void CopyTo(IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1C0BDD0 Offset: 0x1C0B1D0 VA: 0x181C0BDD0
	public IOEntity.IOConnection.LinePointList Copy() { }

	// RVA: 0x1C0CD10 Offset: 0x1C0C110 VA: 0x181C0CD10
	public static IOEntity.IOConnection.LinePointList Deserialize(Stream stream) { }

	// RVA: 0x1C0BE80 Offset: 0x1C0B280 VA: 0x181C0BE80
	public static IOEntity.IOConnection.LinePointList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C0C960 Offset: 0x1C0BD60 VA: 0x181C0C960
	public static IOEntity.IOConnection.LinePointList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C0D2E0 Offset: 0x1C0C6E0 VA: 0x181C0D2E0
	public static IOEntity.IOConnection.LinePointList Deserialize(byte[] buffer) { }

	// RVA: 0x1C0DBA0 Offset: 0x1C0CFA0 VA: 0x181C0DBA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C0F690 Offset: 0x1C0EA90 VA: 0x181C0F690 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C0F6B0 Offset: 0x1C0EAB0 VA: 0x181C0F6B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, IOEntity.IOConnection.LinePointList previous) { }

	// RVA: 0x1C0DE70 Offset: 0x1C0D270 VA: 0x181C0DE70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C0D690 Offset: 0x1C0CA90 VA: 0x181C0D690
	public static IOEntity.IOConnection.LinePointList Deserialize(byte[] buffer, IOEntity.IOConnection.LinePointList instance, bool isDelta = False) { }

	// RVA: 0x1C0D010 Offset: 0x1C0C410 VA: 0x181C0D010
	public static IOEntity.IOConnection.LinePointList Deserialize(Stream stream, IOEntity.IOConnection.LinePointList instance, bool isDelta) { }

	// RVA: 0x1C0C260 Offset: 0x1C0B660 VA: 0x181C0C260
	public static IOEntity.IOConnection.LinePointList DeserializeLengthDelimited(Stream stream, IOEntity.IOConnection.LinePointList instance, bool isDelta) { }

	// RVA: 0x1C0C5F0 Offset: 0x1C0B9F0 VA: 0x181C0C5F0
	public static IOEntity.IOConnection.LinePointList DeserializeLength(Stream stream, int length, IOEntity.IOConnection.LinePointList instance, bool isDelta) { }

	// RVA: 0x1C0E3C0 Offset: 0x1C0D7C0 VA: 0x181C0E3C0
	public static void SerializeDelta(Stream stream, IOEntity.IOConnection.LinePointList instance, IOEntity.IOConnection.LinePointList previous) { }

	// RVA: 0x1C0F000 Offset: 0x1C0E400 VA: 0x181C0F000
	public static void Serialize(Stream stream, IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1C0F680 Offset: 0x1C0EA80 VA: 0x181C0F680
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C0F690 Offset: 0x1C0EA90 VA: 0x181C0F690
	public void ToProto(Stream stream) { }

	// RVA: 0x1C0EEF0 Offset: 0x1C0E2F0 VA: 0x181C0EEF0
	public static byte[] SerializeToBytes(IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x1C0EE40 Offset: 0x1C0E240 VA: 0x181C0EE40
	public static void SerializeLengthDelimited(Stream stream, IOEntity.IOConnection.LinePointList instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class IOEntity : DecayEntity // TypeDefIndex: 8587
{	// Fields
	[HeaderAttribute] // RVA: 0xAE7D0 Offset: 0xADBD0 VA: 0x1800AE7D0
	public Transform debugOrigin; // 0x258
	public ItemDefinition sourceItem; // 0x260
	[ServerVar] // RVA: 0xAFC30 Offset: 0xAF030 VA: 0x1800AFC30
	[HelpAttribute] // RVA: 0xAFC30 Offset: 0xAF030 VA: 0x1800AFC30
	public static float framebudgetms; // 0x0
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static float responsetime; // 0x4
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int backtracking; // 0x8
	public const BaseEntity.Flags Flag_ShortCircuit = 32768;
	public const BaseEntity.Flags Flag_HasPower = 65536;
	public IOEntity.IOSlot[] inputs; // 0x268
	public IOEntity.IOSlot[] outputs; // 0x270
	public IOEntity.IOType ioType; // 0x278
	public int client_powerin; // 0x27C
	public int client_slotpower; // 0x280
	public bool client_extradata_dirty; // 0x284

	// Properties
	public virtual bool IsGravitySource { get; }
	protected virtual float LiquidPassthroughGravityThreshold { get; }
	protected virtual bool DisregardGravityRestrictionsOnLiquid { get; }

	// Methods

	// RVA: 0x761840 Offset: 0x760C40 VA: 0x180761840 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x761E70 Offset: 0x761270 VA: 0x180761E70 Slot: 27
	public override void ResetState() { }

	// RVA: 0x760570 Offset: 0x75F970 VA: 0x180760570
	public string GetDisplayName() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 145
	public virtual bool IsRootEntity() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 146
	public virtual bool get_IsGravitySource() { }

	// RVA: 0x760060 Offset: 0x75F460 VA: 0x180760060
	public IOEntity FindGravitySource(ref Vector3 worldHandlePosition, int depth, bool ignoreSelf) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 147
	public virtual void SetFuelType(ItemDefinition def, IOEntity source) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 148
	public virtual bool WantsPower() { }

	// RVA: 0x761EB0 Offset: 0x7612B0 VA: 0x180761EB0 Slot: 149
	public virtual bool WantsPassthroughPower() { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 150
	public virtual int ConsumptionAmount() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 151
	public virtual int MaximalPowerOutput() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 152
	public virtual bool AllowDrainFrom(int outputSlot) { }

	// RVA: 0x5714C0 Offset: 0x5708C0 VA: 0x1805714C0 Slot: 153
	public virtual bool IsPowered() { }

	// RVA: 0x7607F0 Offset: 0x75FBF0 VA: 0x1807607F0
	public bool IsConnectedToAnySlot(IOEntity entity, int slot, int depth, bool defaultReturn = False) { }

	// RVA: 0x760B10 Offset: 0x75FF10 VA: 0x180760B10
	public bool IsConnectedTo(IOEntity entity, int slot, int depth, bool defaultReturn = False) { }

	// RVA: 0x760950 Offset: 0x75FD50 VA: 0x180760950
	public bool IsConnectedTo(IOEntity entity, int depth, bool defaultReturn = False) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 154
	protected virtual bool ConsiderConnectedTo(IOEntity entity) { }

	// RVA: 0x761D30 Offset: 0x761130 VA: 0x180761D30
	public void RequestAdditionalData(int slot, bool input) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x75FEF0 Offset: 0x75F2F0 VA: 0x18075FEF0
	private void Client_ReceiveAdditionalData(BaseEntity.RPCMessage msg) { }

	// RVA: 0x761D20 Offset: 0x761120 VA: 0x180761D20 Slot: 155
	public virtual void ProcessAdditionalData(int first, int second, float third, float fourth) { }

	// RVA: 0x4C0690 Offset: 0x4BFA90 VA: 0x1804C0690 Slot: 156
	protected virtual float get_LiquidPassthroughGravityThreshold() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 157
	protected virtual bool get_DisregardGravityRestrictionsOnLiquid() { }

	// RVA: 0x75FDA0 Offset: 0x75F1A0 VA: 0x18075FDA0 Slot: 158
	public virtual bool AllowLiquidPassthrough(IOEntity fromSource, Vector3 sourceWorldPosition, bool forPlacement = False) { }

	// RVA: 0x760C80 Offset: 0x760080 VA: 0x180760C80 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x760370 Offset: 0x75F770 VA: 0x180760370
	public int GetConnectedInputCount() { }

	// RVA: 0x760470 Offset: 0x75F870 VA: 0x180760470
	public int GetConnectedOutputCount() { }

	// RVA: 0x760620 Offset: 0x75FA20 VA: 0x180760620
	public bool HasConnections() { }

	// RVA: 0x75FFE0 Offset: 0x75F3E0 VA: 0x18075FFE0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x761F30 Offset: 0x761330 VA: 0x180761F30
	public void .ctor() { }

	// RVA: 0x761ED0 Offset: 0x7612D0 VA: 0x180761ED0
	private static void .cctor() { }

}

public enum IOEntity.IOType // TypeDefIndex: 8588
{	// Fields
	public int value__; // 0x0
	public const IOEntity.IOType Electric = 0;
	public const IOEntity.IOType Fluidic = 1;
	public const IOEntity.IOType Kinetic = 2;
	public const IOEntity.IOType Generic = 3;

}

public class IOEntity.IORef // TypeDefIndex: 8589
{	// Fields
	public EntityRef entityRef; // 0x10
	public IOEntity ioEnt; // 0x20

	// Methods

	// RVA: 0x762100 Offset: 0x761500 VA: 0x180762100
	public void Init() { }

	// RVA: 0x762040 Offset: 0x761440 VA: 0x180762040
	public void InitClient() { }

	// RVA: 0x761F70 Offset: 0x761370 VA: 0x180761F70
	public IOEntity Get(bool isServer = True) { }

	// RVA: 0x761F40 Offset: 0x761340 VA: 0x180761F40
	public void Clear() { }

	// RVA: 0x7621E0 Offset: 0x7615E0 VA: 0x1807621E0
	public void Set(IOEntity newIOEnt) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class IOEntity.IOSlot // TypeDefIndex: 8590
{	// Fields
	public string niceName; // 0x10
	public IOEntity.IOType type; // 0x18
	public IOEntity.IORef connectedTo; // 0x20
	public int connectedToSlot; // 0x28
	public Vector3[] linePoints; // 0x30
	public float[] slackLevels; // 0x38
	public ClientIOLine line; // 0x40
	public Vector3 handlePosition; // 0x48
	public bool rootConnectionsOnly; // 0x54
	public bool mainPowerSlot; // 0x55
	public WireTool.WireColour wireColour; // 0x58

	// Methods

	// RVA: 0x762540 Offset: 0x761940 VA: 0x180762540
	public void OnDestroy() { }

	// RVA: 0x7622E0 Offset: 0x7616E0 VA: 0x1807622E0
	public void Clear() { }

	// RVA: 0x7621F0 Offset: 0x7615F0 VA: 0x1807621F0
	public void CleanupLines() { }

	// RVA: 0x762550 Offset: 0x761950 VA: 0x180762550
	public void UpdateLines(Transform transform) { }

	// RVA: 0x7623B0 Offset: 0x7617B0 VA: 0x1807623B0
	public float GetLength() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

