public abstract class TypeDescriptionProvider // TypeDefIndex: 2755
{	private TypeDescriptionProvider _parent; // 0x10
	private TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor; // 0x18


	protected void .ctor() { }

	public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	public virtual IDictionary GetCache(object instance) { }

	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

	public Type GetReflectionType(Type objectType) { }

	public virtual Type GetReflectionType(Type objectType, object instance) { }

	public ICustomTypeDescriptor GetTypeDescriptor(Type objectType) { }

	public ICustomTypeDescriptor GetTypeDescriptor(object instance) { }

	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

private sealed class TypeDescriptionProvider.EmptyCustomTypeDescriptor : CustomTypeDescriptor // TypeDefIndex: 2756
{
	public void .ctor() { }

}

