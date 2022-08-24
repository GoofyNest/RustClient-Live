public abstract class CustomTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 2681
{

public class ComponentConverter : ReferenceConverter 

public class CultureInfoConverter : TypeConverter 

public abstract class CustomTypeDescriptor : ICustomTypeDescriptor 
	private ICustomTypeDescriptor _parent; 


	protected void .ctor() { }

	public virtual AttributeCollection GetAttributes() { }

	public virtual TypeConverter GetConverter() { }

	public virtual PropertyDescriptorCollection GetProperties() { }

	public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	public virtual object GetPropertyOwner(PropertyDescriptor pd) { }

}

