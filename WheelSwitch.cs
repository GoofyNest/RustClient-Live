public class WheelSwitch : IOEntity // TypeDefIndex: 8487
{	private Option __menuOption_Menu_Turn; // 0x288
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

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void OnUseStopped(BasePlayer player) { }

	public override void PostNetworkUpdate() { }

	public void Update() { }

	[BaseEntity.Menu] // RVA: 0x9CD90 Offset: 0x9C190 VA: 0x18009CD90
	[BaseEntity.Menu.Description] // RVA: 0x9CD90 Offset: 0x9C190 VA: 0x18009CD90
	[BaseEntity.Menu.Icon] // RVA: 0x9CD90 Offset: 0x9C190 VA: 0x18009CD90
	[BaseEntity.Menu.ShowIf] // RVA: 0x9CD90 Offset: 0x9C190 VA: 0x18009CD90
	public void Menu_Turn(BasePlayer player) { }

	public bool Menu_Turn_ShowIf(BasePlayer player) { }

	public bool IsBeingRotated() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

