public class OvenLootPanel : MonoBehaviour // TypeDefIndex: 12784
{
	public GameObject controlsOn; 
	public GameObject controlsOff; 
	public Image TitleBackground; 
	public RustText TitleText; 
	public Color AlertBackgroundColor; 
	public Color AlertTextColor; 
	public Color OffBackgroundColor; 
	public Color OffTextColor; 
	public Color OnBackgroundColor; 
	public Color OnTextColor; 
	private Translate.Phrase OffPhrase; 
	private Translate.Phrase OnPhrase; 
	private Translate.Phrase NoFuelPhrase; 
	public GameObject FuelRowPrefab; 
	public GameObject MaterialRowPrefab; 
	public GameObject ItemRowPrefab; 
	public Sprite IconBackground_Wood; 
	public Sprite IconBackGround_Input; 
	public LootGrid LootGrid_Wood; 
	public LootGrid LootGrid_Input; 
	public LootGrid LootGrid_Output; 
	public GameObject Contents; 
	private ItemContainerSource containerSource; 
	private int _slotIndex; 
	private List<OvenItemIcon> _icons; 
	private bool _inventoryCreated; 


	public void SetStatus(OvenStatus status) { }

	public void EnsureInventoryCreated(BaseOven oven, ItemContainerSource source) { }

	private void CreateInventory(int fuelSlots, int inputSlots, int outputSlots, ItemContainerSource container) { }

	private void AddRows(int count, OvenSlotType inputType, OvenSlotType outputType) { }

	[IteratorStateMachineAttribute] 
	public IEnumerable<ItemIcon> GetItemIcons() { }

	public void .ctor() { }

}

private sealed class OvenLootPanel.<GetItemIcons>d__30 : IEnumerable<ItemIcon>, IEnumerable, IEnumerator<ItemIcon>, IEnumerator, IDisposable // TypeDefIndex: 12785
{
	private int <>1__state; 
	private ItemIcon <>2__current; 
	private int <>l__initialThreadId; 
	public OvenLootPanel <>4__this; 
	private List.Enumerator<OvenItemIcon> <>7__wrap1; 

	private ItemIcon System.Collections.Generic.IEnumerator<ItemIcon>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] 
	private ItemIcon System.Collections.Generic.IEnumerator<ItemIcon>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] 
	private IEnumerator<ItemIcon> System.Collections.Generic.IEnumerable<ItemIcon>.GetEnumerator() { }

	[DebuggerHiddenAttribute] 
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

