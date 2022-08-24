public abstract class FieldBuilder : FieldInfo // TypeDefIndex: 604
{

public abstract class FieldBuilder : FieldInfo 
	public override FieldAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override Type FieldType { get; }
	public override string Name { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override Type ReflectedType { get; }


	public override FieldAttributes get_Attributes() { }

	public override Type get_DeclaringType() { }

	public override Type get_FieldType() { }

	public override string get_Name() { }

	public override object GetValue(object obj) { }

	public override RuntimeFieldHandle get_FieldHandle() { }

	public override Type get_ReflectedType() { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}

