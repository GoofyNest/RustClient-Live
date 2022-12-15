public class BlackjackMachine : BaseCardGameEntity // TypeDefIndex: 10087
{
	private Option __menuOption_Menu_Play;
	[HeaderAttribute]
	[SerializeField]
	private GameObjectRef mainScreenPrefab;
	[SerializeField]
	private GameObjectRef smallScreenPrefab;
	[SerializeField]
	private Transform mainScreenParent;
	[SerializeField]
	private Transform[] smallScreenParents;
	private static int _maxbet;
	private BlackjackController controller;
	private BlackjackMainScreenUI mainScreenUI;
	private BlackjackSmallScreenUI[] smallScreenUIs;

	public override bool HasMenuOptions { get; }
	[ServerVar]
	public static int maxbet { get; set; }
	protected override float MaxStorageInteractionDist { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public static int get_maxbet() { }

	public static void set_maxbet(int value) { }

	protected override float get_MaxStorageInteractionDist() { }

	public override void InitShared() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	protected override void ClientInit(Entity info) { }

	public override void RefreshLocalPlayer(CardPlayerData localPlayerData) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public override void Menu_Play(BasePlayer player) { }

	public void .ctor() { }

	private static void .cctor() { }

}

