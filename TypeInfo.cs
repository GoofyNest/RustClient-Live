public abstract class TypeInfo : Type, IReflectableType // TypeDefIndex: 554
{	public virtual IEnumerable<FieldInfo> DeclaredFields { get; }


	[FriendAccessAllowedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void .ctor() { }

	private TypeInfo System.Reflection.IReflectableType.GetTypeInfo() { }

	public virtual IEnumerable<FieldInfo> get_DeclaredFields() { }

}

internal class TypeInfo : IRemotingTypeInfo // TypeDefIndex: 1153
{	private string serverType; // 0x10
	private string[] serverHierarchy; // 0x18
	private string[] interfacesImplemented; // 0x20

	public string TypeName { get; }


	public void .ctor(Type type) { }

	public string get_TypeName() { }

	public bool CanCastTo(Type fromType, object o) { }

}

