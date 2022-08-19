public class SonarObject : MonoBehaviour, IClientComponent // TypeDefIndex: 11673
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SonarObject.SType sonarType; // 0x18
	public static List<SonarObject> trackedObjects; // 0x0

	// Properties
	public SonarObject.SType SonarType { get; }

	// Methods

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public SonarObject.SType get_SonarType() { }

	// RVA: 0x5D93D0 Offset: 0x5D87D0 VA: 0x1805D93D0
	protected void OnEnable() { }

	// RVA: 0x5D9350 Offset: 0x5D8750 VA: 0x1805D9350
	protected void OnDisable() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0x5D94A0 Offset: 0x5D88A0 VA: 0x1805D94A0
	private static void .cctor() { }

}

public enum SonarObject.SType // TypeDefIndex: 11674
{	// Fields
	public int value__; // 0x0
	public const SonarObject.SType MoonPool = 0;
	public const SonarObject.SType Sub = 1;

}

