using MathLib.Geometry;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.CodeDom;
using Microsoft.CSharp;
using System.CodeDom.Compiler;

namespace MathLib
{
    public class FunctionScriptTool : IFunction
    {
        public Assembly assembly;

        public string Script { get; set; } = "";
        public string ErrorText { get; private set; } = "";

        public void Update()
        {
            CompileCode(
               "public class Script : MathLib.Geometry.IFunction" +
               "{"+
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
            
            if (assembly != null)
            {
                foreach (Type type in assembly.GetExportedTypes())
                {
                    foreach (Type iface in type.GetInterfaces())
                    {
                        if (iface == typeof(IFunction))
                        {
                            ConstructorInfo constructor = type.GetConstructor(System.Type.EmptyTypes);
                            if (constructor != null && constructor.IsPublic)
                            {
                                IFunction scriptObject = constructor.Invoke(null) as IFunction;
                                if (scriptObject != null)
                                {
                                    try
                                    {
                                        return scriptObject.Function(x);
                                    }
                                    catch(Exception exception)
                                    {
                                        ErrorText = "Dårligt script: " + exception.Message;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return 0;
        }

        void CompileCode(string code)
        {
            CSharpCodeProvider csProvider = new CSharpCodeProvider();

            CompilerParameters options = new CompilerParameters();
            options.GenerateExecutable = false; 
            options.GenerateInMemory = true; 

            options.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);

            // Compile our code
            CompilerResults result;
            result = csProvider.CompileAssemblyFromSource(options, code);

            if (result.Errors.HasErrors)
            {
                ErrorText = "Linje " + result.Errors[0].Line + " - " + result.Errors[0].ErrorText;

                // TODO: report back to the user that the script has errored
                assembly = null;
                return;
            }
            ErrorText = "";

            assembly = result.CompiledAssembly;
        }
    }
}
