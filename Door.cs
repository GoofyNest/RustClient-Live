public class Door : AnimatedBuildingBlock, INotifyTrigger // TypeDefIndex: 8381
{	// Fields
	private Option __menuOption_Menu_CloseDoor; // 0x270
	private Option __menuOption_Menu_KnockDoor; // 0x2C8
	private Option __menuOption_Menu_OpenDoor; // 0x320
	private Option __menuOption_Menu_ToggleHatch; // 0x378
	public GameObjectRef knockEffect; // 0x3D0
	public bool canTakeLock; // 0x3D8
	public bool hasHatch; // 0x3D9
	public bool canTakeCloser; // 0x3DA
	public bool canTakeKnocker; // 0x3DB
	public bool canNpcOpen; // 0x3DC
	public bool canHandOpen; // 0x3DD
	public bool isSecurityDoor; // 0x3DE
	public TriggerNotify[] vehiclePhysBoxes; // 0x3E0
	public bool checkPhysBoxesOnOpen; // 0x3E8
	public SoundDefinition vehicleCollisionSfx; // 0x3F0
	public GameObject[] ClosedColliderRoots; // 0x3F8
	private static int openHash; // 0x0
	private static int closeHash; // 0x4

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAA88A0 Offset: 0xAA7CA0 VA: 0x180AA88A0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAAA380 Offset: 0xAA9780 VA: 0x180AAA380 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAA9CD0 Offset: 0xAA90D0 VA: 0x180AA9CD0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAAA120 Offset: 0xAA9520 VA: 0x180AAA120 Slot: 27
	public override void ResetState() { }

	// RVA: 0xAA9490 Offset: 0xAA8890 VA: 0x180AA9490 Slot: 85
	public override bool HasSlot(BaseEntity.Slot slot) { }

	// RVA: 0xAA8730 Offset: 0xAA7B30 VA: 0x180AA8730 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD8E40 Offset: 0xD8240 VA: 0x1800D8E40
	[BaseEntity.Menu.Description] // RVA: 0xD8E40 Offset: 0xD8240 VA: 0x1800D8E40
	[BaseEntity.Menu.Icon] // RVA: 0xD8E40 Offset: 0xD8240 VA: 0x1800D8E40
	[BaseEntity.Menu.ShowIf] // RVA: 0xD8E40 Offset: 0xD8240 VA: 0x1800D8E40
	[BaseEntity.Menu.UsableWhileWounded] // RVA: 0xD8E40 Offset: 0xD8240 VA: 0x1800D8E40
	// RVA: 0xAA9880 Offset: 0xAA8C80 VA: 0x180AA9880
	public void Menu_OpenDoor(BasePlayer player) { }

	// RVA: 0xAA9760 Offset: 0xAA8B60 VA: 0x180AA9760
	public void Menu_OpenDoor_Proxy(ref Option option) { }

	// RVA: 0xAA9720 Offset: 0xAA8B20 VA: 0x180AA9720
	public void Menu_OpenDoorStart() { }

	// RVA: 0xAA9840 Offset: 0xAA8C40 VA: 0x180AA9840
	public bool Menu_OpenDoor_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD9270 Offset: 0xD8670 VA: 0x1800D9270
	[BaseEntity.Menu.Description] // RVA: 0xD9270 Offset: 0xD8670 VA: 0x1800D9270
	[BaseEntity.Menu.Icon] // RVA: 0xD9270 Offset: 0xD8670 VA: 0x1800D9270
	[BaseEntity.Menu.ShowIf] // RVA: 0xD9270 Offset: 0xD8670 VA: 0x1800D9270
	[BaseEntity.Menu.UsableWhileWounded] // RVA: 0xD9270 Offset: 0xD8670 VA: 0x1800D9270
	// RVA: 0xAA9630 Offset: 0xAA8A30 VA: 0x180AA9630
	public void Menu_CloseDoor(BasePlayer player) { }

	// RVA: 0xAA9510 Offset: 0xAA8910 VA: 0x180AA9510
	public void Menu_CloseDoor_Proxy(ref Option option) { }

	// RVA: 0xAA94D0 Offset: 0xAA88D0 VA: 0x180AA94D0
	public void Menu_CloseDoorStart() { }

	// RVA: 0xAA95F0 Offset: 0xAA89F0 VA: 0x180AA95F0
	public bool Menu_CloseDoor_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD9750 Offset: 0xD8B50 VA: 0x1800D9750
	[BaseEntity.Menu.Description] // RVA: 0xD9750 Offset: 0xD8B50 VA: 0x1800D9750
	[BaseEntity.Menu.Icon] // RVA: 0xD9750 Offset: 0xD8B50 VA: 0x1800D9750
	[BaseEntity.Menu.ShowIf] // RVA: 0xD9750 Offset: 0xD8B50 VA: 0x1800D9750
	[BaseEntity.Menu.UsableWhileWounded] // RVA: 0xD9750 Offset: 0xD8B50 VA: 0x1800D9750
	// RVA: 0xAA96E0 Offset: 0xAA8AE0 VA: 0x180AA96E0
	public void Menu_KnockDoor(BasePlayer player) { }

	// RVA: 0xAA9670 Offset: 0xAA8A70 VA: 0x180AA9670
	public bool Menu_KnockDoor_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD9A60 Offset: 0xD8E60 VA: 0x1800D9A60
	[BaseEntity.Menu.Description] // RVA: 0xD9A60 Offset: 0xD8E60 VA: 0x1800D9A60
	[BaseEntity.Menu.Icon] // RVA: 0xD9A60 Offset: 0xD8E60 VA: 0x1800D9A60
	[BaseEntity.Menu.ShowIf] // RVA: 0xD9A60 Offset: 0xD8E60 VA: 0x1800D9A60
	// RVA: 0xAA98D0 Offset: 0xAA8CD0 VA: 0x180AA98D0
	public void Menu_ToggleHatch(BasePlayer player) { }

	// RVA: 0xAA98C0 Offset: 0xAA8CC0 VA: 0x180AA98C0
	public bool Menu_ToggleHatch_ShowIf(BasePlayer player) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 72
	public override bool NeedsCrosshair() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAA9910 Offset: 0xAA8D10 VA: 0x180AA9910
	private void OnDoorInterrupted(BaseEntity.RPCMessage msg) { }

	// RVA: 0xAAA130 Offset: 0xAA9530 VA: 0x180AAA130
	private void ReverseDoorAnimation(bool wasOpening) { }

	// RVA: 0x7A3AD0 Offset: 0x7A2ED0 VA: 0x1807A3AD0 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 146
	public void OnObjects(TriggerNotify trigger) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 147
	public void OnEmpty() { }

	// RVA: 0xAA9BA0 Offset: 0xAA8FA0 VA: 0x180AA9BA0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xAAA360 Offset: 0xAA9760 VA: 0x180AAA360
	public void .ctor() { }

	// RVA: 0xAAA2F0 Offset: 0xAA96F0 VA: 0x180AAA2F0
	private static void .cctor() { }

}

