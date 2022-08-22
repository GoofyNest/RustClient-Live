internal abstract class BaseInvokableCall // TypeDefIndex: 3627
{
	protected void .ctor() { }

	protected void .ctor(object target, MethodInfo function) { }

	public abstract void Invoke(object[] args);

	protected static void ThrowOnInvalidArg<T>(object arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E4270 Offset: 0x5E3670 VA: 0x1805E4270
	|-BaseInvokableCall.ThrowOnInvalidArg<Option>
	|
	|-RVA: 0x5E3CF0 Offset: 0x5E30F0 VA: 0x1805E3CF0
	|-BaseInvokableCall.ThrowOnInvalidArg<bool>
	|
	|-RVA: 0x5E4110 Offset: 0x5E3510 VA: 0x1805E4110
	|-BaseInvokableCall.ThrowOnInvalidArg<int>
	|
	|-RVA: 0x5E3FB0 Offset: 0x5E33B0 VA: 0x1805E3FB0
	|-BaseInvokableCall.ThrowOnInvalidArg<Int32Enum>
	|
	|-RVA: 0x5E43D0 Offset: 0x5E37D0 VA: 0x1805E43D0
	|-BaseInvokableCall.ThrowOnInvalidArg<object>
	|
	|-RVA: 0x5E4530 Offset: 0x5E3930 VA: 0x1805E4530
	|-BaseInvokableCall.ThrowOnInvalidArg<float>
	|
	|-RVA: 0x5E4690 Offset: 0x5E3A90 VA: 0x1805E4690
	|-BaseInvokableCall.ThrowOnInvalidArg<ulong>
	|
	|-RVA: 0x5E3E50 Offset: 0x5E3250 VA: 0x1805E3E50
	|-BaseInvokableCall.ThrowOnInvalidArg<Color>
	|
	|-RVA: 0x5E47F0 Offset: 0x5E3BF0 VA: 0x1805E47F0
	|-BaseInvokableCall.ThrowOnInvalidArg<Vector2>
	*/

	protected static bool AllowInvoke(Delegate delegate) { }

	public abstract bool Find(object targetObj, MethodInfo method);

}

