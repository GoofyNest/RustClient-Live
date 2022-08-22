public class WellKnownClientTypeEntry : TypeEntry // TypeDefIndex: 1154
{	private Type obj_type; // 0x20
	private string obj_url; // 0x28
	private string app_url; // 0x30

	public string ApplicationUrl { get; }
	public Type ObjectType { get; }
	public string ObjectUrl { get; }


	public void .ctor(string typeName, string assemblyName, string objectUrl) { }

	public string get_ApplicationUrl() { }

	public Type get_ObjectType() { }

	public string get_ObjectUrl() { }

	public override string ToString() { }

}

