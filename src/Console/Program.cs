// See https://aka.ms/new-console-template for more information

using Zatsuon.NET;
using Zatsuon.NET.Requests;

var rnd = new RandomOrgClient(String.Empty);

var res = await rnd.Integer.GenerateIntegerSequences(new GenerateIntegerSequencesRequest()
{
    Amount = 2,
    Max = new []{ 25, 25 },
    Base = 10,
    Length = new []{ 2, 3 },
    Min = new [] { 0, 0 },
});

Console.WriteLine(res);
