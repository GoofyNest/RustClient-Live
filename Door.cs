public class Door : AnimatedBuildingBlock, INotifyTrigger // TypeDefIndex: 10102
{
	private Option __menuOption_Menu_CloseDoor;
	private Option __menuOption_Menu_KnockDoor;
	private Option __menuOption_Menu_OpenDoor;
	private Option __menuOption_Menu_ToggleHatch;
	public GameObjectRef knockEffect;
	public bool canTakeLock;
	public bool hasHatch;
	public bool canTakeCloser;
	public bool canTakeKnocker;
	public bool canNpcOpen;
	public bool canHandOpen;
	public bool isSecurityDoor;
	public TriggerNotify[] vehiclePhysBoxes;
	public bool checkPhysBoxesOnOpen;
	public SoundDefinition vehicleCollisionSfx;
	public GameObject[] ClosedColliderRoots;
	private static int openHash;
	private static int closeHash;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void ResetState() { }

	public override bool HasSlot(BaseEntity.Slot slot) { }

	public override bool CanPickup(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	[BaseEntity.Menu.UsableWhileWounded]
	public void Menu_OpenDoor(BasePlayer player) { }

	public void Menu_OpenDoor_Proxy(ref Option option) { }

	public void Menu_OpenDoorStart() { }

	public bool Menu_OpenDoor_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	[BaseEntity.Menu.UsableWhileWounded]
	public void Menu_CloseDoor(BasePlayer player) { }

	public void Menu_CloseDoor_Proxy(ref Option option) { }

	public void Menu_CloseDoorStart() { }

	public bool Menu_CloseDoor_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	[BaseEntity.Menu.UsableWhileWounded]
	public void Menu_KnockDoor(BasePlayer player) { }

	public bool Menu_KnockDoor_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_ToggleHatch(BasePlayer player) { }

	public bool Menu_ToggleHatch_ShowIf(BasePlayer player) { }

	public override bool NeedsCrosshair() { }

	[BaseEntity.RPC_Client]
	private void OnDoorInterrupted(BaseEntity.RPCMessage msg) { }

	private void ReverseDoorAnimation(bool wasOpening) { }

	public override float BoundsPadding() { }

	public void OnObjects(TriggerNotify trigger) { }

	public void OnEmpty() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public void .ctor() { }

	private static void .cctor() { }

}

