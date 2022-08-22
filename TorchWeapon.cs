public class TorchWeapon : BaseMelee // TypeDefIndex: 8656
{	public float fuelTickAmount; // 0x2E0
	[HeaderAttribute] // RVA: 0xB6F30 Offset: 0xB6330 VA: 0x1800B6F30
	public AnimatorOverrideController LitHoldAnimationOverride; // 0x2E8
	private bool specVmWasOn; // 0x2F0
	private TimeUntil blockVmUpdates; // 0x2F4


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void GetAttackStats(HitInfo info) { }

	public override void OnInput() { }

	private void ToggleOn() { }

	public override void OnViewmodelEvent(string name) { }

	public override AnimatorOverrideController GetHoldAnimations() { }

	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	public void .ctor() { }

}

