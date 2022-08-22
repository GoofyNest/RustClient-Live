public class AdventCalendar : BaseCombatEntity // TypeDefIndex: 8304
{	private Option __menuOption_Menu_OpenCalendar; // 0x240
	public int startMonth; // 0x298
	public int startDay; // 0x29C
	public AdventCalendar.DayReward[] days; // 0x2A0
	public GameObject[] crosses; // 0x2A8
	public static List<AdventCalendar> all; // 0x0
	public static Dictionary<ulong, List<int>> playerRewardHistory; // 0x8
	public static readonly Translate.Phrase CheckLater; // 0x10
	public static readonly Translate.Phrase EventOver; // 0x18
	public GameObjectRef giftEffect; // 0x2B0
	public GameObjectRef boxCloseEffect; // 0x2B8

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xB00F0 Offset: 0xAF4F0 VA: 0x1800B00F0
	[BaseEntity.Menu.Description] // RVA: 0xB00F0 Offset: 0xAF4F0 VA: 0x1800B00F0
	[BaseEntity.Menu.Icon] // RVA: 0xB00F0 Offset: 0xAF4F0 VA: 0x1800B00F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB00F0 Offset: 0xAF4F0 VA: 0x1800B00F0
	public void Menu_OpenCalendar(BasePlayer player) { }

	public bool Menu_OpenCalendar_ShowIf(BasePlayer player) { }

	protected override void ClientInit(Entity info) { }

	public void CheckCrosses() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class AdventCalendar.DayReward // TypeDefIndex: 8305
{	public ItemAmount[] rewards; // 0x10


	public void .ctor() { }

}

