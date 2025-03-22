using System;
using System.Collections;
using System.Collections.Generic;

//the hashtable is used to store key-value pairs
//key and value can be of any data type
//there must be a key but value can be null
namespace HashTableByErvisTrupja
{
    class Program
    {
    static void Main( string[] args )
      {
      Dictionary<int, string> myDictionary = new Dictionary<int, string>();
      //add hashtable
      //key and value can be of any datatype
      //key cannot be null but value can
      myDictionary.Add( 1, "One" );
      myDictionary.Add( 6, "Number 6" );

      //create hashtable object
      Hashtable myHashtable = new Hashtable( myDictionary );

      //remove one certain value from the hashtable by entering the key
      myHashtable.Remove( 1 );
      //remove one certain value from the hashtable which contains a value
      //myHashtable.ContainsKey( 6 );
      //clear whole hashtable
      myHashtable.Clear();

      //retrieve value from value
      string valueOfOne = (string) myHashtable[ 1 ];
      Console.WriteLine( $"Value Of One = {valueOfOne}" );

      foreach ( DictionaryEntry value in myHashtable )
        {
        Console.WriteLine( $"Key: {value.Key}, Value: {value.Value}" );
        }
      }
    }
}
