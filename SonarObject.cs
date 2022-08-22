public class SonarObject : MonoBehaviour, IClientComponent // TypeDefIndex: 11673
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SonarObject.SType sonarType; // 0x18
	public static List<SonarObject> trackedObjects; // 0x0

	public SonarObject.SType SonarType { get; }


	public SonarObject.SType get_SonarType() { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum SonarObject.SType // TypeDefIndex: 11674
{	public int value__; // 0x0
	public const SonarObject.SType MoonPool = 0;
	public const SonarObject.SType Sub = 1;

}

