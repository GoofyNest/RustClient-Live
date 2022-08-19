public class PowerCounter : IOEntity // TypeDefIndex: 8428
{	// Fields
	private Option __menuOption_Menu_SetTarget; // 0x288
	private Option __menuOption_Menu_ShowCounter; // 0x2E0
	private Option __menuOption_Menu_ShowPassthrough; // 0x338
	private int counterNumber; // 0x390
	private int targetCounterNumber; // 0x394
	public Canvas canvas; // 0x398
	public CanvasGroup screenAlpha; // 0x3A0
	public Text screenText; // 0x3A8
	public const BaseEntity.Flags Flag_ShowPassthrough = 256;
	public GameObjectRef counterConfigPanel; // 0x3B0
	public Color passthroughColor; // 0x3B8
	public Color counterColor; // 0x3C8
	private int client_counterNumber; // 0x3D8
	private int client_passthrough; // 0x3DC
	private float nextScreenVisTime; // 0x3E0
	private int pendingNumberChange; // 0x3E4

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x97C9B0 Offset: 0x97BDB0 VA: 0x18097C9B0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x97DC80 Offset: 0x97D080 VA: 0x18097DC80 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x97D590 Offset: 0x97C990 VA: 0x18097D590 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x593220 Offset: 0x592620 VA: 0x180593220
	public bool DisplayPassthrough() { }

	// RVA: 0x97C930 Offset: 0x97BD30 VA: 0x18097C930
	public bool DisplayCounter() { }

	// RVA: 0x97C770 Offset: 0x97BB70 VA: 0x18097C770
	public bool CanPlayerAdmin(BasePlayer player) { }

	// RVA: 0x97D1B0 Offset: 0x97C5B0 VA: 0x18097D1B0
	public int GetTarget() { }

	// RVA: 0x97D700 Offset: 0x97CB00 VA: 0x18097D700 Slot: 27
	public override void ResetState() { }

	// RVA: 0x97D1C0 Offset: 0x97C5C0 VA: 0x18097D1C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x97D950 Offset: 0x97CD50 VA: 0x18097D950
	public void UpdateNumber(int newNumber) { }

	// RVA: 0x97DA10 Offset: 0x97CE10 VA: 0x18097DA10
	public void Update() { }

	// RVA: 0x97C890 Offset: 0x97BC90 VA: 0x18097C890
	public void DelayedNumberChange() { }

	// RVA: 0x97C950 Offset: 0x97BD50 VA: 0x18097C950
	public Color GetColor() { }

	// RVA: 0x97D8A0 Offset: 0x97CCA0 VA: 0x18097D8A0
	public void UpdateColor() { }

	// RVA: 0x97C7F0 Offset: 0x97BBF0 VA: 0x18097C7F0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x97D680 Offset: 0x97CA80 VA: 0x18097D680 Slot: 16
	public override void PostNetworkUpdate() { }

	[BaseEntity.Menu] // RVA: 0x7C880 Offset: 0x7BC80 VA: 0x18007C880
	[BaseEntity.Menu.Description] // RVA: 0x7C880 Offset: 0x7BC80 VA: 0x18007C880
	[BaseEntity.Menu.Icon] // RVA: 0x7C880 Offset: 0x7BC80 VA: 0x18007C880
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C880 Offset: 0x7BC80 VA: 0x18007C880
	// RVA: 0x97D540 Offset: 0x97C940 VA: 0x18097D540
	public void Menu_ShowPassthrough(BasePlayer player) { }

	// RVA: 0x97C930 Offset: 0x97BD30 VA: 0x18097C930
	public bool Menu_Passthrough_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7CC60 Offset: 0x7C060 VA: 0x18007CC60
	[BaseEntity.Menu.Description] // RVA: 0x7CC60 Offset: 0x7C060 VA: 0x18007CC60
	[BaseEntity.Menu.Icon] // RVA: 0x7CC60 Offset: 0x7C060 VA: 0x18007CC60
	[BaseEntity.Menu.ShowIf] // RVA: 0x7CC60 Offset: 0x7C060 VA: 0x18007CC60
	// RVA: 0x97D4F0 Offset: 0x97C8F0 VA: 0x18097D4F0
	public void Menu_ShowCounter(BasePlayer player) { }

	// RVA: 0x593220 Offset: 0x592620 VA: 0x180593220
	public bool Menu_Counter_ShowIf(BasePlayer player) { }

	// RVA: 0x97D740 Offset: 0x97CB40 VA: 0x18097D740
	public void SendNewTarget(int newTarget) { }

	[BaseEntity.Menu] // RVA: 0x7CE80 Offset: 0x7C280 VA: 0x18007CE80
	[BaseEntity.Menu.Description] // RVA: 0x7CE80 Offset: 0x7C280 VA: 0x18007CE80
	[BaseEntity.Menu.Icon] // RVA: 0x7CE80 Offset: 0x7C280 VA: 0x18007CE80
	[BaseEntity.Menu.ShowIf] // RVA: 0x7CE80 Offset: 0x7C280 VA: 0x18007CE80
	// RVA: 0x97D2E0 Offset: 0x97C6E0 VA: 0x18097D2E0
	public void Menu_SetTarget(BasePlayer player) { }

	// RVA: 0x97D240 Offset: 0x97C640 VA: 0x18097D240
	public bool Menu_SetTarget_ShowIf(BasePlayer player) { }

	// RVA: 0x97DC10 Offset: 0x97D010 VA: 0x18097DC10
	public void .ctor() { }

}

