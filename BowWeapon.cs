public class BowWeapon : BaseProjectile // TypeDefIndex: 8535
{	// Fields
	protected bool attackReady; // 0x378
	private float arrowBack; // 0x37C
	private SwapArrows swapArrows; // 0x380
	private bool wasAiming; // 0x388

	// Methods

	// RVA: 0x5379A0 Offset: 0x536DA0 VA: 0x1805379A0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x537100 Offset: 0x536500 VA: 0x180537100 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x537A90 Offset: 0x536E90 VA: 0x180537A90 Slot: 83
	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0x537EE0 Offset: 0x5372E0 VA: 0x180537EE0
	public void UpdatePullbackThink() { }

	// RVA: 0x537090 Offset: 0x536490 VA: 0x180537090
	public void CancelPullbackThink() { }

	// RVA: 0x537DA0 Offset: 0x5371A0 VA: 0x180537DA0
	public void PullbackThink() { }

	// RVA: 0x537620 Offset: 0x536A20 VA: 0x180537620 Slot: 138
	public override void OnInput() { }

	// RVA: 0x5375E0 Offset: 0x5369E0 VA: 0x1805375E0 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x537170 Offset: 0x536570 VA: 0x180537170 Slot: 171
	public override void DoAttack() { }

	// RVA: 0x537410 Offset: 0x536810 VA: 0x180537410
	public bool IsAiming() { }

	// RVA: 0x537C00 Offset: 0x537000 VA: 0x180537C00 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x5374B0 Offset: 0x5368B0 VA: 0x1805374B0 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x537C70 Offset: 0x537070 VA: 0x180537C70 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x537E70 Offset: 0x537270 VA: 0x180537E70
	private void TryReload() { }

	// RVA: 0x537D10 Offset: 0x537110 VA: 0x180537D10 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x51E690 Offset: 0x51DA90 VA: 0x18051E690
	public void .ctor() { }

}

