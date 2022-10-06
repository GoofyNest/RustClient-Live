public class PowerCounter : IOEntity // TypeDefIndex: 10133
{
	private Option __menuOption_Menu_SetTarget; 
	private Option __menuOption_Menu_ShowCounter; 
	private Option __menuOption_Menu_ShowPassthrough; 
	private int counterNumber; 
	private int targetCounterNumber; 
	public Canvas canvas; 
	public CanvasGroup screenAlpha; 
	public Text screenText; 
	public const BaseEntity.Flags Flag_ShowPassthrough = 256;
	public GameObjectRef counterConfigPanel; 
	public Color passthroughColor; 
	public Color counterColor; 
	private int client_counterNumber; 
	private int client_passthrough; 
	private float nextScreenVisTime; 
	private int pendingNumberChange; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool DisplayPassthrough() { }

	public bool DisplayCounter() { }

	public bool CanPlayerAdmin(BasePlayer player) { }

	public int GetTarget() { }

	public override void ResetState() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void UpdateNumber(int newNumber) { }

	public void Update() { }

	public void DelayedNumberChange() { }

	public Color GetColor() { }

	public void UpdateColor() { }

	protected override void ClientInit(Entity info) { }

	public override void PostNetworkUpdate() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_ShowPassthrough(BasePlayer player) { }

	public bool Menu_Passthrough_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_ShowCounter(BasePlayer player) { }

	public bool Menu_Counter_ShowIf(BasePlayer player) { }

	public void SendNewTarget(int newTarget) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_SetTarget(BasePlayer player) { }

	public bool Menu_SetTarget_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

