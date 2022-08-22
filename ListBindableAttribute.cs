public sealed class ListBindableAttribute : Attribute // TypeDefIndex: 2724
{	public static readonly ListBindableAttribute Yes; // 0x0
	public static readonly ListBindableAttribute No; // 0x8
	public static readonly ListBindableAttribute Default; // 0x10
	private bool listBindable; // 0x10
	private bool isDefault; // 0x11

	public bool ListBindable { get; }


	public void .ctor(bool listBindable) { }

	public bool get_ListBindable() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override bool IsDefaultAttribute() { }

	private static void .cctor() { }

}

