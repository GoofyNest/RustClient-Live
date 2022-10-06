public class SearchFilterInput : MonoBehaviour // TypeDefIndex: 10942
{
	public GameObject OpenRoot; 
	public GameObject ClosedRoot; 
	public RustInput InputField; 
	[CompilerGeneratedAttribute] 
	private string <CurrentSearchInput>k__BackingField; 
	public Action<string> OnSearchFilterChanged; 

	public bool IsOpen { get; }
	public string CurrentSearchInput { get; set; }


	public bool get_IsOpen() { }

	[CompilerGeneratedAttribute] 
	public string get_CurrentSearchInput() { }

	[CompilerGeneratedAttribute] 
	private void set_CurrentSearchInput(string value) { }

	public void Toggle() { }

	public void SetOpen(bool state) { }

	public void Cancel() { }

	public void OnSearchStringChanged(string newInput) { }

	public void OnSearchStringSubmit(string newInput) { }

	public void .ctor() { }

}

