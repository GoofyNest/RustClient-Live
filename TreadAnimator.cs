public class TreadAnimator : MonoBehaviour, IClientComponent // TypeDefIndex: 8864
{
	public Animator mainBodyAnimator; 
	public Transform[] wheelBones; 
	public Vector3[] vecShocksOffsetPosition; 
	public Vector3[] wheelBoneOrigin; 
	public float wheelBoneDistMax; 
	public Renderer treadRenderer; 
	public Material leftTread; 
	public Material rightTread; 
	public TreadEffects treadEffects; 
	public float traceThickness; 
	public float heightFudge; 
	public bool useWheelYOrigin; 
	public Vector2 treadTextureDirection; 
	public bool isMetallic; 
	private float angularVelocity; 
	private Vector3 lastForward; 
	private Vector3 currentVelocity; 
	private Vector3 lastPos; 
	public float angularTreadConstant; 
	public float treadConstant; 
	public float wheelSpinConstant; 
	private float wheelAngle; 
	private float treadMovementL; 
	private float treadMovementR; 
	public float traceLineMin; 
	public float traceLineMax; 
	public float maxShockDist; 
	private int cachedMask; 


	public void Awake() { }

	public void Update() { }

	public void CalculateVelocity() { }

	public Vector3 GetCurrentVelocity() { }

	public float GetAngularSpeed() { }

	public float GetSpeed(bool rightSide) { }

	private void AnimateWheelsTreads() { }

	public void UpdateHeights() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	private void <AnimateWheelsTreads>g__AnimateTreadWheel|30_0(ref float treadMovement, ref Material treadMat, bool left, ref TreadAnimator.<>c__DisplayClass30_0 ) { }

}

private struct TreadAnimator.<>c__DisplayClass30_0 // TypeDefIndex: 8865
{
	public float forwardSpeed; 
	public float angularSpeed; 
	public TreadAnimator <>4__this; 

}

