internal class Bootstring // TypeDefIndex: 744
{	// Fields
	private readonly char delimiter; // 0x10
	private readonly int base_num; // 0x14
	private readonly int tmin; // 0x18
	private readonly int tmax; // 0x1C
	private readonly int skew; // 0x20
	private readonly int damp; // 0x24
	private readonly int initial_bias; // 0x28
	private readonly int initial_n; // 0x2C

	// Methods

	// RVA: 0x10CA4D0 Offset: 0x10C98D0 VA: 0x1810CA4D0
	public void .ctor(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN) { }

	// RVA: 0x10CA0D0 Offset: 0x10C94D0 VA: 0x1810CA0D0
	public string Encode(string s, int offset) { }

	// RVA: 0x10CA0B0 Offset: 0x10C94B0 VA: 0x1810CA0B0
	private char EncodeDigit(int d) { }

	// RVA: 0x10C9DA0 Offset: 0x10C91A0 VA: 0x1810C9DA0
	private int DecodeDigit(char c) { }

	// RVA: 0x10C9D30 Offset: 0x10C9130 VA: 0x1810C9D30
	private int Adapt(int delta, int numPoints, bool firstTime) { }

	// RVA: 0x10C9DD0 Offset: 0x10C91D0 VA: 0x1810C9DD0
	public string Decode(string s, int offset) { }

}

