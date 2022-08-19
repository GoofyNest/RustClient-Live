internal sealed class RegexParser // TypeDefIndex: 2627
{	// Fields
	internal RegexNode _stack; // 0x10
	internal RegexNode _group; // 0x18
	internal RegexNode _alternation; // 0x20
	internal RegexNode _concatenation; // 0x28
	internal RegexNode _unit; // 0x30
	internal string _pattern; // 0x38
	internal int _currentPos; // 0x40
	internal CultureInfo _culture; // 0x48
	internal int _autocap; // 0x50
	internal int _capcount; // 0x54
	internal int _captop; // 0x58
	internal int _capsize; // 0x5C
	internal Hashtable _caps; // 0x60
	internal Hashtable _capnames; // 0x68
	internal int[] _capnumlist; // 0x70
	internal List<string> _capnamelist; // 0x78
	internal RegexOptions _options; // 0x80
	internal List<RegexOptions> _optionsStack; // 0x88
	internal bool _ignoreNextParen; // 0x90
	internal static readonly byte[] _category; // 0x0

	// Methods

	// RVA: 0x16AD790 Offset: 0x16ACB90 VA: 0x1816AD790
	internal static RegexTree Parse(string re, RegexOptions op) { }

	// RVA: 0x16AD600 Offset: 0x16ACA00 VA: 0x1816AD600
	internal static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op) { }

	// RVA: 0x16AC7B0 Offset: 0x16ABBB0 VA: 0x1816AC7B0
	internal static string Escape(string input) { }

	// RVA: 0x16B1CE0 Offset: 0x16B10E0 VA: 0x1816B1CE0
	private void .ctor(CultureInfo culture) { }

	// RVA: 0x16B1A60 Offset: 0x16B0E60 VA: 0x1816B1A60
	internal void SetPattern(string Re) { }

	// RVA: 0x16ADCC0 Offset: 0x16AD0C0 VA: 0x1816ADCC0
	internal void Reset(RegexOptions topopts) { }

	// RVA: 0x16B0FE0 Offset: 0x16B03E0 VA: 0x1816B0FE0
	internal RegexNode ScanRegex() { }

	// RVA: 0x16B1840 Offset: 0x16B0C40 VA: 0x1816B1840
	internal RegexNode ScanReplacement() { }

	// RVA: 0x16AEE10 Offset: 0x16AE210 VA: 0x1816AEE10
	internal RegexCharClass ScanCharClass(bool caseInsensitive) { }

	// RVA: 0x16AEE20 Offset: 0x16AE220 VA: 0x1816AEE20
	internal RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly) { }

	// RVA: 0x16B0080 Offset: 0x16AF480 VA: 0x1816B0080
	internal RegexNode ScanGroupOpen() { }

	// RVA: 0x16AE9A0 Offset: 0x16ADDA0 VA: 0x1816AE9A0
	internal void ScanBlank() { }

	// RVA: 0x16ADDB0 Offset: 0x16AD1B0 VA: 0x1816ADDB0
	internal RegexNode ScanBackslash() { }

	// RVA: 0x16AE300 Offset: 0x16AD700 VA: 0x1816AE300
	internal RegexNode ScanBasicBackslash() { }

	// RVA: 0x16AFC60 Offset: 0x16AF060 VA: 0x1816AFC60
	internal RegexNode ScanDollar() { }

	// RVA: 0x16AED50 Offset: 0x16AE150 VA: 0x1816AED50
	internal string ScanCapname() { }

	// RVA: 0x16B0E40 Offset: 0x16B0240 VA: 0x1816B0E40
	internal char ScanOctal() { }

	// RVA: 0x16AFB90 Offset: 0x16AEF90 VA: 0x1816AFB90
	internal int ScanDecimal() { }

	// RVA: 0x16B0D20 Offset: 0x16B0120 VA: 0x1816B0D20
	internal char ScanHex(int c) { }

	// RVA: 0x16AC9B0 Offset: 0x16ABDB0 VA: 0x1816AC9B0
	internal static int HexDigit(char ch) { }

	// RVA: 0x16AFAC0 Offset: 0x16AEEC0 VA: 0x1816AFAC0
	internal char ScanControl() { }

	// RVA: 0x16ACB40 Offset: 0x16ABF40 VA: 0x1816ACB40
	internal bool IsOnlyTopOption(RegexOptions option) { }

	// RVA: 0x16B0ED0 Offset: 0x16B02D0 VA: 0x1816B0ED0
	internal void ScanOptions() { }

	// RVA: 0x16AF700 Offset: 0x16AEB00 VA: 0x1816AF700
	internal char ScanCharEscape() { }

	// RVA: 0x16AD440 Offset: 0x16AC840 VA: 0x1816AD440
	internal string ParseProperty() { }

	// RVA: 0x16B1B90 Offset: 0x16B0F90 VA: 0x1816B1B90
	internal int TypeFromCode(char ch) { }

	// RVA: 0x16AD3A0 Offset: 0x16AC7A0 VA: 0x1816AD3A0
	internal static RegexOptions OptionFromCode(char ch) { }

	// RVA: 0x16AC3E0 Offset: 0x16AB7E0 VA: 0x1816AC3E0
	internal void CountCaptures() { }

	// RVA: 0x16AD250 Offset: 0x16AC650 VA: 0x1816AD250
	internal void NoteCaptureSlot(int i, int pos) { }

	// RVA: 0x16AD120 Offset: 0x16AC520 VA: 0x1816AD120
	internal void NoteCaptureName(string name, int pos) { }

	// RVA: 0x16AD350 Offset: 0x16AC750 VA: 0x1816AD350
	internal void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames) { }

	// RVA: 0x16ABCD0 Offset: 0x16AB0D0 VA: 0x1816ABCD0
	internal void AssignNameSlots() { }

	// RVA: 0x16AC310 Offset: 0x16AB710 VA: 0x1816AC310
	internal int CaptureSlotFromName(string capname) { }

	// RVA: 0x16ACA00 Offset: 0x16ABE00 VA: 0x1816ACA00
	internal bool IsCaptureSlot(int i) { }

	// RVA: 0x16AC9E0 Offset: 0x16ABDE0 VA: 0x1816AC9E0
	internal bool IsCaptureName(string capname) { }

	// RVA: 0x16B1C40 Offset: 0x16B1040 VA: 0x1816B1C40
	internal bool UseOptionN() { }

	// RVA: 0x16B1C20 Offset: 0x16B1020 VA: 0x1816B1C20
	internal bool UseOptionI() { }

	// RVA: 0x16B1C30 Offset: 0x16B1030 VA: 0x1816B1C30
	internal bool UseOptionM() { }

	// RVA: 0x16B1C50 Offset: 0x16B1050 VA: 0x1816B1C50
	internal bool UseOptionS() { }

	// RVA: 0x16B1C60 Offset: 0x16B1060 VA: 0x1816B1C60
	internal bool UseOptionX() { }

	// RVA: 0x16B1C10 Offset: 0x16B1010 VA: 0x1816B1C10
	internal bool UseOptionE() { }

	// RVA: 0x16ACCA0 Offset: 0x16AC0A0 VA: 0x1816ACCA0
	internal static bool IsSpecial(char ch) { }

	// RVA: 0x16ACD40 Offset: 0x16AC140 VA: 0x1816ACD40
	internal static bool IsStopperX(char ch) { }

	// RVA: 0x16ACB60 Offset: 0x16ABF60 VA: 0x1816ACB60
	internal static bool IsQuantifier(char ch) { }

	// RVA: 0x16ACDE0 Offset: 0x16AC1E0 VA: 0x1816ACDE0
	internal bool IsTrueQuantifier() { }

	// RVA: 0x16ACC00 Offset: 0x16AC000 VA: 0x1816ACC00
	internal static bool IsSpace(char ch) { }

	// RVA: 0x16ACAA0 Offset: 0x16ABEA0 VA: 0x1816ACAA0
	internal static bool IsMetachar(char ch) { }

	// RVA: 0x16AB460 Offset: 0x16AA860 VA: 0x1816AB460
	internal void AddConcatenate(int pos, int cch, bool isReplacement) { }

	// RVA: 0x16ADBF0 Offset: 0x16ACFF0 VA: 0x1816ADBF0
	internal void PushGroup() { }

	// RVA: 0x16AD9D0 Offset: 0x16ACDD0 VA: 0x1816AD9D0
	internal void PopGroup() { }

	// RVA: 0x16AC7A0 Offset: 0x16ABBA0 VA: 0x1816AC7A0
	internal bool EmptyStack() { }

	// RVA: 0x16B1AD0 Offset: 0x16B0ED0 VA: 0x1816B1AD0
	internal void StartGroup(RegexNode openGroup) { }

	// RVA: 0x16AB300 Offset: 0x16AA700 VA: 0x1816AB300
	internal void AddAlternate() { }

	// RVA: 0x16AB7E0 Offset: 0x16AABE0 VA: 0x1816AB7E0
	internal void AddConcatenate() { }

	// RVA: 0x16AB690 Offset: 0x16AAA90 VA: 0x1816AB690
	internal void AddConcatenate(bool lazy, int min, int max) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	internal RegexNode Unit() { }

	// RVA: 0x16ABAF0 Offset: 0x16AAEF0 VA: 0x1816ABAF0
	internal void AddUnitOne(char ch) { }

	// RVA: 0x16ABA20 Offset: 0x16AAE20 VA: 0x1816ABA20
	internal void AddUnitNotone(char ch) { }

	// RVA: 0x16ABBC0 Offset: 0x16AAFC0 VA: 0x1816ABBC0
	internal void AddUnitSet(string cc) { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	internal void AddUnitNode(RegexNode node) { }

	// RVA: 0x16ABC50 Offset: 0x16AB050 VA: 0x1816ABC50
	internal void AddUnitType(int type) { }

	// RVA: 0x16AB830 Offset: 0x16AAC30 VA: 0x1816AB830
	internal void AddGroup() { }

	// RVA: 0x16ADC70 Offset: 0x16AD070 VA: 0x1816ADC70
	internal void PushOptions() { }

	// RVA: 0x16ADB60 Offset: 0x16ACF60 VA: 0x1816ADB60
	internal void PopOptions() { }

	// RVA: 0x16AC750 Offset: 0x16ABB50 VA: 0x1816AC750
	internal bool EmptyOptionsStack() { }

	// RVA: 0x16ADB10 Offset: 0x16ACF10 VA: 0x1816ADB10
	internal void PopKeepOptions() { }

	// RVA: 0x16ACF70 Offset: 0x16AC370 VA: 0x1816ACF70
	internal ArgumentException MakeException(string message) { }

	// RVA: 0x5F7C80 Offset: 0x5F7080 VA: 0x1805F7C80
	internal int Textpos() { }

	// RVA: 0x6B9860 Offset: 0x6B8C60 VA: 0x1806B9860
	internal void Textto(int pos) { }

	// RVA: 0x16AD0D0 Offset: 0x16AC4D0 VA: 0x1816AD0D0
	internal char MoveRightGetChar() { }

	// RVA: 0x16AD100 Offset: 0x16AC500 VA: 0x1816AD100
	internal void MoveRight() { }

	// RVA: 0x16AD110 Offset: 0x16AC510 VA: 0x1816AD110
	internal void MoveRight(int i) { }

	// RVA: 0x16AD0C0 Offset: 0x16AC4C0 VA: 0x1816AD0C0
	internal void MoveLeft() { }

	// RVA: 0x16AC3A0 Offset: 0x16AB7A0 VA: 0x1816AC3A0
	internal char CharAt(int i) { }

	// RVA: 0x16ADD80 Offset: 0x16AD180 VA: 0x1816ADD80
	internal char RightChar() { }

	// RVA: 0x16ADD50 Offset: 0x16AD150 VA: 0x1816ADD50
	internal char RightChar(int i) { }

	// RVA: 0x16AC3C0 Offset: 0x16AB7C0 VA: 0x1816AC3C0
	internal int CharsRight() { }

	// RVA: 0x16B1C70 Offset: 0x16B1070 VA: 0x1816B1C70
	private static void .cctor() { }

}

