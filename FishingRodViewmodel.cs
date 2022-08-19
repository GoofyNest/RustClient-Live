public class FishingRodViewmodel : MonoBehaviour // TypeDefIndex: 11433
{	// Fields
	public Transform PitchTransform; // 0x18
	public Transform YawTransform; // 0x20
	public float YawLerpSpeed; // 0x28
	public float PitchLerpSpeed; // 0x2C
	public Transform LineRendererStartPos; // 0x30
	public ParticleSystem[] StrainParticles; // 0x38
	public bool ApplyTransformRotation; // 0x40
	public GameObject CatchRoot; // 0x48
	public Transform CatchLinePoint; // 0x50
	public FishingRodViewmodel.FishViewmodel[] FishViewmodels; // 0x58
	public float ShakeMaxScale; // 0x60
	private static int InputStateX_Param; // 0x0
	private static int InputStateY_Param; // 0x4
	private Vector2 lerpedInputState; // 0x64

	// Methods

	// RVA: 0x78B300 Offset: 0x78A700 VA: 0x18078B300
	private void Start() { }

	// RVA: 0x78B330 Offset: 0x78A730 VA: 0x18078B330
	public void UpdateState(bool pullingLeft, bool pullingRight, bool pullingBack, float strainAmount, Animator forAnimator) { }

	// RVA: 0x78B150 Offset: 0x78A550 VA: 0x18078B150
	public void SetFish(int id) { }

	// RVA: 0x78B310 Offset: 0x78A710 VA: 0x18078B310
	public void ToggleCatchRoot(bool state) { }

	// RVA: 0x78B840 Offset: 0x78AC40 VA: 0x18078B840
	public void .ctor() { }

	// RVA: 0x78B7D0 Offset: 0x78ABD0 VA: 0x18078B7D0
	private static void .cctor() { }

}

public struct FishingRodViewmodel.FishViewmodel // TypeDefIndex: 11434
{	// Fields
	public ItemDefinition Item; // 0x0
	public GameObject Root; // 0x8

}

