public class AdventCalendar : BaseCombatEntity // TypeDefIndex: 9974
{
	private Option __menuOption_Menu_OpenCalendar; 
	public int startMonth; 
	public int startDay; 
	public AdventCalendar.DayReward[] days; 
	public GameObject[] crosses; 
	public static List<AdventCalendar> all; 
	public static Dictionary<ulong, List<int>> playerRewardHistory; 
	public static readonly Translate.Phrase CheckLater; 
	public static readonly Translate.Phrase EventOver; 
	public GameObjectRef giftEffect; 
	public GameObjectRef boxCloseEffect; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_OpenCalendar(BasePlayer player) { }

	public bool Menu_OpenCalendar_ShowIf(BasePlayer player) { }

	protected override void ClientInit(Entity info) { }

	public void CheckCrosses() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class AdventCalendar.DayReward // TypeDefIndex: 9975
{
	public ItemAmount[] rewards; 


	public void .ctor() { }

}

