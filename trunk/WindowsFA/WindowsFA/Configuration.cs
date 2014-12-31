using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFA
{

    #region -- Configuration Class --
   /// <summary>
   /// This Configuration class is basically just a set of 
   /// properties with a couple of static methods to manage
   /// the serialization to and deserialization from a
   /// simple XML file.
   /// </summary>
   [Serializable]
   public class Configuration
   {
      int _StartupFormIndex;
      int _InetConnectionIndex;
      string _ProxyURL;
      int _QuoteSourceIndex;
      int _TVMOptionalInfo;

      public Configuration()
      {
          _StartupFormIndex = 0;
          _InetConnectionIndex = 0;
          _ProxyURL = "";
          _QuoteSourceIndex = 0;
          _TVMOptionalInfo = 0;
      }
      public static void Serialize(string file, Configuration c)
      {
         System.Xml.Serialization.XmlSerializer xs 
            = new System.Xml.Serialization.XmlSerializer(c.GetType());
         StreamWriter writer = File.CreateText(file);
         xs.Serialize(writer, c);
         writer.Flush();
         writer.Close();
      }
      public static Configuration Deserialize(string file)
      {
         System.Xml.Serialization.XmlSerializer xs 
            = new System.Xml.Serialization.XmlSerializer(
               typeof(Configuration));
         StreamReader reader = File.OpenText(file);
         Configuration c = (Configuration)xs.Deserialize(reader);
         reader.Close();
         return c;
      }
      public int StartupFormIndex
      {
          get { return _StartupFormIndex; }
          set { _StartupFormIndex = value; }
      }
      public int InetConnectionIndex
      {
          get { return _InetConnectionIndex; }
          set { _InetConnectionIndex = value; }
      }
      public string ProxyURL
      {
          get { return _ProxyURL; }
          set { _ProxyURL = value; }
      }
       public int QuoteSourceIndex
       {
           get { return _QuoteSourceIndex; }
           set { _QuoteSourceIndex = value; }
       }
       public int TVMOptionalInfo
       {
           get { return _TVMOptionalInfo; }
           set { _TVMOptionalInfo = value; }
       }

   }
   #endregion

}