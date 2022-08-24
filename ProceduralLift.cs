public class ProceduralLift : BaseEntity // TypeDefIndex: 8432
{
	private Option __menuOption_Menu_UseLift; 
	public float movementSpeed; 
	public float resetDelay; 
	public ProceduralLiftCabin cabin; 
	public ProceduralLiftStop[] stops; 
	public GameObjectRef triggerPrefab; 
	public string triggerBone; 
	private int floorIndex; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_UseLift(BasePlayer player) { }

	public bool Menu_UseLift_ShowIf(BasePlayer player) { }

	public override bool NeedsCrosshair() { }

	private void ResetLift() { }

	private void MoveToFloor(int floor) { }

	private void SnapToFloor(int floor) { }

	private void OnFinishedMoving() { }

	protected void Update() { }

	public void .ctor() { }

}

