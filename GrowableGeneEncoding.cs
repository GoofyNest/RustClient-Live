public static class GrowableGeneEncoding // TypeDefIndex: 9541
{	// Methods

	// RVA: 0x74A020 Offset: 0x749420 VA: 0x18074A020
	public static void EncodeGenesToItem(GrowableEntity sourceGrowable, Item targetItem) { }

	// RVA: 0x749FA0 Offset: 0x7493A0 VA: 0x180749FA0
	public static void EncodeGenesToItem(int genes, Item targetItem) { }

	// RVA: 0x749F10 Offset: 0x749310 VA: 0x180749F10
	public static int EncodeGenesToInt(GrowableGenes genes) { }

	// RVA: 0x74A180 Offset: 0x749580 VA: 0x18074A180
	public static int EncodePreviousGenesToInt(GrowableGenes genes) { }

	// RVA: 0x749E20 Offset: 0x749220 VA: 0x180749E20
	public static void DecodeIntToGenes(int data, GrowableGenes genes) { }

	// RVA: 0x749EA0 Offset: 0x7492A0 VA: 0x180749EA0
	public static void DecodeIntToPreviousGenes(int data, GrowableGenes genes) { }

	// RVA: 0x749C80 Offset: 0x749080 VA: 0x180749C80
	public static string DecodeIntToGeneString(int data) { }

	// RVA: 0x74A230 Offset: 0x749630 VA: 0x18074A230
	private static int Set(int storage, int slot, int value) { }

	// RVA: 0x74A210 Offset: 0x749610 VA: 0x18074A210
	private static int Get(int storage, int slot) { }

}

