public class MobilePhone : HeldEntity // TypeDefIndex: 8607
{	// Fields
	public PhoneController Controller; // 0x1F8

	// Methods

	// RVA: 0x76B2B0 Offset: 0x76A6B0 VA: 0x18076B2B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x76AFC0 Offset: 0x76A3C0 VA: 0x18076AFC0 Slot: 141
	public override void OnDeployed() { }

	// RVA: 0x76B060 Offset: 0x76A460 VA: 0x18076B060 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x76B140 Offset: 0x76A540 VA: 0x18076B140 Slot: 138
	public override void OnInput() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x76D030 Offset: 0x76C430 VA: 0x18076D030
	public void UpdatePhoneNumber(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x76CFF0 Offset: 0x76C3F0 VA: 0x18076CFF0
	public void SetClientState(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x76AD40 Offset: 0x76A140 VA: 0x18076AD40
	public void ClientOnDialFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x76ADC0 Offset: 0x76A1C0 VA: 0x18076ADC0
	private void ClientReceiveAnsweringData(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x76AD80 Offset: 0x76A180 VA: 0x18076AD80
	private void ClientPlayAnsweringMessage(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x76B110 Offset: 0x76A510 VA: 0x18076B110
	public void OnIncomingCallDuringCall() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x76B270 Offset: 0x76A670 VA: 0x18076B270
	public void OnReceivedVoice(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x76CFB0 Offset: 0x76C3B0 VA: 0x18076CFB0
	private void ReceivePhoneDirectory(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x76AE00 Offset: 0x76A200 VA: 0x18076AE00
	private void ClientToggleVoicemail(BaseEntity.RPCMessage msg) { }

	// RVA: 0x76AE40 Offset: 0x76A240 VA: 0x18076AE40 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x76B010 Offset: 0x76A410 VA: 0x18076B010 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x76D070 Offset: 0x76C470 VA: 0x18076D070
	public void .ctor() { }

}

