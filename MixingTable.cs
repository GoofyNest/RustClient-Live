public class MixingTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6387
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float totalMixTime; 
	public float remainingMixTime; 


	public static void ResetToPool(MixingTable instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(MixingTable instance) { }

	public MixingTable Copy() { }

	public static MixingTable Deserialize(Stream stream) { }

	public static MixingTable DeserializeLengthDelimited(Stream stream) { }

	public static MixingTable DeserializeLength(Stream stream, int length) { }

	public static MixingTable Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, MixingTable previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static MixingTable Deserialize(byte[] buffer, MixingTable instance, bool isDelta = False) { }

	public static MixingTable Deserialize(Stream stream, MixingTable instance, bool isDelta) { }

	public static MixingTable DeserializeLengthDelimited(Stream stream, MixingTable instance, bool isDelta) { }

	public static MixingTable DeserializeLength(Stream stream, int length, MixingTable instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, MixingTable instance, MixingTable previous) { }

	public static void Serialize(Stream stream, MixingTable instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(MixingTable instance) { }

	public static void SerializeLengthDelimited(Stream stream, MixingTable instance) { }

	public void .ctor() { }

}

public class MixingTable : StorageContainer // TypeDefIndex: 8413
{
	private Option __menuOption_Menu_TurnOff; 
	private Option __menuOption_Menu_TurnOn; 
	public GameObject Particles; 
	public RecipeList Recipes; 
	public bool OnlyAcceptValidIngredients; 
	[CompilerGeneratedAttribute] 
	private float <RemainingMixTime>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <TotalMixTime>k__BackingField; 
	private float lastTickTimestamp; 
	private List<Item> inventoryItems; 

	public override bool HasMenuOptions { get; }
	public float RemainingMixTime { get; set; }
	public float TotalMixTime { get; set; }
	public float ClientEstimatedRemainingMixTime { get; }
	public float ProgressFraction { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] 
	public float get_RemainingMixTime() { }

	[CompilerGeneratedAttribute] 
	private void set_RemainingMixTime(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_TotalMixTime() { }

	[CompilerGeneratedAttribute] 
	private void set_TotalMixTime(float value) { }

	public float get_ClientEstimatedRemainingMixTime() { }

	public float get_ProgressFraction() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_TurnOn(BasePlayer player) { }

	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_TurnOff(BasePlayer player) { }

	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	private int GetItemWaterAmount(Item item) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public List<Item> GetOrderedContainerItems(ItemContainer container, out bool itemsAreContiguous) { }

	public void .ctor() { }

}

