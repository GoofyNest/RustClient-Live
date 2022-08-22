public class ProceduralLift : BaseEntity // TypeDefIndex: 8432
{	private Option __menuOption_Menu_UseLift; // 0x168
	public float movementSpeed; // 0x1C0
	public float resetDelay; // 0x1C4
	public ProceduralLiftCabin cabin; // 0x1C8
	public ProceduralLiftStop[] stops; // 0x1D0
	public GameObjectRef triggerPrefab; // 0x1D8
	public string triggerBone; // 0x1E0
	private int floorIndex; // 0x1E8

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x7DA70 Offset: 0x7CE70 VA: 0x18007DA70
	[BaseEntity.Menu.Description] // RVA: 0x7DA70 Offset: 0x7CE70 VA: 0x18007DA70
	[BaseEntity.Menu.Icon] // RVA: 0x7DA70 Offset: 0x7CE70 VA: 0x18007DA70
	[BaseEntity.Menu.ShowIf] // RVA: 0x7DA70 Offset: 0x7CE70 VA: 0x18007DA70
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

