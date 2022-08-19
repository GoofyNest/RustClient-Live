public class SearchFilterInput : MonoBehaviour // TypeDefIndex: 9234
{	// Fields
	public GameObject OpenRoot; // 0x18
	public GameObject ClosedRoot; // 0x20
	public RustInput InputField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <CurrentSearchInput>k__BackingField; // 0x30
	public Action<string> OnSearchFilterChanged; // 0x38

	// Properties
	public bool IsOpen { get; }
	public string CurrentSearchInput { get; set; }

	// Methods

	// RVA: 0x4A2EF0 Offset: 0x4A22F0 VA: 0x1804A2EF0
	public bool get_IsOpen() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_CurrentSearchInput() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	private void set_CurrentSearchInput(string value) { }

	// RVA: 0x4A2EA0 Offset: 0x4A22A0 VA: 0x1804A2EA0
	public void Toggle() { }

	// RVA: 0x4A2DB0 Offset: 0x4A21B0 VA: 0x1804A2DB0
	public void SetOpen(bool state) { }

	// RVA: 0x4A2BD0 Offset: 0x4A1FD0 VA: 0x1804A2BD0
	public void Cancel() { }

	// RVA: 0x4A2CD0 Offset: 0x4A20D0 VA: 0x1804A2CD0
	public void OnSearchStringChanged(string newInput) { }

	// RVA: 0x4A2D40 Offset: 0x4A2140 VA: 0x1804A2D40
	public void OnSearchStringSubmit(string newInput) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

