public class TorchWeapon : BaseMelee // TypeDefIndex: 8656
{	// Fields
	public float fuelTickAmount; // 0x2E0
	[HeaderAttribute] // RVA: 0xB6F30 Offset: 0xB6330 VA: 0x1800B6F30
	public AnimatorOverrideController LitHoldAnimationOverride; // 0x2E8
	private bool specVmWasOn; // 0x2F0
	private TimeUntil blockVmUpdates; // 0x2F4

	// Methods

	// RVA: 0x9E9760 Offset: 0x9E8B60 VA: 0x1809E9760 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9E94E0 Offset: 0x9E88E0 VA: 0x1809E94E0 Slot: 158
	public override void GetAttackStats(HitInfo info) { }

	// RVA: 0x9E9580 Offset: 0x9E8980 VA: 0x1809E9580 Slot: 138
	public override void OnInput() { }

	// RVA: 0x9E9A50 Offset: 0x9E8E50 VA: 0x1809E9A50
	private void ToggleOn() { }

	// RVA: 0x9E9850 Offset: 0x9E8C50 VA: 0x1809E9850 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x9E9550 Offset: 0x9E8950 VA: 0x1809E9550 Slot: 148
	public override AnimatorOverrideController GetHoldAnimations() { }

	// RVA: 0x9E9910 Offset: 0x9E8D10 VA: 0x1809E9910 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x9E9AF0 Offset: 0x9E8EF0 VA: 0x1809E9AF0
	public void .ctor() { }

}

