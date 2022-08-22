public class PlanterBox : StorageContainer, ISplashable // TypeDefIndex: 8619
{	public int soilSaturation; // 0x3D0
	public int soilSaturationMax; // 0x3D4
	public MeshRenderer soilRenderer; // 0x3D8
	private MaterialPropertyBlock block; // 0x3E0
	private TimeSince saturationUpdate; // 0x3E8

	public float soilSaturationFraction { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public float get_soilSaturationFraction() { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public void SetupMaterialBlock() { }

	public void UpdateMaterialSettings() { }

	public override bool ShouldShowLootMenus() { }

	public override void LookingAtTick() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void RPC_ReceiveSaturationUpdate(BaseEntity.RPCMessage msg) { }

	public override bool SupportsChildDeployables() { }

	public void .ctor() { }

}

