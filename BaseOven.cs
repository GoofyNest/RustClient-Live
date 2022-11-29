public class BaseOven : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6448
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float cookSpeed; 


	public static void ResetToPool(BaseOven instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(BaseOven instance) { }

	public BaseOven Copy() { }

	public static BaseOven Deserialize(Stream stream) { }

	public static BaseOven DeserializeLengthDelimited(Stream stream) { }

	public static BaseOven DeserializeLength(Stream stream, int length) { }

	public static BaseOven Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, BaseOven previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static BaseOven Deserialize(byte[] buffer, BaseOven instance, bool isDelta = False) { }

	public static BaseOven Deserialize(Stream stream, BaseOven instance, bool isDelta) { }

	public static BaseOven DeserializeLengthDelimited(Stream stream, BaseOven instance, bool isDelta) { }

	public static BaseOven DeserializeLength(Stream stream, int length, BaseOven instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, BaseOven instance, BaseOven previous) { }

	public static void Serialize(Stream stream, BaseOven instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(BaseOven instance) { }

	public static void SerializeLengthDelimited(Stream stream, BaseOven instance) { }

	public void .ctor() { }

}

public class BaseOven : StorageContainer, ISplashable // TypeDefIndex: 10050
{
	private Option __menuOption_SwitchOff; 
	private Option __menuOption_SwitchOn; 
	private static Dictionary<float, HashSet<ItemDefinition>> _materialOutputCache; 
	public BaseOven.TemperatureType temperature; 
	public BaseEntity.Menu.Option switchOnMenu; 
	public BaseEntity.Menu.Option switchOffMenu; 
	public ItemAmount[] startupContents; 
	public bool allowByproductCreation; 
	public ItemDefinition fuelType; 
	public bool canModFire; 
	public bool disabledBySplash; 
	public int smeltSpeed; 
	public int fuelSlots; 
	public int inputSlots; 
	public int outputSlots; 
	private float cookSpeedClient; 

	public override bool HasMenuOptions { get; }
	private float cookingTemperature { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public float GetSmeltingSpeed() { }

	private float get_cookingTemperature() { }

	private bool IsBurnableItem(Item item) { }

	private bool IsBurnableByproduct(Item item) { }

	private bool IsMaterialInput(Item item) { }

	private bool IsMaterialOutput(Item item) { }

	private bool IsOutputItem(Item item) { }

	private void BuildMaterialOutputCache() { }

	public override bool HasSlot(BaseEntity.Slot slot) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.ShowIf] 
	public void SwitchOn(BasePlayer player) { }

	protected virtual bool SwitchOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.ShowIf] 
	public void SwitchOff(BasePlayer player) { }

	protected virtual bool SwitchOff_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

public enum BaseOven.TemperatureType // TypeDefIndex: 10051
{
	public int value__; 
	public const BaseOven.TemperatureType Normal = 0;
	public const BaseOven.TemperatureType Warming = 1;
	public const BaseOven.TemperatureType Cooking = 2;
	public const BaseOven.TemperatureType Smelting = 3;
	public const BaseOven.TemperatureType Fractioning = 4;

}

private sealed class BaseOven.<>c // TypeDefIndex: 10052
{
	public static readonly BaseOven.<>c <>9; 
	public static Func<GameObject, BaseOven> <>9__28_0; 
	public static Func<BaseOven, bool> <>9__28_1; 
	public static Func<BaseOven, float> <>9__28_2; 


	private static void .cctor() { }

	public void .ctor() { }

	internal BaseOven <BuildMaterialOutputCache>

	internal bool <BuildMaterialOutputCache>

	internal float <BuildMaterialOutputCache>

}

