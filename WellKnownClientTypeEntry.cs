public class WellKnownClientTypeEntry : TypeEntry // TypeDefIndex: 1154
{
	private Type obj_type; 
	private string obj_url; 
	private string app_url; 

public string ApplicationUrl { get; }
public Type ObjectType { get; }
public string ObjectUrl { get; }


public void .ctor(string typeName, string assemblyName, string objectUrl) { }

public string get_ApplicationUrl() { }

public Type get_ObjectType() { }

public string get_ObjectUrl() { }

public override string ToString() { }

}

