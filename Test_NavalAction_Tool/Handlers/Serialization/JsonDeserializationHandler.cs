using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Test_NavalAction_Tool.Handlers.Serialization
{
    public class JsonDeserializationHandler
    {
        //Create new project with logic of internet requests
        ItemTemplates = new List<SortedDictionary<string, object>>();
        string text="";
        string text_remove = "var ItemTemplates = ";
        string file_path = "Item_Templates.json";
        text = new StreamReader(((HttpWebResponse)((HttpWebRequest)WebRequest.Create("http://storage.googleapis.com/nacleanopenworldprodshards/ItemTemplates_cleanopenworldprodeu1.json")).GetResponse()).GetResponseStream(), Encoding.UTF8).ReadToEnd();
        text = text.Remove(text.Length - 1);            
        text = text.Remove(0, text_remove.Length);
        File.WriteAllText(file_path, text);
        ItemTemplates = JsonConvert.DeserializeObject<List<SortedDictionary<string, object>>>(text); 
        return ItemTemplates;
    }
}
