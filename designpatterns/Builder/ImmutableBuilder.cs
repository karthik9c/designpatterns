using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MyHttpRequest
    {
        public string Url { get; }
        public string Method { get; }
        public string ContentType { get; }
        public string Headers { get; }
        private MyHttpRequest(string url, string method, string contentType, string headers) {
            this.Url = url;
            this.Method = method;
            this.ContentType = contentType;
            this.Headers = headers;
        }

        public static Builder GetBuilder()
        {
            return new Builder();
        }

        public class Builder
        {
            private string _url;
            private string _method;
            private string _contentType;
            private string _headers;

            public Builder SetURL(string url) { 
                _url = url;

                return this;
            }

            public Builder SetMethod(string method) { _method = method; return this; }
            public Builder SetContentType(string contentType) { _contentType = contentType; return this; }
            public Builder SetHeaders(string headers) { _headers = headers; return this; }

            public MyHttpRequest Build() 
            { 
                return new MyHttpRequest(_url, _method, _contentType, _headers); 
            }
        }
    }
}
