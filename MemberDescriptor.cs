public abstract class MemberDescriptor // TypeDefIndex: 2729
{
	private string name;
	private string displayName;
	private int nameHash;
	private AttributeCollection attributeCollection;
	private Attribute[] attributes;
	private Attribute[] originalAttributes;
	private bool attributesFiltered;
	private bool attributesFilled;
	private int metadataVersion;
	private string category;
	private string description;
	private object lockCookie;

	protected virtual Attribute[] AttributeArray { get; set; }
	public virtual AttributeCollection Attributes { get; }
	public virtual string Name { get; }
	protected virtual int NameHashCode { get; }
	public virtual string DisplayName { get; }


	protected void .ctor(string name, Attribute[] attributes) { }

	protected void .ctor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes) { }

	protected virtual Attribute[] get_AttributeArray() { }

	protected virtual void set_AttributeArray(Attribute[] value) { }

	public virtual AttributeCollection get_Attributes() { }

	public virtual string get_Name() { }

	protected virtual int get_NameHashCode() { }

	public virtual string get_DisplayName() { }

	private void CheckAttributesValid() { }

	protected virtual AttributeCollection CreateAttributeCollection() { }

	public override bool Equals(object obj) { }

	protected virtual void FillAttributes(IList attributeList) { }

	private void FilterAttributesIfNeeded() { }

	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType) { }

	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly) { }

	public override int GetHashCode() { }

	protected virtual object GetInvocationTarget(Type type, object instance) { }

	protected static ISite GetSite(object component) { }

}

