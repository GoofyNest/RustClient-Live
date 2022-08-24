public class ContentDispositionHeaderValue : ICloneable // TypeDefIndex: 5763
{
	private string dispositionType; 
	private List<NameValueHeaderValue> parameters; 

public ICollection<NameValueHeaderValue> Parameters { get; }


private void .ctor() { }

protected void .ctor(ContentDispositionHeaderValue source) { }

public ICollection<NameValueHeaderValue> get_Parameters() { }

private object System.ICloneable.Clone() { }

public override bool Equals(object obj) { }

public override int GetHashCode() { }

public override string ToString() { }

public static bool TryParse(string input, out ContentDispositionHeaderValue parsedValue) { }

}

