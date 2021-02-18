using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;


namespace ConsoleApp1
{
    class Program
    {



        static void Main(string[] args)
        {

            string tx1 = "aad28e85f31ae79339b49d114d7c1811d2c667681a1904ebbc326842a0a81985";
            string tx2 = "b963d3426088217357b146d5600817c54f93c2ea1a23126988e36460015ffc0e";
            string tx3 = "82498f4da1e1b662b02e95150dc9fd64307ee96b35657f75c7abd82530168ce3";
            string tx4 = "ceecfd37686a3ed1759d3cef25e412a800fc8e8846154dbe2a2d72b2af3e3b64";

            string tx12 = tx1 + tx2;

            byte[] tx12hash1stringbytes = Encoding.ASCII.GetBytes(tx12);
            byte[] tx12hashBytes = SHA256.Create().ComputeHash(tx12hash1stringbytes);
            string tx12hexHash1 =  BitConverter.ToString(tx12hashBytes).Replace("-", "").ToLower();

            byte[] tx12hash2stringbytes = Encoding.ASCII.GetBytes(tx12hexHash1);
            byte[] tx12hashBytes2 = SHA256.Create().ComputeHash(tx12hash2stringbytes);
            string tx12hexHash2 = BitConverter.ToString(tx12hashBytes2).Replace("-", "").ToLower();

            string tx34 = tx3 + tx4;

            byte[] tx34hash1stringbytes = Encoding.ASCII.GetBytes(tx34);
            byte[] tx34hashBytes = SHA256.Create().ComputeHash(tx34hash1stringbytes);
            string tx34hexHash1 = BitConverter.ToString(tx34hashBytes).Replace("-", "").ToLower();

            byte[] tx34hash2stringbytes = Encoding.ASCII.GetBytes(tx34hexHash1);
            byte[] tx34hashBytes2 = SHA256.Create().ComputeHash(tx34hash2stringbytes);
            string tx34hexHash2 = BitConverter.ToString(tx34hashBytes2).Replace("-", "").ToLower();

            string tx1234 = tx12hexHash2 + tx34hexHash2;

            byte[] tx1234hash1stringbytes = Encoding.ASCII.GetBytes(tx1234);
            byte[] tx1234hashBytes = SHA256.Create().ComputeHash(tx1234hash1stringbytes);
            string tx1234hexHash1 = BitConverter.ToString(tx1234hashBytes).Replace("-", "").ToLower();

            byte[] tx1234hash2stringbytes = Encoding.ASCII.GetBytes(tx1234hexHash1);
            byte[] tx1234hashBytes2 = SHA256.Create().ComputeHash(tx1234hash2stringbytes);
            string tx1234hexHash2 = BitConverter.ToString(tx1234hashBytes2).Replace("-", "").ToLower();




            Console.WriteLine(tx1234hexHash2);
        }
    }

 

            
            
}
