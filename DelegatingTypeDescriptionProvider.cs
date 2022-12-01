internal sealed class DelegatingTypeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 2688
{
	private Type _type;

	internal TypeDescriptionProvider Provider { get; }


	internal void .ctor(Type type) { }

	internal TypeDescriptionProvider get_Provider() { }

	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	public override IDictionary GetCache(object instance) { }

	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	public override Type GetReflectionType(Type objectType, object instance) { }

	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

