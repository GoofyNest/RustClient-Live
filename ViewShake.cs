public class ViewShake // TypeDefIndex: 9251
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <PositionOffset>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <AnglesOffset>k__BackingField; // 0x1C
	protected List<ViewShake.ShakeParameters> Entries; // 0x28

	public Vector3 PositionOffset { get; set; }
	public Vector3 AnglesOffset { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Vector3 get_PositionOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected void set_PositionOffset(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Vector3 get_AnglesOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected void set_AnglesOffset(Vector3 value) { }

	public void AddShake(float amplitude, float frequency, float duration) { }

	public void Update() { }

	public void Stop() { }

	public void .ctor() { }

}

private sealed class ViewShake.<>c // TypeDefIndex: 9253
{	public static readonly ViewShake.<>c <>9; // 0x0
	public static Predicate<ViewShake.ShakeParameters> <>9__11_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <Update>b__11_0(ViewShake.ShakeParameters i) { }

}

