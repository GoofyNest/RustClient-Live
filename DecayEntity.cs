public class DecayEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6335
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float decayTimer; // 0x14
	public uint buildingID; // 0x18
	public float upkeepTimer; // 0x1C

	// Methods

	// RVA: 0x20B55A0 Offset: 0x20B49A0 VA: 0x1820B55A0
	public static void ResetToPool(DecayEntity instance) { }

	// RVA: 0x20B5630 Offset: 0x20B4A30 VA: 0x1820B5630
	public void ResetToPool() { }

	// RVA: 0x20B52C0 Offset: 0x20B46C0 VA: 0x1820B52C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E231E0 Offset: 0x1E225E0 VA: 0x181E231E0
	public void CopyTo(DecayEntity instance) { }

	// RVA: 0x20B4350 Offset: 0x20B3750 VA: 0x1820B4350
	public DecayEntity Copy() { }

	// RVA: 0x20B4C90 Offset: 0x20B4090 VA: 0x1820B4C90
	public static DecayEntity Deserialize(Stream stream) { }

	// RVA: 0x20B4660 Offset: 0x20B3A60 VA: 0x1820B4660
	public static DecayEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B4950 Offset: 0x20B3D50 VA: 0x1820B4950
	public static DecayEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B49E0 Offset: 0x20B3DE0 VA: 0x1820B49E0
	public static DecayEntity Deserialize(byte[] buffer) { }

	// RVA: 0x20B53D0 Offset: 0x20B47D0 VA: 0x1820B53D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B5BA0 Offset: 0x20B4FA0 VA: 0x1820B5BA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B5BC0 Offset: 0x20B4FC0 VA: 0x1820B5BC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DecayEntity previous) { }

	// RVA: 0x20B5580 Offset: 0x20B4980 VA: 0x1820B5580 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B5030 Offset: 0x20B4430 VA: 0x1820B5030
	public static DecayEntity Deserialize(byte[] buffer, DecayEntity instance, bool isDelta = False) { }

	// RVA: 0x20B4E80 Offset: 0x20B4280 VA: 0x1820B4E80
	public static DecayEntity Deserialize(Stream stream, DecayEntity instance, bool isDelta) { }

	// RVA: 0x20B43D0 Offset: 0x20B37D0 VA: 0x1820B43D0
	public static DecayEntity DeserializeLengthDelimited(Stream stream, DecayEntity instance, bool isDelta) { }

	// RVA: 0x20B46E0 Offset: 0x20B3AE0 VA: 0x1820B46E0
	public static DecayEntity DeserializeLength(Stream stream, int length, DecayEntity instance, bool isDelta) { }

	// RVA: 0x20B56C0 Offset: 0x20B4AC0 VA: 0x1820B56C0
	public static void SerializeDelta(Stream stream, DecayEntity instance, DecayEntity previous) { }

	// RVA: 0x20B5A60 Offset: 0x20B4E60 VA: 0x1820B5A60
	public static void Serialize(Stream stream, DecayEntity instance) { }

	// RVA: 0x20B5B90 Offset: 0x20B4F90 VA: 0x1820B5B90
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B5BA0 Offset: 0x20B4FA0 VA: 0x1820B5BA0
	public void ToProto(Stream stream) { }

	// RVA: 0x20B5950 Offset: 0x20B4D50 VA: 0x1820B5950
	public static byte[] SerializeToBytes(DecayEntity instance) { }

	// RVA: 0x20B58A0 Offset: 0x20B4CA0 VA: 0x1820B58A0
	public static void SerializeLengthDelimited(Stream stream, DecayEntity instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class DecayEntity : BaseCombatEntity // TypeDefIndex: 9528
{	// Fields
	public GameObjectRef debrisPrefab; // 0x240
	public uint buildingID; // 0x248
	private Upkeep upkeep; // 0x250

	// Methods

	// RVA: 0x8E6EB0 Offset: 0x8E62B0 VA: 0x1808E6EB0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x8E6FB0 Offset: 0x8E63B0 VA: 0x1808E6FB0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x8E6700 Offset: 0x8E5B00 VA: 0x1808E6700
	public void AttachToBuilding(uint id) { }

	// RVA: 0x8E6E20 Offset: 0x8E6220 VA: 0x1808E6E20
	public BuildingManager.Building GetBuilding() { }

	// RVA: 0x8E6D80 Offset: 0x8E6180 VA: 0x1808E6D80 Slot: 82
	public override BuildingPrivlidge GetBuildingPrivilege() { }

	// RVA: 0x8E67C0 Offset: 0x8E5BC0 VA: 0x1808E67C0
	public void CalculateUpkeepCostAmounts(List<ItemAmount> itemAmounts, float multiplier) { }

	// RVA: 0x8E6B80 Offset: 0x8E5F80 VA: 0x1808E6B80 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x8E6D00 Offset: 0x8E6100 VA: 0x1808E6D00 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x8E6C70 Offset: 0x8E6070 VA: 0x1808E6C70 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x499120 Offset: 0x498520 VA: 0x180499120
	public void .ctor() { }

}

