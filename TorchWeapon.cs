public class TorchWeapon : BaseMelee // TypeDefIndex: 10365
{
	public float fuelTickAmount; 
	[HeaderAttribute] 
	public AnimatorOverrideController LitHoldAnimationOverride; 
	public GameObjectRef litStrikeFX; 
	private bool specVmWasOn; 
	private TimeUntil blockVmUpdates; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void GetAttackStats(HitInfo info) { }

	public override void OnInput() { }

	private void ToggleOn() { }

	public override void OnViewmodelEvent(string name) { }

	public override AnimatorOverrideController GetHoldAnimations() { }

	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	public override string GetStrikeEffectPath(string materialName) { }

	public void .ctor() { }

}

