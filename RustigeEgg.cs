public class RustigeEgg : BaseCombatEntity // TypeDefIndex: 10160
{
	private Option __menuOption_Menu_Close;
	private Option __menuOption_Menu_Open;
	private Option __menuOption_Menu_Spin;
	private Option __menuOption_Menu_StopSpin;
	public const BaseEntity.Flags Flag_Spin = 128;
	public Transform eggRotationTransform;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsSpinning() { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_Spin(BasePlayer player) { }

	public bool Menu_Spin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_StopSpin(BasePlayer player) { }

	public bool Menu_StopSpin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_Open(BasePlayer player) { }

	public bool Menu_Open_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_Close(BasePlayer player) { }

	public bool Menu_Close_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client]
	public void FaceEggPosition(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

}

