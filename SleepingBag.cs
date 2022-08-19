public class SleepingBag : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6316
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18
	public ulong deployerID; // 0x20

	// Methods

	// RVA: 0x1DA9100 Offset: 0x1DA8500 VA: 0x181DA9100
	public static void ResetToPool(SleepingBag instance) { }

	// RVA: 0x1DA9050 Offset: 0x1DA8450 VA: 0x181DA9050
	public void ResetToPool() { }

	// RVA: 0x1DA8EF0 Offset: 0x1DA82F0 VA: 0x181DA8EF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DA81B0 Offset: 0x1DA75B0 VA: 0x181DA81B0
	public void CopyTo(SleepingBag instance) { }

	// RVA: 0x1DA81F0 Offset: 0x1DA75F0 VA: 0x181DA81F0
	public SleepingBag Copy() { }

	// RVA: 0x1DA8830 Offset: 0x1DA7C30 VA: 0x181DA8830
	public static SleepingBag Deserialize(Stream stream) { }

	// RVA: 0x1DA8280 Offset: 0x1DA7680 VA: 0x181DA8280
	public static SleepingBag DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DA87A0 Offset: 0x1DA7BA0 VA: 0x181DA87A0
	public static SleepingBag DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DA8C70 Offset: 0x1DA8070 VA: 0x181DA8C70
	public static SleepingBag Deserialize(byte[] buffer) { }

	// RVA: 0x1DA9010 Offset: 0x1DA8410 VA: 0x181DA9010
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DA9660 Offset: 0x1DA8A60 VA: 0x181DA9660 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DA9680 Offset: 0x1DA8A80 VA: 0x181DA9680 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SleepingBag previous) { }

	// RVA: 0x1DA9030 Offset: 0x1DA8430 VA: 0x181DA9030 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DA8B70 Offset: 0x1DA7F70 VA: 0x181DA8B70
	public static SleepingBag Deserialize(byte[] buffer, SleepingBag instance, bool isDelta = False) { }

	// RVA: 0x1DA89F0 Offset: 0x1DA7DF0 VA: 0x181DA89F0
	public static SleepingBag Deserialize(Stream stream, SleepingBag instance, bool isDelta) { }

	// RVA: 0x1DA8300 Offset: 0x1DA7700 VA: 0x181DA8300
	public static SleepingBag DeserializeLengthDelimited(Stream stream, SleepingBag instance, bool isDelta) { }

	// RVA: 0x1DA8560 Offset: 0x1DA7960 VA: 0x181DA8560
	public static SleepingBag DeserializeLength(Stream stream, int length, SleepingBag instance, bool isDelta) { }

	// RVA: 0x1DA91B0 Offset: 0x1DA85B0 VA: 0x181DA91B0
	public static void SerializeDelta(Stream stream, SleepingBag instance, SleepingBag previous) { }

	// RVA: 0x1DA9500 Offset: 0x1DA8900 VA: 0x181DA9500
	public static void Serialize(Stream stream, SleepingBag instance) { }

	// RVA: 0x1DA9650 Offset: 0x1DA8A50 VA: 0x181DA9650
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DA9660 Offset: 0x1DA8A60 VA: 0x181DA9660
	public void ToProto(Stream stream) { }

	// RVA: 0x1DA93F0 Offset: 0x1DA87F0 VA: 0x181DA93F0
	public static byte[] SerializeToBytes(SleepingBag instance) { }

	// RVA: 0x1DA9340 Offset: 0x1DA8740 VA: 0x181DA9340
	public static void SerializeLengthDelimited(Stream stream, SleepingBag instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class SleepingBag : DecayEntity // TypeDefIndex: 8446
{	// Fields
	private Option __menuOption_Menu_AssignToFriend; // 0x258
	private Option __menuOption_Menu_CloseDoor; // 0x2B0
	private Option __menuOption_Menu_MakeBed; // 0x308
	private Option __menuOption_Menu_MakePrivate; // 0x360
	private Option __menuOption_Menu_MakePublic; // 0x3B8
	public ulong deployerUserID; // 0x410
	public GameObject renameDialog; // 0x418
	public GameObject assignDialog; // 0x420
	public float secondsBetweenReuses; // 0x428
	public string niceName; // 0x430
	public Vector3 spawnOffset; // 0x438
	public RespawnInformation.SpawnOptions.RespawnType RespawnType; // 0x444
	public bool isStatic; // 0x448
	public bool canBePublic; // 0x449
	public const BaseEntity.Flags IsPublicFlag = 512;

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x5C25C0 Offset: 0x5C19C0 VA: 0x1805C25C0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x5C3770 Offset: 0x5C2B70 VA: 0x1805C3770 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x5C3630 Offset: 0x5C2A30 VA: 0x1805C3630 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5264E0 Offset: 0x5258E0 VA: 0x1805264E0
	public bool IsPublic() { }

	// RVA: 0x5C31C0 Offset: 0x5C25C0 VA: 0x1805C31C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5C2500 Offset: 0x5C1900 VA: 0x1805C2500
	public void ClientRename(string newName) { }

	[BaseEntity.Menu] // RVA: 0x844E0 Offset: 0x838E0 VA: 0x1800844E0
	[BaseEntity.Menu.Icon] // RVA: 0x844E0 Offset: 0x838E0 VA: 0x1800844E0
	[BaseEntity.Menu.Description] // RVA: 0x844E0 Offset: 0x838E0 VA: 0x1800844E0
	[BaseEntity.Menu.ShowIf] // RVA: 0x844E0 Offset: 0x838E0 VA: 0x1800844E0
	// RVA: 0x5C3360 Offset: 0x5C2760 VA: 0x1805C3360
	public void Menu_CloseDoor(BasePlayer player) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 145
	public virtual bool CanRename_Test(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x847F0 Offset: 0x83BF0 VA: 0x1800847F0
	[BaseEntity.Menu.Icon] // RVA: 0x847F0 Offset: 0x83BF0 VA: 0x1800847F0
	[BaseEntity.Menu.Description] // RVA: 0x847F0 Offset: 0x83BF0 VA: 0x1800847F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x847F0 Offset: 0x83BF0 VA: 0x1800847F0
	// RVA: 0x5C3270 Offset: 0x5C2670 VA: 0x1805C3270
	public void Menu_AssignToFriend(BasePlayer player) { }

	// RVA: 0x5C3240 Offset: 0x5C2640 VA: 0x1805C3240 Slot: 146
	public virtual bool Menu_AssignToFriend_Test(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x84AB0 Offset: 0x83EB0 VA: 0x180084AB0
	[BaseEntity.Menu.Icon] // RVA: 0x84AB0 Offset: 0x83EB0 VA: 0x180084AB0
	[BaseEntity.Menu.Description] // RVA: 0x84AB0 Offset: 0x83EB0 VA: 0x180084AB0
	[BaseEntity.Menu.ShowIf] // RVA: 0x84AB0 Offset: 0x83EB0 VA: 0x180084AB0
	// RVA: 0x5C35E0 Offset: 0x5C29E0 VA: 0x1805C35E0
	public void Menu_MakePublic(BasePlayer player) { }

	// RVA: 0x5C3580 Offset: 0x5C2980 VA: 0x1805C3580
	public bool Menu_MakePublic_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x84FC0 Offset: 0x843C0 VA: 0x180084FC0
	[BaseEntity.Menu.Icon] // RVA: 0x84FC0 Offset: 0x843C0 VA: 0x180084FC0
	[BaseEntity.Menu.Description] // RVA: 0x84FC0 Offset: 0x843C0 VA: 0x180084FC0
	[BaseEntity.Menu.ShowIf] // RVA: 0x84FC0 Offset: 0x843C0 VA: 0x180084FC0
	// RVA: 0x5C3530 Offset: 0x5C2930 VA: 0x1805C3530
	public void Menu_MakePrivate(BasePlayer player) { }

	// RVA: 0x5C34B0 Offset: 0x5C28B0 VA: 0x1805C34B0 Slot: 147
	public virtual bool Menu_MakePrivate_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x85360 Offset: 0x84760 VA: 0x180085360
	[BaseEntity.Menu.Icon] // RVA: 0x85360 Offset: 0x84760 VA: 0x180085360
	[BaseEntity.Menu.Description] // RVA: 0x85360 Offset: 0x84760 VA: 0x180085360
	[BaseEntity.Menu.ShowIf] // RVA: 0x85360 Offset: 0x84760 VA: 0x180085360
	// RVA: 0x5C3470 Offset: 0x5C2870 VA: 0x1805C3470
	public void Menu_MakeBed(BasePlayer player) { }

	// RVA: 0x5C3410 Offset: 0x5C2810 VA: 0x1805C3410 Slot: 148
	public virtual bool Menu_MakeBed_ShowIf(BasePlayer player) { }

	// RVA: 0x5C2550 Offset: 0x5C1950 VA: 0x1805C2550 Slot: 64
	public override Info GetMenuInformation(GameObject primaryObject, BasePlayer player) { }

	// RVA: 0x5C24B0 Offset: 0x5C18B0 VA: 0x1805C24B0 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x5C1570 Offset: 0x5C0970 VA: 0x1805C1570
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5C3720 Offset: 0x5C2B20 VA: 0x1805C3720
	private void <Menu_AssignToFriend>b__24_0(ulong id, string steamName) { }

}

