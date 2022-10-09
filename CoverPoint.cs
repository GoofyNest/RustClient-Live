public class CoverPoint // TypeDefIndex: 13863
{
	[CompilerGeneratedAttribute] 
	private CoverPointVolume <Volume>k__BackingField; 
	public CoverPoint.CoverType NormalCoverType; 
	public bool IsDynamic; 
	public Transform SourceTransform; 
	private Vector3 _staticPosition; 
	private Vector3 _staticNormal; 
	[CompilerGeneratedAttribute] 
	private BaseEntity <ReservedFor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <IsCompromised>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <Score>k__BackingField; 

	public CoverPointVolume Volume { get; set; }
	public Vector3 Position { get; set; }
	public Vector3 Normal { get; set; }
	public BaseEntity ReservedFor { get; set; }
	public bool IsReserved { get; }
	public bool IsCompromised { get; set; }
	public float Score { get; set; }


	[CompilerGeneratedAttribute] 
	public CoverPointVolume get_Volume() { }

	[CompilerGeneratedAttribute] 
	private void set_Volume(CoverPointVolume value) { }

	public Vector3 get_Position() { }

	public void set_Position(Vector3 value) { }

	public Vector3 get_Normal() { }

	public void set_Normal(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	public BaseEntity get_ReservedFor() { }

	[CompilerGeneratedAttribute] 
	public void set_ReservedFor(BaseEntity value) { }

	public bool get_IsReserved() { }

	[CompilerGeneratedAttribute] 
	public bool get_IsCompromised() { }

	[CompilerGeneratedAttribute] 
	public void set_IsCompromised(bool value) { }

	[CompilerGeneratedAttribute] 
	public float get_Score() { }

	[CompilerGeneratedAttribute] 
	public void set_Score(float value) { }

	public bool IsValidFor(BaseEntity entity) { }

	public void .ctor(CoverPointVolume volume, float score) { }

	public void CoverIsCompromised(float cooldown) { }

	[IteratorStateMachineAttribute] 
	private IEnumerator StartCooldown(float cooldown) { }

	public bool ProvidesCoverFromPoint(Vector3 point, float arcThreshold) { }

}

public enum CoverPoint.CoverType // TypeDefIndex: 13864
{
	public int value__; 
	public const CoverPoint.CoverType Full = 0;
	public const CoverPoint.CoverType Partial = 1;
	public const CoverPoint.CoverType None = 2;

}

private sealed class CoverPoint.<StartCooldown>d__33 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13865
{
	private int <>1__state; 
	private object <>2__current; 
	public CoverPoint <>4__this; 
	public float cooldown; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

