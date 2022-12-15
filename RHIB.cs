public class RHIB : MotorRowboat // TypeDefIndex: 10162
{
	private Option __menuOption_Release;
	public GameObject steeringWheel;
	[ServerVar]
	public static float rhibpopulation;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Release(BasePlayer player) { }

	public bool Release_ShowIf(BasePlayer player) { }

	public override bool LookingAtEngine(BasePlayer player) { }

	public override bool LookingAtFuelArea(BasePlayer player) { }

	public override void UpdateEngineRotation() { }

	public void .ctor() { }

	private static void .cctor() { }

}

