public abstract class TypeInfo : Type, IReflectableType // TypeDefIndex: 554
{	// Properties
	public virtual IEnumerable<FieldInfo> DeclaredFields { get; }

	// Methods

	[FriendAccessAllowedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFF1640 Offset: 0xFF0A40 VA: 0x180FF1640
	internal void .ctor() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 120
	private TypeInfo System.Reflection.IReflectableType.GetTypeInfo() { }

	// RVA: 0xFF16A0 Offset: 0xFF0AA0 VA: 0x180FF16A0 Slot: 121
	public virtual IEnumerable<FieldInfo> get_DeclaredFields() { }

}

internal class TypeInfo : IRemotingTypeInfo // TypeDefIndex: 1153
{	// Fields
	private string serverType; // 0x10
	private string[] serverHierarchy; // 0x18
	private string[] interfacesImplemented; // 0x20

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x1200E50 Offset: 0x1200250 VA: 0x181200E50
	public void .ctor(Type type) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 4
	public string get_TypeName() { }

	// RVA: 0x1200BF0 Offset: 0x11FFFF0 VA: 0x181200BF0 Slot: 5
	public bool CanCastTo(Type fromType, object o) { }

}

