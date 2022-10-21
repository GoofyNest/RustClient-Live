public class Recycler : StorageContainer // TypeDefIndex: 10141
{
	private Option __menuOption_Menu_TurnOff; 
	private Option __menuOption_Menu_TurnOn; 
	public float recycleEfficiency; 
	public SoundDefinition grindingLoopDef; 
	public GameObjectRef startSound; 
	public GameObjectRef stopSound; 
	private bool lastFrameOn; 
	private SoundModulation.Modulator grindingSoundModulator; 
	private Sound grindingLoop; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void ResetState() { }

	private bool CanBeRecycled(Item item) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_TurnOn(BasePlayer player) { }

	public bool Menu_TurnOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_TurnOff(BasePlayer player) { }

	public bool Menu_TurnOff_ShowIf(BasePlayer player) { }

	protected override void ClientInit(Entity info) { }

	public void InitializeClientsideEffects() { }

	protected override void DoClientDestroy() { }

	public void Update() { }

	public void .ctor() { }

}

