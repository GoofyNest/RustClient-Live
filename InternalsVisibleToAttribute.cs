public sealed class InternalsVisibleToAttribute : Attribute // TypeDefIndex: 1307
{
	private string _assemblyName; 
	private bool _allInternalsVisible; 

public string AssemblyName { get; }
public bool AllInternalsVisible { get; set; }


public void .ctor(string assemblyName) { }

public string get_AssemblyName() { }

public bool get_AllInternalsVisible() { }

public void set_AllInternalsVisible(bool value) { }

}

