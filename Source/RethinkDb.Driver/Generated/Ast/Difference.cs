












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public class Difference : ReqlExpr {

    
    
    
/// <summary>
/// <para>Remove the elements of one array from another array.</para>
/// </summary>
/// <example><para>Example: Retrieve Iron Man's equipment list without boots.</para>
/// <code>r.table('marvel').get('IronMan')('equipment').difference(['Boots']).run(conn, callback)
/// </code></example>
        public Difference (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Remove the elements of one array from another array.</para>
/// </summary>
/// <example><para>Example: Retrieve Iron Man's equipment list without boots.</para>
/// <code>r.table('marvel').get('IronMan')('equipment').difference(['Boots']).run(conn, callback)
/// </code></example>
        public Difference (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Remove the elements of one array from another array.</para>
/// </summary>
/// <example><para>Example: Retrieve Iron Man's equipment list without boots.</para>
/// <code>r.table('marvel').get('IronMan')('equipment').difference(['Boots']).run(conn, callback)
/// </code></example>
        public Difference (Arguments args, OptArgs optargs)
             : this(TermType.DIFFERENCE, args, optargs) {
        }

    protected Difference (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
