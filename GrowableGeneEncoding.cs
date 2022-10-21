public static class GrowableGeneEncoding // TypeDefIndex: 11262
{

	public static void EncodeGenesToItem(GrowableEntity sourceGrowable, Item targetItem) { }

	public static void EncodeGenesToItem(int genes, Item targetItem) { }

	public static int EncodeGenesToInt(GrowableGenes genes) { }

	public static int EncodePreviousGenesToInt(GrowableGenes genes) { }

	public static void DecodeIntToGenes(int data, GrowableGenes genes) { }

	public static void DecodeIntToPreviousGenes(int data, GrowableGenes genes) { }

	public static string DecodeIntToGeneString(int data) { }

	private static int Set(int storage, int slot, int value) { }

	private static int Get(int storage, int slot) { }

}

