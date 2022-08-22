public class StaticInstrument : BaseMountable // TypeDefIndex: 8652
{	public AnimatorOverrideController AnimatorOverride; // 0x320
	public bool ShowDeployAnimation; // 0x328
	public InstrumentKeyController KeyController; // 0x330
	public bool ShouldSuppressHandsAnimationLayer; // 0x338
	private BasePlayer lateUpdatePlayer; // 0x340


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

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void Client_PlayNote(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void Client_StopNote(BaseEntity.RPCMessage msg) { }

	public override bool IsInstrument() { }

	public void .ctor() { }

}

