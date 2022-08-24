internal class KnownHttpVerb // TypeDefIndex: 2892
{
	internal string Name; 
	internal bool RequireContentBody; 
	internal bool ContentBodyNotAllowed; 
	internal bool ConnectRequest; 
	internal bool ExpectNoContentResponse; 
	private static ListDictionary NamedHeaders; 
	internal static KnownHttpVerb Get; 
	internal static KnownHttpVerb Connect; 
	internal static KnownHttpVerb Head; 
	internal static KnownHttpVerb Put; 
	internal static KnownHttpVerb Post; 
	internal static KnownHttpVerb MkCol; 


	internal void .ctor(string name, bool requireContentBody, bool contentBodyNotAllowed, bool connectRequest, bool expectNoContentResponse) { }

	private static void .cctor() { }

	public static KnownHttpVerb Parse(string name) { }

}

