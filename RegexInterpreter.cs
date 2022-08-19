internal sealed class RegexInterpreter : RegexRunner // TypeDefIndex: 2619
{	// Fields
	internal int runoperator; // 0x80
	internal int[] runcodes; // 0x88
	internal int runcodepos; // 0x90
	internal string[] runstrings; // 0x98
	internal RegexCode runcode; // 0xA0
	internal RegexPrefix runfcPrefix; // 0xA8
	internal RegexBoyerMoore runbmPrefix; // 0xB0
	internal int runanchors; // 0xB8
	internal bool runrtl; // 0xBC
	internal bool runci; // 0xBD
	internal CultureInfo runculture; // 0xC0

	// Methods

	// RVA: 0x16A9A50 Offset: 0x16A8E50 VA: 0x1816A9A50
	internal void .ctor(RegexCode code, CultureInfo culture) { }

	// RVA: 0x16A9050 Offset: 0x16A8450 VA: 0x1816A9050 Slot: 6
	protected override void InitTrackCount() { }

	// RVA: 0x16A6070 Offset: 0x16A5470 VA: 0x1816A6070
	private void Advance() { }

	// RVA: 0x16A5FF0 Offset: 0x16A53F0 VA: 0x1816A5FF0
	private void Advance(int i) { }

	// RVA: 0x16A8FC0 Offset: 0x16A83C0 VA: 0x1816A8FC0
	private void Goto(int newpos) { }

	// RVA: 0x7E8DF0 Offset: 0x7E81F0 VA: 0x1807E8DF0
	private void Textto(int newpos) { }

	// RVA: 0x16A9A30 Offset: 0x16A8E30 VA: 0x1816A9A30
	private void Trackto(int newpos) { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	private int Textstart() { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	private int Textpos() { }

	// RVA: 0x16A9A10 Offset: 0x16A8E10 VA: 0x1816A9A10
	private int Trackpos() { }

	// RVA: 0x16A9850 Offset: 0x16A8C50 VA: 0x1816A9850
	private void TrackPush() { }

	// RVA: 0x16A98A0 Offset: 0x16A8CA0 VA: 0x1816A98A0
	private void TrackPush(int I1) { }

	// RVA: 0x16A97A0 Offset: 0x16A8BA0 VA: 0x1816A97A0
	private void TrackPush(int I1, int I2) { }

	// RVA: 0x16A9920 Offset: 0x16A8D20 VA: 0x1816A9920
	private void TrackPush(int I1, int I2, int I3) { }

	// RVA: 0x16A9660 Offset: 0x16A8A60 VA: 0x1816A9660
	private void TrackPush2(int I1) { }

	// RVA: 0x16A96E0 Offset: 0x16A8AE0 VA: 0x1816A96E0
	private void TrackPush2(int I1, int I2) { }

	// RVA: 0x16A6080 Offset: 0x16A5480 VA: 0x1816A6080
	private void Backtrack() { }

	// RVA: 0x16A9290 Offset: 0x16A8690 VA: 0x1816A9290
	private void SetOperator(int op) { }

	// RVA: 0x16A9650 Offset: 0x16A8A50 VA: 0x1816A9650
	private void TrackPop() { }

	// RVA: 0x16A9640 Offset: 0x16A8A40 VA: 0x1816A9640
	private void TrackPop(int framesize) { }

	// RVA: 0x16A95C0 Offset: 0x16A89C0 VA: 0x1816A95C0
	private int TrackPeek() { }

	// RVA: 0x16A9600 Offset: 0x16A8A00 VA: 0x1816A9600
	private int TrackPeek(int i) { }

	// RVA: 0x16A93E0 Offset: 0x16A87E0 VA: 0x1816A93E0
	private void StackPush(int I1) { }

	// RVA: 0x16A9360 Offset: 0x16A8760 VA: 0x1816A9360
	private void StackPush(int I1, int I2) { }

	// RVA: 0x16A9350 Offset: 0x16A8750 VA: 0x1816A9350
	private void StackPop() { }

	// RVA: 0x16A9340 Offset: 0x16A8740 VA: 0x1816A9340
	private void StackPop(int framesize) { }

	// RVA: 0x16A92C0 Offset: 0x16A86C0 VA: 0x1816A92C0
	private int StackPeek() { }

	// RVA: 0x16A9300 Offset: 0x16A8700 VA: 0x1816A9300
	private int StackPeek(int i) { }

	// RVA: 0x59C1A0 Offset: 0x59B5A0 VA: 0x18059C1A0
	private int Operator() { }

	// RVA: 0x16A9090 Offset: 0x16A8490 VA: 0x1816A9090
	private int Operand(int i) { }

	// RVA: 0x16A9080 Offset: 0x16A8480 VA: 0x1816A9080
	private int Leftchars() { }

	// RVA: 0x16A9280 Offset: 0x16A8680 VA: 0x1816A9280
	private int Rightchars() { }

	// RVA: 0x16A6190 Offset: 0x16A5590 VA: 0x1816A6190
	private int Bump() { }

	// RVA: 0x16A66B0 Offset: 0x16A5AB0 VA: 0x1816A66B0
	private int Forwardchars() { }

	// RVA: 0x16A6600 Offset: 0x16A5A00 VA: 0x1816A6600
	private char Forwardcharnext() { }

	// RVA: 0x16A9430 Offset: 0x16A8830 VA: 0x1816A9430
	private bool Stringmatch(string str) { }

	// RVA: 0x16A90E0 Offset: 0x16A84E0 VA: 0x1816A90E0
	private bool Refmatch(int index, int len) { }

	// RVA: 0x16A6170 Offset: 0x16A5570 VA: 0x1816A6170
	private void Backwardnext() { }

	// RVA: 0x16A61B0 Offset: 0x16A55B0 VA: 0x1816A61B0
	private char CharAt(int j) { }

	// RVA: 0x16A61D0 Offset: 0x16A55D0 VA: 0x1816A61D0 Slot: 5
	protected override bool FindFirstChar() { }

	// RVA: 0x16A66D0 Offset: 0x16A5AD0 VA: 0x1816A66D0 Slot: 4
	protected override void Go() { }

}

