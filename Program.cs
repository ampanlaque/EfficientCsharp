
using EfficientCsharp;

using BenchmarkDotNet.Running;
BenchmarkRunner.Run<GuiderBenchmarks>();


//var id = Guid.NewGuid();
//Console.WriteLine("id:"+id);

//var base64Id = Convert.ToBase64String(id.ToByteArray());
//Console.WriteLine("url:"+ base64Id);

//var urlFriendlyBase64Id = Guider.ToStringFromGuid(id);
//Console.WriteLine("url from guid:" + urlFriendlyBase64Id);

//var urlFriendlyBase64IdOp = Guider.ToStringFromGuidOp(id);
//Console.WriteLine("url from guid OP:" + urlFriendlyBase64IdOp);

//var idFromUrl = Guider.ToGuidFromString(urlFriendlyBase64Id);
//Console.WriteLine("Id from Url:" + idFromUrl);

//var idFromUrlOp = Guider.ToGuidFromStringOp(urlFriendlyBase64Id);
//Console.WriteLine("Id from Url OP:" + idFromUrlOp);
