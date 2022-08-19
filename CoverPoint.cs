public class CoverPoint // TypeDefIndex: 12122
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Properties
	public CoverPointVolume Volume { get; set; }
	public Vector3 Position { get; set; }
	public Vector3 Normal { get; set; }
	public BaseEntity ReservedFor { get; set; }
	public bool IsReserved { get; }
	public bool IsCompromised { get; set; }
	public float Score { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public CoverPointVolume get_Volume() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	private void set_Volume(CoverPointVolume value) { }

	// RVA: 0x4B9390 Offset: 0x4B8790 VA: 0x1804B9390
	public Vector3 get_Position() { }

	// RVA: 0x4B9490 Offset: 0x4B8890 VA: 0x1804B9490
	public void set_Position(Vector3 value) { }

	// RVA: 0x4B92E0 Offset: 0x4B86E0 VA: 0x1804B92E0
	public Vector3 get_Normal() { }

	// RVA: 0x4B9480 Offset: 0x4B8880 VA: 0x1804B9480
	public void set_Normal(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public BaseEntity get_ReservedFor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	public void set_ReservedFor(BaseEntity value) { }

	// RVA: 0x4B9280 Offset: 0x4B8680 VA: 0x1804B9280
	public bool get_IsReserved() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9270 Offset: 0x4B8670 VA: 0x1804B9270
	public bool get_IsCompromised() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9470 Offset: 0x4B8870 VA: 0x1804B9470
	public void set_IsCompromised(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9450 Offset: 0x4B8850 VA: 0x1804B9450
	public float get_Score() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94B0 Offset: 0x4B88B0 VA: 0x1804B94B0
	public void set_Score(float value) { }

	// RVA: 0x4B8EC0 Offset: 0x4B82C0 VA: 0x1804B8EC0
	public bool IsValidFor(BaseEntity entity) { }

	// RVA: 0x4B9220 Offset: 0x4B8620 VA: 0x1804B9220
	public void .ctor(CoverPointVolume volume, float score) { }

	// RVA: 0x4B8DC0 Offset: 0x4B81C0 VA: 0x1804B8DC0
	public void CoverIsCompromised(float cooldown) { }

	[IteratorStateMachineAttribute] // RVA: 0xDF410 Offset: 0xDE810 VA: 0x1800DF410
	// RVA: 0x4B91A0 Offset: 0x4B85A0 VA: 0x1804B91A0
	private IEnumerator StartCooldown(float cooldown) { }

	// RVA: 0x4B8F90 Offset: 0x4B8390 VA: 0x1804B8F90
	public bool ProvidesCoverFromPoint(Vector3 point, float arcThreshold) { }

}

public enum CoverPoint.CoverType // TypeDefIndex: 12123
{	// Fields
	public int value__; // 0x0
	public const CoverPoint.CoverType Full = 0;
	public const CoverPoint.CoverType Partial = 1;
	public const CoverPoint.CoverType None = 2;

}

private sealed class CoverPoint.<StartCooldown>d__33 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12124
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CoverPoint <>4__this; // 0x20
	public float cooldown; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x4CE3C0 Offset: 0x4CD7C0 VA: 0x1804CE3C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CE480 Offset: 0x4CD880 VA: 0x1804CE480 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

