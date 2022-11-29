internal abstract class BaseInvokableCall // TypeDefIndex: 3630
{

	protected void .ctor() { }

	protected void .ctor(object target, MethodInfo function) { }

	public abstract void Invoke(object[] args);

	protected static void ThrowOnInvalidArg<T>(object arg) { }
	/* GenericInstMethod :
	|
	|-BaseInvokableCall.ThrowOnInvalidArg<Option>
	|
	|-BaseInvokableCall.ThrowOnInvalidArg<bool>
	|
	|-BaseInvokableCall.ThrowOnInvalidArg<int>
	|
	|-BaseInvokableCall.ThrowOnInvalidArg<Int32Enum>
	|
	|-BaseInvokableCall.ThrowOnInvalidArg<object>
	|
	|-BaseInvokableCall.ThrowOnInvalidArg<float>
	|
	|-BaseInvokableCall.ThrowOnInvalidArg<ulong>
	|
	|-BaseInvokableCall.ThrowOnInvalidArg<Color>
	|
	|-BaseInvokableCall.ThrowOnInvalidArg<Vector2>
	*/

	protected static bool AllowInvoke(Delegate delegate) { }

	public abstract bool Find(object targetObj, MethodInfo method);

}

