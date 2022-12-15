public class IconSkinPicker : MonoBehaviour // TypeDefIndex: 10934
{
	private static IconSkinPicker.SkinHistory loadedHistory;
	private const string PrefsKey = "SkinHistory";
	public GameObjectRef pickerIcon;
	public GameObject container;
	public Action skinChangedEvent;
	public ScrollRect scroller;
	public SearchFilterInput searchFilter;
	private ItemBlueprint lastBlueprintRefresh;
	private List<IconSkin> spawnedSkinIcons;


	public static bool HasRecentlyUsed(int skinId, out TimeSpan timeSince) { }

	public static void RegisterAsRecentlyUsedSkin(int skinId) { }

	private static void LoadSkinHistory() { }

	private static void SaveSkinHistory() { }

	private void OnEnable() { }

	private void OnSearchFilterChanged(string filter) { }

	private void OnDisable() { }

	internal void ForceNextRefresh() { }

	internal bool Refresh(ItemBlueprint blueprint) { }

	private void ResetScroller() { }

	private int CompareSkinOption(IconSkinPicker.SkinButtonSetup a, IconSkinPicker.SkinButtonSetup b) { }

	private void AddOption(ItemDefinition item, int skinid, string text, bool canUse) { }

	public virtual void OnSkinChanged(int skinId) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private class IconSkinPicker.SkinHistory // TypeDefIndex: 10935
{
	public Dictionary<int, long> lastUsedSkins;


	public void .ctor() { }

}

private struct IconSkinPicker.SkinButtonSetup // TypeDefIndex: 10936
{
	public ItemDefinition item;
	public int skinid;
	public string text;
	public bool canUse;

}

