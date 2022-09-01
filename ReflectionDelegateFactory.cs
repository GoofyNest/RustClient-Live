internal abstract class ReflectionDelegateFactory // TypeDefIndex: 5922
{

	public Func<T, object> CreateGet<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-ReflectionDelegateFactory.CreateGet<object>
	*/

	public Action<T, object> CreateSet<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-ReflectionDelegateFactory.CreateSet<object>
	*/

	public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);
	/* GenericInstMethod :
	|
	|-ReflectionDelegateFactory.CreateMethodCall<object>
	*/

	public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);

	public abstract Func<T> CreateDefaultConstructor<T>(Type type);
	/* GenericInstMethod :
	|
	|-ReflectionDelegateFactory.CreateDefaultConstructor<object>
	*/

	public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);
	/* GenericInstMethod :
	|
	|-ReflectionDelegateFactory.CreateGet<object>
	*/

	public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo);
	/* GenericInstMethod :
	|
	|-ReflectionDelegateFactory.CreateGet<object>
	*/

	public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo);
	/* GenericInstMethod :
	|
	|-ReflectionDelegateFactory.CreateSet<object>
	*/

	public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);
	/* GenericInstMethod :
	|
	|-ReflectionDelegateFactory.CreateSet<object>
	*/

	protected void .ctor() { }

}

