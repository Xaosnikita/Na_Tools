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


namespace Test_NavalAction_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
            string text = new StreamReader(((HttpWebResponse)((HttpWebRequest)WebRequest.Create("http://storage.googleapis.com/nacleanopenworldprodshards/ItemTemplates_cleanopenworldprodeu1.json")).GetResponse()).GetResponseStream(), Encoding.UTF8).ReadToEnd();
            text = text.Remove(text.Length - 1);
            text = text.Remove(0, 20);
            File.WriteAllText("Item_Templates.json", text);
            this.ItemTemplates = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(text);
            this.Storage = this.func_Storage_population();
            foreach (Dictionary<string, object> current in this.ItemTemplates)
            {
                if (!this.List_Info_Types.Contains(current["ItemType"].ToString()))
                {
                    this.List_Info_Types.Add(current["ItemType"].ToString());
                }
                this.SDictionary_Info_IDtoName.Add(Convert.ToInt32(current["Id"].ToString()), current["Name"].ToString());
            }
            foreach (KeyValuePair<int, string> current2 in this.SDictionary_Info_IDtoName)
            {
                this.List_Info_IDtoName.Add(current2.Key.ToString() + "        " + current2.Value);
            }
            this.List_Info_Types.Sort();
            this.comboBox_Info_Type.DataSource = this.List_Info_Types;
            this.listBox_Info_IDtoName.DataSource = this.List_Info_IDtoName;
            this.comboBox_Info_Type.SelectedIndexChanged += new EventHandler(this.comboBox_Type_SelectedIndexChanged);
            this.listBox_Info_Name.SelectedIndexChanged += new EventHandler(this.listBox_Name_SelectedIndexChanged);
            this.func_Tab_Storage_filling();
            this.textBox_Storage_LH_Labour_Hours_Quantity.TextChanged += new EventHandler(this.textBox_Storage_LH_Labour_Hours_Quantity_TextChanged);
            this.textBox_Storage_LH_LabourHours_Price.TextChanged += new EventHandler(this.textBox_Storage_LH_LabourHours_Price_TextChanged);
            this.textBox_Storage_LH_Labour_Contracts_Quantity.TextChanged += new EventHandler(this.textBox_Storage_LH_Labour_Contracts_Quantity_TextChanged);
            this.textBox_Storage_LH_LabourContracts_Price.TextChanged += new EventHandler(this.textBox_Storage_LH_LabourContracts_Price_TextChanged);
            foreach (Dictionary<string, object> current3 in this.ItemTemplates)
            {
                if (current3["ItemType"].ToString() == "RecipeShip")
                {
                    RecipeShip value = JsonConvert.DeserializeObject<RecipeShip>(JsonConvert.SerializeObject(current3, Formatting.Indented));
                    this.SDictionary_Craft_ShipRecipes.Add(current3["Name"].ToString().Remove(current3["Name"].ToString().IndexOf(" Blueprint")), value);
                }
                if (current3["ItemType"].ToString() == "RecipeModule")
                {
                    RecipeModule value2 = JsonConvert.DeserializeObject<RecipeModule>(JsonConvert.SerializeObject(current3, Formatting.Indented));
                    this.SDictionary_Craft_ModuleRecipes.Add(current3["Name"].ToString().Remove(current3["Name"].ToString().IndexOf(" Blueprint")), value2);
                }
                if (current3["ItemType"].ToString() == "Recipe")
                {
                    Recipe value3 = JsonConvert.DeserializeObject<Recipe>(JsonConvert.SerializeObject(current3, Formatting.Indented));
                    this.SDictionary_Craft_Recipes.Add(current3["Name"].ToString().Remove(current3["Name"].ToString().IndexOf(" Blueprint")), value3);
                }
                if (current3["ItemType"].ToString() == "Ship")
                {
                    Ship value4 = JsonConvert.DeserializeObject<Ship>(JsonConvert.SerializeObject(current3, Formatting.Indented));
                    this.SD_ShipsTempates.Add(current3["Name"].ToString(), value4);
                }
            }
            this.Dict_Craft_Trim_Extra.Add("Random", new List<string>());
            this.Dict_Craft_Trim_Extra.Add("Build Strength", new List<string>
            {
                "Oak Log",
                "Compass Wood"
            });
            this.Dict_Craft_Trim_Extra.Add("Crew Space", new List<string>
            {
                "Canvas Rolls",
                "Rum",
                "Food Supplies"
            });
            this.Dict_Craft_Trim_Extra.Add("Planking", new List<string>
            {
                "Teak Log",
                "Tar"
            });
            this.Dict_Craft_Trim_Extra.Add("Rigging Quality", new List<string>
            {
                "Cotton",
                "Pine Log"
            });
            this.Dict_Craft_Trim_Extra.Add("Speed", new List<string>
            {
                "Fir Log",
                "Copper Ingots"
            });
            this.Dict_Craft_Trim_Extra.Add("Stiffness", new List<string>
            {
                "Teak Log",
                "Compass Wood"
            });
            this.SpeedCurves_Graphics_Draw();
            this.SD_Craft_Recipes_custom = this.func_SD_Craft_Recipes_custom_Population();
            JsonConvert.SerializeObject(this.SD_Craft_Recipes_custom, Formatting.Indented);
            this.SD_Craft_Recipes_custom_sorted = this.func_SD_Craft_Recipes_custom_FlagSort(this.SD_Craft_Recipes_custom);
            JsonConvert.SerializeObject(this.SD_Craft_Recipes_custom_sorted, Formatting.Indented);
        }
    }
}
