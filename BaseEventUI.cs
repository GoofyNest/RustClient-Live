public class BaseEventUI : MonoBehaviour // TypeDefIndex: 10788
{	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	public int ID { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_ID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_ID(int value) { }

	public virtual void Init(AIEventType eventType, BaseStateUI stateUI) { }

	public virtual AIEventData Save() { }

	public virtual void Load(AIEventData data) { }

	public void SetOutputStateContainer(int id) { }

	public void ClearOutputStateContainer() { }

	public int GetOutputStateContainer() { }

	public float ParseFloat(string input) { }

	public void Clicked() { }

	public void OutputClicked(object value) { }

	public void DeleteClicked() { }

	public void MoveUpClicked() { }

	public void MoveDownClicked() { }

	public void SetTriggered(bool flag) { }

	public void .ctor() { }

}

