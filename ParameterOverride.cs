public abstract class ParameterOverride // TypeDefIndex: 11820
{	// Fields
	public bool overrideState; // 0x10

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void Interp(ParameterOverride from, ParameterOverride to, float t);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetHash();

	// RVA: -1 Offset: -1
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

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	protected internal virtual void OnEnable() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	protected internal virtual void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void SetValue(ParameterOverride parameter);

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

