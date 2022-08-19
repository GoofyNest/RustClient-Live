internal abstract class BaseInvokableCall // TypeDefIndex: 3627
{	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x181A460 Offset: 0x1819860 VA: 0x18181A460
	protected void .ctor(object target, MethodInfo function) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Invoke(object[] args);

	// RVA: -1 Offset: -1
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

	// RVA: 0x181A3B0 Offset: 0x18197B0 VA: 0x18181A3B0
	protected static bool AllowInvoke(Delegate delegate) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Find(object targetObj, MethodInfo method);

}

