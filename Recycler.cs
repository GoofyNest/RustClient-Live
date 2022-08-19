public class Recycler : StorageContainer // TypeDefIndex: 8434
{	// Fields
	private Option __menuOption_Menu_TurnOff; // 0x3D0
	private Option __menuOption_Menu_TurnOn; // 0x428
	public float recycleEfficiency; // 0x480
	public SoundDefinition grindingLoopDef; // 0x488
	public GameObjectRef startSound; // 0x490
	public GameObjectRef stopSound; // 0x498
	private bool lastFrameOn; // 0x4A0
	private SoundModulation.Modulator grindingSoundModulator; // 0x4A8
	private Sound grindingLoop; // 0x4B0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x91E240 Offset: 0x91D640 VA: 0x18091E240 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x91ED80 Offset: 0x91E180 VA: 0x18091ED80 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x91EAE0 Offset: 0x91DEE0 VA: 0x18091EAE0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x91EBD0 Offset: 0x91DFD0 VA: 0x18091EBD0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x91DFC0 Offset: 0x91D3C0 VA: 0x18091DFC0
	private bool CanBeRecycled(Item item) { }

	[BaseEntity.Menu] // RVA: 0x7F720 Offset: 0x7EB20 VA: 0x18007F720
	[BaseEntity.Menu.Description] // RVA: 0x7F720 Offset: 0x7EB20 VA: 0x18007F720
	[BaseEntity.Menu.Icon] // RVA: 0x7F720 Offset: 0x7EB20 VA: 0x18007F720
	[BaseEntity.Menu.ShowIf] // RVA: 0x7F720 Offset: 0x7EB20 VA: 0x18007F720
	// RVA: 0x91EA90 Offset: 0x91DE90 VA: 0x18091EA90
	public void Menu_TurnOn(BasePlayer player) { }

	// RVA: 0x91E9D0 Offset: 0x91DDD0 VA: 0x18091E9D0
	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7F920 Offset: 0x7ED20 VA: 0x18007F920
	[BaseEntity.Menu.Description] // RVA: 0x7F920 Offset: 0x7ED20 VA: 0x18007F920
	[BaseEntity.Menu.Icon] // RVA: 0x7F920 Offset: 0x7ED20 VA: 0x18007F920
	[BaseEntity.Menu.ShowIf] // RVA: 0x7F920 Offset: 0x7ED20 VA: 0x18007F920
	// RVA: 0x91E980 Offset: 0x91DD80 VA: 0x18091E980
	public void Menu_TurnOff(BasePlayer player) { }

	// RVA: 0x91E8C0 Offset: 0x91DCC0 VA: 0x18091E8C0
	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	// RVA: 0x91E040 Offset: 0x91D440 VA: 0x18091E040 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x91E790 Offset: 0x91DB90 VA: 0x18091E790
	public void InitializeClientsideEffects() { }

	// RVA: 0x91E180 Offset: 0x91D580 VA: 0x18091E180 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x91EC00 Offset: 0x91E000 VA: 0x18091EC00
	public void Update() { }

	// RVA: 0x91ED20 Offset: 0x91E120 VA: 0x18091ED20
	public void .ctor() { }

}

