public class IndividualSpawner : BaseMonoBehaviour, IServerComponent // TypeDefIndex: 10001
{	// Fields
	public GameObjectRef entityPrefab; // 0x18
	public float respawnDelayMin; // 0x20
	public float respawnDelayMax; // 0x24
	public bool useCustomBoundsCheckMask; // 0x28
	public LayerMask customBoundsCheckMask; // 0x2C
	[TooltipAttribute] // RVA: 0xACD30 Offset: 0xAC130 VA: 0x1800ACD30
	[SerializeField] // RVA: 0xACD30 Offset: 0xAC130 VA: 0x1800ACD30
	private bool oneTimeSpawner; // 0x30

	// Methods

	// RVA: 0x8114A0 Offset: 0x8108A0 VA: 0x1808114A0
	public void .ctor() { }

}

