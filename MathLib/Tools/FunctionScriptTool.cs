using MathLib.Geometry;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.CodeDom;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Drawing;

namespace MathLib
{
    public interface IAssemblyFunction
    {
        double Function(double x);
    }

    public class FunctionScriptTool : IFunction, IPoints
    {
        private Assembly assembly;
        private IAssemblyFunction assemblyFunction;

        public string Script { get; set; } = "";
        public string ErrorText { get; private set; } = "";
        public Function Properties { get; set; } = new Function();
        public bool IsCoordinateShown { get; set; } = false;
        public double X { get; set; }
        public double Y { get; private set; }

        public void Update()
        {
            CompileCode(
               "public class Script : MathLib.IAssemblyFunction" +
               "{" +
               "double sin(double x) { return System.Math.Sin(x); }" +
               "double cos(double x) { return System.Math.Cos(x); }" +
               "double tan(double x) { return System.Math.Tan(x); }" +
               "double asin(double x) { return System.Math.Asin(x); }" +
               "double acos(double x) { return System.Math.Acos(x); }" +
               "double atan(double x) { return System.Math.Atan(x); }" +
               "double sqrt(double x) { return System.Math.Sqrt(x); }" +
               "double sqrt(double x, double y) { return System.Math.Pow(x, (double)1 / y); }" +
               "double pow(double x, double y) { return System.Math.Pow(x, y); }" +
               "double log(double x) { return System.Math.Log(x); }" +
               "double log10(double x) { return System.Math.Log10(x); }" +
               "double floor(double x) { return System.Math.Floor(x); }" +
               "double round(double x) { return System.Math.Round(x); }" +
               "double ceil(double x) { return System.Math.Ceiling(x); }" +
               "double sign(double x) { return System.Math.Sign(x); }" +
               "double truncate(double x) { return System.Math.Truncate(x); }" +
               "double abs(double x) { return System.Math.Abs(x); }" +
               "double pi = System.Math.PI;" +
               "double e = 2.7182818284590452353602874713527;" +
               "public double Function(double x){" +
               "int ix = (int)x;" +
               "uint uix = (uint)x;" +
               "short sx = (short)x;" +
               "ushort usx = (ushort)x;" +
               "sbyte bx = (sbyte)x;" +
               "byte ubx = (byte)x;" +
               "const double none = 0.1254232;" +
               $"{Script}" +
               $"return none;" +
               "}" +
               "}");
        }

        public double Function(double x)
        {
            if (assemblyFunction != null)
            {
                return assemblyFunction.Function(x);
            }
            else
            {
                return 0.1254232;
            }
        }

        void CompileCode(string code)
        {
            CSharpCodeProvider csProvider = new CSharpCodeProvider();

            CompilerParameters options = new CompilerParameters();
            options.GenerateExecutable = false; 
            options.GenerateInMemory = true; 

            options.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            options.ReferencedAssemblies.Add("netstandard.dll");

            // Compile our code
            CompilerResults result;
            result = csProvider.CompileAssemblyFromSource(options, code);

            if (result.Errors.HasErrors)
            {
                ErrorText = "Fejl på linje " + result.Errors[0].Line;

                // TODO: report back to the user that the script has errored
                assembly = null;
                return;
            }
            ErrorText = "";

            assembly = result.CompiledAssembly;
            if (assembly != null)
            {
                foreach (Type type in assembly.GetExportedTypes())
                {
                    foreach (Type iface in type.GetInterfaces())
                    {
                        if (iface == typeof(IAssemblyFunction))
                        {
                            ConstructorInfo constructor = type.GetConstructor(System.Type.EmptyTypes);
                            if (constructor != null && constructor.IsPublic)
                            {
                                assemblyFunction = constructor.Invoke(null) as IAssemblyFunction;
                            }
                        }
                    }
                }
            }
        }

        public Point2D[] Points()
        {
            if (IsCoordinateShown)
            {
                Y = 0;

                if (assemblyFunction != null)
                {
                    Y = assemblyFunction.Function(X);
                }

                return new Point2D[]
                {
                new Point2D(X, Y, "#", Color.Red)
                };
            }
            else
            {
                return new Point2D[] { };
            }
        }
    }
}
