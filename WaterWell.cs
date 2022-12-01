public class WaterWell : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6352
{
	public bool ShouldPool;
	private bool _disposed;
	public float pressure;
	public float waterLevel;


	public static void ResetToPool(WaterWell instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(WaterWell instance) { }

	public WaterWell Copy() { }

	public static WaterWell Deserialize(Stream stream) { }

	public static WaterWell DeserializeLengthDelimited(Stream stream) { }

	public static WaterWell DeserializeLength(Stream stream, int length) { }

	public static WaterWell Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, WaterWell previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static WaterWell Deserialize(byte[] buffer, WaterWell instance, bool isDelta = False) { }

	public static WaterWell Deserialize(Stream stream, WaterWell instance, bool isDelta) { }

	public static WaterWell DeserializeLengthDelimited(Stream stream, WaterWell instance, bool isDelta) { }

	public static WaterWell DeserializeLength(Stream stream, int length, WaterWell instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, WaterWell instance, WaterWell previous) { }

	public static void Serialize(Stream stream, WaterWell instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(WaterWell instance) { }

	public static void SerializeLengthDelimited(Stream stream, WaterWell instance) { }

	public void .ctor() { }

}

public class WaterWell : LiquidContainer // TypeDefIndex: 10206
{
	private Option __menuOption_Menu_Pump;
	public Animator animator;
	private const BaseEntity.Flags Pumping = 256;
	private const BaseEntity.Flags WaterFlow = 512;
	public float caloriesPerPump;
	public float pressurePerPump;
	public float pressureForProduction;
	public float currentPressure;
	public int waterPerPump;
	public GameObject waterLevelObj;
	public float waterLevelObjFullOffset;
	private float cachedWaterLevel;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public float GetWaterAmount() { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_Pump(BasePlayer player) { }

	public bool Menu_Pump_ShowIf(BasePlayer player) { }

	public override bool ShouldShowLootMenus() { }

	public override bool DrinkEligable(BasePlayer player) { }

	public void Update() { }

	public void .ctor() { }

}

