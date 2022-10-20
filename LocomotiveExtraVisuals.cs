public class LocomotiveExtraVisuals : MonoBehaviour // TypeDefIndex: 11484
{
	[HeaderAttribute] 
	[SerializeField] 
	private TrainEngine trainEngine; 
	[SerializeField] 
	private Transform needleA; 
	[SerializeField] 
	private Transform needleB; 
	[SerializeField] 
	private Transform needleC; 
	[SerializeField] 
	private float maxAngle; 
	[SerializeField] 
	private float speedoMoveSpeed; 
	[SerializeField] 
	private float pressureMoveSpeed; 
	[SerializeField] 
	private float fanAcceleration; 
	[SerializeField] 
	private float fanMaxSpeed; 
	[SerializeField] 
	private float speedoMax; 
	[HeaderAttribute] 
	[SerializeField] 
	private Transform[] engineFans; 
	private Vector3 _v3; 
	private float fanPrevSpeed; 
	private float[] fanSpeedVariation; 


	public void UpdateTick() { }

	public void StopAll() { }

	private void UpdateNeedle(Transform needle, LocomotiveExtraVisuals.NeedleType type) { }

	private float GetTargetAngle(LocomotiveExtraVisuals.NeedleType type) { }

	private void SetAngle(Transform tr, float angle) { }

	public void .ctor() { }

}

private enum LocomotiveExtraVisuals.NeedleType // TypeDefIndex: 11485
{
	public int value__; 
	public const LocomotiveExtraVisuals.NeedleType Speed = 0;
	public const LocomotiveExtraVisuals.NeedleType Pressure = 1;

}

