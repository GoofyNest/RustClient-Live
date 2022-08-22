internal sealed class SerializationFieldInfo : FieldInfo // TypeDefIndex: 1057
{	private RuntimeFieldInfo m_field; // 0x10
	private string m_serializationName; // 0x18

	public override Module Module { get; }
	public override int MetadataToken { get; }
	public override string Name { get; }
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override Type FieldType { get; }
	internal RuntimeFieldInfo FieldInfo { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override FieldAttributes Attributes { get; }


	public override Module get_Module() { }

	public override int get_MetadataToken() { }

	internal void .ctor(RuntimeFieldInfo field, string namePrefix) { }

	public override string get_Name() { }

	public override Type get_DeclaringType() { }

	public override Type get_ReflectedType() { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public override Type get_FieldType() { }

	public override object GetValue(object obj) { }

	internal object InternalGetValue(object obj) { }

	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	internal void InternalSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	internal RuntimeFieldInfo get_FieldInfo() { }

	public override RuntimeFieldHandle get_FieldHandle() { }

	public override FieldAttributes get_Attributes() { }

}

