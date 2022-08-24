public class WellKnownServiceTypeEntry : TypeEntry // TypeDefIndex: 1156
{
	private Type obj_type; 
	private string obj_uri; 
	private WellKnownObjectMode obj_mode; 

	public WellKnownObjectMode Mode { get; }
	public Type ObjectType { get; }
	public string ObjectUri { get; }


	public void .ctor(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode) { }

	public WellKnownObjectMode get_Mode() { }

	public Type get_ObjectType() { }

	public string get_ObjectUri() { }

	public override string ToString() { }

}

