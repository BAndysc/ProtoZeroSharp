﻿using BenchmarkDotNet.Running;

namespace Benchmarks;

class Program
{
    static void Main(string[] args)
    {
        //var summary = BenchmarkRunner.Run<ProtoZeroVsCanonical>();
        var summary = BenchmarkRunner.Run<ProtoZeroVsCanonicalReader>();
    }
}