public static class LocalPlayer // TypeDefIndex: 11416
{
	[CompilerGeneratedAttribute]
	private static BasePlayer <Entity>k__BackingField;
	[CompilerGeneratedAttribute]
	private static ulong <LastAttackerSteamID>k__BackingField;
	[CompilerGeneratedAttribute]
	private static string <LastAttackerName>k__BackingField;
	public static float LastDeathTime;
	public static PetCommandList.PetCommandDesc CurrentPetCommandDesc;
	private static Dictionary<int, int> CraftCounts;
	public static LocalPlayer.ItemBlueprintComparer ItemBluePrintOrdered;

	public static BasePlayer Entity { get; set; }
	public static ulong LastAttackerSteamID { get; set; }
	public static string LastAttackerName { get; set; }
	public static float TimeSinceLastDeath { get; }
	public static bool isSleeping { get; }
	public static bool isAdmin { get; }
	public static bool isDeveloper { get; }
	public static BasePlayer LocalOrSpectatePlayer { get; }
	public static BasePlayer SpectatePlayer { get; }


	[CompilerGeneratedAttribute]
	public static BasePlayer get_Entity() { }

	[CompilerGeneratedAttribute]
	public static void set_Entity(BasePlayer value) { }

	[CompilerGeneratedAttribute]
	public static ulong get_LastAttackerSteamID() { }

	[CompilerGeneratedAttribute]
	public static void set_LastAttackerSteamID(ulong value) { }

	[CompilerGeneratedAttribute]
	public static string get_LastAttackerName() { }

	[CompilerGeneratedAttribute]
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
	|-LocalPlayer.ItemCommandEx<int>
	|
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

public class LocalPlayer.ItemBlueprintComparer : IComparer<ItemBlueprint> // TypeDefIndex: 11417
{

	public int Compare(ItemBlueprint a, ItemBlueprint b) { }

	public void .ctor() { }

}

private sealed class LocalPlayer.<>c__DisplayClass40_0 // TypeDefIndex: 11418
{
	public int id;


	public void .ctor() { }

	internal bool <HasInventoryItem>

}

