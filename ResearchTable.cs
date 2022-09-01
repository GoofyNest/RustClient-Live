public class ResearchTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6322
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float researchTimeLeft; 


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

public class ResearchTable : StorageContainer // TypeDefIndex: 8637
{
	public float researchFinishedTime; 
	public float researchCostFraction; 
	public float researchDuration; 
	public int requiredPaper; 
	public GameObjectRef researchStartEffect; 
	public GameObjectRef researchFailEffect; 
	public GameObjectRef researchSuccessEffect; 
	public ItemDefinition researchResource; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void ResetState() { }

	public void TryResearch() { }

	public bool IsResearching() { }

	public int RarityMultiplier(Rarity rarity) { }

	public int GetBlueprintStacksize(Item sourceItem) { }

	public int ScrapForResearch(Item item) { }

	public static int ScrapForResearch(ItemDefinition info) { }

	public bool IsItemResearchable(Item item) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

