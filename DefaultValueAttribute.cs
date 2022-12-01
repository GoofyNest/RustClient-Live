public class DefaultValueAttribute : Attribute // TypeDefIndex: 2687
{
	private object value;

	public virtual object Value { get; }


	public void .ctor(int value) { }

	public void .ctor(long value) { }

	public void .ctor(bool value) { }

	public void .ctor(string value) { }

	public void .ctor(object value) { }

	public virtual object get_Value() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

}

public class DefaultValueAttribute : Attribute // TypeDefIndex: 3803
{
	private object DefaultValue;

	public object Value { get; }


	public void .ctor(string value) { }

	public object get_Value() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

}

