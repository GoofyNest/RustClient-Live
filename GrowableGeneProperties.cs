public class GrowableGeneProperties : ScriptableObject // TypeDefIndex: 9542
{	// Fields
	[ArrayIndexIsEnum] // RVA: 0x76C10 Offset: 0x76010 VA: 0x180076C10
	public GrowableGeneProperties.GeneWeight[] Weights; // 0x18

	// Methods

	// RVA: 0x74A250 Offset: 0x749650 VA: 0x18074A250
	public void .ctor() { }

}

public struct GrowableGeneProperties.GeneWeight // TypeDefIndex: 9543
{	// Fields
	public float BaseWeight; // 0x0
	public float[] SlotWeights; // 0x8
	public float CrossBreedingWeight; // 0x10

}

