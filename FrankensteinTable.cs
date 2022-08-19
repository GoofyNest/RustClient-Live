public class FrankensteinTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6309
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> itemIds; // 0x18

	// Methods

	// RVA: 0x1D55CD0 Offset: 0x1D550D0 VA: 0x181D55CD0
	public static void ResetToPool(FrankensteinTable instance) { }

	// RVA: 0x1D55DB0 Offset: 0x1D551B0 VA: 0x181D55DB0
	public void ResetToPool() { }

	// RVA: 0x1D55B40 Offset: 0x1D54F40 VA: 0x181D55B40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D54E50 Offset: 0x1D54250 VA: 0x181D54E50
	public void CopyTo(FrankensteinTable instance) { }

	// RVA: 0x1D54F70 Offset: 0x1D54370 VA: 0x181D54F70
	public FrankensteinTable Copy() { }

	// RVA: 0x1D55900 Offset: 0x1D54D00 VA: 0x181D55900
	public static FrankensteinTable Deserialize(Stream stream) { }

	// RVA: 0x1D55360 Offset: 0x1D54760 VA: 0x181D55360
	public static FrankensteinTable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D55650 Offset: 0x1D54A50 VA: 0x181D55650
	public static FrankensteinTable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D556E0 Offset: 0x1D54AE0 VA: 0x181D556E0
	public static FrankensteinTable Deserialize(byte[] buffer) { }

	// RVA: 0x1D55C90 Offset: 0x1D55090 VA: 0x181D55C90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D56300 Offset: 0x1D55700 VA: 0x181D56300 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D56320 Offset: 0x1D55720 VA: 0x181D56320 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, FrankensteinTable previous) { }

	// RVA: 0x1D55CB0 Offset: 0x1D550B0 VA: 0x181D55CB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D55800 Offset: 0x1D54C00 VA: 0x181D55800
	public static FrankensteinTable Deserialize(byte[] buffer, FrankensteinTable instance, bool isDelta = False) { }

	// RVA: 0x1D55980 Offset: 0x1D54D80 VA: 0x181D55980
	public static FrankensteinTable Deserialize(Stream stream, FrankensteinTable instance, bool isDelta) { }

	// RVA: 0x1D550D0 Offset: 0x1D544D0 VA: 0x181D550D0
	public static FrankensteinTable DeserializeLengthDelimited(Stream stream, FrankensteinTable instance, bool isDelta) { }

	// RVA: 0x1D553E0 Offset: 0x1D547E0 VA: 0x181D553E0
	public static FrankensteinTable DeserializeLength(Stream stream, int length, FrankensteinTable instance, bool isDelta) { }

	// RVA: 0x1D55E90 Offset: 0x1D55290 VA: 0x181D55E90
	public static void SerializeDelta(Stream stream, FrankensteinTable instance, FrankensteinTable previous) { }

	// RVA: 0x1D561A0 Offset: 0x1D555A0 VA: 0x181D561A0
	public static void Serialize(Stream stream, FrankensteinTable instance) { }

	// RVA: 0x1D562F0 Offset: 0x1D556F0 VA: 0x181D562F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D56300 Offset: 0x1D55700 VA: 0x181D56300
	public void ToProto(Stream stream) { }

	// RVA: 0x1D56090 Offset: 0x1D55490 VA: 0x181D56090
	public static byte[] SerializeToBytes(FrankensteinTable instance) { }

	// RVA: 0x1D55FE0 Offset: 0x1D553E0 VA: 0x181D55FE0
	public static void SerializeLengthDelimited(Stream stream, FrankensteinTable instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class FrankensteinTable : StorageContainer // TypeDefIndex: 8392
{	// Fields
	private Option __menuOption_MenuSleepFrankenstein; // 0x3D0
	private Option __menuOption_MenuWakeFrankenstein; // 0x428
	public GameObjectRef FrankensteinPrefab; // 0x480
	public Transform SpawnLocation; // 0x488
	public ItemDefinition WeaponItem; // 0x490
	public List<ItemDefinition> HeadItems; // 0x498
	public List<ItemDefinition> TorsoItems; // 0x4A0
	public List<ItemDefinition> LegItems; // 0x4A8
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public List<ItemDefinition> ItemsToUse; // 0x4B0
	public FrankensteinTableVisuals TableVisuals; // 0x4B8
	[HeaderAttribute] // RVA: 0xDFAC0 Offset: 0xDEEC0 VA: 0x1800DFAC0
	public float TableDownDuration; // 0x4C0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x6F0140 Offset: 0x6EF540 VA: 0x1806F0140 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6F1550 Offset: 0x6F0950 VA: 0x1806F1550 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6F0FA0 Offset: 0x6F03A0 VA: 0x1806F0FA0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6F0B90 Offset: 0x6EFF90 VA: 0x1806F0B90
	public bool IsHeadItem(ItemDefinition itemDef) { }

	// RVA: 0x6F0C50 Offset: 0x6F0050 VA: 0x1806F0C50
	public bool IsTorsoItem(ItemDefinition itemDef) { }

	// RVA: 0x6F0BF0 Offset: 0x6EFFF0 VA: 0x1806F0BF0
	public bool IsLegsItem(ItemDefinition itemDef) { }

	// RVA: 0x6F0100 Offset: 0x6EF500 VA: 0x1806F0100
	public void Create() { }

	[BaseEntity.Menu] // RVA: 0xDFC20 Offset: 0xDF020 VA: 0x1800DFC20
	[BaseEntity.Menu.Description] // RVA: 0xDFC20 Offset: 0xDF020 VA: 0x1800DFC20
	[BaseEntity.Menu.ShowIf] // RVA: 0xDFC20 Offset: 0xDF020 VA: 0x1800DFC20
	[BaseEntity.Menu.Icon] // RVA: 0xDFC20 Offset: 0xDF020 VA: 0x1800DFC20
	// RVA: 0x6F0F60 Offset: 0x6F0360 VA: 0x1806F0F60
	public void MenuWakeFrankenstein(BasePlayer ply) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	public bool CanWake(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDFE00 Offset: 0xDF200 VA: 0x1800DFE00
	[BaseEntity.Menu.Description] // RVA: 0xDFE00 Offset: 0xDF200 VA: 0x1800DFE00
	[BaseEntity.Menu.ShowIf] // RVA: 0xDFE00 Offset: 0xDF200 VA: 0x1800DFE00
	[BaseEntity.Menu.Icon] // RVA: 0xDFE00 Offset: 0xDF200 VA: 0x1800DFE00
	// RVA: 0x6F0F20 Offset: 0x6F0320 VA: 0x1806F0F20
	public void MenuSleepFrankenstein(BasePlayer ply) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	public bool CanSleep(BasePlayer player) { }

	// RVA: 0x6F0B70 Offset: 0x6EFF70 VA: 0x1806F0B70
	public bool HasValidItems(ItemContainer container) { }

	// RVA: 0x6F0640 Offset: 0x6EFA40 VA: 0x1806F0640
	public List<ItemDefinition> GetValidItems(ItemContainer container) { }

	// RVA: 0x6F0890 Offset: 0x6EFC90 VA: 0x1806F0890
	public bool HasAllValidItems(List<ItemDefinition> items) { }

	// RVA: 0x6F0060 Offset: 0x6EF460 VA: 0x1806F0060
	private void CheckItem(ItemDefinition item, List<ItemDefinition> itemList, List<ItemDefinition> validItems, ref bool set) { }

	// RVA: 0x6F0CB0 Offset: 0x6F00B0 VA: 0x1806F0CB0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x6EFFE0 Offset: 0x6EF3E0 VA: 0x1806EFFE0
	public void CL_WakeFrankenstein(BaseEntity.RPCMessage msg) { }

	// RVA: 0x6F1440 Offset: 0x6F0840 VA: 0x1806F1440
	public void RefreshVisuals() { }

	// RVA: 0x6F14F0 Offset: 0x6F08F0 VA: 0x1806F14F0
	public void .ctor() { }

}

