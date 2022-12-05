public abstract class ParameterOverride // TypeDefIndex: 13629
{
	public bool overrideState;


	internal abstract void Interp(ParameterOverride from, ParameterOverride to, float t);

	public abstract int GetHash();

	public T GetValue<T>() { }
	/* GenericInstMethod :
	|
	|-ParameterOverride.GetValue<bool>
	|
	|-ParameterOverride.GetValue<int>
	|-ParameterOverride.GetValue<Int32Enum>
	|
	|-ParameterOverride.GetValue<object>
	|
	|-ParameterOverride.GetValue<float>
	|
	|-ParameterOverride.GetValue<Color>
	|-ParameterOverride.GetValue<Vector4>
	|
	|-ParameterOverride.GetValue<Vector2>
	|
	|-ParameterOverride.GetValue<Vector3>
	*/

	protected internal virtual void OnEnable() { }

	protected internal virtual void OnDisable() { }

	internal abstract void SetValue(ParameterOverride parameter);

	protected void .ctor() { }

}

