internal abstract class ReflectionDelegateFactory // TypeDefIndex: 5921
{	// Methods

	// RVA: -1 Offset: -1
	public Func<T, object> CreateGet<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B151D0 Offset: 0x1B145D0 VA: 0x181B151D0
	|-ReflectionDelegateFactory.CreateGet<object>
	*/

	// RVA: -1 Offset: -1
	public Action<T, object> CreateSet<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1259680 Offset: 0x1258A80 VA: 0x181259680
	|-ReflectionDelegateFactory.CreateSet<object>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateMethodCall<object>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Func<T> CreateDefaultConstructor<T>(Type type);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateDefaultConstructor<object>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateGet<object>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateGet<object>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateSet<object>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateSet<object>
	*/

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

