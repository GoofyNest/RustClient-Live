public class LiquidWobble : MonoBehaviour // TypeDefIndex: 12363
{
	private Renderer rend; 
	private Vector3 lastPos; 
	private Vector3 velocity; 
	private Vector3 lastRot; 
	private Vector3 angularVelocity; 
	[RangeAttribute] 
	public float CurrentWaterLevelFraction; 
	public float MinWaterLevel; 
	public float MaxWaterLevel; 
	public float MaxWobble; 
	public float WobbleSpeed; 
	public float Recovery; 
	private float wobbleAmountX; 
	private float wobbleAmountZ; 
	private float wobbleAmountToAddX; 
	private float wobbleAmountToAddZ; 
	private float pulse; 
	private float time; 
	public float turbulence; 
	private static MaterialPropertyBlock propertyBlock; 
	private static int wobbleXID; 
	private static int wobbleZID; 
	private static int waterLevelID; 
	private static int turbulenceID; 


	private void Awake() { }

	private void Update() { }

	private float CalculateWaterLevel() { }

	public void .ctor() { }

	private static void .cctor() { }

}

