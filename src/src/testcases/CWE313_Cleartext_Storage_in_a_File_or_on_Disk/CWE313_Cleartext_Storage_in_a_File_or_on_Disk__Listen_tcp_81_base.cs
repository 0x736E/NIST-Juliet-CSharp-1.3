/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE313_Cleartext_Storage_in_a_File_or_on_Disk__Listen_tcp_81_base.cs
Label Definition File: CWE313_Cleartext_Storage_in_a_File_or_on_Disk.label.xml
Template File: sources-sinks-81_base.tmpl.cs
*/
/*
 * @description
 * CWE: 313 Cleartext storage in a File or on Disk
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: Hash data before storing in registry
 *    BadSink : Store data directly in a file
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Web;

namespace testcases.CWE313_Cleartext_Storage_in_a_File_or_on_Disk
{
abstract class CWE313_Cleartext_Storage_in_a_File_or_on_Disk__Listen_tcp_81_base
{
    public abstract void Action(string data );
}
}