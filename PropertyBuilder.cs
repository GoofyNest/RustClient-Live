public abstract class PropertyBuilder : PropertyInfo // TypeDefIndex: 611
{
public class ParameterBuilder // TypeDefIndex: 610

public abstract class PropertyBuilder : PropertyInfo // TypeDefIndex: 611
	public override PropertyAttributes Attributes { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }


	public override PropertyAttributes get_Attributes() { }

	public override bool get_CanRead() { }

	public override bool get_CanWrite() { }

	public override Type get_DeclaringType() { }

	public override string get_Name() { }

	public override Type get_PropertyType() { }

	public override ParameterInfo[] GetIndexParameters() { }

	public override Type get_ReflectedType() { }

	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override MethodInfo GetGetMethod(bool nonPublic) { }

	public override MethodInfo GetSetMethod(bool nonPublic) { }

	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

}

