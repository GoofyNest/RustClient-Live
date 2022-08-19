public class ReactiveTarget : IOEntity // TypeDefIndex: 8433
{	// Fields
	private Option __menuOption_Lower_Target; // 0x288
	private Option __menuOption_Reset_target; // 0x2E0
	public Animator myAnimator; // 0x338
	public GameObjectRef bullseyeEffect; // 0x340
	public GameObjectRef knockdownEffect; // 0x348
	public float activationPowerTime; // 0x350
	public int activationPowerAmount; // 0x354
	private float lastToggleTime; // 0x358

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x6A92B0 Offset: 0x6A86B0 VA: 0x1806A92B0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6AA540 Offset: 0x6A9940 VA: 0x1806AA540 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6A9DF0 Offset: 0x6A91F0 VA: 0x1806A9DF0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6A9D00 Offset: 0x6A9100 VA: 0x1806A9D00
	public void OnHitShared(HitInfo info) { }

	// RVA: 0x5277F0 Offset: 0x526BF0 VA: 0x1805277F0
	public bool IsKnockedDown() { }

	// RVA: 0x6A9AC0 Offset: 0x6A8EC0 VA: 0x1806A9AC0 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	// RVA: 0x6A9200 Offset: 0x6A8600 VA: 0x1806A9200 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x6A9240 Offset: 0x6A8640 VA: 0x1806A9240
	public bool CanToggle() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x6A9830 Offset: 0x6A8C30 VA: 0x1806A9830
	public void HitEffect(BaseEntity.RPCMessage msg) { }

	// RVA: 0x6A9270 Offset: 0x6A8670 VA: 0x1806A9270 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x6A9BC0 Offset: 0x6A8FC0 VA: 0x1806A9BC0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x6AA410 Offset: 0x6A9810 VA: 0x1806AA410
	private void UpdateAnimationParameters(bool isOn) { }

	[BaseEntity.Menu] // RVA: 0x7F0F0 Offset: 0x7E4F0 VA: 0x18007F0F0
	[BaseEntity.Menu.Description] // RVA: 0x7F0F0 Offset: 0x7E4F0 VA: 0x18007F0F0
	[BaseEntity.Menu.Icon] // RVA: 0x7F0F0 Offset: 0x7E4F0 VA: 0x18007F0F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7F0F0 Offset: 0x7E4F0 VA: 0x18007F0F0
	// RVA: 0x6AA3D0 Offset: 0x6A97D0 VA: 0x1806AA3D0
	public void Reset_target(BasePlayer player) { }

	// RVA: 0x6A9A70 Offset: 0x6A8E70 VA: 0x1806A9A70
	public bool Menu_Reset_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7F430 Offset: 0x7E830 VA: 0x18007F430
	[BaseEntity.Menu.Description] // RVA: 0x7F430 Offset: 0x7E830 VA: 0x18007F430
	[BaseEntity.Menu.Icon] // RVA: 0x7F430 Offset: 0x7E830 VA: 0x18007F430
	[BaseEntity.Menu.ShowIf] // RVA: 0x7F430 Offset: 0x7E830 VA: 0x18007F430
	// RVA: 0x6A99E0 Offset: 0x6A8DE0 VA: 0x1806A99E0
	public void Lower_Target(BasePlayer player) { }

	// RVA: 0x6A9A20 Offset: 0x6A8E20 VA: 0x1806A9A20
	public bool Menu_Lower_ShowIf(BasePlayer player) { }

	// RVA: 0x6AA4D0 Offset: 0x6A98D0 VA: 0x1806AA4D0
	public void .ctor() { }

}

