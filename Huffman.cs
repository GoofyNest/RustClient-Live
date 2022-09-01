internal sealed class Huffman // TypeDefIndex: 7394
{
	private static readonly int[][] ValTab0; 
	private static readonly int[][] ValTab1; 
	private static readonly int[][] ValTab2; 
	private static readonly int[][] ValTab3; 
	private static readonly int[][] ValTab4; 
	private static readonly int[][] ValTab5; 
	private static readonly int[][] ValTab6; 
	private static readonly int[][] ValTab7; 
	private static readonly int[][] ValTab8; 
	private static readonly int[][] ValTab9; 
	private static readonly int[][] ValTab10; 
	private static readonly int[][] ValTab11; 
	private static readonly int[][] ValTab12; 
	private static readonly int[][] ValTab13; 
	private static readonly int[][] ValTab14; 
	private static readonly int[][] ValTab15; 
	private static readonly int[][] ValTab16; 
	private static readonly int[][] ValTab24; 
	private static readonly int[][] ValTab32; 
	private static readonly int[][] ValTab33; 
	internal static Huffman[] HuffmanTable; 
	private readonly int _Linbits; 
	private readonly char _Tablename0; 
	private readonly char _Tablename1; 
	private readonly int _Treelen; 
	private readonly int[][] _Val; 
	private readonly int _Xlen; 
	private readonly int _Ylen; 
	private readonly int[] _Hlen; 
	private readonly int _Linmax; 
	private readonly int _RefRenamed; 
	private readonly int[] _Table; 
	private readonly char _Tablename2; 


	private static void .cctor() { }

	private void .ctor(string s, int xlen, int ylen, int linbits, int linmax, int ref, int[] table, int[] hlen, int[][] val, int treelen) { }

	internal static int Decode(Huffman h, int[] x, int[] y, int[] v, int[] w, BitReserve br) { }

	internal static void Initialize() { }

}

