public sealed class ReadOnlyAttribute : Attribute // TypeDefIndex: 2738
{	private bool isReadOnly; // 0x10
	public static readonly ReadOnlyAttribute Yes; // 0x0
	public static readonly ReadOnlyAttribute No; // 0x8
	public static readonly ReadOnlyAttribute Default; // 0x10

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

public class ReadOnlyAttribute : PropertyAttribute // TypeDefIndex: 8019
{
	public void .ctor() { }

}

