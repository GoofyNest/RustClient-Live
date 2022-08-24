public abstract class Module : ISerializable, ICustomAttributeProvider, _Module // TypeDefIndex: 571
{
	public static readonly TypeFilter FilterTypeName; 
	public static readonly TypeFilter FilterTypeNameIgnoreCase; 
	internal IntPtr _impl; 
	internal Assembly assembly; 
	internal string fqname; 
	internal string name; 
	internal string scopename; 
	internal bool is_resource; 
	internal int token; 
private const BindingFlags defaultBindingFlags = 28;

public virtual Assembly Assembly { get; }
public virtual string ScopeName { get; }
public virtual Guid ModuleVersionId { get; }


protected void .ctor() { }

public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

public override string ToString() { }

internal virtual Guid GetModuleVersionId() { }

private static bool filter_by_type_name(Type m, object filterCriteria) { }

private static bool filter_by_type_name_ignore_case(Type m, object filterCriteria) { }

private string GetGuidInternal() { }

public override bool Equals(object o) { }

public override int GetHashCode() { }

public static bool op_Equality(Module left, Module right) { }

public virtual Assembly get_Assembly() { }

public virtual string get_ScopeName() { }

public virtual Guid get_ModuleVersionId() { }

private static Exception CreateNIE() { }

public virtual bool IsResource() { }

public virtual object[] GetCustomAttributes(bool inherit) { }

public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

public virtual bool IsDefined(Type attributeType, bool inherit) { }

private static void .cctor() { }

}

