public class RandomDynamicObject : MonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 10353
{	public uint Seed; // 0x18
	public float Distance; // 0x1C
	public float Probability; // 0x20
	public GameObject[] Candidates; // 0x28
	private GameObject instance; // 0x30
	private LODCell cell; // 0x38


	protected void OnEnable() { }

	protected void OnDisable() { }

	public void RefreshLOD() { }

	public void ChangeLOD() { }

	public void .ctor() { }

}

