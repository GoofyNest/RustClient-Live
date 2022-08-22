internal sealed class Huffman // TypeDefIndex: 7393
{	private static readonly int[][] ValTab0; // 0x0
	private static readonly int[][] ValTab1; // 0x8
	private static readonly int[][] ValTab2; // 0x10
	private static readonly int[][] ValTab3; // 0x18
	private static readonly int[][] ValTab4; // 0x20
	private static readonly int[][] ValTab5; // 0x28
	private static readonly int[][] ValTab6; // 0x30
	private static readonly int[][] ValTab7; // 0x38
	private static readonly int[][] ValTab8; // 0x40
	private static readonly int[][] ValTab9; // 0x48
	private static readonly int[][] ValTab10; // 0x50
	private static readonly int[][] ValTab11; // 0x58
	private static readonly int[][] ValTab12; // 0x60
	private static readonly int[][] ValTab13; // 0x68
	private static readonly int[][] ValTab14; // 0x70
	private static readonly int[][] ValTab15; // 0x78
	private static readonly int[][] ValTab16; // 0x80
	private static readonly int[][] ValTab24; // 0x88
	private static readonly int[][] ValTab32; // 0x90
	private static readonly int[][] ValTab33; // 0x98
	internal static Huffman[] HuffmanTable; // 0xA0
	private readonly int _Linbits; // 0x10
	private readonly char _Tablename0; // 0x14
	private readonly char _Tablename1; // 0x16
	private readonly int _Treelen; // 0x18
	private readonly int[][] _Val; // 0x20
	private readonly int _Xlen; // 0x28
	private readonly int _Ylen; // 0x2C
	private readonly int[] _Hlen; // 0x30
	private readonly int _Linmax; // 0x38
	private readonly int _RefRenamed; // 0x3C
	private readonly int[] _Table; // 0x40
	private readonly char _Tablename2; // 0x48


	private static void .cctor() { }

	private void .ctor(string s, int xlen, int ylen, int linbits, int linmax, int ref, int[] table, int[] hlen, int[][] val, int treelen) { }

	internal static int Decode(Huffman h, int[] x, int[] y, int[] v, int[] w, BitReserve br) { }

	internal static void Initialize() { }

}

