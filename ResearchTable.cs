public class ResearchTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6321
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float researchTimeLeft; // 0x14

	// Methods

	// RVA: 0x1DFDA00 Offset: 0x1DFCE00 VA: 0x181DFDA00
	public static void ResetToPool(ResearchTable instance) { }

	// RVA: 0x1DFD980 Offset: 0x1DFCD80 VA: 0x181DFD980
	public void ResetToPool() { }

	// RVA: 0x1DFD850 Offset: 0x1DFCC50 VA: 0x181DFD850 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(ResearchTable instance) { }

	// RVA: 0x1DFCEC0 Offset: 0x1DFC2C0 VA: 0x181DFCEC0
	public ResearchTable Copy() { }

	// RVA: 0x1DFD6D0 Offset: 0x1DFCAD0 VA: 0x181DFD6D0
	public static ResearchTable Deserialize(Stream stream) { }

	// RVA: 0x1DFCF30 Offset: 0x1DFC330 VA: 0x181DFCF30
	public static ResearchTable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DFD3D0 Offset: 0x1DFC7D0 VA: 0x181DFD3D0
	public static ResearchTable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DFD460 Offset: 0x1DFC860 VA: 0x181DFD460
	public static ResearchTable Deserialize(byte[] buffer) { }

	// RVA: 0x1DFD940 Offset: 0x1DFCD40 VA: 0x181DFD940
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DFDE50 Offset: 0x1DFD250 VA: 0x181DFDE50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DFDE70 Offset: 0x1DFD270 VA: 0x181DFDE70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ResearchTable previous) { }

	// RVA: 0x1DFD960 Offset: 0x1DFCD60 VA: 0x181DFD960 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DFD750 Offset: 0x1DFCB50 VA: 0x181DFD750
	public static ResearchTable Deserialize(byte[] buffer, ResearchTable instance, bool isDelta = False) { }

	// RVA: 0x1DFD580 Offset: 0x1DFC980 VA: 0x181DFD580
	public static ResearchTable Deserialize(Stream stream, ResearchTable instance, bool isDelta) { }

	// RVA: 0x1DFCFB0 Offset: 0x1DFC3B0 VA: 0x181DFCFB0
	public static ResearchTable DeserializeLengthDelimited(Stream stream, ResearchTable instance, bool isDelta) { }

	// RVA: 0x1DFD1D0 Offset: 0x1DFC5D0 VA: 0x181DFD1D0
	public static ResearchTable DeserializeLength(Stream stream, int length, ResearchTable instance, bool isDelta) { }

	// RVA: 0x1DFDA80 Offset: 0x1DFCE80 VA: 0x181DFDA80
	public static void SerializeDelta(Stream stream, ResearchTable instance, ResearchTable previous) { }

	// RVA: 0x1DFDD60 Offset: 0x1DFD160 VA: 0x181DFDD60
	public static void Serialize(Stream stream, ResearchTable instance) { }

	// RVA: 0x1DFDE40 Offset: 0x1DFD240 VA: 0x181DFDE40
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DFDE50 Offset: 0x1DFD250 VA: 0x181DFDE50
	public void ToProto(Stream stream) { }

	// RVA: 0x1DFDC50 Offset: 0x1DFD050 VA: 0x181DFDC50
	public static byte[] SerializeToBytes(ResearchTable instance) { }

	// RVA: 0x1DFDBA0 Offset: 0x1DFCFA0 VA: 0x181DFDBA0
	public static void SerializeLengthDelimited(Stream stream, ResearchTable instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class ResearchTable : StorageContainer // TypeDefIndex: 8634
{	// Fields
	public float researchFinishedTime; // 0x3D0
	public float researchCostFraction; // 0x3D4
	public float researchDuration; // 0x3D8
	public int requiredPaper; // 0x3DC
	public GameObjectRef researchStartEffect; // 0x3E0
	public GameObjectRef researchFailEffect; // 0x3E8
	public GameObjectRef researchSuccessEffect; // 0x3F0
	public ItemDefinition researchResource; // 0x3F8

	// Methods

	// RVA: 0x934920 Offset: 0x933D20 VA: 0x180934920 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x934A40 Offset: 0x933E40 VA: 0x180934A40 Slot: 27
	public override void ResetState() { }

	// RVA: 0x934B10 Offset: 0x933F10 VA: 0x180934B10
	public void TryResearch() { }

	// RVA: 0x934640 Offset: 0x933A40 VA: 0x180934640 Slot: 152
	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x4F2CB0 Offset: 0x4F20B0 VA: 0x1804F2CB0
	public bool IsResearching() { }

	// RVA: 0x934A10 Offset: 0x933E10 VA: 0x180934A10
	public int RarityMultiplier(Rarity rarity) { }

	// RVA: 0x934570 Offset: 0x933970 VA: 0x180934570
	public int GetBlueprintStacksize(Item sourceItem) { }

	// RVA: 0x934A60 Offset: 0x933E60 VA: 0x180934A60
	public int ScrapForResearch(Item item) { }

	// RVA: 0x934AC0 Offset: 0x933EC0 VA: 0x180934AC0
	public static int ScrapForResearch(ItemDefinition info) { }

	// RVA: 0x9347C0 Offset: 0x933BC0 VA: 0x1809347C0
	public bool IsItemResearchable(Item item) { }

	// RVA: 0x9348B0 Offset: 0x933CB0 VA: 0x1809348B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x934B50 Offset: 0x933F50 VA: 0x180934B50
	public void .ctor() { }

}

