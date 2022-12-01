public class DisplayNameAttribute : Attribute // TypeDefIndex: 2696
{
	public static readonly DisplayNameAttribute Default;
	private string _displayName;

	public virtual string DisplayName { get; }
	protected string DisplayNameValue { get; }


	public void .ctor() { }

	public void .ctor(string displayName) { }

	public virtual string get_DisplayName() { }

	protected string get_DisplayNameValue() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override bool IsDefaultAttribute() { }

	private static void .cctor() { }

}

public sealed class DisplayNameAttribute : Attribute // TypeDefIndex: 13553
{
	public readonly string displayName;


	public void .ctor(string displayName) { }

}

