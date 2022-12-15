public class BaseEventUI : MonoBehaviour // TypeDefIndex: 12567
{
	[HideInInspector]
	public AIEventType EventType;
	public RustText TextEventType;
	public RustText TextOutput;
	public RustButton ToggleInvert;
	public Dropdown DropdownInputMemorySlot;
	public Dropdown DropdownOutputMemorySlot;
	public RustInput InputFloatValue;
	public RustInput InputFloatValue2;
	[HideInInspector]
	public BaseStateUI Output;
	[CompilerGeneratedAttribute]
	private int <ID>k__BackingField;
	private BaseStateUI stateUI;
	private Color outputColor;

	public int ID { get; set; }


	[CompilerGeneratedAttribute]
	public int get_ID() { }

	[CompilerGeneratedAttribute]
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

