public class BasePortal : BaseCombatEntity // TypeDefIndex: 10069
{
	private Option __menuOption_Menu_UsePortal;
	public bool isUsablePortal;
	private Vector3 destination_pos;
	private Quaternion destination_rot;
	public BasePortal targetPortal;
	public uint targetID;
	public Transform localEntryExitPos;
	public Transform relativeAnchor;
	public bool isMirrored;
	public GameObjectRef appearEffect;
	public GameObjectRef disappearEffect;
	public GameObjectRef transitionSoundEffect;
	public string useTagString;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsActive() { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	private void Menu_UsePortal(BasePlayer player) { }

	private bool Menu_UsePortal_ShowIf(BasePlayer player) { }

	public bool IsUsablePortal() { }

	public void .ctor() { }

}

