public class CultureNotFoundException : ArgumentException, ISerializable // TypeDefIndex: 691
{
	private string m_invalidCultureName; 
	private Nullable<int> m_invalidCultureId; 

public virtual Nullable<int> InvalidCultureId { get; }
public virtual string InvalidCultureName { get; }
private static string DefaultMessage { get; }
private string FormatedInvalidCultureId { get; }
public override string Message { get; }


public void .ctor() { }

public void .ctor(string paramName, string message) { }

public void .ctor(string paramName, string invalidCultureName, string message) { }

protected void .ctor(SerializationInfo info, StreamingContext context) { }

public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

public virtual Nullable<int> get_InvalidCultureId() { }

public virtual string get_InvalidCultureName() { }

private static string get_DefaultMessage() { }

private string get_FormatedInvalidCultureId() { }

public override string get_Message() { }

}

