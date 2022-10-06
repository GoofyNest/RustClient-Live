public class StaticInstrument : BaseMountable // TypeDefIndex: 10360
{
	public AnimatorOverrideController AnimatorOverride; 
	public bool ShowDeployAnimation; 
	public InstrumentKeyController KeyController; 
	public bool ShouldSuppressHandsAnimationLayer; 
	private BasePlayer lateUpdatePlayer; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	protected override AnimatorOverrideController GetAnimationOverride() { }

	protected override float GetSpineLookAtWeight() { }

	protected override bool SuppressHandsAnimationLayer() { }

	public override float GetMountedAnimationSpeed() { }

	public override void OnClientInput(BasePlayer player) { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	private void LateUpdate() { }

	protected override void ClientOnPlayerMounted(BasePlayer player) { }

	protected override void ClientOnPlayerDismounted(BasePlayer player) { }

	public override void ResetState() { }

	[BaseEntity.RPC_Client] 
	private void Client_PlayNote(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	private void Client_StopNote(BaseEntity.RPCMessage msg) { }

	public override bool IsInstrument() { }

	public void .ctor() { }

}

