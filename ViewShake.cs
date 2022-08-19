public class ViewShake // TypeDefIndex: 9251
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <PositionOffset>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <AnglesOffset>k__BackingField; // 0x1C
	protected List<ViewShake.ShakeParameters> Entries; // 0x28

	// Properties
	public Vector3 PositionOffset { get; set; }
	public Vector3 AnglesOffset { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7D5F10 Offset: 0x7D5310 VA: 0x1807D5F10
	public Vector3 get_PositionOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7D5F40 Offset: 0x7D5340 VA: 0x1807D5F40
	protected void set_PositionOffset(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7D5EF0 Offset: 0x7D52F0 VA: 0x1807D5EF0
	public Vector3 get_AnglesOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7D5F30 Offset: 0x7D5330 VA: 0x1807D5F30
	protected void set_AnglesOffset(Vector3 value) { }

	// RVA: 0x7D5720 Offset: 0x7D4B20 VA: 0x1807D5720
	public void AddShake(float amplitude, float frequency, float duration) { }

	// RVA: 0x7D58D0 Offset: 0x7D4CD0 VA: 0x1807D58D0
	public void Update() { }

	// RVA: 0x7D5830 Offset: 0x7D4C30 VA: 0x1807D5830
	public void Stop() { }

	// RVA: 0x7D5E80 Offset: 0x7D5280 VA: 0x1807D5E80
	public void .ctor() { }

}

private sealed class ViewShake.<>c // TypeDefIndex: 9253
{	// Fields
	public static readonly ViewShake.<>c <>9; // 0x0
	public static Predicate<ViewShake.ShakeParameters> <>9__11_0; // 0x8

	// Methods

	// RVA: 0x7CFEA0 Offset: 0x7CF2A0 VA: 0x1807CFEA0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7CFE20 Offset: 0x7CF220 VA: 0x1807CFE20
	internal bool <Update>b__11_0(ViewShake.ShakeParameters i) { }

}

