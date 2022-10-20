public class HeldBoomBox : HeldEntity, ICassettePlayer // TypeDefIndex: 10282
{
	public BoomBox BoxController; 
	public SwapKeycard cassetteSwapper; 
	private TimeSince lastPlayToggle; 
	private static int animPlay; 

	public BaseEntity ToBaseEntity { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public BaseEntity get_ToBaseEntity() { }

	public override void OnInput() { }

	public override void OnHolster() { }

	public override void OnDeploy() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	[BaseEntity.RPC_Client] 
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void OnRadioIPChanged(BaseEntity.RPCMessage msg) { }

	public void OnLoadedWithCassette(Cassette c) { }

	public void OnCensorRecordingsChanged() { }

	private void UpdateCassetteSwapper() { }

	private void UpdateViewmodelCassette(ViewModel vm) { }

	private void UpdateViewmodelPlay(ViewModel vm) { }

	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

	private static void .cctor() { }

}

