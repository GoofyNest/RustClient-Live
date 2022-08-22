internal class Bootstring // TypeDefIndex: 744
{	private readonly char delimiter; // 0x10
	private readonly int base_num; // 0x14
	private readonly int tmin; // 0x18
	private readonly int tmax; // 0x1C
	private readonly int skew; // 0x20
	private readonly int damp; // 0x24
	private readonly int initial_bias; // 0x28
	private readonly int initial_n; // 0x2C


	public void .ctor(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN) { }

	public string Encode(string s, int offset) { }

	private char EncodeDigit(int d) { }

	private int DecodeDigit(char c) { }

	private int Adapt(int delta, int numPoints, bool firstTime) { }

	public string Decode(string s, int offset) { }

}

