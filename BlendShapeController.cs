public class BlendShapeController : MonoBehaviour // TypeDefIndex: 10856
{
	public SkinnedMeshRenderer TargetRenderer;
	public BlendShapeController.BlendState[] States;
	public float LerpSpeed;
	public BlendShapeController.BlendMode CurrentMode;
	private float[] currentStates;


	private void Start() { }

	public void UpdateState() { }

	public void .ctor() { }

}

public enum BlendShapeController.BlendMode // TypeDefIndex: 10857
{
	public int value__;
	public const BlendShapeController.BlendMode Idle = 0;
	public const BlendShapeController.BlendMode Happy = 1;
	public const BlendShapeController.BlendMode Angry = 2;

}

public struct BlendShapeController.BlendState // TypeDefIndex: 10858
{
	[RangeAttribute]
	public float[] States;
	public BlendShapeController.BlendMode Mode;

}

