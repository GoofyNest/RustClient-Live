internal sealed class CachedCodeEntry // TypeDefIndex: 2601
{
	internal string _key; 
	internal RegexCode _code; 
	internal Hashtable _caps; 
	internal Hashtable _capnames; 
	internal string[] _capslist; 
	internal int _capsize; 
	internal RegexRunnerFactory _factory; 
	internal ExclusiveReference _runnerref; 
	internal SharedReference _replref; 


	internal void .ctor(string key, Hashtable capnames, string[] capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, SharedReference repl) { }

}

