public class SonarObject : MonoBehaviour, IClientComponent // TypeDefIndex: 13369
{
	[SerializeField] 
	private SonarObject.SType sonarType; 
	public static List<SonarObject> trackedObjects; 

	public SonarObject.SType SonarType { get; }


	public SonarObject.SType get_SonarType() { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum SonarObject.SType // TypeDefIndex: 13370
{
	public int value__; 
	public const SonarObject.SType MoonPool = 0;
	public const SonarObject.SType Sub = 1;

}

