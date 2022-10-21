public class WorldItem : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6309
{
	public bool ShouldPool; 
	private bool _disposed; 
	public Item item; 


	public static void ResetToPool(WorldItem instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(WorldItem instance) { }

	public WorldItem Copy() { }

	public static WorldItem Deserialize(Stream stream) { }

	public static WorldItem DeserializeLengthDelimited(Stream stream) { }

	public static WorldItem DeserializeLength(Stream stream, int length) { }

	public static WorldItem Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, WorldItem previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static WorldItem Deserialize(byte[] buffer, WorldItem instance, bool isDelta = False) { }

	public static WorldItem Deserialize(Stream stream, WorldItem instance, bool isDelta) { }

	public static WorldItem DeserializeLengthDelimited(Stream stream, WorldItem instance, bool isDelta) { }

	public static WorldItem DeserializeLength(Stream stream, int length, WorldItem instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, WorldItem instance, WorldItem previous) { }

	public static void Serialize(Stream stream, WorldItem instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(WorldItem instance) { }

	public static void SerializeLengthDelimited(Stream stream, WorldItem instance) { }

	public void .ctor() { }

}

public class WorldItem : BaseEntity // TypeDefIndex: 10377
{
	[HeaderAttribute] 
	public bool allowPickup; 
	public Item item; 

	public override BaseEntity.TraitFlag Traits { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	protected override void ClientInit(Entity info) { }

	[BaseEntity.RPC_Client] 
	public void UpdateItem(BaseEntity.RPCMessage packet) { }

	[BaseEntity.RPC_Client] 
	public void PickupSound(BaseEntity.RPCMessage msg) { }

	public virtual Vector3 IdealMenuPosition(BasePlayer playerUser) { }

	public override Info GetMenuInformation(GameObject primaryObject, BasePlayer player) { }

	public override List<Option> GetMenuItems(BasePlayer player) { }

	protected override void DoClientDestroy() { }

	public override Item GetItem() { }

	public void InitializeItem(Item in_item) { }

	public void RemoveItem() { }

	public void DestroyItem() { }

	protected virtual void OnItemDirty(Item in_item) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override BaseEntity.TraitFlag get_Traits() { }

	public override string ToString() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	private void <GetMenuItems>b__6_0(BasePlayer ply) { }

}

