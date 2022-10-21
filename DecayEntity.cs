public class DecayEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6340
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float decayTimer; 
	public uint buildingID; 
	public float upkeepTimer; 


	public static void ResetToPool(DecayEntity instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(DecayEntity instance) { }

	public DecayEntity Copy() { }

	public static DecayEntity Deserialize(Stream stream) { }

	public static DecayEntity DeserializeLengthDelimited(Stream stream) { }

	public static DecayEntity DeserializeLength(Stream stream, int length) { }

	public static DecayEntity Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, DecayEntity previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static DecayEntity Deserialize(byte[] buffer, DecayEntity instance, bool isDelta = False) { }

	public static DecayEntity Deserialize(Stream stream, DecayEntity instance, bool isDelta) { }

	public static DecayEntity DeserializeLengthDelimited(Stream stream, DecayEntity instance, bool isDelta) { }

	public static DecayEntity DeserializeLength(Stream stream, int length, DecayEntity instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, DecayEntity instance, DecayEntity previous) { }

	public static void Serialize(Stream stream, DecayEntity instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(DecayEntity instance) { }

	public static void SerializeLengthDelimited(Stream stream, DecayEntity instance) { }

	public void .ctor() { }

}

public class DecayEntity : BaseCombatEntity // TypeDefIndex: 11249
{
	public GameObjectRef debrisPrefab; 
	public uint buildingID; 
	private Upkeep upkeep; 


	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void ResetState() { }

	public void AttachToBuilding(uint id) { }

	public BuildingManager.Building GetBuilding() { }

	public override BuildingPrivlidge GetBuildingPrivilege() { }

	public void CalculateUpkeepCostAmounts(List<ItemAmount> itemAmounts, float multiplier) { }

	protected override void ClientInit(Entity info) { }

	protected override void DoClientDestroy() { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public void .ctor() { }

}

