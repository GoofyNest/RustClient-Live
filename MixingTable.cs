public class MixingTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6386
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float totalMixTime; // 0x14
	public float remainingMixTime; // 0x18

	// Methods

	// RVA: 0x1F4E950 Offset: 0x1F4DD50 VA: 0x181F4E950
	public static void ResetToPool(MixingTable instance) { }

	// RVA: 0x1F4E8D0 Offset: 0x1F4DCD0 VA: 0x181F4E8D0
	public void ResetToPool() { }

	// RVA: 0x1F4E630 Offset: 0x1F4DA30 VA: 0x181F4E630 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB9660 Offset: 0x1DB8A60 VA: 0x181DB9660
	public void CopyTo(MixingTable instance) { }

	// RVA: 0x1F4D830 Offset: 0x1F4CC30 VA: 0x181F4D830
	public MixingTable Copy() { }

	// RVA: 0x1F4E470 Offset: 0x1F4D870 VA: 0x181F4E470
	public static MixingTable Deserialize(Stream stream) { }

	// RVA: 0x1F4DAF0 Offset: 0x1F4CEF0 VA: 0x181F4DAF0
	public static MixingTable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F4DDA0 Offset: 0x1F4D1A0 VA: 0x181F4DDA0
	public static MixingTable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F4DE30 Offset: 0x1F4D230 VA: 0x181F4DE30
	public static MixingTable Deserialize(byte[] buffer) { }

	// RVA: 0x1F4E730 Offset: 0x1F4DB30 VA: 0x181F4E730
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F4EE20 Offset: 0x1F4E220 VA: 0x181F4EE20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F4EE40 Offset: 0x1F4E240 VA: 0x181F4EE40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MixingTable previous) { }

	// RVA: 0x1F4E8B0 Offset: 0x1F4DCB0 VA: 0x181F4E8B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F4E0A0 Offset: 0x1F4D4A0 VA: 0x181F4E0A0
	public static MixingTable Deserialize(byte[] buffer, MixingTable instance, bool isDelta = False) { }

	// RVA: 0x1F4E2F0 Offset: 0x1F4D6F0 VA: 0x181F4E2F0
	public static MixingTable Deserialize(Stream stream, MixingTable instance, bool isDelta) { }

	// RVA: 0x1F4D8A0 Offset: 0x1F4CCA0 VA: 0x181F4D8A0
	public static MixingTable DeserializeLengthDelimited(Stream stream, MixingTable instance, bool isDelta) { }

	// RVA: 0x1F4DB70 Offset: 0x1F4CF70 VA: 0x181F4DB70
	public static MixingTable DeserializeLength(Stream stream, int length, MixingTable instance, bool isDelta) { }

	// RVA: 0x1F4E9D0 Offset: 0x1F4DDD0 VA: 0x181F4E9D0
	public static void SerializeDelta(Stream stream, MixingTable instance, MixingTable previous) { }

	// RVA: 0x1F4ED10 Offset: 0x1F4E110 VA: 0x181F4ED10
	public static void Serialize(Stream stream, MixingTable instance) { }

	// RVA: 0x1F4EE10 Offset: 0x1F4E210 VA: 0x181F4EE10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F4EE20 Offset: 0x1F4E220 VA: 0x181F4EE20
	public void ToProto(Stream stream) { }

	// RVA: 0x1F4EC00 Offset: 0x1F4E000 VA: 0x181F4EC00
	public static byte[] SerializeToBytes(MixingTable instance) { }

	// RVA: 0x1F4EB50 Offset: 0x1F4DF50 VA: 0x181F4EB50
	public static void SerializeLengthDelimited(Stream stream, MixingTable instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class MixingTable : StorageContainer // TypeDefIndex: 8411
{	// Fields
	private Option __menuOption_Menu_TurnOff; // 0x3D0
	private Option __menuOption_Menu_TurnOn; // 0x428
	public GameObject Particles; // 0x480
	public RecipeList Recipes; // 0x488
	public bool OnlyAcceptValidIngredients; // 0x490
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <RemainingMixTime>k__BackingField; // 0x494
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <TotalMixTime>k__BackingField; // 0x498
	private float lastTickTimestamp; // 0x49C
	private List<Item> inventoryItems; // 0x4A0

	// Properties
	public override bool HasMenuOptions { get; }
	public float RemainingMixTime { get; set; }
	public float TotalMixTime { get; set; }
	public float ClientEstimatedRemainingMixTime { get; }
	public float ProgressFraction { get; }

	// Methods

	// RVA: 0x7697E0 Offset: 0x768BE0 VA: 0x1807697E0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x76A3D0 Offset: 0x7697D0 VA: 0x18076A3D0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x76A1B0 Offset: 0x7695B0 VA: 0x18076A1B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x76A600 Offset: 0x769A00 VA: 0x18076A600
	public float get_RemainingMixTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x76A620 Offset: 0x769A20 VA: 0x18076A620
	private void set_RemainingMixTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x76A610 Offset: 0x769A10 VA: 0x18076A610
	public float get_TotalMixTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x76A630 Offset: 0x769A30 VA: 0x18076A630
	private void set_TotalMixTime(float value) { }

	// RVA: 0x76A330 Offset: 0x769730 VA: 0x18076A330
	public float get_ClientEstimatedRemainingMixTime() { }

	// RVA: 0x76A520 Offset: 0x769920 VA: 0x18076A520
	public float get_ProgressFraction() { }

	[BaseEntity.Menu] // RVA: 0xEDEC0 Offset: 0xED2C0 VA: 0x1800EDEC0
	[BaseEntity.Menu.Description] // RVA: 0xEDEC0 Offset: 0xED2C0 VA: 0x1800EDEC0
	[BaseEntity.Menu.Icon] // RVA: 0xEDEC0 Offset: 0xED2C0 VA: 0x1800EDEC0
	[BaseEntity.Menu.ShowIf] // RVA: 0xEDEC0 Offset: 0xED2C0 VA: 0x1800EDEC0
	// RVA: 0x76A160 Offset: 0x769560 VA: 0x18076A160
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x76A0A0 Offset: 0x7694A0 VA: 0x18076A0A0
	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xEE2D0 Offset: 0xED6D0 VA: 0x1800EE2D0
	[BaseEntity.Menu.Description] // RVA: 0xEE2D0 Offset: 0xED6D0 VA: 0x1800EE2D0
	[BaseEntity.Menu.Icon] // RVA: 0xEE2D0 Offset: 0xED6D0 VA: 0x1800EE2D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xEE2D0 Offset: 0xED6D0 VA: 0x1800EE2D0
	// RVA: 0x76A050 Offset: 0x769450 VA: 0x18076A050
	public void Menu_TurnOff(BasePlayer player) { }

	// RVA: 0x769F90 Offset: 0x769390 VA: 0x180769F90
	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	// RVA: 0x769760 Offset: 0x768B60 VA: 0x180769760
	private int GetItemWaterAmount(Item item) { }

	// RVA: 0x769E80 Offset: 0x769280 VA: 0x180769E80 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x769D30 Offset: 0x769130 VA: 0x180769D30
	public List<Item> GetOrderedContainerItems(ItemContainer container, out bool itemsAreContiguous) { }

	// RVA: 0x76A2A0 Offset: 0x7696A0 VA: 0x18076A2A0
	public void .ctor() { }

}

