public abstract class TypeInfo : Type, IReflectableType // TypeDefIndex: 554
{
	public virtual IEnumerable<FieldInfo> DeclaredFields { get; }


	[FriendAccessAllowedAttribute] 
	internal void .ctor() { }

	private TypeInfo System.Reflection.IReflectableType.GetTypeInfo() { }

	public virtual IEnumerable<FieldInfo> get_DeclaredFields() { }

}

internal class TypeInfo : IRemotingTypeInfo // TypeDefIndex: 1153
{
	private string serverType; 
	private string[] serverHierarchy; 
	private string[] interfacesImplemented; 

	public string TypeName { get; }


	public void .ctor(Type type) { }

	public string get_TypeName() { }

	public bool CanCastTo(Type fromType, object o) { }

}

