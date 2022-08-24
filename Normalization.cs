internal class Normalization // TypeDefIndex: 478
{
	private static byte* props; 
	private static int* mappedChars; 
	private static short* charMapIndex; 
	private static short* helperIndex; 
	private static ushort* mapIdxToComposite; 
	private static byte* combiningClass; 
	private static object forLock; 
	public static readonly bool isReady; 


	private static uint PropValue(int cp) { }

	private static int CharMapIdx(int cp) { }

	private static byte GetCombiningClass(int c) { }

	private static int GetPrimaryCompositeFromMapIndex(int src) { }

	private static int GetPrimaryCompositeHelperIndex(int cp) { }

	private static string Compose(string source, int checkType) { }

	private static StringBuilder Combine(string source, int start, int checkType) { }

	private static void Combine(StringBuilder sb, int i, int checkType) { }

	private static int CombineHangul(StringBuilder sb, string s, int current) { }

	private static int Fetch(StringBuilder sb, string s, int i) { }

	private static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current) { }

	private static int TryCompose(int i, int starter, int candidate) { }

	private static string Decompose(string source, int checkType) { }

	private static void Decompose(string source, ref StringBuilder sb, int checkType) { }

	private static void ReorderCanonical(string src, ref StringBuilder sb, int start) { }

	private static void DecomposeChar(ref StringBuilder sb, ref int[] buf, string s, int i, int checkType, ref int start) { }

	public static NormalizationCheck QuickCheck(char c, int type) { }

	private static int GetCanonicalHangul(int s, int[] buf, int bufIdx) { }

	private static int GetCanonical(int c, int[] buf, int bufIdx, int checkType) { }

	public static string Normalize(string source, NormalizationForm normalizationForm) { }

	public static string Normalize(string source, int type) { }

	private static void load_normalization_resource(out IntPtr props, out IntPtr mappedChars, out IntPtr charMapIndex, out IntPtr helperIndex, out IntPtr mapIdxToComposite, out IntPtr combiningClass) { }

	private static void .cctor() { }

}

