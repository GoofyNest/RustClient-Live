public sealed class NamedPermissionSet : PermissionSet // TypeDefIndex: 901
{	private string name; // 0x30
	private string description; // 0x38

	public string Name { get; set; }


	internal void .ctor() { }

	public void .ctor(string name, PermissionState state) { }

	public void .ctor(string name) { }

	public string get_Name() { }

	public void set_Name(string value) { }

	public override SecurityElement ToXml() { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public override int GetHashCode() { }

}

