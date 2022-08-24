public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo // TypeDefIndex: 596
{
	protected Type ClassImpl; 
	protected object DefaultValueImpl; 
	protected MemberInfo MemberImpl; 
	protected string NameImpl; 
	protected int PositionImpl; 
	protected ParameterAttributes AttrsImpl; 
	internal MarshalAsAttribute marshalAs; 

public virtual Type ParameterType { get; }
public virtual ParameterAttributes Attributes { get; }
public bool IsIn { get; }
public bool IsOptional { get; }
public bool IsOut { get; }
public bool IsRetval { get; }
public virtual MemberInfo Member { get; }
public virtual string Name { get; }
public virtual int Position { get; }
public virtual object DefaultValue { get; }


protected void .ctor() { }

public override string ToString() { }

internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization) { }

public virtual Type get_ParameterType() { }

public virtual ParameterAttributes get_Attributes() { }

public bool get_IsIn() { }

public bool get_IsOptional() { }

public bool get_IsOut() { }

public bool get_IsRetval() { }

public virtual MemberInfo get_Member() { }

public virtual string get_Name() { }

public virtual int get_Position() { }

internal object[] GetPseudoCustomAttributes() { }

internal object GetDefaultValueImpl() { }

public virtual object get_DefaultValue() { }

public virtual object[] GetCustomAttributes(bool inherit) { }

public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

public object GetRealObject(StreamingContext context) { }

public virtual bool IsDefined(Type attributeType, bool inherit) { }

internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member) { }

}

