internal class ErrorMessage : IMethodCallMessage, IMethodMessage, IMessage // TypeDefIndex: 1236
{
	private string _uri; 

public int ArgCount { get; }
public object[] Args { get; }
public MethodBase MethodBase { get; }
public string MethodName { get; }
public object MethodSignature { get; }
public virtual IDictionary Properties { get; }
public string TypeName { get; }
public string Uri { get; }
public LogicalCallContext LogicalCallContext { get; }


public void .ctor() { }

public int get_ArgCount() { }

public object[] get_Args() { }

public MethodBase get_MethodBase() { }

public string get_MethodName() { }

public object get_MethodSignature() { }

public virtual IDictionary get_Properties() { }

public string get_TypeName() { }

public string get_Uri() { }

public object GetArg(int arg_num) { }

public LogicalCallContext get_LogicalCallContext() { }

}

