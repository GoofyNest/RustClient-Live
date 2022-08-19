internal class Normalization // TypeDefIndex: 478
{	// Fields
	private static byte* props; // 0x0
	private static int* mappedChars; // 0x8
	private static short* charMapIndex; // 0x10
	private static short* helperIndex; // 0x18
	private static ushort* mapIdxToComposite; // 0x20
	private static byte* combiningClass; // 0x28
	private static object forLock; // 0x30
	public static readonly bool isReady; // 0x38

	// Methods

	// RVA: 0x1919A40 Offset: 0x1918E40 VA: 0x181919A40
	private static uint PropValue(int cp) { }

	// RVA: 0x1918210 Offset: 0x1917610 VA: 0x181918210
	private static int CharMapIdx(int cp) { }

	// RVA: 0x19195F0 Offset: 0x19189F0 VA: 0x1819195F0
	private static byte GetCombiningClass(int c) { }

	// RVA: 0x19196B0 Offset: 0x1918AB0 VA: 0x1819196B0
	private static int GetPrimaryCompositeFromMapIndex(int src) { }

	// RVA: 0x1919770 Offset: 0x1918B70 VA: 0x181919770
	private static int GetPrimaryCompositeHelperIndex(int cp) { }

	// RVA: 0x1918810 Offset: 0x1917C10 VA: 0x181918810
	private static string Compose(string source, int checkType) { }

	// RVA: 0x19186E0 Offset: 0x1917AE0 VA: 0x1819186E0
	private static StringBuilder Combine(string source, int start, int checkType) { }

	// RVA: 0x1918480 Offset: 0x1917880 VA: 0x181918480
	private static void Combine(StringBuilder sb, int i, int checkType) { }

	// RVA: 0x19182B0 Offset: 0x19176B0 VA: 0x1819182B0
	private static int CombineHangul(StringBuilder sb, string s, int current) { }

	// RVA: 0x1919070 Offset: 0x1918470 VA: 0x181919070
	private static int Fetch(StringBuilder sb, string s, int i) { }

	// RVA: 0x1919EF0 Offset: 0x19192F0 VA: 0x181919EF0
	private static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current) { }

	// RVA: 0x191A2A0 Offset: 0x19196A0 VA: 0x18191A2A0
	private static int TryCompose(int i, int starter, int candidate) { }

	// RVA: 0x1918C70 Offset: 0x1918070 VA: 0x181918C70
	private static string Decompose(string source, int checkType) { }

	// RVA: 0x1918D10 Offset: 0x1918110 VA: 0x181918D10
	private static void Decompose(string source, ref StringBuilder sb, int checkType) { }

	// RVA: 0x1919C40 Offset: 0x1919040 VA: 0x181919C40
	private static void ReorderCanonical(string src, ref StringBuilder sb, int start) { }

	// RVA: 0x1918A10 Offset: 0x1917E10 VA: 0x181918A10
	private static void DecomposeChar(ref StringBuilder sb, ref int[] buf, string s, int i, int checkType, ref int start) { }

	// RVA: 0x1919AE0 Offset: 0x1918EE0 VA: 0x181919AE0
	public static NormalizationCheck QuickCheck(char c, int type) { }

	// RVA: 0x19190C0 Offset: 0x19184C0 VA: 0x1819190C0
	private static int GetCanonicalHangul(int s, int[] buf, int bufIdx) { }

	// RVA: 0x1919210 Offset: 0x1918610 VA: 0x181919210
	private static int GetCanonical(int c, int[] buf, int bufIdx, int checkType) { }

	// RVA: 0x1919950 Offset: 0x1918D50 VA: 0x181919950
	public static string Normalize(string source, NormalizationForm normalizationForm) { }

	// RVA: 0x1919830 Offset: 0x1918C30 VA: 0x181919830
	public static string Normalize(string source, int type) { }

	// RVA: 0x191A650 Offset: 0x1919A50 VA: 0x18191A650
	private static void load_normalization_resource(out IntPtr props, out IntPtr mappedChars, out IntPtr charMapIndex, out IntPtr helperIndex, out IntPtr mapIdxToComposite, out IntPtr combiningClass) { }

	// RVA: 0x191A430 Offset: 0x1919830 VA: 0x18191A430
	private static void .cctor() { }

}

