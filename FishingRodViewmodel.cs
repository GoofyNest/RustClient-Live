public class FishingRodViewmodel : MonoBehaviour // TypeDefIndex: 11433
{	public Transform PitchTransform; // 0x18
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


	private void Start() { }

	public void UpdateState(bool pullingLeft, bool pullingRight, bool pullingBack, float strainAmount, Animator forAnimator) { }

	public void SetFish(int id) { }

	public void ToggleCatchRoot(bool state) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct FishingRodViewmodel.FishViewmodel // TypeDefIndex: 11434
{	public ItemDefinition Item; // 0x0
	public GameObject Root; // 0x8

}

