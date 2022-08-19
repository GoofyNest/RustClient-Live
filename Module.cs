public abstract class Module : ISerializable, ICustomAttributeProvider, _Module // TypeDefIndex: 571
{	// Fields
	public static readonly TypeFilter FilterTypeName; // 0x0
	public static readonly TypeFilter FilterTypeNameIgnoreCase; // 0x8
	internal IntPtr _impl; // 0x10
	internal Assembly assembly; // 0x18
	internal string fqname; // 0x20
	internal string name; // 0x28
	internal string scopename; // 0x30
	internal bool is_resource; // 0x38
	internal int token; // 0x3C
	private const BindingFlags defaultBindingFlags = 28;

	// Properties
	public virtual Assembly Assembly { get; }
	public virtual string ScopeName { get; }
	public virtual Guid ModuleVersionId { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x18C8100 Offset: 0x18C7500 VA: 0x1818C8100 Slot: 8
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 3
	public override string ToString() { }

	// RVA: 0x18C80D0 Offset: 0x18C74D0 VA: 0x1818C80D0 Slot: 9
	internal virtual Guid GetModuleVersionId() { }

	// RVA: 0x18C83E0 Offset: 0x18C77E0 VA: 0x1818C83E0
	private static bool filter_by_type_name(Type m, object filterCriteria) { }

	// RVA: 0x18C82C0 Offset: 0x18C76C0 VA: 0x1818C82C0
	private static bool filter_by_type_name_ignore_case(Type m, object filterCriteria) { }

	// RVA: 0x18C80C0 Offset: 0x18C74C0 VA: 0x1818C80C0
	private string GetGuidInternal() { }

	// RVA: 0x128C380 Offset: 0x128B780 VA: 0x18128C380 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0xCC95C0 Offset: 0xCC89C0 VA: 0x180CC95C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C11E0 Offset: 0x18C05E0 VA: 0x1818C11E0
	public static bool op_Equality(Module left, Module right) { }

	// RVA: 0x18C84F0 Offset: 0x18C78F0 VA: 0x1818C84F0 Slot: 10
	public virtual Assembly get_Assembly() { }

	// RVA: 0x18C85B0 Offset: 0x18C79B0 VA: 0x1818C85B0 Slot: 11
	public virtual string get_ScopeName() { }

	// RVA: 0x18C8550 Offset: 0x18C7950 VA: 0x1818C8550 Slot: 12
	public virtual Guid get_ModuleVersionId() { }

	// RVA: 0x18C7FB0 Offset: 0x18C73B0 VA: 0x1818C7FB0
	private static Exception CreateNIE() { }

	// RVA: 0x18C81B0 Offset: 0x18C75B0 VA: 0x1818C81B0 Slot: 13
	public virtual bool IsResource() { }

	// RVA: 0x18C8060 Offset: 0x18C7460 VA: 0x1818C8060 Slot: 14
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C8000 Offset: 0x18C7400 VA: 0x1818C8000 Slot: 15
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C8150 Offset: 0x18C7550 VA: 0x1818C8150 Slot: 16
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18C8210 Offset: 0x18C7610 VA: 0x1818C8210
	private static void .cctor() { }

}

