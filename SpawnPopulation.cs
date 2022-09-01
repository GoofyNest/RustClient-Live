public class SpawnPopulation : BaseScriptableObject // TypeDefIndex: 10001
{
	[HeaderAttribute] 
	public string ResourceFolder; 
	public GameObjectRef[] ResourceList; 
	[HeaderAttribute] 
	[TooltipAttribute] 
	[SerializeField] 
	[FormerlySerializedAsAttribute] 
	private float _targetDensity; 
	public float SpawnRate; 
	public int ClusterSizeMin; 
	public int ClusterSizeMax; 
	public int ClusterDithering; 
	public int SpawnAttemptsInitial; 
	public int SpawnAttemptsRepeating; 
	public bool EnforcePopulationLimits; 
	public bool ScaleWithLargeMaps; 
	public bool ScaleWithSpawnFilter; 
	public bool ScaleWithServerPopulation; 
	public bool AlignToNormal; 
	public SpawnFilter Filter; 
	public float FilterCutoff; 

	public virtual float TargetDensity { get; }


	public virtual float get_TargetDensity() { }

	public void .ctor() { }

}

