public abstract class BaseFootstepEffect : MonoBehaviour, IClientComponent // TypeDefIndex: 11076
{
	public LayerMask validImpactLayers;
	private const float minTimeBetweenSteps = 0,05;
	private float lastFootstepTime;
	private const float minDistanceBetweenSteps = 0,5;
	private const float minDistanceBetweenStepsSqr = 0,25;
	protected Vector3 lastFootstepPos;
	private const float maxDistanceToCamera = 75;


	protected BaseFootstepEffect.GroundInfo GetGroundInfo(Vector3 position, Vector3 forward, bool bIgnoreDistanceCheck = False) { }

	protected void .ctor() { }

}

