using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Diagnostics;
using System.Text;

//void TestCase1()
//{
//    Stopwatch stopwatch = new Stopwatch();
//    stopwatch.Start();

//    StringTest();
//    stopwatch.Stop();
//    Console.WriteLine(stopwatch.ElapsedMilliseconds);

//    stopwatch.Restart();
//    stopwatch.Start();

//    StringBuilderTest();
//    stopwatch.Stop();
//    Console.WriteLine(stopwatch.ElapsedMilliseconds);
//}
//void StringTest()
//{
//    string result = "";
//    for (int i = 0; i < 100000; i++)
//    {
//        result += "a";
//    }
//}
//void StringBuilderTest()
//{
//    StringBuilder sb=new StringBuilder();
//    for (int i = 0;i <100000;i++)
//    {
//        sb.Append("a");
//    }
//}

//TestCase1();
BenchmarkRunner.Run<StrinBuilderVsString>();
public class StrinBuilderVsString()
{
    private const int NumberOfIterations = 100000;
    [Benchmark]
    #region stringtest
    public void StringTest()
    {
        string result = "";
        for (int i = 0; i < NumberOfIterations; i++)
        {
            result += "a";
        }
    }
    #endregion
    [Benchmark]
    #region stringbuilder
    public void StringBuilderTest()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < NumberOfIterations; i++)
        {
            sb.Append("a");
        }
    }
    #endregion
}

