public class MaterialParameterToggle : MonoBehaviour // TypeDefIndex: 10944
{
	[InspectorFlagsAttribute]
	public MaterialParameterToggle.ToggleMode Toggle;
	public Renderer[] TargetRenderers;
	[ColorUsageAttribute]
	public Color EmissionColor;
	private Material originalMaterial;
	private Material modifiedMaterial;
	private static readonly int DetailLayer;
	private static readonly int EmissionColor1;


	private void Setup() { }

	public void EnableToggle() { }

	public void DisableToggle() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum MaterialParameterToggle.ToggleMode // TypeDefIndex: 10945
{
	public int value__;
	public const MaterialParameterToggle.ToggleMode Detail = 0;
	public const MaterialParameterToggle.ToggleMode Emission = 1;

}

