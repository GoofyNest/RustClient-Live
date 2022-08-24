internal class Bootstring // TypeDefIndex: 744
{
	private readonly char delimiter; 
	private readonly int base_num; 
	private readonly int tmin; 
	private readonly int tmax; 
	private readonly int skew; 
	private readonly int damp; 
	private readonly int initial_bias; 
	private readonly int initial_n; 


public void .ctor(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN) { }

public string Encode(string s, int offset) { }

private char EncodeDigit(int d) { }

private int DecodeDigit(char c) { }

private int Adapt(int delta, int numPoints, bool firstTime) { }

public string Decode(string s, int offset) { }

}

