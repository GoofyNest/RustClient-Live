public class HeldBoomBox : HeldEntity, ICassettePlayer // TypeDefIndex: 8574
{	// Fields
	public BoomBox BoxController; // 0x1F8
	public SwapKeycard cassetteSwapper; // 0x200
	private TimeSince lastPlayToggle; // 0x208
	private static int animPlay; // 0x0

	// Properties
	public BaseEntity ToBaseEntity { get; }

	// Methods

	// RVA: 0x74FF00 Offset: 0x74F300 VA: 0x18074FF00 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 157
	public BaseEntity get_ToBaseEntity() { }

	// RVA: 0x74FD30 Offset: 0x74F130 VA: 0x18074FD30 Slot: 138
	public override void OnInput() { }

	// RVA: 0x74FB50 Offset: 0x74EF50 VA: 0x18074FB50 Slot: 142
	public override void OnHolster() { }

	// RVA: 0x74F950 Offset: 0x74ED50 VA: 0x18074F950 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x74F990 Offset: 0x74ED90 VA: 0x18074F990 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x74F7F0 Offset: 0x74EBF0 VA: 0x18074F7F0
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x74F840 Offset: 0x74EC40 VA: 0x18074F840
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x74FEC0 Offset: 0x74F2C0 VA: 0x18074FEC0
	public void OnRadioIPChanged(BaseEntity.RPCMessage msg) { }

	// RVA: 0x74FE80 Offset: 0x74F280 VA: 0x18074FE80 Slot: 158
	public void OnLoadedWithCassette(Cassette c) { }

	// RVA: 0x74F920 Offset: 0x74ED20 VA: 0x18074F920 Slot: 159
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x750A10 Offset: 0x74FE10 VA: 0x180750A10
	private void UpdateCassetteSwapper() { }

	// RVA: 0x750AE0 Offset: 0x74FEE0 VA: 0x180750AE0
	private void UpdateViewmodelCassette(ViewModel vm) { }

	// RVA: 0x750CD0 Offset: 0x7500D0 VA: 0x180750CD0
	private void UpdateViewmodelPlay(ViewModel vm) { }

	// RVA: 0x7509E0 Offset: 0x74FDE0 VA: 0x1807509E0 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x74F890 Offset: 0x74EC90 VA: 0x18074F890 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x750ED0 Offset: 0x7502D0 VA: 0x180750ED0
	public void .ctor() { }

	// RVA: 0x750E80 Offset: 0x750280 VA: 0x180750E80
	private static void .cctor() { }

}

