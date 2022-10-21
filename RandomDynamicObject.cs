public class RandomDynamicObject : MonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 12084
{
	public uint Seed; 
	public float Distance; 
	public float Probability; 
	public GameObject[] Candidates; 
	private GameObject instance; 
	private LODCell cell; 


	protected void OnEnable() { }

	protected void OnDisable() { }

	public void RefreshLOD() { }

	public void ChangeLOD() { }

	public void .ctor() { }

}

