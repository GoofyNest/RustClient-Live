internal sealed class RegexParser // TypeDefIndex: 2627
{
	internal RegexNode _stack; 
	internal RegexNode _group; 
	internal RegexNode _alternation; 
	internal RegexNode _concatenation; 
	internal RegexNode _unit; 
	internal string _pattern; 
	internal int _currentPos; 
	internal CultureInfo _culture; 
	internal int _autocap; 
	internal int _capcount; 
	internal int _captop; 
	internal int _capsize; 
	internal Hashtable _caps; 
	internal Hashtable _capnames; 
	internal int[] _capnumlist; 
	internal List<string> _capnamelist; 
	internal RegexOptions _options; 
	internal List<RegexOptions> _optionsStack; 
	internal bool _ignoreNextParen; 
	internal static readonly byte[] _category; 


	internal static RegexTree Parse(string re, RegexOptions op) { }

	internal static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op) { }

	internal static string Escape(string input) { }

	private void .ctor(CultureInfo culture) { }

	internal void SetPattern(string Re) { }

	internal void Reset(RegexOptions topopts) { }

	internal RegexNode ScanRegex() { }

	internal RegexNode ScanReplacement() { }

	internal RegexCharClass ScanCharClass(bool caseInsensitive) { }

	internal RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly) { }

	internal RegexNode ScanGroupOpen() { }

	internal void ScanBlank() { }

	internal RegexNode ScanBackslash() { }

	internal RegexNode ScanBasicBackslash() { }

	internal RegexNode ScanDollar() { }

	internal string ScanCapname() { }

	internal char ScanOctal() { }

	internal int ScanDecimal() { }

	internal char ScanHex(int c) { }

	internal static int HexDigit(char ch) { }

	internal char ScanControl() { }

	internal bool IsOnlyTopOption(RegexOptions option) { }

	internal void ScanOptions() { }

	internal char ScanCharEscape() { }

	internal string ParseProperty() { }

	internal int TypeFromCode(char ch) { }

	internal static RegexOptions OptionFromCode(char ch) { }

	internal void CountCaptures() { }

	internal void NoteCaptureSlot(int i, int pos) { }

	internal void NoteCaptureName(string name, int pos) { }

	internal void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames) { }

	internal void AssignNameSlots() { }

	internal int CaptureSlotFromName(string capname) { }

	internal bool IsCaptureSlot(int i) { }

	internal bool IsCaptureName(string capname) { }

	internal bool UseOptionN() { }

	internal bool UseOptionI() { }

	internal bool UseOptionM() { }

	internal bool UseOptionS() { }

	internal bool UseOptionX() { }

	internal bool UseOptionE() { }

	internal static bool IsSpecial(char ch) { }

	internal static bool IsStopperX(char ch) { }

	internal static bool IsQuantifier(char ch) { }

	internal bool IsTrueQuantifier() { }

	internal static bool IsSpace(char ch) { }

	internal static bool IsMetachar(char ch) { }

	internal void AddConcatenate(int pos, int cch, bool isReplacement) { }

	internal void PushGroup() { }

	internal void PopGroup() { }

	internal bool EmptyStack() { }

	internal void StartGroup(RegexNode openGroup) { }

	internal void AddAlternate() { }

	internal void AddConcatenate() { }

	internal void AddConcatenate(bool lazy, int min, int max) { }

	internal RegexNode Unit() { }

	internal void AddUnitOne(char ch) { }

	internal void AddUnitNotone(char ch) { }

	internal void AddUnitSet(string cc) { }

	internal void AddUnitNode(RegexNode node) { }

	internal void AddUnitType(int type) { }

	internal void AddGroup() { }

	internal void PushOptions() { }

	internal void PopOptions() { }

	internal bool EmptyOptionsStack() { }

	internal void PopKeepOptions() { }

	internal ArgumentException MakeException(string message) { }

	internal int Textpos() { }

	internal void Textto(int pos) { }

	internal char MoveRightGetChar() { }

	internal void MoveRight() { }

	internal void MoveRight(int i) { }

	internal void MoveLeft() { }

	internal char CharAt(int i) { }

	internal char RightChar() { }

	internal char RightChar(int i) { }

	internal int CharsRight() { }

	private static void .cctor() { }

}

