public class LocalPositionAnimation : MonoBehaviour, IClientComponent // TypeDefIndex: 10913
{
	public Vector3 centerPosition; 
	public bool worldSpace; 
	public float scaleX; 
	public float timeScaleX; 
	public AnimationCurve movementX; 
	public float scaleY; 
	public float timeScaleY; 
	public AnimationCurve movementY; 
	public float scaleZ; 
	public float timeScaleZ; 
	public AnimationCurve movementZ; 
	private const float maxDistSq = 10000;


	protected void Update() { }

	public void .ctor() { }

}

