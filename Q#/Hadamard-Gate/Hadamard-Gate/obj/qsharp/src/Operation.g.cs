#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.Hadamard_Gate", "Set (desired : Result, q1 : Qubit) : ()", new string[] { }, "C:\\Users\\felix.schildorfer\\OneDrive - Avanade\\Education\\Q#\\Quantum Experiments\\Hadamard-Gate\\Hadamard-Gate\\Operation.qs", 169L, 7L, 5L)]
[assembly: OperationDeclaration("Quantum.Hadamard_Gate", "BellTest (count : Int, initial : Result) : (Int, Int)", new string[] { }, "C:\\Users\\felix.schildorfer\\OneDrive - Avanade\\Education\\Q#\\Quantum Experiments\\Hadamard-Gate\\Hadamard-Gate\\Operation.qs", 416L, 20L, 5L)]
#line hidden
namespace Quantum.Hadamard_Gate
{
    public class Set : Operation<(Result,Qubit), QVoid>
    {
        public Set(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.M), typeof(Microsoft.Quantum.Primitive.X) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected ICallable<Qubit, Result> M
        {
            get
            {
                return this.Factory.Get<ICallable<Qubit, Result>, Microsoft.Quantum.Primitive.M>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.X>();
            }
        }

        public override Func<(Result,Qubit), QVoid> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum.Hadamard_Gate.Set", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
                    var (desired,q1) = _args;
#line 10 "C:\\Users\\felix.schildorfer\\OneDrive - Avanade\\Education\\Q#\\Quantum Experiments\\Hadamard-Gate\\Hadamard-Gate\\Operation.qs"
                    var current = M.Apply<Result>(q1);
#line 11 "C:\\Users\\felix.schildorfer\\OneDrive - Avanade\\Education\\Q#\\Quantum Experiments\\Hadamard-Gate\\Hadamard-Gate\\Operation.qs"
                    if ((desired != current))
                    {
#line 13 "C:\\Users\\felix.schildorfer\\OneDrive - Avanade\\Education\\Q#\\Quantum Experiments\\Hadamard-Gate\\Hadamard-Gate\\Operation.qs"
                        MicrosoftQuantumPrimitiveX.Apply(q1);
                    }

#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum.Hadamard_Gate.Set", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desired, Qubit q1)
        {
            return __m__.Run<Set, (Result,Qubit), QVoid>((desired, q1));
        }
    }

    public class BellTest : Operation<(Int64,Result), (Int64,Int64)>
    {
        public BellTest(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Primitive.H), typeof(Microsoft.Quantum.Primitive.M), typeof(Microsoft.Quantum.Primitive.Release), typeof(Quantum.Hadamard_Gate.Set), typeof(Microsoft.Quantum.Primitive.Z) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected Allocate Allocate
        {
            get
            {
                return this.Factory.Get<Allocate, Microsoft.Quantum.Primitive.Allocate>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.H>();
            }
        }

        protected ICallable<Qubit, Result> M
        {
            get
            {
                return this.Factory.Get<ICallable<Qubit, Result>, Microsoft.Quantum.Primitive.M>();
            }
        }

        protected Release Release
        {
            get
            {
                return this.Factory.Get<Release, Microsoft.Quantum.Primitive.Release>();
            }
        }

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get
            {
                return this.Factory.Get<ICallable<(Result,Qubit), QVoid>, Quantum.Hadamard_Gate.Set>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.Z>();
            }
        }

        public override Func<(Int64,Result), (Int64,Int64)> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum.Hadamard_Gate.BellTest", OperationFunctor.Body, _args);
                var __result__ = default((Int64,Int64));
                try
                {
                    var (count,initial) = _args;
#line 23 "C:\\Users\\felix.schildorfer\\OneDrive - Avanade\\Education\\Q#\\Quantum Experiments\\Hadamard-Gate\\Hadamard-Gate\\Operation.qs"
                    var numOnes = 0L;
#line 24 "C:\\Users\\felix.schildorfer\\OneDrive - Avanade\\Education\\Q#\\Quantum Experiments\\Hadamard-Gate\\Hadamard-Gate\\Operation.qs"
                    var qubits = Allocate.Apply(1L);
#line 26 "C:\\Users\\felix.schildorfer\\OneDrive - Avanade\\Education\\Q#\\Quantum Experiments\\Hadamard-Gate\\Hadamard-Gate\\Operation.qs"
                    foreach (var test in new Range(1L, count))
                    {
#line 28 "C:\\Users\\felix.schildorfer\\OneDrive - Avanade\\Education\\Q#\\Quantum Experiments\\Hadamard-Gate\\Hadamard-Gate\\Operation.qs"
                        Set.Apply((initial, qubits[0L]));
#line 30 "C:\\Users\\felix.schildorfer\\OneDrive - Avanade\\Education\\Q#\\Quantum Experiments\\Hadamard-Gate\\Hadamard-Gate\\Operation.qs"
                        MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 31 "C:\\Users\\felix.schildorfer\\OneDrive - Avanade\\Education\\Q#\\Quantum Experiments\\Hadamard-Gate\\Hadamard-Gate\\Operation.qs"
                        MicrosoftQuantumPrimitiveZ.Apply(qubits[0L]);
#line 32 "C:\\Users\\felix.schildorfer\\OneDrive - Avanade\\Education\\Q#\\Quantum Experiments\\Hadamard-Gate\\Hadamard-Gate\\Operation.qs"
                        var res = M.Apply<Result>(qubits[0L]);
                        // Count the number of ones we saw:
#line 35 "C:\\Users\\felix.schildorfer\\OneDrive - Avanade\\Education\\Q#\\Quantum Experiments\\Hadamard-Gate\\Hadamard-Gate\\Operation.qs"
                        if ((res == Result.One))
                        {
#line 37 "C:\\Users\\felix.schildorfer\\OneDrive - Avanade\\Education\\Q#\\Quantum Experiments\\Hadamard-Gate\\Hadamard-Gate\\Operation.qs"
                            numOnes = (numOnes + 1L);
                        }
                    }

#line 40 "C:\\Users\\felix.schildorfer\\OneDrive - Avanade\\Education\\Q#\\Quantum Experiments\\Hadamard-Gate\\Hadamard-Gate\\Operation.qs"
                    Set.Apply((Result.Zero, qubits[0L]));
#line hidden
                    Release.Apply(qubits);
#line hidden
                    __result__ = ((count - numOnes), numOnes);
                    // Return number of times we saw a |0> and number of times we saw a |1>
#line 43 "C:\\Users\\felix.schildorfer\\OneDrive - Avanade\\Education\\Q#\\Quantum Experiments\\Hadamard-Gate\\Hadamard-Gate\\Operation.qs"
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum.Hadamard_Gate.BellTest", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<(Int64,Int64)> Run(IOperationFactory __m__, Int64 count, Result initial)
        {
            return __m__.Run<BellTest, (Int64,Result), (Int64,Int64)>((count, initial));
        }
    }
}