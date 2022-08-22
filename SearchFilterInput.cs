public class SearchFilterInput : MonoBehaviour // TypeDefIndex: 9234
{	public GameObject OpenRoot; // 0x18
	public GameObject ClosedRoot; // 0x20
	public RustInput InputField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <CurrentSearchInput>k__BackingField; // 0x30
	public Action<string> OnSearchFilterChanged; // 0x38

	public bool IsOpen { get; }
	public string CurrentSearchInput { get; set; }


	public bool get_IsOpen() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_CurrentSearchInput() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_CurrentSearchInput(string value) { }

	public void Toggle() { }

	public void SetOpen(bool state) { }

	public void Cancel() { }

	public void OnSearchStringChanged(string newInput) { }

	public void OnSearchStringSubmit(string newInput) { }

	public void .ctor() { }

}

