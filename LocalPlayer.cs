public static class LocalPlayer // TypeDefIndex: 9664
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static BasePlayer <Entity>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static ulong <LastAttackerSteamID>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static string <LastAttackerName>k__BackingField; // 0x10
	public static float LastDeathTime; // 0x18
	public static PetCommandList.PetCommandDesc CurrentPetCommandDesc; // 0x20
	private static Dictionary<int, int> CraftCounts; // 0x50
	public static LocalPlayer.ItemBlueprintComparer ItemBluePrintOrdered; // 0x58

	public static BasePlayer Entity { get; set; }
	public static ulong LastAttackerSteamID { get; set; }
	public static string LastAttackerName { get; set; }
	public static float TimeSinceLastDeath { get; }
	public static bool isSleeping { get; }
	public static bool isAdmin { get; }
	public static bool isDeveloper { get; }
	public static BasePlayer LocalOrSpectatePlayer { get; }
	public static BasePlayer SpectatePlayer { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static BasePlayer get_Entity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void set_Entity(BasePlayer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static ulong get_LastAttackerSteamID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void set_LastAttackerSteamID(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static string get_LastAttackerName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void set_LastAttackerName(string value) { }

	public static float get_TimeSinceLastDeath() { }

	public static void EndLooting() { }

	internal static ItemContainer GetContainer(PlayerInventory.Type type) { }

	internal static ItemContainer GetLootContainer(int i) { }

	public static void OnInventoryChanged() { }

	public static void OnItemAmountChanged() { }

	internal static bool HasUnlocked(ItemDefinition targetItem) { }

	internal static float GetCraftLevel() { }

	internal static bool HasCraftLevel(int levelReq) { }

	public static void MoveItem(uint itemid, uint targetContainer, int targetSlot, int amount) { }

	public static void DropItemStack(uint itemid) { }

	public static void DropItem(uint itemid, int count) { }

	public static void ItemCommand(uint itemid, string command) { }

	public static void ItemCommandEx<T1>(uint itemid, string command, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1542580 Offset: 0x1541980 VA: 0x181542580
	|-LocalPlayer.ItemCommandEx<int>
	|
	|-RVA: 0x1542730 Offset: 0x1541B30 VA: 0x181542730
	|-LocalPlayer.ItemCommandEx<object>
	*/

	public static bool get_isSleeping() { }

	public static bool get_isAdmin() { }

	public static bool get_isDeveloper() { }

	public static void FindAmmo(List<Item> list, AmmoTypes ammo) { }

	public static void ModifyCamera() { }

	public static bool HasItems(List<ItemAmount> list, int amount = 1) { }

	public static int GetItemAmount(ItemDefinition item) { }

	public static string BuildItemRequiredString(List<ItemAmount> list) { }

	public static bool HasInventoryItem(int id) { }

	public static void ResetCraftCounts() { }

	public static void ListCraftCounts() { }

	public static int GetCraftCount(ItemBlueprint x) { }

	public static void AddCraftCount(ItemBlueprint x) { }

	public static BasePlayer get_LocalOrSpectatePlayer() { }

	public static BasePlayer get_SpectatePlayer() { }

	private static void .cctor() { }

}

public class LocalPlayer.ItemBlueprintComparer : IComparer<ItemBlueprint> // TypeDefIndex: 9665
{
	public int Compare(ItemBlueprint a, ItemBlueprint b) { }

	public void .ctor() { }

}

private sealed class LocalPlayer.<>c__DisplayClass40_0 // TypeDefIndex: 9666
{	public int id; // 0x10


	public void .ctor() { }

	internal bool <HasInventoryItem>b__0(IPlayerItem x) { }

}

