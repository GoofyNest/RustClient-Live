public class ViewmodelBob : MonoBehaviour // TypeDefIndex: 11453
{
	public float bobSpeedWalk; 
	public float bobSpeedRun; 
	public float bobAmountWalk; 
	public float bobAmountRun; 
	public float leftOffsetRun; 
	internal float bobAmountRotateYaw; 
	internal float bobAmountRotateRoll; 
	internal Vector3 velocity; 
	internal Vector3 bobOffset; 
	internal float bobRotateYaw; 
	internal float bobRotateRoll; 
	internal float bobCycle; 
	internal ViewmodelBob.BobSettings smoothedBob; 


private ViewmodelBob.BobSettings WorkoutBobSettings(Vector3 newVelocity, float fov, bool isRunning, bool OnGround, bool isAiming, bool isDucked, bool isMounted) { }

public void Apply(ref CachedTransform<BaseViewModel> vm, float fov, BasePlayer player) { }

private void ApplySettings(ref CachedTransform<BaseViewModel> vm, ViewmodelBob.BobSettings settings) { }

public void .ctor() { }

}

public struct ViewmodelBob.BobSettings // TypeDefIndex: 11454
{
	public float bobSpeed; 
	public float bobAmount; 
	public float offsetLateral; 
	public float bobRotate; 
	public float effectAmount; 

}

