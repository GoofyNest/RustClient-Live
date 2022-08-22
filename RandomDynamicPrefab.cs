public class RandomDynamicPrefab : MonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 10354
{	public uint Seed; // 0x18
	public float Distance; // 0x1C
	public float Probability; // 0x20
	public string ResourceFolder; // 0x28
	private Prefab prefab; // 0x30
	private GameObject instance; // 0x38
	private LODCell cell; // 0x40


	protected void OnEnable() { }

	protected void OnDisable() { }

	public void RefreshLOD() { }

	public void ChangeLOD() { }

	public void .ctor() { }

}

