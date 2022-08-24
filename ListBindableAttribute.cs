public sealed class ListBindableAttribute : Attribute // TypeDefIndex: 2724
{
	public static readonly ListBindableAttribute Yes; 
	public static readonly ListBindableAttribute No; 
	public static readonly ListBindableAttribute Default; 
	private bool listBindable; 
	private bool isDefault; 

	public bool ListBindable { get; }


	public void .ctor(bool listBindable) { }

	public bool get_ListBindable() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override bool IsDefaultAttribute() { }

	private static void .cctor() { }

}

