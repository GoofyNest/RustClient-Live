public class WorldPositionGenerator : ScriptableObject // TypeDefIndex: 11952
{
	public SpawnFilter Filter; 
	public float FilterCutoff; 
	public bool aboveWater; 
	public float MaxSlopeRadius; 
	public float MaxSlopeDegrees; 
	public float CheckSphereRadius; 
	public LayerMask CheckSphereMask; 


	public void .ctor() { }

}

