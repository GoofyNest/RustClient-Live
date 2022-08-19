public class SpawnPopulation : BaseScriptableObject // TypeDefIndex: 9994
{	// Fields
	[HeaderAttribute] // RVA: 0xAC640 Offset: 0xABA40 VA: 0x1800AC640
	public string ResourceFolder; // 0x20
	public GameObjectRef[] ResourceList; // 0x28
	[HeaderAttribute] // RVA: 0xAC700 Offset: 0xABB00 VA: 0x1800AC700
	[TooltipAttribute] // RVA: 0xAC700 Offset: 0xABB00 VA: 0x1800AC700
	[SerializeField] // RVA: 0xAC700 Offset: 0xABB00 VA: 0x1800AC700
	[FormerlySerializedAsAttribute] // RVA: 0xAC700 Offset: 0xABB00 VA: 0x1800AC700
	private float _targetDensity; // 0x30
	public float SpawnRate; // 0x34
	public int ClusterSizeMin; // 0x38
	public int ClusterSizeMax; // 0x3C
	public int ClusterDithering; // 0x40
	public int SpawnAttemptsInitial; // 0x44
	public int SpawnAttemptsRepeating; // 0x48
	public bool EnforcePopulationLimits; // 0x4C
	public bool ScaleWithLargeMaps; // 0x4D
	public bool ScaleWithSpawnFilter; // 0x4E
	public bool ScaleWithServerPopulation; // 0x4F
	public bool AlignToNormal; // 0x50
	public SpawnFilter Filter; // 0x58
	public float FilterCutoff; // 0x60

	// Properties
	public virtual float TargetDensity { get; }

	// Methods

	// RVA: 0x516B60 Offset: 0x515F60 VA: 0x180516B60 Slot: 4
	public virtual float get_TargetDensity() { }

	// RVA: 0xA791F0 Offset: 0xA785F0 VA: 0x180A791F0
	public void .ctor() { }

}

