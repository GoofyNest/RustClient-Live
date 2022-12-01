public sealed class NamedPermissionSet : PermissionSet // TypeDefIndex: 901
{
	private string name;
	private string description;

	public string Name { get; set; }


	internal void .ctor() { }

	public void .ctor(string name, PermissionState state) { }

	public void .ctor(string name) { }

	public string get_Name() { }

	public void set_Name(string value) { }

	public override SecurityElement ToXml() { }

	[ComVisibleAttribute]
	public override bool Equals(object obj) { }

	[ComVisibleAttribute]
	public override int GetHashCode() { }

}

