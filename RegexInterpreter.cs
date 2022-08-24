internal sealed class RegexInterpreter : RegexRunner // TypeDefIndex: 2619
{
	internal int runoperator; 
	internal int[] runcodes; 
	internal int runcodepos; 
	internal string[] runstrings; 
	internal RegexCode runcode; 
	internal RegexPrefix runfcPrefix; 
	internal RegexBoyerMoore runbmPrefix; 
	internal int runanchors; 
	internal bool runrtl; 
	internal bool runci; 
	internal CultureInfo runculture; 


	internal void .ctor(RegexCode code, CultureInfo culture) { }

	protected override void InitTrackCount() { }

	private void Advance() { }

	private void Advance(int i) { }

	private void Goto(int newpos) { }

	private void Textto(int newpos) { }

	private void Trackto(int newpos) { }

	private int Textstart() { }

	private int Textpos() { }

	private int Trackpos() { }

	private void TrackPush() { }

	private void TrackPush(int I1) { }

	private void TrackPush(int I1, int I2) { }

	private void TrackPush(int I1, int I2, int I3) { }

	private void TrackPush2(int I1) { }

	private void TrackPush2(int I1, int I2) { }

	private void Backtrack() { }

	private void SetOperator(int op) { }

	private void TrackPop() { }

	private void TrackPop(int framesize) { }

	private int TrackPeek() { }

	private int TrackPeek(int i) { }

	private void StackPush(int I1) { }

	private void StackPush(int I1, int I2) { }

	private void StackPop() { }

	private void StackPop(int framesize) { }

	private int StackPeek() { }

	private int StackPeek(int i) { }

	private int Operator() { }

	private int Operand(int i) { }

	private int Leftchars() { }

	private int Rightchars() { }

	private int Bump() { }

	private int Forwardchars() { }

	private char Forwardcharnext() { }

	private bool Stringmatch(string str) { }

	private bool Refmatch(int index, int len) { }

	private void Backwardnext() { }

	private char CharAt(int j) { }

	protected override bool FindFirstChar() { }

	protected override void Go() { }

}

