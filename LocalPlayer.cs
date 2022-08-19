public static class LocalPlayer // TypeDefIndex: 9664
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static BasePlayer <Entity>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static ulong <LastAttackerSteamID>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static string <LastAttackerName>k__BackingField; // 0x10
	public static float LastDeathTime; // 0x18
	public static PetCommandList.PetCommandDesc CurrentPetCommandDesc; // 0x20
	private static Dictionary<int, int> CraftCounts; // 0x50
	public static LocalPlayer.ItemBlueprintComparer ItemBluePrintOrdered; // 0x58

	// Properties
	public static BasePlayer Entity { get; set; }
	public static ulong LastAttackerSteamID { get; set; }
	public static string LastAttackerName { get; set; }
	public static float TimeSinceLastDeath { get; }
	public static bool isSleeping { get; }
	public static bool isAdmin { get; }
	public static bool isDeveloper { get; }
	public static BasePlayer LocalOrSpectatePlayer { get; }
	public static BasePlayer SpectatePlayer { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4FA120 Offset: 0x4F9520 VA: 0x1804FA120
	public static BasePlayer get_Entity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4FAB50 Offset: 0x4F9F50 VA: 0x1804FAB50
	public static void set_Entity(BasePlayer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4FA1E0 Offset: 0x4F95E0 VA: 0x1804FA1E0
	public static ulong get_LastAttackerSteamID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4FAC20 Offset: 0x4FA020 VA: 0x1804FAC20
	public static void set_LastAttackerSteamID(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4FA180 Offset: 0x4F9580 VA: 0x1804FA180
	public static string get_LastAttackerName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4FABB0 Offset: 0x4F9FB0 VA: 0x1804FABB0
	public static void set_LastAttackerName(string value) { }

	// RVA: 0x4FA720 Offset: 0x4F9B20 VA: 0x1804FA720
	public static float get_TimeSinceLastDeath() { }

	// RVA: 0x4F8350 Offset: 0x4F7750 VA: 0x1804F8350
	public static void EndLooting() { }

	// RVA: 0x4F86E0 Offset: 0x4F7AE0 VA: 0x1804F86E0
	internal static ItemContainer GetContainer(PlayerInventory.Type type) { }

	// RVA: 0x4F8D80 Offset: 0x4F8180 VA: 0x1804F8D80
	internal static ItemContainer GetLootContainer(int i) { }

	// RVA: 0x4F9D10 Offset: 0x4F9110 VA: 0x1804F9D10
	public static void OnInventoryChanged() { }

	// RVA: 0x4F9EB0 Offset: 0x4F92B0 VA: 0x1804F9EB0
	public static void OnItemAmountChanged() { }

	// RVA: 0x4F9590 Offset: 0x4F8990 VA: 0x1804F9590
	internal static bool HasUnlocked(ItemDefinition targetItem) { }

	// RVA: 0x4F88F0 Offset: 0x4F7CF0 VA: 0x1804F88F0
	internal static float GetCraftLevel() { }

	// RVA: 0x4F8FB0 Offset: 0x4F83B0 VA: 0x1804F8FB0
	internal static bool HasCraftLevel(int levelReq) { }

	// RVA: 0x4F9B90 Offset: 0x4F8F90 VA: 0x1804F9B90
	public static void MoveItem(uint itemid, uint targetContainer, int targetSlot, int amount) { }

	// RVA: 0x4F8100 Offset: 0x4F7500 VA: 0x1804F8100
	public static void DropItemStack(uint itemid) { }

	// RVA: 0x4F82E0 Offset: 0x4F76E0 VA: 0x1804F82E0
	public static void DropItem(uint itemid, int count) { }

	// RVA: 0x4F96E0 Offset: 0x4F8AE0 VA: 0x1804F96E0
	public static void ItemCommand(uint itemid, string command) { }

	// RVA: -1 Offset: -1
	public static void ItemCommandEx<T1>(uint itemid, string command, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1542580 Offset: 0x1541980 VA: 0x181542580
	|-LocalPlayer.ItemCommandEx<int>
	|
	|-RVA: 0x1542730 Offset: 0x1541B30 VA: 0x181542730
	|-LocalPlayer.ItemCommandEx<object>
	*/

	// RVA: 0x4FAA10 Offset: 0x4F9E10 VA: 0x1804FAA10
	public static bool get_isSleeping() { }

	// RVA: 0x4FA790 Offset: 0x4F9B90 VA: 0x1804FA790
	public static bool get_isAdmin() { }

	// RVA: 0x4FA8D0 Offset: 0x4F9CD0 VA: 0x1804FA8D0
	public static bool get_isDeveloper() { }

	// RVA: 0x4F8560 Offset: 0x4F7960 VA: 0x1804F8560
	public static void FindAmmo(List<Item> list, AmmoTypes ammo) { }

	// RVA: 0x4F9A20 Offset: 0x4F8E20 VA: 0x1804F9A20
	public static void ModifyCamera() { }

	// RVA: 0x4F9340 Offset: 0x4F8740 VA: 0x1804F9340
	public static bool HasItems(List<ItemAmount> list, int amount = 1) { }

	// RVA: 0x4F8B60 Offset: 0x4F7F60 VA: 0x1804F8B60
	public static int GetItemAmount(ItemDefinition item) { }

	// RVA: 0x4F7A40 Offset: 0x4F6E40 VA: 0x1804F7A40
	public static string BuildItemRequiredString(List<ItemAmount> list) { }

	// RVA: 0x4F9010 Offset: 0x4F8410 VA: 0x1804F9010
	public static bool HasInventoryItem(int id) { }

	// RVA: 0x4F9F00 Offset: 0x4F9300 VA: 0x1804F9F00
	public static void ResetCraftCounts() { }

	// RVA: 0x4F9880 Offset: 0x4F8C80 VA: 0x1804F9880
	public static void ListCraftCounts() { }

	// RVA: 0x4F8790 Offset: 0x4F7B90 VA: 0x1804F8790
	public static int GetCraftCount(ItemBlueprint x) { }

	// RVA: 0x4F7960 Offset: 0x4F6D60 VA: 0x1804F7960
	public static void AddCraftCount(ItemBlueprint x) { }

	// RVA: 0x4FA240 Offset: 0x4F9640 VA: 0x1804FA240
	public static BasePlayer get_LocalOrSpectatePlayer() { }

	// RVA: 0x4FA360 Offset: 0x4F9760 VA: 0x1804FA360
	public static BasePlayer get_SpectatePlayer() { }

	// RVA: 0x4FA070 Offset: 0x4F9470 VA: 0x1804FA070
	private static void .cctor() { }

}

public class LocalPlayer.ItemBlueprintComparer : IComparer<ItemBlueprint> // TypeDefIndex: 9665
{	// Methods

	// RVA: 0x4EBD60 Offset: 0x4EB160 VA: 0x1804EBD60 Slot: 4
	public int Compare(ItemBlueprint a, ItemBlueprint b) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class LocalPlayer.<>c__DisplayClass40_0 // TypeDefIndex: 9666
{	// Fields
	public int id; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x508910 Offset: 0x507D10 VA: 0x180508910
	internal bool <HasInventoryItem>b__0(IPlayerItem x) { }

}

