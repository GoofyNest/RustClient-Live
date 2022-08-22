public class TrainCarFuelHatches : MonoBehaviour // TypeDefIndex: 9768
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TrainCar owner; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float animSpeed; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform hatch1Col; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform hatch1Vis; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform hatch2Col; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform hatch2Vis; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform hatch3Col; // 0x48
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform hatch3Vis; // 0x50
	private const float closedXAngle = 0;
	private const float openXAngle = -145;
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition hatchOpenSoundDef; // 0x58
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition hatchCloseSoundDef; // 0x60
	private Vector3 _angles; // 0x68
	private float _hatchLerp; // 0x74
	private bool opening; // 0x78
	private bool openingQueued; // 0x79
	private bool isMoving; // 0x7A


	public void LinedUpStateChanged(bool linedUp) { }

	private void MoveTick() { }

	private void EndMove() { }

	private void SetAngleOnAll(float lerpT, bool closing) { }

	private void SetAngle(Transform transform, float angle) { }

	private void PlayOpenSounds() { }

	private void PlayCloseSounds() { }

	public void .ctor() { }

}

