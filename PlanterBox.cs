public class PlanterBox : StorageContainer, ISplashable // TypeDefIndex: 10328
{
	public int soilSaturation; 
	public int soilSaturationMax; 
	public MeshRenderer soilRenderer; 
	private MaterialPropertyBlock block; 
	private TimeSince saturationUpdate; 

	public float soilSaturationFraction { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public float get_soilSaturationFraction() { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public void SetupMaterialBlock() { }

	public void UpdateMaterialSettings() { }

	public override bool ShouldShowLootMenus() { }

	public override void LookingAtTick() { }

	[BaseEntity.RPC_Client] 
	private void RPC_ReceiveSaturationUpdate(BaseEntity.RPCMessage msg) { }

	public override bool SupportsChildDeployables() { }

	public void .ctor() { }

}

