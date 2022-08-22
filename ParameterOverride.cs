public abstract class ParameterOverride // TypeDefIndex: 11820
{	public bool overrideState; // 0x10


	internal abstract void Interp(ParameterOverride from, ParameterOverride to, float t);

	public abstract int GetHash();

	public T GetValue<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BF980 Offset: 0x14BED80 VA: 0x1814BF980
	|-ParameterOverride.GetValue<bool>
	|
	|-RVA: 0x14BFAD0 Offset: 0x14BEED0 VA: 0x1814BFAD0
	|-ParameterOverride.GetValue<int>
	|-ParameterOverride.GetValue<Int32Enum>
	|
	|-RVA: 0x14BFB70 Offset: 0x14BEF70 VA: 0x1814BFB70
	|-ParameterOverride.GetValue<object>
	|
	|-RVA: 0x14BFC10 Offset: 0x14BF010 VA: 0x1814BFC10
	|-ParameterOverride.GetValue<float>
	|
	|-RVA: 0x14BFA20 Offset: 0x14BEE20 VA: 0x1814BFA20
	|-ParameterOverride.GetValue<Color>
	|-ParameterOverride.GetValue<Vector4>
	|
	|-RVA: 0x14BFCB0 Offset: 0x14BF0B0 VA: 0x1814BFCB0
	|-ParameterOverride.GetValue<Vector2>
	|
	|-RVA: 0x14BFD60 Offset: 0x14BF160 VA: 0x1814BFD60
	|-ParameterOverride.GetValue<Vector3>
	*/

	protected internal virtual void OnEnable() { }

	protected internal virtual void OnDisable() { }

	internal abstract void SetValue(ParameterOverride parameter);

	protected void .ctor() { }

}

