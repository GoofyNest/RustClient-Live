public class TrainCarFuelHatches : MonoBehaviour // TypeDefIndex: 9768
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Methods

	// RVA: 0x9EAA10 Offset: 0x9E9E10 VA: 0x1809EAA10
	public void LinedUpStateChanged(bool linedUp) { }

	// RVA: 0x9EAC80 Offset: 0x9EA080 VA: 0x1809EAC80
	private void MoveTick() { }

	// RVA: 0x9EA980 Offset: 0x9E9D80 VA: 0x1809EA980
	private void EndMove() { }

	// RVA: 0x9EAF40 Offset: 0x9EA340 VA: 0x1809EAF40
	private void SetAngleOnAll(float lerpT, bool closing) { }

	// RVA: 0x9EB220 Offset: 0x9EA620 VA: 0x1809EB220
	private void SetAngle(Transform transform, float angle) { }

	// RVA: 0x9EAE30 Offset: 0x9EA230 VA: 0x1809EAE30
	private void PlayOpenSounds() { }

	// RVA: 0x9EAD20 Offset: 0x9EA120 VA: 0x1809EAD20
	private void PlayCloseSounds() { }

	// RVA: 0x9EB260 Offset: 0x9EA660 VA: 0x1809EB260
	public void .ctor() { }

}

