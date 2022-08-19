public class WheelSwitch : IOEntity // TypeDefIndex: 8487
{	// Fields
	private Option __menuOption_Menu_Turn; // 0x288
	public Transform wheelObj; // 0x2E0
	public float rotateSpeed; // 0x2E8
	public BaseEntity.Flags BeingRotated; // 0x2EC
	public BaseEntity.Flags RotatingLeft; // 0x2F0
	public BaseEntity.Flags RotatingRight; // 0x2F4
	public float rotateProgress; // 0x2F8
	public Animator animator; // 0x300
	public float kineticEnergyPerSec; // 0x308
	private BasePlayer rotatorPlayer; // 0x310
	private float animProgress; // 0x318

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x89EEA0 Offset: 0x89E2A0 VA: 0x18089EEA0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x89F540 Offset: 0x89E940 VA: 0x18089F540 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x89F270 Offset: 0x89E670 VA: 0x18089F270 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x89F360 Offset: 0x89E760 VA: 0x18089F360 Slot: 69
	public override void OnUseStopped(BasePlayer player) { }

	// RVA: 0x5CAB30 Offset: 0x5C9F30 VA: 0x1805CAB30 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x89F3C0 Offset: 0x89E7C0 VA: 0x18089F3C0
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0x9CD90 Offset: 0x9C190 VA: 0x18009CD90
	[BaseEntity.Menu.Description] // RVA: 0x9CD90 Offset: 0x9C190 VA: 0x18009CD90
	[BaseEntity.Menu.Icon] // RVA: 0x9CD90 Offset: 0x9C190 VA: 0x18009CD90
	[BaseEntity.Menu.ShowIf] // RVA: 0x9CD90 Offset: 0x9C190 VA: 0x18009CD90
	// RVA: 0x89F230 Offset: 0x89E630 VA: 0x18089F230
	public void Menu_Turn(BasePlayer player) { }

	// RVA: 0x89F210 Offset: 0x89E610 VA: 0x18089F210
	public bool Menu_Turn_ShowIf(BasePlayer player) { }

	// RVA: 0x89F1A0 Offset: 0x89E5A0 VA: 0x18089F1A0
	public bool IsBeingRotated() { }

	// RVA: 0x89F1B0 Offset: 0x89E5B0 VA: 0x18089F1B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x89F4B0 Offset: 0x89E8B0 VA: 0x18089F4B0
	public void .ctor() { }

}

