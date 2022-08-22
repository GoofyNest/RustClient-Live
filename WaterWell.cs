public class WaterWell : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6343
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float pressure; // 0x14
	public float waterLevel; // 0x18


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

public class WaterWell : LiquidContainer // TypeDefIndex: 8486
{	private Option __menuOption_Menu_Pump; // 0x3F8
	public Animator animator; // 0x450
	private const BaseEntity.Flags Pumping = 256;
	private const BaseEntity.Flags WaterFlow = 512;
	public float caloriesPerPump; // 0x458
	public float pressurePerPump; // 0x45C
	public float pressureForProduction; // 0x460
	public float currentPressure; // 0x464
	public int waterPerPump; // 0x468
	public GameObject waterLevelObj; // 0x470
	public float waterLevelObjFullOffset; // 0x478
	private float cachedWaterLevel; // 0x47C

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public float GetWaterAmount() { }

	[BaseEntity.Menu] // RVA: 0x9CA40 Offset: 0x9BE40 VA: 0x18009CA40
	[BaseEntity.Menu.Description] // RVA: 0x9CA40 Offset: 0x9BE40 VA: 0x18009CA40
	[BaseEntity.Menu.Icon] // RVA: 0x9CA40 Offset: 0x9BE40 VA: 0x18009CA40
	[BaseEntity.Menu.ShowIf] // RVA: 0x9CA40 Offset: 0x9BE40 VA: 0x18009CA40
	public void Menu_Pump(BasePlayer player) { }

	public bool Menu_Pump_ShowIf(BasePlayer player) { }

	public override bool ShouldShowLootMenus() { }

	public override bool DrinkEligable(BasePlayer player) { }

	public void Update() { }

	public void .ctor() { }

}

