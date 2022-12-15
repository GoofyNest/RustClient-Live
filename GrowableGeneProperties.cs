public class GrowableGeneProperties : ScriptableObject // TypeDefIndex: 11293
{
	[ArrayIndexIsEnum]
	public GrowableGeneProperties.GeneWeight[] Weights;


	public void .ctor() { }

}

public struct GrowableGeneProperties.GeneWeight // TypeDefIndex: 11294
{
	public float BaseWeight;
	public float[] SlotWeights;
	public float CrossBreedingWeight;

}

