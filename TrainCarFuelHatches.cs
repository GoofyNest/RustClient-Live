public class TrainCarFuelHatches : MonoBehaviour // TypeDefIndex: 11441
{
	[SerializeField] 
	private TrainCar owner; 
	[SerializeField] 
	private float animSpeed; 
	[SerializeField] 
	private Transform hatch1Col; 
	[SerializeField] 
	private Transform hatch1Vis; 
	[SerializeField] 
	private Transform hatch2Col; 
	[SerializeField] 
	private Transform hatch2Vis; 
	[SerializeField] 
	private Transform hatch3Col; 
	[SerializeField] 
	private Transform hatch3Vis; 
	private const float closedXAngle = 0;
	private const float openXAngle = -145;
	[SerializeField] 
	private SoundDefinition hatchOpenSoundDef; 
	[SerializeField] 
	private SoundDefinition hatchCloseSoundDef; 
	private Vector3 _angles; 
	private float _hatchLerp; 
	private bool opening; 
	private bool openingQueued; 
	private bool isMoving; 


	public void LinedUpStateChanged(bool linedUp) { }

	private void MoveTick() { }

	private void EndMove() { }

	private void SetAngleOnAll(float lerpT, bool closing) { }

	private void SetAngle(Transform transform, float angle) { }

	private void PlayOpenSounds() { }

	private void PlayCloseSounds() { }

	public void .ctor() { }

}

