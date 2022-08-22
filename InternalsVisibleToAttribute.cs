public sealed class InternalsVisibleToAttribute : Attribute // TypeDefIndex: 1307
{	private string _assemblyName; // 0x10
	private bool _allInternalsVisible; // 0x18

	public string AssemblyName { get; }
	public bool AllInternalsVisible { get; set; }


	public void .ctor(string assemblyName) { }

	public string get_AssemblyName() { }

	public bool get_AllInternalsVisible() { }

	public void set_AllInternalsVisible(bool value) { }

}

