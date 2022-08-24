public abstract class ConstructorBuilder : ConstructorInfo // TypeDefIndex: 600
{

public abstract class ConstructorBuilder : ConstructorInfo 
public override MethodAttributes Attributes { get; }
public override Type DeclaringType { get; }
public override string Name { get; }
public override RuntimeMethodHandle MethodHandle { get; }
public override Type ReflectedType { get; }


public override MethodAttributes get_Attributes() { }

public override Type get_DeclaringType() { }

public override string get_Name() { }

public override ParameterInfo[] GetParameters() { }

public override RuntimeMethodHandle get_MethodHandle() { }

public override Type get_ReflectedType() { }

public override object[] GetCustomAttributes(bool inherit) { }

public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

public override MethodImplAttributes GetMethodImplementationFlags() { }

public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

public override bool IsDefined(Type attributeType, bool inherit) { }

}

