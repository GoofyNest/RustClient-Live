public class ComputerStation : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6376
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string bookmarks; // 0x18

	// Methods

	// RVA: 0x20AC060 Offset: 0x20AB460 VA: 0x1820AC060
	public static void ResetToPool(ComputerStation instance) { }

	// RVA: 0x20AC0F0 Offset: 0x20AB4F0 VA: 0x1820AC0F0
	public void ResetToPool() { }

	// RVA: 0x20ABF10 Offset: 0x20AB310 VA: 0x1820ABF10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D62910 Offset: 0x1D61D10 VA: 0x181D62910
	public void CopyTo(ComputerStation instance) { }

	// RVA: 0x20AB570 Offset: 0x20AA970 VA: 0x1820AB570
	public ComputerStation Copy() { }

	// RVA: 0x20ABB20 Offset: 0x20AAF20 VA: 0x1820ABB20
	public static ComputerStation Deserialize(Stream stream) { }

	// RVA: 0x20AB5F0 Offset: 0x20AA9F0 VA: 0x1820AB5F0
	public static ComputerStation DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20AB890 Offset: 0x20AAC90 VA: 0x1820AB890
	public static ComputerStation DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20ABCA0 Offset: 0x20AB0A0 VA: 0x1820ABCA0
	public static ComputerStation Deserialize(byte[] buffer) { }

	// RVA: 0x20AC020 Offset: 0x20AB420 VA: 0x1820AC020
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20AC560 Offset: 0x20AB960 VA: 0x1820AC560 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20AC580 Offset: 0x20AB980 VA: 0x1820AC580 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ComputerStation previous) { }

	// RVA: 0x20AC040 Offset: 0x20AB440 VA: 0x1820AC040 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20ABBA0 Offset: 0x20AAFA0 VA: 0x1820ABBA0
	public static ComputerStation Deserialize(byte[] buffer, ComputerStation instance, bool isDelta = False) { }

	// RVA: 0x20ABDC0 Offset: 0x20AB1C0 VA: 0x1820ABDC0
	public static ComputerStation Deserialize(Stream stream, ComputerStation instance, bool isDelta) { }

	// RVA: 0x20AB670 Offset: 0x20AAA70 VA: 0x1820AB670
	public static ComputerStation DeserializeLengthDelimited(Stream stream, ComputerStation instance, bool isDelta) { }

	// RVA: 0x20AB920 Offset: 0x20AAD20 VA: 0x1820AB920
	public static ComputerStation DeserializeLength(Stream stream, int length, ComputerStation instance, bool isDelta) { }

	// RVA: 0x20AC180 Offset: 0x20AB580 VA: 0x1820AC180
	public static void SerializeDelta(Stream stream, ComputerStation instance, ComputerStation previous) { }

	// RVA: 0x20AC460 Offset: 0x20AB860 VA: 0x1820AC460
	public static void Serialize(Stream stream, ComputerStation instance) { }

	// RVA: 0x20AC550 Offset: 0x20AB950 VA: 0x1820AC550
	public byte[] ToProtoBytes() { }

	// RVA: 0x20AC560 Offset: 0x20AB960 VA: 0x1820AC560
	public void ToProto(Stream stream) { }

	// RVA: 0x20AC350 Offset: 0x20AB750 VA: 0x1820AC350
	public static byte[] SerializeToBytes(ComputerStation instance) { }

	// RVA: 0x20AC2A0 Offset: 0x20AB6A0 VA: 0x1820AC2A0
	public static void SerializeLengthDelimited(Stream stream, ComputerStation instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class ComputerStation : BaseMountable // TypeDefIndex: 8562
{	// Fields
	[HeaderAttribute] // RVA: 0xAA970 Offset: 0xA9D70 VA: 0x1800AA970
	public GameObjectRef menuPrefab; // 0x320
	public ComputerMenu computerMenu; // 0x328
	public EntityRef currentlyControllingEnt; // 0x330
	public Dictionary<string, uint> controlBookmarks; // 0x340
	public Transform leftHandIKPosition; // 0x348
	public Transform rightHandIKPosition; // 0x350
	public SoundDefinition turnOnSoundDef; // 0x358
	public SoundDefinition turnOffSoundDef; // 0x360
	public SoundDefinition onLoopSoundDef; // 0x368
	public bool isStatic; // 0x370
	public float autoGatherRadius; // 0x374
	private Sound onLoopSound; // 0x378

	// Methods

	// RVA: 0x6D1430 Offset: 0x6D0830 VA: 0x1806D1430 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6D10B0 Offset: 0x6D04B0 VA: 0x1806D10B0
	public static bool IsValidIdentifier(string str) { }

	// RVA: 0x6D0C70 Offset: 0x6D0070 VA: 0x1806D0C70 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x6D1130 Offset: 0x6D0530 VA: 0x1806D1130 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x6D0F70 Offset: 0x6D0370 VA: 0x1806D0F70 Slot: 175
	public override Quaternion GetMountedRotation() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x6D1E10 Offset: 0x6D1210 VA: 0x1806D1E10
	public void ReceiveBookmarks(BaseEntity.RPCMessage msg) { }

	// RVA: 0x6D1A00 Offset: 0x6D0E00 VA: 0x1806D1A00 Slot: 177
	public override void PlayerDismounted(BasePlayer player, bool wasSwap) { }

	// RVA: 0x6D0ED0 Offset: 0x6D02D0 VA: 0x1806D0ED0 Slot: 146
	public override BasePlayer.CameraMode GetMountedCameraMode() { }

	// RVA: 0x6D1370 Offset: 0x6D0770 VA: 0x1806D1370
	public void MenuShutdown() { }

	// RVA: 0x6D1B70 Offset: 0x6D0F70 VA: 0x1806D1B70 Slot: 176
	public override void PlayerMounted(BasePlayer player, bool wasSwap) { }

	// RVA: 0x6D0E90 Offset: 0x6D0290 VA: 0x1806D0E90 Slot: 149
	public override Quaternion GetMountedBodyAngles() { }

	// RVA: 0x6D0C80 Offset: 0x6D0080 VA: 0x1806D0C80 Slot: 154
	public override Vector3 EyePositionForPlayer(BasePlayer player, Quaternion lookRot) { }

	// RVA: 0x6D1390 Offset: 0x6D0790 VA: 0x1806D1390 Slot: 150
	public override bool ModifiesThirdPersonCamera() { }

	// RVA: 0x6D0DD0 Offset: 0x6D01D0 VA: 0x1806D0DD0 Slot: 148
	public override Transform GetEyeOverride() { }

	// RVA: 0x6D1070 Offset: 0x6D0470 VA: 0x1806D1070 Slot: 151
	public override Vector2 GetPitchClamp() { }

	// RVA: 0x6D1090 Offset: 0x6D0490 VA: 0x1806D1090 Slot: 152
	public override Vector2 GetYawClamp() { }

	// RVA: 0x6D2050 Offset: 0x6D1450 VA: 0x1806D2050 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x6D2170 Offset: 0x6D1570 VA: 0x1806D2170
	public void .ctor() { }

}

