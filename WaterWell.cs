public class WaterWell : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6343
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float pressure; // 0x14
	public float waterLevel; // 0x18

	// Methods

	// RVA: 0x1E4D670 Offset: 0x1E4CA70 VA: 0x181E4D670
	public static void ResetToPool(WaterWell instance) { }

	// RVA: 0x1E4D6F0 Offset: 0x1E4CAF0 VA: 0x181E4D6F0
	public void ResetToPool() { }

	// RVA: 0x1E4D530 Offset: 0x1E4C930 VA: 0x181E4D530 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB9660 Offset: 0x1DB8A60 VA: 0x181DB9660
	public void CopyTo(WaterWell instance) { }

	// RVA: 0x1E4C750 Offset: 0x1E4BB50 VA: 0x181E4C750
	public WaterWell Copy() { }

	// RVA: 0x1E4CFD0 Offset: 0x1E4C3D0 VA: 0x181E4CFD0
	public static WaterWell Deserialize(Stream stream) { }

	// RVA: 0x1E4C7C0 Offset: 0x1E4BBC0 VA: 0x181E4C7C0
	public static WaterWell DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E4CBD0 Offset: 0x1E4BFD0 VA: 0x181E4CBD0
	public static WaterWell DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E4D410 Offset: 0x1E4C810 VA: 0x181E4D410
	public static WaterWell Deserialize(byte[] buffer) { }

	// RVA: 0x1E4D630 Offset: 0x1E4CA30 VA: 0x181E4D630
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E4DC00 Offset: 0x1E4D000 VA: 0x181E4DC00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E4DC20 Offset: 0x1E4D020 VA: 0x181E4DC20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WaterWell previous) { }

	// RVA: 0x1E4D650 Offset: 0x1E4CA50 VA: 0x181E4D650 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E4D310 Offset: 0x1E4C710 VA: 0x181E4D310
	public static WaterWell Deserialize(byte[] buffer, WaterWell instance, bool isDelta = False) { }

	// RVA: 0x1E4D050 Offset: 0x1E4C450 VA: 0x181E4D050
	public static WaterWell Deserialize(Stream stream, WaterWell instance, bool isDelta) { }

	// RVA: 0x1E4C840 Offset: 0x1E4BC40 VA: 0x181E4C840
	public static WaterWell DeserializeLengthDelimited(Stream stream, WaterWell instance, bool isDelta) { }

	// RVA: 0x1E4CC60 Offset: 0x1E4C060 VA: 0x181E4CC60
	public static WaterWell DeserializeLength(Stream stream, int length, WaterWell instance, bool isDelta) { }

	// RVA: 0x1E4D770 Offset: 0x1E4CB70 VA: 0x181E4D770
	public static void SerializeDelta(Stream stream, WaterWell instance, WaterWell previous) { }

	// RVA: 0x1E4DAF0 Offset: 0x1E4CEF0 VA: 0x181E4DAF0
	public static void Serialize(Stream stream, WaterWell instance) { }

	// RVA: 0x1E4DBF0 Offset: 0x1E4CFF0 VA: 0x181E4DBF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E4DC00 Offset: 0x1E4D000 VA: 0x181E4DC00
	public void ToProto(Stream stream) { }

	// RVA: 0x1E4D9E0 Offset: 0x1E4CDE0 VA: 0x181E4D9E0
	public static byte[] SerializeToBytes(WaterWell instance) { }

	// RVA: 0x1E4D8F0 Offset: 0x1E4CCF0 VA: 0x181E4D8F0
	public static void SerializeLengthDelimited(Stream stream, WaterWell instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class WaterWell : LiquidContainer // TypeDefIndex: 8486
{	// Fields
	private Option __menuOption_Menu_Pump; // 0x3F8
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

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x89A250 Offset: 0x899650 VA: 0x18089A250 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x89AC20 Offset: 0x89A020 VA: 0x18089AC20 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x89A7C0 Offset: 0x899BC0 VA: 0x18089A7C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x89A590 Offset: 0x899990 VA: 0x18089A590 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x89A560 Offset: 0x899960 VA: 0x18089A560
	public float GetWaterAmount() { }

	[BaseEntity.Menu] // RVA: 0x9CA40 Offset: 0x9BE40 VA: 0x18009CA40
	[BaseEntity.Menu.Description] // RVA: 0x9CA40 Offset: 0x9BE40 VA: 0x18009CA40
	[BaseEntity.Menu.Icon] // RVA: 0x9CA40 Offset: 0x9BE40 VA: 0x18009CA40
	[BaseEntity.Menu.ShowIf] // RVA: 0x9CA40 Offset: 0x9BE40 VA: 0x18009CA40
	// RVA: 0x89A780 Offset: 0x899B80 VA: 0x18089A780
	public void Menu_Pump(BasePlayer player) { }

	// RVA: 0x89A5F0 Offset: 0x8999F0 VA: 0x18089A5F0
	public bool Menu_Pump_ShowIf(BasePlayer player) { }

	// RVA: 0x89A8B0 Offset: 0x899CB0 VA: 0x18089A8B0 Slot: 164
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x89A1F0 Offset: 0x8995F0 VA: 0x18089A1F0 Slot: 168
	public override bool DrinkEligable(BasePlayer player) { }

	// RVA: 0x89AA10 Offset: 0x899E10 VA: 0x18089AA10
	public void Update() { }

	// RVA: 0x89ABF0 Offset: 0x899FF0 VA: 0x18089ABF0
	public void .ctor() { }

}

