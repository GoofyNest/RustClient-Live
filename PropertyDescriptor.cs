public abstract class PropertyDescriptor : MemberDescriptor // TypeDefIndex: 2734
{
	private TypeConverter converter; 
	private Hashtable valueChangedHandlers; 
	private object[] editors; 
	private Type[] editorTypes; 
	private int editorCount; 

	public abstract Type ComponentType { get; }
	public virtual TypeConverter Converter { get; }
	public abstract bool IsReadOnly { get; }
	public abstract Type PropertyType { get; }


	protected void .ctor(string name, Attribute[] attrs) { }

	protected void .ctor(MemberDescriptor descr, Attribute[] attrs) { }

	public abstract Type get_ComponentType();

	public virtual TypeConverter get_Converter() { }

	public abstract bool get_IsReadOnly();

	public abstract Type get_PropertyType();

	public override bool Equals(object obj) { }

	protected object CreateInstance(Type type) { }

	protected override void FillAttributes(IList attributeList) { }

	public override int GetHashCode() { }

	protected override object GetInvocationTarget(Type type, object instance) { }

	protected Type GetTypeFromName(string typeName) { }

	public abstract object GetValue(object component);

	protected virtual void OnValueChanged(object component, EventArgs e) { }

	public abstract void SetValue(object component, object value);

	public abstract bool ShouldSerializeValue(object component);

}

