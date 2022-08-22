public abstract class Module : ISerializable, ICustomAttributeProvider, _Module // TypeDefIndex: 571
{	public static readonly TypeFilter FilterTypeName; // 0x0
	public static readonly TypeFilter FilterTypeNameIgnoreCase; // 0x8
	internal IntPtr _impl; // 0x10
	internal Assembly assembly; // 0x18
	internal string fqname; // 0x20
	internal string name; // 0x28
	internal string scopename; // 0x30
	internal bool is_resource; // 0x38
	internal int token; // 0x3C
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

