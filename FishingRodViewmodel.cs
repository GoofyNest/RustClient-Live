public class FishingRodViewmodel : MonoBehaviour // TypeDefIndex: 11433
{
	public Transform PitchTransform; 
	public Transform YawTransform; 
	public float YawLerpSpeed; 
	public float PitchLerpSpeed; 
	public Transform LineRendererStartPos; 
	public ParticleSystem[] StrainParticles; 
	public bool ApplyTransformRotation; 
	public GameObject CatchRoot; 
	public Transform CatchLinePoint; 
	public FishingRodViewmodel.FishViewmodel[] FishViewmodels; 
	public float ShakeMaxScale; 
	private static int InputStateX_Param; 
	private static int InputStateY_Param; 
	private Vector2 lerpedInputState; 


private void Start() { }

public void UpdateState(bool pullingLeft, bool pullingRight, bool pullingBack, float strainAmount, Animator forAnimator) { }

public void SetFish(int id) { }

public void ToggleCatchRoot(bool state) { }

public void .ctor() { }

private static void .cctor() { }

}

public struct FishingRodViewmodel.FishViewmodel // TypeDefIndex: 11434
{
	public ItemDefinition Item; 
	public GameObject Root; 

}

