public class PlanterBox : StorageContainer, ISplashable // TypeDefIndex: 8619
{	// Fields
	public int soilSaturation; // 0x3D0
	public int soilSaturationMax; // 0x3D4
	public MeshRenderer soilRenderer; // 0x3D8
	private MaterialPropertyBlock block; // 0x3E0
	private TimeSince saturationUpdate; // 0x3E8

	// Properties
	public float soilSaturationFraction { get; }

	// Methods

	// RVA: 0x8E1BA0 Offset: 0x8E0FA0 VA: 0x1808E1BA0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8E1AC0 Offset: 0x8E0EC0 VA: 0x1808E1AC0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x8E2660 Offset: 0x8E1A60 VA: 0x1808E2660
	public float get_soilSaturationFraction() { }

	// RVA: 0x6B37E0 Offset: 0x6B2BE0 VA: 0x1806B37E0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x8E2030 Offset: 0x8E1430 VA: 0x1808E2030
	public void SetupMaterialBlock() { }

	// RVA: 0x8E2430 Offset: 0x8E1830 VA: 0x1808E2430
	public void UpdateMaterialSettings() { }

	// RVA: 0x8E20A0 Offset: 0x8E14A0 VA: 0x1808E20A0 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x8E1B30 Offset: 0x8E0F30 VA: 0x1808E1B30 Slot: 75
	public override void LookingAtTick() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8E1FF0 Offset: 0x8E13F0 VA: 0x1808E1FF0
	private void RPC_ReceiveSaturationUpdate(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 129
	public override bool SupportsChildDeployables() { }

	// RVA: 0x8E2600 Offset: 0x8E1A00 VA: 0x1808E2600
	public void .ctor() { }

}

