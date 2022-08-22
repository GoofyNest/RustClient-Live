public class CoverPoint // TypeDefIndex: 12122
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CoverPointVolume <Volume>k__BackingField; // 0x10
	public CoverPoint.CoverType NormalCoverType; // 0x18
	public bool IsDynamic; // 0x1C
	public Transform SourceTransform; // 0x20
	private Vector3 _staticPosition; // 0x28
	private Vector3 _staticNormal; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BaseEntity <ReservedFor>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsCompromised>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Score>k__BackingField; // 0x4C

	public CoverPointVolume Volume { get; set; }
	public Vector3 Position { get; set; }
	public Vector3 Normal { get; set; }
	public BaseEntity ReservedFor { get; set; }
	public bool IsReserved { get; }
	public bool IsCompromised { get; set; }
	public float Score { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public CoverPointVolume get_Volume() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Volume(CoverPointVolume value) { }

	public Vector3 get_Position() { }

	public void set_Position(Vector3 value) { }

	public Vector3 get_Normal() { }

	public void set_Normal(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public BaseEntity get_ReservedFor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_ReservedFor(BaseEntity value) { }

	public bool get_IsReserved() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_IsCompromised() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_IsCompromised(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_Score() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Score(float value) { }

	public bool IsValidFor(BaseEntity entity) { }

	public void .ctor(CoverPointVolume volume, float score) { }

	public void CoverIsCompromised(float cooldown) { }

	[IteratorStateMachineAttribute] // RVA: 0xDF410 Offset: 0xDE810 VA: 0x1800DF410
	private IEnumerator StartCooldown(float cooldown) { }

	public bool ProvidesCoverFromPoint(Vector3 point, float arcThreshold) { }

}

public enum CoverPoint.CoverType // TypeDefIndex: 12123
{	public int value__; // 0x0
	public const CoverPoint.CoverType Full = 0;
	public const CoverPoint.CoverType Partial = 1;
	public const CoverPoint.CoverType None = 2;

}

private sealed class CoverPoint.<StartCooldown>d__33 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12124
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CoverPoint <>4__this; // 0x20
	public float cooldown; // 0x28

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

