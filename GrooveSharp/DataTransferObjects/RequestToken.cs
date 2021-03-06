using System.Runtime.Serialization;

namespace GrooveSharp.DataTransferObjects
{
    [DataContract]
    internal class RequestToken<T> where T : new()
    {
        [DataMember(Name = "method")]
        public string Method { get; set; }

        [DataMember(Name = "header")]
        public RequestTokenHeader Header { get; set; }

        [DataMember(Name = "parameters")]
        public T Parameters { get; set; }

        public RequestToken()
        {
            this.Header = new RequestTokenHeader();
            this.Parameters = new T();
        }
    }
}