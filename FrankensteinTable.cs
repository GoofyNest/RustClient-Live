public class FrankensteinTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6313
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<int> itemIds; 


	public static void ResetToPool(FrankensteinTable instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(FrankensteinTable instance) { }

	public FrankensteinTable Copy() { }

	public static FrankensteinTable Deserialize(Stream stream) { }

	public static FrankensteinTable DeserializeLengthDelimited(Stream stream) { }

	public static FrankensteinTable DeserializeLength(Stream stream, int length) { }

	public static FrankensteinTable Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, FrankensteinTable previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static FrankensteinTable Deserialize(byte[] buffer, FrankensteinTable instance, bool isDelta = False) { }

	public static FrankensteinTable Deserialize(Stream stream, FrankensteinTable instance, bool isDelta) { }

	public static FrankensteinTable DeserializeLengthDelimited(Stream stream, FrankensteinTable instance, bool isDelta) { }

	public static FrankensteinTable DeserializeLength(Stream stream, int length, FrankensteinTable instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, FrankensteinTable instance, FrankensteinTable previous) { }

	public static void Serialize(Stream stream, FrankensteinTable instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(FrankensteinTable instance) { }

	public static void SerializeLengthDelimited(Stream stream, FrankensteinTable instance) { }

	public void .ctor() { }

}

public class FrankensteinTable : StorageContainer // TypeDefIndex: 10097
{
	private Option __menuOption_MenuSleepFrankenstein; 
	private Option __menuOption_MenuWakeFrankenstein; 
	public GameObjectRef FrankensteinPrefab; 
	public Transform SpawnLocation; 
	public ItemDefinition WeaponItem; 
	public List<ItemDefinition> HeadItems; 
	public List<ItemDefinition> TorsoItems; 
	public List<ItemDefinition> LegItems; 
	[HideInInspector] 
	public List<ItemDefinition> ItemsToUse; 
	public FrankensteinTableVisuals TableVisuals; 
	[HeaderAttribute] 
	public float TableDownDuration; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsHeadItem(ItemDefinition itemDef) { }

	public bool IsTorsoItem(ItemDefinition itemDef) { }

	public bool IsLegsItem(ItemDefinition itemDef) { }

	public void Create() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.ShowIf] 
	[BaseEntity.Menu.Icon] 
	public void MenuWakeFrankenstein(BasePlayer ply) { }

	public bool CanWake(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.ShowIf] 
	[BaseEntity.Menu.Icon] 
	public void MenuSleepFrankenstein(BasePlayer ply) { }

	public bool CanSleep(BasePlayer player) { }

	public bool HasValidItems(ItemContainer container) { }

	public List<ItemDefinition> GetValidItems(ItemContainer container) { }

	public bool HasAllValidItems(List<ItemDefinition> items) { }

	private void CheckItem(ItemDefinition item, List<ItemDefinition> itemList, List<ItemDefinition> validItems, ref bool set) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.RPC_Client] 
	public void CL_WakeFrankenstein(BaseEntity.RPCMessage msg) { }

	public void RefreshVisuals() { }

	public void .ctor() { }

}

