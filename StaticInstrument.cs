public class StaticInstrument : BaseMountable // TypeDefIndex: 8652
{	// Fields
	public AnimatorOverrideController AnimatorOverride; // 0x320
	public bool ShowDeployAnimation; // 0x328
	public InstrumentKeyController KeyController; // 0x330
	public bool ShouldSuppressHandsAnimationLayer; // 0x338
	private BasePlayer lateUpdatePlayer; // 0x340

	// Methods

	// RVA: 0xA87CF0 Offset: 0xA870F0 VA: 0x180A87CF0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA87B70 Offset: 0xA86F70 VA: 0x180A87B70 Slot: 162
	protected override AnimatorOverrideController GetAnimationOverride() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 163
	protected override float GetSpineLookAtWeight() { }

	// RVA: 0xA88850 Offset: 0xA87C50 VA: 0x180A88850 Slot: 161
	protected override bool SuppressHandsAnimationLayer() { }

	// RVA: 0x4C0690 Offset: 0x4BFA90 VA: 0x1804C0690 Slot: 164
	public override float GetMountedAnimationSpeed() { }

	// RVA: 0xA87C30 Offset: 0xA87030 VA: 0x180A87C30 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0xA88860 Offset: 0xA87C60 VA: 0x180A88860 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0xA87B80 Offset: 0xA86F80 VA: 0x180A87B80
	private void LateUpdate() { }

	// RVA: 0xA876D0 Offset: 0xA86AD0 VA: 0x180A876D0 Slot: 179
	protected override void ClientOnPlayerMounted(BasePlayer player) { }

	// RVA: 0xA87610 Offset: 0xA86A10 VA: 0x180A87610 Slot: 178
	protected override void ClientOnPlayerDismounted(BasePlayer player) { }

	// RVA: 0xA887C0 Offset: 0xA87BC0 VA: 0x180A887C0 Slot: 27
	public override void ResetState() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA877D0 Offset: 0xA86BD0 VA: 0x180A877D0
	private void Client_PlayNote(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA879A0 Offset: 0xA86DA0 VA: 0x180A879A0
	private void Client_StopNote(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 172
	public override bool IsInstrument() { }

	// RVA: 0xA88930 Offset: 0xA87D30 VA: 0x180A88930
	public void .ctor() { }

}

