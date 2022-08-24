internal sealed class JISConvert // TypeDefIndex: 7835
{
	private const int JISX0208_To_Unicode = 1;
	private const int JISX0212_To_Unicode = 2;
	private const int CJK_To_JIS = 3;
	private const int Greek_To_JIS = 4;
	private const int Extra_To_JIS = 5;
	public byte[] jisx0208ToUnicode; 
	public byte[] jisx0212ToUnicode; 
	public byte[] cjkToJis; 
	public byte[] greekToJis; 
	public byte[] extraToJis; 
	private static JISConvert convert; 
	private static readonly object lockobj; 

	public static JISConvert Convert { get; }


	private void .ctor() { }

	private static void .cctor() { }

	public static JISConvert get_Convert() { }

}

