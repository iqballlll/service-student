namespace ServiceStudent.Helper;

public class AppHelper
{
  
}

public class ResponseData<T>
{
    public int code { get; set; }
    public string message { get; set; }
    public T data { get; set; }
}