public class AdventCalendar : BaseCombatEntity // TypeDefIndex: 8304
{	// Fields
	private Option __menuOption_Menu_OpenCalendar; // 0x240
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

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xA9D6B0 Offset: 0xA9CAB0 VA: 0x180A9D6B0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA9DBF0 Offset: 0xA9CFF0 VA: 0x180A9DBF0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA9D9D0 Offset: 0xA9CDD0 VA: 0x180A9D9D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xB00F0 Offset: 0xAF4F0 VA: 0x1800B00F0
	[BaseEntity.Menu.Description] // RVA: 0xB00F0 Offset: 0xAF4F0 VA: 0x1800B00F0
	[BaseEntity.Menu.Icon] // RVA: 0xB00F0 Offset: 0xAF4F0 VA: 0x1800B00F0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB00F0 Offset: 0xAF4F0 VA: 0x1800B00F0
	// RVA: 0xA9D990 Offset: 0xA9CD90 VA: 0x180A9D990
	public void Menu_OpenCalendar(BasePlayer player) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	public bool Menu_OpenCalendar_ShowIf(BasePlayer player) { }

	// RVA: 0xA9D620 Offset: 0xA9CA20 VA: 0x180A9D620 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA9D510 Offset: 0xA9C910 VA: 0x180A9D510
	public void CheckCrosses() { }

	// RVA: 0x499120 Offset: 0x498520 VA: 0x180499120
	public void .ctor() { }

	// RVA: 0xA9DAC0 Offset: 0xA9CEC0 VA: 0x180A9DAC0
	private static void .cctor() { }

}

public class AdventCalendar.DayReward // TypeDefIndex: 8305
{	// Fields
	public ItemAmount[] rewards; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

