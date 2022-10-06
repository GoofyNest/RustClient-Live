public class WaitForSecondsRealtimeEx : CustomYieldInstruction, Pool.IPooled // TypeDefIndex: 6172
{
	private bool _isInPool; 
	private float _waitUntilTime; 
	[CompilerGeneratedAttribute] 
	private float <WaitTime>k__BackingField; 

	public float WaitTime { get; set; }
	public override bool keepWaiting { get; }


	[CompilerGeneratedAttribute] 
	public float get_WaitTime() { }

	[CompilerGeneratedAttribute] 
	public void set_WaitTime(float value) { }

	public override bool get_keepWaiting() { }

	public void EnterPool() { }

	public void LeavePool() { }

	public void .ctor() { }

}

