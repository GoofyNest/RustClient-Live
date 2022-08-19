public class BaseEventUI : MonoBehaviour // TypeDefIndex: 10788
{	// Fields
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public AIEventType EventType; // 0x18
	public RustText TextEventType; // 0x20
	public RustText TextOutput; // 0x28
	public RustButton ToggleInvert; // 0x30
	public Dropdown DropdownInputMemorySlot; // 0x38
	public Dropdown DropdownOutputMemorySlot; // 0x40
	public RustInput InputFloatValue; // 0x48
	public RustInput InputFloatValue2; // 0x50
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public BaseStateUI Output; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID>k__BackingField; // 0x60
	private BaseStateUI stateUI; // 0x68
	private Color outputColor; // 0x70

	// Properties
	public int ID { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC10 Offset: 0x58D010 VA: 0x18058DC10
	public int get_ID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DCA0 Offset: 0x58D0A0 VA: 0x18058DCA0
	private void set_ID(int value) { }

	// RVA: 0x7FF2B0 Offset: 0x7FE6B0 VA: 0x1807FF2B0 Slot: 4
	public virtual void Init(AIEventType eventType, BaseStateUI stateUI) { }

	// RVA: 0x7FF5C0 Offset: 0x7FE9C0 VA: 0x1807FF5C0 Slot: 5
	public virtual AIEventData Save() { }

	// RVA: 0x7FF3B0 Offset: 0x7FE7B0 VA: 0x1807FF3B0 Slot: 6
	public virtual void Load(AIEventData data) { }

	// RVA: 0x7FF750 Offset: 0x7FEB50 VA: 0x1807FF750
	public void SetOutputStateContainer(int id) { }

	// RVA: 0x7FEF80 Offset: 0x7FE380 VA: 0x1807FEF80
	public void ClearOutputStateContainer() { }

	// RVA: 0x7FF260 Offset: 0x7FE660 VA: 0x1807FF260
	public int GetOutputStateContainer() { }

	// RVA: 0x7FF590 Offset: 0x7FE990 VA: 0x1807FF590
	public float ParseFloat(string input) { }

	// RVA: 0x7FEFD0 Offset: 0x7FE3D0 VA: 0x1807FEFD0
	public void Clicked() { }

	// RVA: 0x7FF4F0 Offset: 0x7FE8F0 VA: 0x1807FF4F0
	public void OutputClicked(object value) { }

	// RVA: 0x7FF230 Offset: 0x7FE630 VA: 0x1807FF230
	public void DeleteClicked() { }

	// RVA: 0x7FF4C0 Offset: 0x7FE8C0 VA: 0x1807FF4C0
	public void MoveUpClicked() { }

	// RVA: 0x7FF490 Offset: 0x7FE890 VA: 0x1807FF490
	public void MoveDownClicked() { }

	// RVA: 0x7FF790 Offset: 0x7FEB90 VA: 0x1807FF790
	public void SetTriggered(bool flag) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

