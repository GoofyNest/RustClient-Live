public class MobilePhone : HeldEntity // TypeDefIndex: 10330
{
	public PhoneController Controller;


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void OnDeployed() { }

	public override void OnHolstered() { }

	public override void OnInput() { }

	[BaseEntity.RPC_Client]
	public void UpdatePhoneNumber(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client]
	public void SetClientState(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client]
	public void ClientOnDialFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client]
	private void ClientReceiveAnsweringData(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client]
	private void ClientPlayAnsweringMessage(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client]
	public void OnIncomingCallDuringCall() { }

	[BaseEntity.RPC_Client]
	public void OnReceivedVoice(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client]
	private void ReceivePhoneDirectory(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client]
	private void ClientToggleVoicemail(BaseEntity.RPCMessage msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public void .ctor() { }

}

