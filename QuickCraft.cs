public class QuickCraft : SingletonComponent<QuickCraft>, IInventoryChanged // TypeDefIndex: 12833
{
	public GameObjectRef craftButton;
	public GameObject empty;
	public Sprite FavouriteOnSprite;
	public Sprite FavouriteOffSprite;
	public Color FavouriteOnColor;
	public Color FavouriteOffColor;
	public static HashSet<ItemBlueprint> FavouriteBlueprints;
	private float lastRebuildTime;
	private bool forceRebuild;
	private bool isDirty;
	private int lastHash;
	private const int buttonCount = 18;


	protected override void Awake() { }

	private void LoadFavourites() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public void OnInventoryChanged() { }

	private void Dirty() { }

	[IteratorStateMachineAttribute]
	private IEnumerator WatchForChanges() { }

	private void Rebuild() { }

	public bool RecentlyRebuilt() { }

	public void ForceRebuild() { }

	public void ToggleFavourite(ItemBlueprint bp) { }

	public static bool IsBluePrintFavourited(ItemBlueprint bp) { }

	public static void AddFavouriteBlueprint(ItemBlueprint bp) { }

	public static void RemoveFavouriteBlueprint(ItemBlueprint bp) { }

	private static string GetSaveString(ItemBlueprint bp) { }

	public void SetFavouriteIconState(bool favourited, Image image) { }

	public void SetFavouriteIconHoveredState(bool favourited, Image image) { }

	public void SetFavouriteIconUnhoveredState(bool favourited, Image image) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class QuickCraft.<WatchForChanges>d__16 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12834
{
	private int <>1__state;
	private object <>2__current;
	public QuickCraft <>4__this;

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

}

