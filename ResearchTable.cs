public class ResearchTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6321
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float researchTimeLeft; // 0x14


	public static void ResetToPool(ResearchTable instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ResearchTable instance) { }

	public ResearchTable Copy() { }

	public static ResearchTable Deserialize(Stream stream) { }

	public static ResearchTable DeserializeLengthDelimited(Stream stream) { }

	public static ResearchTable DeserializeLength(Stream stream, int length) { }

	public static ResearchTable Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ResearchTable previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ResearchTable Deserialize(byte[] buffer, ResearchTable instance, bool isDelta = False) { }

	public static ResearchTable Deserialize(Stream stream, ResearchTable instance, bool isDelta) { }

	public static ResearchTable DeserializeLengthDelimited(Stream stream, ResearchTable instance, bool isDelta) { }

	public static ResearchTable DeserializeLength(Stream stream, int length, ResearchTable instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ResearchTable instance, ResearchTable previous) { }

	public static void Serialize(Stream stream, ResearchTable instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ResearchTable instance) { }

	public static void SerializeLengthDelimited(Stream stream, ResearchTable instance) { }

	public void .ctor() { }

}

public class ResearchTable : StorageContainer // TypeDefIndex: 8634
{	public float researchFinishedTime; // 0x3D0
	public float researchCostFraction; // 0x3D4
	public float researchDuration; // 0x3D8
	public int requiredPaper; // 0x3DC
	public GameObjectRef researchStartEffect; // 0x3E0
	public GameObjectRef researchFailEffect; // 0x3E8
	public GameObjectRef researchSuccessEffect; // 0x3F0
	public ItemDefinition researchResource; // 0x3F8


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void ResetState() { }

	public void TryResearch() { }

	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	public bool IsResearching() { }

	public int RarityMultiplier(Rarity rarity) { }

	public int GetBlueprintStacksize(Item sourceItem) { }

	public int ScrapForResearch(Item item) { }

	public static int ScrapForResearch(ItemDefinition info) { }

	public bool IsItemResearchable(Item item) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

