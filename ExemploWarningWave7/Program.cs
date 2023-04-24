using System.Runtime.InteropServices;
using ExemploWarningWave7;

Console.WriteLine("***** Testes com C# 11 | Warning wave 7 *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");

Console.WriteLine();
Console.WriteLine("Classes com nome em minusculo e que estao gerando alertas:");
Console.WriteLine($"- {nameof(test)}");
Console.WriteLine($"- {nameof(assert)}");
Console.WriteLine($"- {nameof(validator)}");