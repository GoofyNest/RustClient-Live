public sealed class ReadOnlyAttribute : Attribute // TypeDefIndex: 2738
{
	private bool isReadOnly; 
	public static readonly ReadOnlyAttribute Yes; 
	public static readonly ReadOnlyAttribute No; 
	public static readonly ReadOnlyAttribute Default; 

	public bool IsReadOnly { get; }


	public void .ctor(bool isReadOnly) { }

	public bool get_IsReadOnly() { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

	public override bool IsDefaultAttribute() { }

	private static void .cctor() { }

}

public sealed class ReadOnlyAttribute : Attribute // TypeDefIndex: 3315
{

	public void .ctor() { }

}

public class ReadOnlyAttribute : PropertyAttribute // TypeDefIndex: 8028
{

	public void .ctor() { }

}

