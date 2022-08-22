public class IndividualSpawner : BaseMonoBehaviour, IServerComponent // TypeDefIndex: 10001
{	public GameObjectRef entityPrefab; // 0x18
	public float respawnDelayMin; // 0x20
	public float respawnDelayMax; // 0x24
	public bool useCustomBoundsCheckMask; // 0x28
	public LayerMask customBoundsCheckMask; // 0x2C
	[TooltipAttribute] // RVA: 0xACD30 Offset: 0xAC130 VA: 0x1800ACD30
	[SerializeField] // RVA: 0xACD30 Offset: 0xAC130 VA: 0x1800ACD30
	private bool oneTimeSpawner; // 0x30


	public void .ctor() { }

}

