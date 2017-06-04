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
        #region Переменные
        private int i_Craft_Add;
        private List<SortedDictionary<string, object>> ItemTemplates;
        private List<string> List_Info_Types = new List<string>();
        private List<string> List_Info_IDtoName = new List<string>();
        private Dictionary<string, SortedDictionary<string, int>> Dict_sorted_by_flag_Name_amount = new Dictionary<string, SortedDictionary<string, int>>();
        private Storage Storage = new Storage();
        private List<Storage_LabourHours> List_Storage_LabourHours = new List<Storage_LabourHours>();
        private List<Storage_Ship_Recipes> List_Storage_Ship_Recipes = new List<Storage_Ship_Recipes>();
        private SortedDictionary<int, string> SDictionary_Info_IDtoName = new SortedDictionary<int, string>();
        private SortedDictionary<string, Storage_Resources> SDictionary_Storage_Resource = new SortedDictionary<string, Storage_Resources>();
        private SortedDictionary<string, Storage_Materials> SDictionary_Storage_Materials = new SortedDictionary<string, Storage_Materials>();
        private SortedDictionary<string, Storage_LabourHours> SDictionary_Storage_LabourHours = new SortedDictionary<string, Storage_LabourHours>();
        private SortedDictionary<string, bool> SDictionary_Storage_ShipRecipes = new SortedDictionary<string, bool>();
        private SortedDictionary<string, RecipeShip> SDictionary_Craft_ShipRecipes = new SortedDictionary<string, RecipeShip>();
        private SortedDictionary<string, RecipeModule> SDictionary_Craft_ModuleRecipes = new SortedDictionary<string, RecipeModule>();
        private SortedDictionary<string, Recipe> SDictionary_Craft_Recipes = new SortedDictionary<string, Recipe>();
        private SortedDictionary<int, Craft_Order> SDictionary_Craft_Order = new SortedDictionary<int, Craft_Order>();
        private SortedDictionary<string, int> SD_Craft_Name_Amount = new SortedDictionary<string, int>();
        private SortedDictionary<string, Ship> SD_ShipsTempates = new SortedDictionary<string, Ship>();
        private SortedDictionary<string, Craft_Recipe> SD_Craft_Recipes_custom = new SortedDictionary<string, Craft_Recipe>();
        private SortedDictionary<string, Craft_Recipe> SD_Craft_Recipes_custom_sorted = new SortedDictionary<string, Craft_Recipe>();
        private Dictionary<string, List<string>> Dict_Craft_Trim_Extra = new Dictionary<string, List<string>>();
        #endregion

        public Form1()
        {

            InitializeComponent();

            string text = new StreamReader(((HttpWebResponse)((HttpWebRequest)WebRequest.Create("http://storage.googleapis.com/nacleanopenworldprodshards/ItemTemplates_cleanopenworldprodus1.json")).GetResponse()).GetResponseStream(), Encoding.UTF8).ReadToEnd();

            text = text.Remove(text.Length - 1);
            text = text.Remove(0, 20);
            string file_path = "/Item_Templates.json";

            File.WriteAllText(file_path, text);

            ItemTemplates = JsonConvert.DeserializeObject<List<SortedDictionary<string, object>>>(text);


            Storage = func_Storage_population();

            foreach (SortedDictionary<string, object> current in ItemTemplates)
            {
                if (!List_Info_Types.Contains(current["ItemType"].ToString()))
                {
                    List_Info_Types.Add(current["ItemType"].ToString());
                }
                SDictionary_Info_IDtoName.Add(Convert.ToInt32(current["Id"].ToString()), current["Name"].ToString());
            }
            foreach (KeyValuePair<int, string> current2 in SDictionary_Info_IDtoName)
            {
                List_Info_IDtoName.Add(current2.Key.ToString() + "        " + current2.Value);
            }
            List_Info_Types.Sort();
            comboBox_Info_Type.DataSource = List_Info_Types;
            listBox_Info_IDtoName.DataSource = List_Info_IDtoName;
            comboBox_Info_Type.SelectedIndexChanged += new EventHandler(comboBox_Type_SelectedIndexChanged);
            listBox_Info_Name.SelectedIndexChanged += new EventHandler(listBox_Name_SelectedIndexChanged);
            func_Tab_Storage_filling();
            textBox_Storage_LH_Labour_Hours_Quantity.TextChanged += new EventHandler(textBox_Storage_LH_Labour_Hours_Quantity_TextChanged);
            textBox_Storage_LH_LabourHours_Price.TextChanged += new EventHandler(textBox_Storage_LH_LabourHours_Price_TextChanged);
            textBox_Storage_LH_Labour_Contracts_Quantity.TextChanged += new EventHandler(textBox_Storage_LH_Labour_Contracts_Quantity_TextChanged);
            textBox_Storage_LH_LabourContracts_Price.TextChanged += new EventHandler(textBox_Storage_LH_LabourContracts_Price_TextChanged);


            #region вкладка Крафта

            foreach (SortedDictionary<string, object> current3 in ItemTemplates)
            {
                /*
                 *                 if (current3["ItemType"].ToString() == "RecipeShip")
                {
                    RecipeShip value = JsonConvert.DeserializeObject<RecipeShip>(JsonConvert.SerializeObject(current3, Formatting.Indented));
                    SDictionary_Craft_ShipRecipes.Add(current3["Name"].ToString().Remove(current3["Name"].ToString().IndexOf(" Blueprint")), value);
                }
                if (current3["ItemType"].ToString() == "RecipeModule")
                {
                    RecipeModule value2 = JsonConvert.DeserializeObject<RecipeModule>(JsonConvert.SerializeObject(current3, Formatting.Indented));
                    SDictionary_Craft_ModuleRecipes.Add(current3["Name"].ToString().Remove(current3["Name"].ToString().IndexOf(" Blueprint")), value2);
                }
                if (current3["ItemType"].ToString() == "Recipe")
                {
                    Recipe value3 = JsonConvert.DeserializeObject<Recipe>(JsonConvert.SerializeObject(current3, Formatting.Indented));
                    SDictionary_Craft_Recipes.Add(current3["Name"].ToString().Remove(current3["Name"].ToString().IndexOf(" Blueprint")), value3);
                }
                 */

                if (current3["ItemType"].ToString() == "Ship")
                {
                    Ship value4 = JsonConvert.DeserializeObject<Ship>(JsonConvert.SerializeObject(current3, Formatting.Indented));
                    SD_ShipsTempates.Add(current3["Name"].ToString(), value4);
                }
            }
            Dict_Craft_Trim_Extra.Add("Random", new List<string>());
            Dict_Craft_Trim_Extra.Add("Build Strength", new List<string>
            {
                "Oak Log",
                "Compass Wood"
            });
            Dict_Craft_Trim_Extra.Add("Crew Space", new List<string>
            {
                "Canvas Rolls",
                "Rum",
                "Food Supplies"
            });
            Dict_Craft_Trim_Extra.Add("Planking", new List<string>
            {
                "Teak Log",
                "Tar"
            });
            Dict_Craft_Trim_Extra.Add("Rigging Quality", new List<string>
            {
                "Cotton",
                "Pine Log"
            });
            Dict_Craft_Trim_Extra.Add("Speed", new List<string>
            {
                "Fir Log",
                "Copper Ingots"
            });
            Dict_Craft_Trim_Extra.Add("Stiffness", new List<string>
            {
                "Teak Log",
                "Compass Wood"
            });

            /*
             * SD_Craft_Recipes_custom = func_SD_Craft_Recipes_custom_Population();
            JsonConvert.SerializeObject(SD_Craft_Recipes_custom, Formatting.Indented);
            SD_Craft_Recipes_custom_sorted = func_SD_Craft_Recipes_custom_FlagSort(SD_Craft_Recipes_custom);
            JsonConvert.SerializeObject(SD_Craft_Recipes_custom_sorted, Formatting.Indented);
             */


            #endregion

            SpeedCurves_Graphics_Draw();



        }

        private void textBox__Storage_Resource_Quantity_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Storage_Resources[] storage_Resources = Storage.Storage_Resources;
            for (int i = 0; i < storage_Resources.Length; i++)
            {
                Storage_Resources storage_Resources2 = storage_Resources[i];
                if (storage_Resources2.Name == textBox.Name.Substring("textBox_Storage_Resource_Quantity_".Length))
                {
                    storage_Resources2.Quantity = Convert.ToInt32(textBox.Text);
                }
            }
        }

        private void textBox__Storage_Resource_Price_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Storage_Resources[] storage_Resources = Storage.Storage_Resources;
            for (int i = 0; i < storage_Resources.Length; i++)
            {
                Storage_Resources storage_Resources2 = storage_Resources[i];
                if (storage_Resources2.Name == textBox.Name.Substring("textBox_Storage_Resource_Price_".Length))
                {
                    storage_Resources2.Price = Convert.ToInt32(textBox.Text);
                }
            }
        }

        private void textBox__Storage_Materials_Quantity_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Storage_Materials[] storage_Materials = Storage.Storage_Materials;
            for (int i = 0; i < storage_Materials.Length; i++)
            {
                Storage_Materials storage_Materials2 = storage_Materials[i];
                if (storage_Materials2.Name == textBox.Name.Substring("textBox_Storage_Materials_Quantity_".Length))
                {
                    storage_Materials2.Quantity = Convert.ToInt32(textBox.Text);
                }
            }
        }

        private void textBox_Storage_LH_Labour_Hours_Quantity_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Storage.Storage_LabourHours[0].Quantity = Convert.ToInt32(textBox.Text);
        }

        private void textBox_Storage_LH_LabourHours_Price_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Storage.Storage_LabourHours[0].Price = Convert.ToInt32(textBox.Text);
            Storage.Storage_LabourHours[1].Price = Convert.ToInt32(textBox.Text) * 500;
            textBox_Storage_LH_LabourContracts_Price.Text = Storage.Storage_LabourHours[1].Price.ToString();
        }

        private void textBox_Storage_LH_Labour_Contracts_Quantity_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Storage.Storage_LabourHours[1].Quantity = Convert.ToInt32(textBox.Text);
        }

        private void textBox_Storage_LH_LabourContracts_Price_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Storage.Storage_LabourHours[1].Price = Convert.ToInt32(textBox.Text);
            Storage.Storage_LabourHours[0].Price = Convert.ToInt32(textBox.Text) / 500;
            textBox_Storage_LH_LabourHours_Price.Text = Storage.Storage_LabourHours[0].Price.ToString();
        }

        private Storage func_Storage_population()
        {
            Storage storage = new Storage();
            int num = 0;
            int num2 = 0;
            foreach (SortedDictionary<string, object> current in ItemTemplates)
            {
                if (current["ItemType"].ToString() == "Resource")
                {
                    Storage_Resources storage_Resources = new Storage_Resources();
                    storage_Resources.Name = current["Name"].ToString();
                    storage_Resources.Quantity = 0;
                    storage_Resources.Price = Convert.ToInt32(current["BasePrice"].ToString());
                    storage_Resources.BasePrice = Convert.ToInt32(current["BasePrice"].ToString());
                    storage_Resources.AutoFillPrice = Convert.ToInt32(current["AutoFillCoefficient"].ToString());
                    storage_Resources.ItemWeight = Convert.ToDouble(current["ItemWeight"].ToString());
                    storage_Resources.Id = Convert.ToInt32(current["Id"].ToString());
                    storage_Resources.ProducedByNation = Convert.ToInt32(current["ProducedByNation"].ToString());
                    SDictionary_Storage_Resource.Add(storage_Resources.Name, storage_Resources);
                    num++;
                }
                if (current["ItemType"].ToString() == "Material")
                {
                    Storage_Materials storage_Materials = new Storage_Materials();
                    storage_Materials.Name = current["Name"].ToString();
                    storage_Materials.Quantity = 0;
                    storage_Materials.Price = Convert.ToInt32(current["BasePrice"].ToString());
                    storage_Materials.BasePrice = Convert.ToInt32(current["BasePrice"].ToString());
                    storage_Materials.ItemWeight = Convert.ToDouble(current["ItemWeight"].ToString());
                    storage_Materials.Id = Convert.ToInt32(current["Id"].ToString());
                    SDictionary_Storage_Materials.Add(storage_Materials.Name, storage_Materials);
                    num2++;
                }
                if (current["ItemType"].ToString() == "RecipeShip")
                {
                    SDictionary_Storage_ShipRecipes.Add(current["Name"].ToString(), false);
                }
            }
            Storage_LabourHours storage_LabourHours = new Storage_LabourHours();
            Storage_LabourHours storage_LabourHours2 = new Storage_LabourHours();
            storage_LabourHours.Name = label_Storage_LH_Labour_Hours.Text;
            storage_LabourHours.Quantity = Convert.ToInt32(textBox_Storage_LH_Labour_Hours_Quantity.Text);
            SDictionary_Storage_LabourHours.Add("Labour Hours", storage_LabourHours);
            List_Storage_LabourHours.Add(storage_LabourHours);
            foreach (SortedDictionary<string, object> current2 in ItemTemplates)
            {
                if (current2["ItemType"].ToString() == "ExtraLaborHoursUsableItem")
                {
                    storage_LabourHours2.Name = current2["Name"].ToString();
                    storage_LabourHours2.Quantity = Convert.ToInt32(textBox_Storage_LH_Labour_Hours_Quantity.Text);
                    storage_LabourHours2.Price = Convert.ToInt32(current2["BasePrice"]);
                    storage_LabourHours.Price = storage_LabourHours2.Price / 500;
                    SDictionary_Storage_LabourHours.Add("Labour Contracts", storage_LabourHours2);
                    List_Storage_LabourHours.Add(storage_LabourHours2);
                }
            }
            foreach (string current3 in SDictionary_Storage_ShipRecipes.Keys)
            {
                Storage_Ship_Recipes storage_Ship_Recipes = new Storage_Ship_Recipes();
                bool @checked = false;
                @checked = SDictionary_Storage_ShipRecipes.TryGetValue(current3, out @checked);
                storage_Ship_Recipes.Checked = @checked;
                storage_Ship_Recipes.Name = current3;
                List_Storage_Ship_Recipes.Add(storage_Ship_Recipes);
            }
            SDictionary_Storage_Resource.Values.ToArray<Storage_Resources>();
            storage.Storage_Resources = SDictionary_Storage_Resource.Values.ToArray<Storage_Resources>();
            storage.Storage_Materials = SDictionary_Storage_Materials.Values.ToArray<Storage_Materials>();
            storage.Storage_LabourHours = List_Storage_LabourHours.ToArray();
            storage.Storage_Ship_Recipes = List_Storage_Ship_Recipes.ToArray();
            Storage = storage;
            return Storage;
        }

        private void func_Tab_Storage_filling()
        {
            groupBox_Storage_Resources.Controls.Clear();
            func_func_Storage_Tab_Resource_top_Controls_Drawings();
            int num = 1;
            Storage_Resources[] storage_Resources = Storage.Storage_Resources;
            for (int i = 0; i < storage_Resources.Length; i++)
            {
                Storage_Resources storage_Resources2 = storage_Resources[i];
                if (radioButton_Storage_All.Checked)
                {
                    func_Storage_Tab_Resource_Controls_Drawings(num, storage_Resources2);
                    num++;
                }
                if (radioButton_Storage_Craft.Checked && storage_Resources2.ProducedByNation == -1)
                {
                    func_Storage_Tab_Resource_Controls_Drawings(num, storage_Resources2);
                    num++;
                }
                if (radioButton_Storage_Trade.Checked && storage_Resources2.ProducedByNation != -1)
                {
                    func_Storage_Tab_Resource_Controls_Drawings(num, storage_Resources2);
                    num++;
                }
            }
            int num2 = 1;
            Storage_Materials[] storage_Materials = Storage.Storage_Materials;
            for (int i = 0; i < storage_Materials.Length; i++)
            {
                Storage_Materials storage_Materials2 = storage_Materials[i];
                Label label = new Label();
                label.Name = "label_Storage_Materials_" + storage_Materials2.Name;
                label.AutoSize = true;
                label.Location = new Point(label_Storage_Materials_Name.Location.X, label_Storage_Materials_Name.Location.Y + num2 * label.Height);
                label.Size = new Size(38, 13);
                label.TabIndex = 0;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Text = storage_Materials2.Name;
                groupBox_Storage_Materials.Controls.Add(label);
                TextBox textBox = new TextBox();
                textBox.Name = "textBox_Storage_Materials_Quantity_" + storage_Materials2.Name;
                textBox.Location = new Point(label_Storage_Materials_Quantity.Location.X, label.Location.Y - 3);
                textBox.Size = new Size(40, 20);
                textBox.TabIndex = 0;
                textBox.TextAlign = HorizontalAlignment.Center;
                textBox.Text = storage_Materials2.Quantity.ToString();
                textBox.TextChanged += new EventHandler(textBox__Storage_Materials_Quantity_TextChanged);
                groupBox_Storage_Materials.Controls.Add(textBox);
                Label label2 = new Label();
                label2.AutoSize = false;
                label2.Name = "label_Storage_Materials_Price_" + storage_Materials2.Name;
                label2.Location = new Point(label_Storage_Materials_Price.Location.X, label.Location.Y);
                label2.Size = new Size(label_Storage_Materials_Price.Size.Width, 13);
                label2.TabIndex = 0;
                label2.TextAlign = ContentAlignment.MiddleCenter;
                label2.Text = storage_Materials2.BasePrice.ToString();
                groupBox_Storage_Materials.Controls.Add(label2);
                Label label3 = new Label();
                label3.AutoSize = false;
                label3.Name = "label_Storage_Materials_BP_" + storage_Materials2.Name;
                label3.Location = new Point(label_Storage_Materials_BasePrice.Location.X, label.Location.Y);
                label3.Size = new Size(label_Storage_Materials_BasePrice.Size.Width, 13);
                label3.TabIndex = 0;
                label3.TextAlign = ContentAlignment.MiddleCenter;
                label3.Text = storage_Materials2.BasePrice.ToString();
                groupBox_Storage_Materials.Controls.Add(label3);
                Label label4 = new Label();
                label4.Name = "label_Storage_Materials_Weight_" + storage_Materials2.Name;
                label4.AutoSize = false;
                label4.Location = new Point(label_Storage_Materials_ItemWeight.Location.X, label.Location.Y);
                label4.Size = new Size(label_Storage_Materials_ItemWeight.Size.Width, 13);
                label4.TabIndex = 0;
                label4.TextAlign = ContentAlignment.MiddleCenter;
                label4.Text = storage_Materials2.ItemWeight.ToString();
                groupBox_Storage_Materials.Controls.Add(label4);
                groupBox_Storage_Materials.Size = new Size(groupBox_Storage_Materials.Size.Width, label.Location.Y + label.Height + 10);
                num2++;
            }
            textBox_Storage_LH_Labour_Hours_Quantity.Text = Storage.Storage_LabourHours[0].Quantity.ToString();
            textBox_Storage_LH_LabourHours_Price.Text = Storage.Storage_LabourHours[0].Price.ToString();
            textBox_Storage_LH_Labour_Contracts_Quantity.Text = Storage.Storage_LabourHours[1].Quantity.ToString();
            textBox_Storage_LH_LabourContracts_Price.Text = Storage.Storage_LabourHours[1].Price.ToString();
            checkedListBox_Storage_ShipRecipes.Items.Clear();
            Storage_Ship_Recipes[] storage_Ship_Recipes = Storage.Storage_Ship_Recipes;
            for (int i = 0; i < storage_Ship_Recipes.Length; i++)
            {
                Storage_Ship_Recipes storage_Ship_Recipes2 = storage_Ship_Recipes[i];
                int num3 = 0;
                bool value = false;
                value = SDictionary_Storage_ShipRecipes.TryGetValue(storage_Ship_Recipes2.Name, out value);
                checkedListBox_Storage_ShipRecipes.Items.Add(storage_Ship_Recipes2.Name);
                checkedListBox_Storage_ShipRecipes.SetItemChecked(num3, value);
                num3++;
            }
        }

        private void func_func_Storage_Tab_Resource_top_Controls_Drawings()
        {
            Label label = new Label();
            label.Location = new Point(329, 20);
            label.Name = "label_Storage_Resources_AutoBuy";
            label.Size = new Size(74, 13);
            label.TabIndex = 5;
            label.Text = "Auto Fill Price:";
            label.TextAlign = ContentAlignment.MiddleCenter;
            Label label2 = new Label();
            label2.Location = new Point(279, 20);
            label2.Name = "label_Storage_Resources_ItemWeight";
            label2.Size = new Size(44, 13);
            label2.TabIndex = 4;
            label2.Text = "Weight:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            Label label3 = new Label();
            label3.Location = new Point(212, 20);
            label3.Name = "label_Storage_Resources_BasePrice";
            label3.Size = new Size(61, 13);
            label3.TabIndex = 3;
            label3.Text = "Base Price:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            Label label4 = new Label();
            label4.AutoSize = true;
            label4.Location = new Point(172, 20);
            label4.Name = "label_Storage_Resources_Price";
            label4.Size = new Size(34, 13);
            label4.TabIndex = 2;
            label4.Text = "Price:";
            Label label5 = new Label();
            label5.AutoSize = true;
            label5.Location = new Point(117, 20);
            label5.Name = "label_Storage_Resources_Quantity";
            label5.Size = new Size(49, 13);
            label5.TabIndex = 1;
            label5.Text = "Quantity:";
            Label label6 = new Label();
            label6.Location = new Point(6, 20);
            label6.Name = "label_Storage_Resources_Name";
            label6.Size = new Size(105, 13);
            label6.TabIndex = 0;
            label6.Text = "Name:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            groupBox_Storage_Resources.Controls.Add(label);
            groupBox_Storage_Resources.Controls.Add(label2);
            groupBox_Storage_Resources.Controls.Add(label3);
            groupBox_Storage_Resources.Controls.Add(label4);
            groupBox_Storage_Resources.Controls.Add(label5);
            groupBox_Storage_Resources.Controls.Add(label6);
        }

        private void func_Storage_Tab_Resource_Controls_Drawings(int i_Storage_resource, Storage_Resources Item)
        {
            Label label = new Label();
            label.Name = "label_Storage_Resource_" + Item.Name;
            label.AutoSize = true;
            label.Location = new Point(groupBox_Storage_Resources.Location.X, label_Storage_Resources_Name.Location.Y + i_Storage_resource * label.Height);
            label.Size = new Size(38, 13);
            label.TabIndex = 0;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = Item.Name;
            groupBox_Storage_Resources.Controls.Add(label);
            TextBox textBox = new TextBox();
            textBox.Name = "textBox_Storage_Resource_Quantity_" + Item.Name;
            textBox.Location = new Point(label_Storage_Resources_Quantity.Location.X, label.Location.Y - 3);
            textBox.Size = new Size(40, 20);
            textBox.TabIndex = 0;
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.Text = Item.Quantity.ToString();
            textBox.TextChanged += new EventHandler(textBox__Storage_Resource_Quantity_TextChanged);
            groupBox_Storage_Resources.Controls.Add(textBox);
            TextBox textBox2 = new TextBox();
            textBox2.Name = "textBox_Storage_Resource_Price_" + Item.Name;
            textBox2.Location = new Point(label_Storage_Resources_Price.Location.X, label.Location.Y - 3);
            textBox2.Size = new Size(40, 20);
            textBox2.TabIndex = 0;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.Text = Item.Price.ToString();
            textBox2.TextChanged += new EventHandler(textBox__Storage_Resource_Price_TextChanged);
            groupBox_Storage_Resources.Controls.Add(textBox2);
            Label label2 = new Label();
            label2.AutoSize = false;
            label2.Name = "label_Storage_Resource_BP_" + Item.Name;
            label2.Location = new Point(label_Storage_Resources_BasePrice.Location.X, label.Location.Y);
            label2.Size = new Size(label_Storage_Resources_BasePrice.Size.Width, 13);
            label2.TabIndex = 0;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Text = Item.BasePrice.ToString();
            groupBox_Storage_Resources.Controls.Add(label2);
            Label label3 = new Label();
            label3.Name = "label_Storage_Resource_Weight_" + Item.Name;
            label3.AutoSize = false;
            label3.Location = new Point(label_Storage_Resources_ItemWeight.Location.X, label.Location.Y);
            label3.Size = new Size(label_Storage_Resources_ItemWeight.Size.Width, 13);
            label3.TabIndex = 0;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Text = Item.ItemWeight.ToString();
            groupBox_Storage_Resources.Controls.Add(label3);
            Label label4 = new Label();
            label4.Name = "label_Storage_Resource_AutoFillPrice_" + Item.Name;
            label4.AutoSize = false;
            label4.Location = new Point(label_Storage_Resources_AutoBuy.Location.X, label.Location.Y);
            label4.Size = new Size(label_Storage_Resources_AutoBuy.Size.Width, 13);
            label4.TabIndex = 0;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            string text;
            if (Item.AutoFillPrice > 999)
            {
                text = "N/A";
            }
            else
            {
                text = (Item.AutoFillPrice * Item.BasePrice).ToString();
            }
            label4.Text = text;
            groupBox_Storage_Resources.Controls.Add(label4);
            groupBox_Storage_Resources.Size = new Size(groupBox_Storage_Resources.Size.Width, label.Location.Y + label.Height + 10);
        }

        private void comboBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Info_Name.Enabled = true;
            comboBox_Info_Type.SelectedItem.ToString();
            listBox_Info_Name.Items.Clear();
            foreach (SortedDictionary<string, object> current in ItemTemplates)
            {
                if (current["ItemType"].ToString() == comboBox_Info_Type.SelectedItem.ToString() && !listBox_Info_Name.Items.Contains(current["Name"].ToString()))
                {
                    listBox_Info_Name.Items.Add(current["Name"].ToString());
                }
            }
        }

        private void listBox_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Info_Object.ResetText();
            foreach (SortedDictionary<string, object> obj in ItemTemplates)
            {
                if (obj["ItemType"].ToString() == comboBox_Info_Type.SelectedItem.ToString() && obj["Name"].ToString() == listBox_Info_Name.SelectedItem.ToString())
                {
                    foreach (string key in obj.Keys)
                    {
                        string text = obj[key].ToString();
                        if (text.Contains("\"Template\": "))
                        {
                            do
                            {
                                string arg_B9_0 = text;
                                string text2 = "\"Template\": ";
                                int num = arg_B9_0.IndexOf(text2);
                                string text3 = arg_B9_0.Substring(num + text2.Count<char>(), 3);
                                num.ToString();
                                if (text3.Contains(","))
                                {
                                    text3 = text3.Remove(text3.IndexOf(","));
                                }
                                int iD = (int)Convert.ToInt16(text3);
                                string value = func_Get_Name_from_ID(iD) + ":";
                                text = arg_B9_0.Insert(num + text2.Count<char>() - 1, value);
                            }
                            while (text.Contains("\"Template\": "));
                        }
                        textBox_Info_Object.Text = string.Concat(new string[]
                        {
                            textBox_Info_Object.Text,
                            key,
                            " : ",
                            text,
                            "\r\n"
                        });
                    }
                }
            }
        }

        private void button_Storage_Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog_Storage.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            StreamReader expr_1F = File.OpenText(openFileDialog_Storage.FileName);
            Storage storage = JsonConvert.DeserializeObject<Storage>(expr_1F.ReadToEnd());
            expr_1F.Close();
            Storage = storage;
            Storage_Resources[] storage_Resources = Storage.Storage_Resources;
            for (int i = 0; i < storage_Resources.Length; i++)
            {
                Storage_Resources storage_Resources2 = storage_Resources[i];
                string key = "textBox_Storage_Resource_Quantity_" + storage_Resources2.Name;
                Control[] array = groupBox_Storage_Resources.Controls.Find(key, true);
                for (int j = 0; j < array.Length; j++)
                {
                    array[j].Text = storage_Resources2.Quantity.ToString();
                }
                string key2 = "textBox_Storage_Resource_Price_" + storage_Resources2.Name;
                array = groupBox_Storage_Resources.Controls.Find(key2, true);
                for (int j = 0; j < array.Length; j++)
                {
                    array[j].Text = storage_Resources2.Price.ToString();
                }
            }
            Storage_Materials[] storage_Materials = Storage.Storage_Materials;
            for (int i = 0; i < storage_Materials.Length; i++)
            {
                Storage_Materials storage_Materials2 = storage_Materials[i];
                string key3 = "textBox_Storage_Materials_Quantity_" + storage_Materials2.Name;
                Control[] array = groupBox_Storage_Materials.Controls.Find(key3, true);
                for (int j = 0; j < array.Length; j++)
                {
                    array[j].Text = storage_Materials2.Quantity.ToString();
                }
            }
            textBox_Storage_LH_Labour_Hours_Quantity.Text = Storage.Storage_LabourHours[0].Quantity.ToString();
            textBox_Storage_LH_LabourHours_Price.Text = Storage.Storage_LabourHours[0].Price.ToString();
            textBox_Storage_LH_Labour_Contracts_Quantity.Text = Storage.Storage_LabourHours[1].Quantity.ToString();
            textBox_Storage_LH_LabourContracts_Price.Text = Storage.Storage_LabourHours[1].Price.ToString();
            MessageBox.Show("Файл открыт");
        }

        private void button_Storage_Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog_Storage.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string arg_28_0 = saveFileDialog_Storage.FileName;
            string contents = JsonConvert.SerializeObject(Storage, Formatting.Indented);
            File.WriteAllText(arg_28_0, contents);
            MessageBox.Show("Файл сохранен");
        }

        private void radioButton_Craft_Ship_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton == null)
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }
            if (radioButton.Checked)
            {
                comboBox_Craft_NewOrder_Name.DataSource = SDictionary_Craft_ShipRecipes.Keys.ToList<string>();
                comboBox_Craft_NewOrder_Quality.Enabled = true;
                comboBox_Craft_NewOrder_Quality.SelectedIndex = 0;
                comboBox_Craft_NewOrder_Wood.Enabled = true;
                comboBox_Craft_NewOrder_Wood.SelectedIndex = 0;
                comboBox_Craft_NewOrder_Trim.Enabled = true;
                comboBox_Craft_NewOrder_Trim.SelectedIndex = 0;
                comboBox_Craft_NewOrder_Name.Refresh();
            }
        }

        private void radioButton_Craft_Module_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton == null)
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }
            if (radioButton.Checked)
            {
                comboBox_Craft_NewOrder_Name.DataSource = SDictionary_Craft_ModuleRecipes.Keys.ToList<string>();
                comboBox_Craft_NewOrder_Quality.Enabled = true;
                comboBox_Craft_NewOrder_Wood.Enabled = false;
                comboBox_Craft_NewOrder_Wood.SelectedIndex = -1;
                comboBox_Craft_NewOrder_Trim.Enabled = false;
                comboBox_Craft_NewOrder_Trim.SelectedIndex = -1;
                comboBox_Craft_NewOrder_Quality.SelectedIndex = 0;
                comboBox_Craft_NewOrder_Name.Refresh();
            }
        }

        private void radioButton_Craft_Recipe_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton == null)
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }
            if (radioButton.Checked)
            {
                comboBox_Craft_NewOrder_Name.DataSource = SDictionary_Craft_Recipes.Keys.ToList<string>();
                comboBox_Craft_NewOrder_Quality.Enabled = false;
                comboBox_Craft_NewOrder_Quality.SelectedIndex = -1;
                comboBox_Craft_NewOrder_Wood.Enabled = false;
                comboBox_Craft_NewOrder_Wood.SelectedIndex = -1;
                comboBox_Craft_NewOrder_Trim.Enabled = false;
                comboBox_Craft_NewOrder_Trim.SelectedIndex = -1;
                comboBox_Craft_NewOrder_Name.Refresh();
            }
        }

        private void button_Craft_Add_Click(object sender, EventArgs e)
        {
            Craft_Order craft_Order = new Craft_Order();
            craft_Order.Name = comboBox_Craft_NewOrder_Name.Text;
            if (radioButton_Craft_Ship.Checked)
            {
                craft_Order.Type = 0;
            }
            if (radioButton_Craft_Module.Checked)
            {
                craft_Order.Type = 1;
            }
            if (radioButton_Craft_Recipe.Checked)
            {
                craft_Order.Type = 2;
            }
            craft_Order.Woodtype = comboBox_Craft_NewOrder_Wood.SelectedIndex;
            craft_Order.Quality = comboBox_Craft_NewOrder_Quality.SelectedIndex;
            craft_Order.Trim = comboBox_Craft_NewOrder_Trim.SelectedIndex;
            SDictionary_Craft_Order.Add(i_Craft_Add, craft_Order);
            Label label = new Label();
            label.Name = "label_Craft_Ordered_" + comboBox_Craft_NewOrder_Name.Text + i_Craft_Add.ToString();
            label.AutoSize = true;
            label.Location = new Point(5, 24 + i_Craft_Add * label.Size.Height);
            label.Size = new Size(152, 13);
            label.TabIndex = 0;
            label.Text = comboBox_Craft_NewOrder_Name.Text + comboBox_Craft_NewOrder_Wood.Text + comboBox_Craft_NewOrder_Trim.Text;
            if (comboBox_Craft_NewOrder_Quality.SelectedIndex == 0)
            {
                comboBox_Craft_NewOrder_Quality.BackColor = Color.LightGray;
                label.BackColor = Color.LightGray;
            }
            if (comboBox_Craft_NewOrder_Quality.SelectedIndex == 1)
            {
                comboBox_Craft_NewOrder_Quality.BackColor = Color.DarkSeaGreen;
                label.BackColor = Color.DarkSeaGreen;
            }
            if (comboBox_Craft_NewOrder_Quality.SelectedIndex == 2)
            {
                comboBox_Craft_NewOrder_Quality.BackColor = Color.LightBlue;
                label.BackColor = Color.LightBlue;
            }
            if (comboBox_Craft_NewOrder_Quality.SelectedIndex == 3)
            {
                comboBox_Craft_NewOrder_Quality.BackColor = Color.PaleVioletRed;
                label.BackColor = Color.PaleVioletRed;
            }
            if (comboBox_Craft_NewOrder_Quality.SelectedIndex == 4)
            {
                comboBox_Craft_NewOrder_Quality.BackColor = Color.Gold;
                label.BackColor = Color.Gold;
            }
            groupBox_Craft_Order.Controls.Add(label);
            groupBox_Craft_Order.Size = new Size(groupBox_Craft_Order.Size.Width, 5 + label.Location.Y + label.Size.Height);
            i_Craft_Add++;
            func_Craft_Text_Uneed();
            func_Craft_Text_CanBuild();
        }

        private void func_Craft_Text_Uneed()
        {
            textBox_Craft_Uneed.Clear();
            SD_Craft_Name_Amount.Clear();
            string str = "Detailed:\r\n";
            string text = "\r\n-------------------\r\n";
            string text2 = "";
            string str2 = "Labour Hours:  ";
            string str3 = "Gives Craft XP:  ";
            string str4 = "Resources:  ";
            int num = 0;
            int num2 = 0;
            foreach (int current in SDictionary_Craft_Order.Keys)
            {
                Craft_Order craft_Order = new Craft_Order();
                SDictionary_Craft_Order.TryGetValue(current, out craft_Order);
                if (craft_Order.Type == 0)
                {
                    foreach (string current2 in SDictionary_Craft_ShipRecipes.Keys)
                    {
                        if (current2 == craft_Order.Name)
                        {
                            RecipeShip recipeShip = new RecipeShip();
                            Ship ship = new Ship();
                            SDictionary_Craft_ShipRecipes.TryGetValue(current2, out recipeShip);
                            SD_ShipsTempates.TryGetValue(current2, out ship);
                            num += recipeShip.LaborPrice;
                            num2 += recipeShip.GivesXP;
                            Fullrequirement[] fullRequirements = recipeShip.FullRequirements;
                            for (int i = 0; i < fullRequirements.Length; i++)
                            {
                                Fullrequirement obj = fullRequirements[i];
                                SD_Craft_Name_Amount = func_SDict_From_FullRequirement(obj);
                            }
                            Requirement[] requirements = recipeShip.WoodTypeDescs[craft_Order.Woodtype].Requirements;
                            for (int i = 0; i < requirements.Length; i++)
                            {
                                Requirement obj2 = requirements[i];
                                SD_Craft_Name_Amount = func_SDict_From_Requirement(obj2);
                            }
                            requirements = recipeShip.Qualities[craft_Order.Quality].Requirements;
                            for (int i = 0; i < requirements.Length; i++)
                            {
                                Requirement obj3 = requirements[i];
                                SD_Craft_Name_Amount = func_SDict_From_Requirement(obj3);
                            }
                            if (craft_Order.Quality > 0)
                            {
                                List<string> list = new List<string>();
                                decimal d = craft_Order.Quality + 1;
                                int num3 = (int)(ship.ShipMass / 50 * (d / 2m));
                                int num4 = 0;
                                Dict_Craft_Trim_Extra.TryGetValue(comboBox_Craft_NewOrder_Trim.Items[craft_Order.Trim].ToString(), out list);
                                foreach (string current3 in list)
                                {
                                    num4 = 0;
                                    SD_Craft_Name_Amount.TryGetValue(current3, out num4);
                                    if (num4 > 0)
                                    {
                                        SD_Craft_Name_Amount.Remove(current3);
                                        int value = num4 + num3;
                                        SD_Craft_Name_Amount.Add(current3, value);
                                    }
                                    else
                                    {
                                        SD_Craft_Name_Amount.Add(current3, num3);
                                    }
                                }
                            }
                        }
                    }
                }
                if (craft_Order.Type == 1)
                {
                    foreach (string current4 in SDictionary_Craft_ModuleRecipes.Keys)
                    {
                        if (current4 == craft_Order.Name)
                        {
                            RecipeModule recipeModule = new RecipeModule();
                            SDictionary_Craft_ModuleRecipes.TryGetValue(current4, out recipeModule);
                            num += recipeModule.LaborPrice;
                            num2 += recipeModule.GivesXP;
                            Fullrequirement[] fullRequirements = recipeModule.FullRequirements;
                            for (int i = 0; i < fullRequirements.Length; i++)
                            {
                                Fullrequirement obj4 = fullRequirements[i];
                                SD_Craft_Name_Amount = func_SDict_From_FullRequirement(obj4);
                            }
                            Requirement[] requirements = recipeModule.Qualities[craft_Order.Quality].Requirements;
                            for (int i = 0; i < requirements.Length; i++)
                            {
                                Requirement obj5 = requirements[i];
                                SD_Craft_Name_Amount = func_SDict_From_Requirement(obj5);
                            }
                        }
                    }
                }
                if (craft_Order.Type == 2)
                {
                    foreach (string current5 in SDictionary_Craft_Recipes.Keys)
                    {
                        if (current5 == craft_Order.Name)
                        {
                            Recipe recipe = new Recipe();
                            SDictionary_Craft_Recipes.TryGetValue(current5, out recipe);
                            num += recipe.LaborPrice;
                            num2 += recipe.GivesXP;
                            Fullrequirement[] fullRequirements = recipe.FullRequirements;
                            for (int i = 0; i < fullRequirements.Length; i++)
                            {
                                Fullrequirement obj6 = fullRequirements[i];
                                SD_Craft_Name_Amount = func_SDict_From_FullRequirement(obj6);
                            }
                        }
                    }
                }
            }
            if (checkBox_Craft_StoredMats.Checked)
            {
                for (int j = SD_Craft_Name_Amount.Count; j > 0; j--)
                {
                    int num5 = 0;
                    int num6 = 0;
                    string text3 = SD_Craft_Name_Amount.Keys.ToList<string>()[j - 1];
                    SD_Craft_Name_Amount.TryGetValue(text3, out num6);
                    Storage_Materials[] storage_Materials = Storage.Storage_Materials;
                    for (int i = 0; i < storage_Materials.Length; i++)
                    {
                        Storage_Materials storage_Materials2 = storage_Materials[i];
                        if (storage_Materials2.Name == text3)
                        {
                            num5 = storage_Materials2.Quantity;
                            break;
                        }
                    }
                    int num7 = num6 - num5;
                    if (num7 <= 0)
                    {
                        SD_Craft_Name_Amount.Remove(text3);
                    }
                    else
                    {
                        SD_Craft_Name_Amount.Remove(text3);
                        SD_Craft_Name_Amount.Add(text3, num7);
                    }
                }
            }
            Dict_sorted_by_flag_Name_amount = func_SD_sorted_Name_Amount(SD_Craft_Name_Amount);
            if (checkBox_Craft_StoredRes.Checked)
            {
                for (int k = Dict_sorted_by_flag_Name_amount["SD_Res"].Count; k > 0; k--)
                {
                    int num8 = 0;
                    int num9 = 0;
                    string text4 = Dict_sorted_by_flag_Name_amount["SD_Res"].Keys.ToList<string>()[k - 1];
                    Dict_sorted_by_flag_Name_amount["SD_Res"].TryGetValue(text4, out num9);
                    Storage_Resources[] storage_Resources = Storage.Storage_Resources;
                    for (int i = 0; i < storage_Resources.Length; i++)
                    {
                        Storage_Resources storage_Resources2 = storage_Resources[i];
                        if (storage_Resources2.Name == text4)
                        {
                            num8 = storage_Resources2.Quantity;
                        }
                    }
                    int num10 = num9 - num8;
                    if (num10 <= 0)
                    {
                        Dict_sorted_by_flag_Name_amount["SD_Res"].Remove(text4);
                    }
                    else
                    {
                        Dict_sorted_by_flag_Name_amount["SD_Res"].Remove(text4);
                        Dict_sorted_by_flag_Name_amount["SD_Res"].Add(text4, num10);
                    }
                }
            }
            int num11 = 0;
            foreach (KeyValuePair<string, SortedDictionary<string, int>> current6 in Dict_sorted_by_flag_Name_amount)
            {
                if (current6.Key == "SD_Res")
                {
                    foreach (KeyValuePair<string, int> current7 in current6.Value)
                    {
                        string text5 = ".......................................................................................";
                        string text6 = " X ";
                        string text7 = " = ";
                        Storage_Resources[] storage_Resources = Storage.Storage_Resources;
                        for (int i = 0; i < storage_Resources.Length; i++)
                        {
                            Storage_Resources storage_Resources3 = storage_Resources[i];
                            if (storage_Resources3.Name == current7.Key)
                            {
                                text6 = text6 + storage_Resources3.Price.ToString() + "g";
                                text7 = text7 + (current7.Value * storage_Resources3.Price).ToString() + "g";
                                num11 += current7.Value * storage_Resources3.Price;
                            }
                        }
                        string expr_7BE = current7.Key.ToString() + text5.Remove(text5.Length - current7.Key.Length);
                        string expr_7CC = expr_7BE.Remove(expr_7BE.Length - 23);
                        string expr_7F1 = expr_7CC.Insert(expr_7CC.Length - 17, current7.Value.ToString() + text6);
                        string expr_819 = expr_7F1.Remove(expr_7F1.Length - (current7.Value.ToString() + text6).Length);
                        string expr_829 = expr_819.Insert(expr_819.Length - 9, text7);
                        expr_829.Remove(expr_829.Length - text7.Length);
                        text2 = string.Concat(new string[]
                        {
                            text2,
                            current7.Key.ToString(),
                            ":  ",
                            current7.Value.ToString(),
                            "\r\n"
                        });
                    }
                    text2 += text;
                }
                else
                {
                    foreach (KeyValuePair<string, int> current8 in current6.Value)
                    {
                        text2 = string.Concat(new string[]
                        {
                            text2,
                            current8.Key.ToString(),
                            ":  ",
                            current8.Value.ToString(),
                            "\r\n"
                        });
                    }
                    text2 += text;
                }
            }
            int num12 = (Dict_sorted_by_flag_Name_amount["Labour Hours"]["Labour Hours"] + num) * Storage.Storage_LabourHours[0].Price;
            int num13 = Dict_sorted_by_flag_Name_amount["Labour Hours"]["Labour Hours"] + num - Storage.Storage_LabourHours[0].Quantity - Storage.Storage_LabourHours[1].Quantity * 500;
            if (num13 < 0)
            {
                num13 = 0;
            }
            int num14 = num13 * Storage.Storage_LabourHours[0].Price;
            string str5 = (Dict_sorted_by_flag_Name_amount["Labour Hours"]["Labour Hours"] + num).ToString();
            string str6 = num13.ToString();
            if (checkBox_Craft_StoredLH.Checked)
            {
                label_Craft_Total_LH.Text = "Total Labour hours:  " + str6;
                label_Craft_TotalCost.Text = "TotalCost:  " + (num14 + num11).ToString() + "g";
            }
            else
            {
                label_Craft_Total_LH.Text = "Total Labour hours:  " + str5;
                label_Craft_TotalCost.Text = "TotalCost:  " + (num12 + num11).ToString() + "g";
            }
            string str7 = (Dict_sorted_by_flag_Name_amount["Craft XP"]["Craft XP"] + num2).ToString();
            label_Craft_GainXP.Text = "Total Craft XP:  " + str7;
            string text8 = ((Dict_sorted_by_flag_Name_amount["Craft XP"]["Craft XP"] + num2) / (Dict_sorted_by_flag_Name_amount["Labour Hours"]["Labour Hours"] + num)).ToString();
            if (text8.Length > 5)
            {
                text8 = text8.Remove(5);
            }
            label_Craft_efficiency.Text = "Efficiency:  " + text8;
            str += text;
            str3 = str3 + num2.ToString() + text;
            str2 = str2 + num.ToString() + text;
            str4 += text;
            textBox_Craft_Uneed.Text = str + text2;
        }

        private void func_Craft_Text_CanBuild()
        {
            textBox_Craft_CanBuild.Clear();
            SD_Craft_Name_Amount.Clear();
            string text = "To craft your order you will need:\r\n";
            string text2 = "\r\n-------------------\r\n";
            string text3 = "";
            string text4 = "You will gain:\r\n";
            string text5 = "Labour Hours:";
            string text6 = "Total weight:";
            int num = 0;
            double num2 = 0.0;
            foreach (int current in SDictionary_Craft_Order.Keys)
            {
                Craft_Order craft_Order = new Craft_Order();
                SDictionary_Craft_Order.TryGetValue(current, out craft_Order);
                if (craft_Order.Type == 0)
                {
                    foreach (string current2 in SDictionary_Craft_ShipRecipes.Keys)
                    {
                        if (current2 == craft_Order.Name)
                        {
                            RecipeShip recipeShip = new RecipeShip();
                            Ship ship = new Ship();
                            SDictionary_Craft_ShipRecipes.TryGetValue(current2, out recipeShip);
                            SD_ShipsTempates.TryGetValue(current2, out ship);
                            num += recipeShip.LaborPrice;
                            text4 = string.Concat(new object[]
                            {
                                text4,
                                comboBox_Craft_NewOrder_Quality.Items[craft_Order.Quality],
                                " ",
                                comboBox_Craft_NewOrder_Wood.Items[craft_Order.Woodtype],
                                " ",
                                craft_Order.Name,
                                " ",
                                comboBox_Craft_NewOrder_Trim.Items[craft_Order.Trim],
                                "\r\n"
                            });
                            Fullrequirement[] fullRequirements = recipeShip.FullRequirements;
                            for (int i = 0; i < fullRequirements.Length; i++)
                            {
                                Fullrequirement obj = fullRequirements[i];
                                SD_Craft_Name_Amount = func_SDict_From_FullRequirement(obj);
                            }
                            Requirement[] requirements = recipeShip.WoodTypeDescs[craft_Order.Woodtype].Requirements;
                            for (int i = 0; i < requirements.Length; i++)
                            {
                                Requirement obj2 = requirements[i];
                                SD_Craft_Name_Amount = func_SDict_From_Requirement(obj2);
                            }
                            requirements = recipeShip.Qualities[craft_Order.Quality].Requirements;
                            for (int i = 0; i < requirements.Length; i++)
                            {
                                Requirement obj3 = requirements[i];
                                SD_Craft_Name_Amount = func_SDict_From_Requirement(obj3);
                            }
                            if (craft_Order.Quality > 0)
                            {
                                List<string> list = new List<string>();
                                decimal d = craft_Order.Quality + 1;
                                int num3 = (int)(ship.ShipMass / 50 * (d / 2m));
                                int num4 = 0;
                                Dict_Craft_Trim_Extra.TryGetValue(comboBox_Craft_NewOrder_Trim.Items[craft_Order.Trim].ToString(), out list);
                                foreach (string current3 in list)
                                {
                                    num4 = 0;
                                    SD_Craft_Name_Amount.TryGetValue(current3, out num4);
                                    if (num4 > 0)
                                    {
                                        SD_Craft_Name_Amount.Remove(current3);
                                        int value = num4 + num3;
                                        SD_Craft_Name_Amount.Add(current3, value);
                                    }
                                    else
                                    {
                                        SD_Craft_Name_Amount.Add(current3, num3);
                                    }
                                }
                            }
                        }
                    }
                }
                if (craft_Order.Type == 1)
                {
                    foreach (string current4 in SDictionary_Craft_ModuleRecipes.Keys)
                    {
                        if (current4 == craft_Order.Name)
                        {
                            RecipeModule recipeModule = new RecipeModule();
                            SDictionary_Craft_ModuleRecipes.TryGetValue(current4, out recipeModule);
                            num += recipeModule.LaborPrice;
                            text4 = text4 + craft_Order.Name + "\r\n";
                            Fullrequirement[] fullRequirements = recipeModule.FullRequirements;
                            for (int i = 0; i < fullRequirements.Length; i++)
                            {
                                Fullrequirement obj4 = fullRequirements[i];
                                SD_Craft_Name_Amount = func_SDict_From_FullRequirement(obj4);
                            }
                            Requirement[] requirements = recipeModule.Qualities[craft_Order.Quality].Requirements;
                            for (int i = 0; i < requirements.Length; i++)
                            {
                                Requirement obj5 = requirements[i];
                                SD_Craft_Name_Amount = func_SDict_From_Requirement(obj5);
                            }
                        }
                    }
                }
                if (craft_Order.Type == 2)
                {
                    foreach (string current5 in SDictionary_Craft_Recipes.Keys)
                    {
                        if (current5 == craft_Order.Name)
                        {
                            Recipe recipe = new Recipe();
                            SDictionary_Craft_Recipes.TryGetValue(current5, out recipe);
                            num += recipe.LaborPrice;
                            text4 = string.Concat(new string[]
                            {
                                text4,
                                craft_Order.Name,
                                "_x_",
                                recipe.Results[0].Amount.ToString(),
                                "\r\n"
                            });
                            Fullrequirement[] fullRequirements = recipe.FullRequirements;
                            for (int i = 0; i < fullRequirements.Length; i++)
                            {
                                Fullrequirement obj6 = fullRequirements[i];
                                SD_Craft_Name_Amount = func_SDict_From_FullRequirement(obj6);
                            }
                        }
                    }
                }
            }
            foreach (KeyValuePair<string, int> current6 in SD_Craft_Name_Amount)
            {
                Storage_Resources storage_Resources = new Storage_Resources();
                Storage_Materials storage_Materials = new Storage_Materials();
                if (SDictionary_Storage_Resource.Keys.Contains(current6.Key))
                {
                    SDictionary_Storage_Resource.TryGetValue(current6.Key, out storage_Resources);
                    num2 += (double)current6.Value * storage_Resources.ItemWeight;
                }
                if (SDictionary_Storage_Materials.Keys.Contains(current6.Key))
                {
                    SDictionary_Storage_Materials.TryGetValue(current6.Key, out storage_Materials);
                    num2 += (double)current6.Value * storage_Materials.ItemWeight;
                }
                text3 = string.Concat(new string[]
                {
                    text3,
                    current6.Key.ToString(),
                    ":  ",
                    current6.Value.ToString(),
                    "\r\n"
                });
            }
            text6 += num2.ToString();
            text += text2;
            text5 = text5 + num.ToString() + text2;
            textBox_Craft_CanBuild.Text = string.Concat(new string[]
            {
                text,
                text5,
                text3,
                text2,
                text6,
                text2,
                text4
            });
        }

        private void old_func_Craft_Text()
        {
            textBox_Craft_Uneed.Clear();
            foreach (int current in SDictionary_Craft_Order.Keys)
            {
                Craft_Order craft_Order = new Craft_Order();
                SDictionary_Craft_Order.TryGetValue(current, out craft_Order);
                if (craft_Order.Type == 0)
                {
                    foreach (string current2 in SDictionary_Craft_ShipRecipes.Keys)
                    {
                        if (current2 == craft_Order.Name)
                        {
                            RecipeShip recipeShip = new RecipeShip();
                            SDictionary_Craft_ShipRecipes.TryGetValue(current2, out recipeShip);
                            string text = "--------\r\n" + recipeShip.Name + "\r\n--------";
                            Fullrequirement[] fullRequirements = recipeShip.FullRequirements;
                            for (int i = 0; i < fullRequirements.Length; i++)
                            {
                                Fullrequirement fullrequirement = fullRequirements[i];
                                string text2 = func_Get_Name_from_ID(fullrequirement.Template);
                                text = string.Concat(new string[]
                                {
                                    text,
                                    "\r\n",
                                    text2,
                                    ":",
                                    fullrequirement.Amount.ToString()
                                });
                            }
                            Requirement[] requirements = recipeShip.WoodTypeDescs[craft_Order.Woodtype].Requirements;
                            for (int i = 0; i < requirements.Length; i++)
                            {
                                Requirement requirement = requirements[i];
                                string text3 = func_Get_Name_from_ID(requirement.Template);
                                text = string.Concat(new string[]
                                {
                                    text,
                                    "\r\n",
                                    text3,
                                    ":",
                                    requirement.Amount.ToString()
                                });
                            }
                            requirements = recipeShip.Qualities[craft_Order.Quality].Requirements;
                            for (int i = 0; i < requirements.Length; i++)
                            {
                                Requirement requirement2 = requirements[i];
                                string text4 = func_Get_Name_from_ID(requirement2.Template);
                                text = string.Concat(new string[]
                                {
                                    text,
                                    "\r\n",
                                    text4,
                                    ":",
                                    requirement2.Amount.ToString()
                                });
                            }
                            textBox_Craft_Uneed.Text = textBox_Craft_Uneed.Text + text + "\r\n";
                        }
                    }
                }
                if (craft_Order.Type == 1)
                {
                    foreach (string current3 in SDictionary_Craft_ModuleRecipes.Keys)
                    {
                        if (current3 == craft_Order.Name)
                        {
                            RecipeModule recipeModule = new RecipeModule();
                            SDictionary_Craft_ModuleRecipes.TryGetValue(current3, out recipeModule);
                            string text5 = "--------\r\n" + recipeModule.Name + "\r\n--------";
                            Fullrequirement[] fullRequirements = recipeModule.FullRequirements;
                            for (int i = 0; i < fullRequirements.Length; i++)
                            {
                                Fullrequirement fullrequirement2 = fullRequirements[i];
                                string text6 = func_Get_Name_from_ID(fullrequirement2.Template);
                                text5 = string.Concat(new string[]
                                {
                                    text5,
                                    "\r\n",
                                    text6,
                                    ":",
                                    fullrequirement2.Amount.ToString()
                                });
                            }
                            Requirement[] requirements = recipeModule.Qualities[craft_Order.Quality].Requirements;
                            for (int i = 0; i < requirements.Length; i++)
                            {
                                Requirement requirement3 = requirements[i];
                                string text7 = func_Get_Name_from_ID(requirement3.Template);
                                text5 = string.Concat(new string[]
                                {
                                    text5,
                                    "\r\n",
                                    text7,
                                    ":",
                                    requirement3.Amount.ToString()
                                });
                            }
                            textBox_Craft_Uneed.Text = textBox_Craft_Uneed.Text + text5 + "\r\n";
                        }
                    }
                }
                if (craft_Order.Type == 2)
                {
                    foreach (string current4 in SDictionary_Craft_Recipes.Keys)
                    {
                        if (current4 == craft_Order.Name)
                        {
                            Recipe recipe = new Recipe();
                            SDictionary_Craft_Recipes.TryGetValue(current4, out recipe);
                            string text8 = string.Concat(new string[]
                            {
                                "--------\r\n",
                                recipe.Name,
                                "_x_",
                                recipe.Results[0].Amount.ToString(),
                                "\r\n--------"
                            });
                            Fullrequirement[] fullRequirements = recipe.FullRequirements;
                            for (int i = 0; i < fullRequirements.Length; i++)
                            {
                                Fullrequirement fullrequirement3 = fullRequirements[i];
                                string text9 = func_Get_Name_from_ID(fullrequirement3.Template);
                                text8 = string.Concat(new string[]
                                {
                                    text8,
                                    "\r\n",
                                    text9,
                                    ":",
                                    fullrequirement3.Amount.ToString()
                                });
                            }
                            textBox_Craft_Uneed.Text = textBox_Craft_Uneed.Text + text8 + "\r\n";
                        }
                    }
                }
            }
        }

        private SortedDictionary<string, int> func_SDict_From_Requirement(Requirement obj)
        {
            int num = 0;
            string key = func_Get_Name_from_ID(obj.Template);
            SD_Craft_Name_Amount.TryGetValue(key, out num);
            if (num > 0)
            {
                SD_Craft_Name_Amount.Remove(key);
                int value = num + obj.Amount;
                SD_Craft_Name_Amount.Add(key, value);
            }
            else
            {
                SD_Craft_Name_Amount.Add(key, obj.Amount);
            }
            return SD_Craft_Name_Amount;
        }

        private SortedDictionary<string, int> func_SDict_From_FullRequirement(Fullrequirement obj)
        {
            int num = 0;
            string key = func_Get_Name_from_ID(obj.Template);
            SD_Craft_Name_Amount.TryGetValue(key, out num);
            if (num > 0)
            {
                SD_Craft_Name_Amount.Remove(key);
                int value = num + obj.Amount;
                SD_Craft_Name_Amount.Add(key, value);
            }
            else
            {
                SD_Craft_Name_Amount.Add(key, obj.Amount);
            }
            return SD_Craft_Name_Amount;
        }

        private SortedDictionary<string, int> func_SDict_From_CR_FullRequirement(CR_Fullrequirement obj)
        {
            int num = 0;
            string key = func_Get_Name_from_ID(obj.Template);
            SD_Craft_Name_Amount.TryGetValue(key, out num);
            if (num > 0)
            {
                SD_Craft_Name_Amount.Remove(key);
                int value = num + obj.Amount;
                SD_Craft_Name_Amount.Add(key, value);
            }
            else
            {
                SD_Craft_Name_Amount.Add(key, obj.Amount);
            }
            return SD_Craft_Name_Amount;
        }

        private Dictionary<string, SortedDictionary<string, int>> func_SD_sorted_Name_Amount(SortedDictionary<string, int> SD)
        {
            Dictionary<string, SortedDictionary<string, int>> dictionary = new Dictionary<string, SortedDictionary<string, int>>();
            new Dictionary<string, SortedDictionary<string, int>>();
            new SortedDictionary<string, int>();
            SortedDictionary<string, int> sortedDictionary = new SortedDictionary<string, int>();
            SortedDictionary<string, int> sortedDictionary2 = new SortedDictionary<string, int>();
            SortedDictionary<string, int> sortedDictionary3 = new SortedDictionary<string, int>();
            SortedDictionary<string, int> sortedDictionary4 = new SortedDictionary<string, int>();
            SortedDictionary<string, int> sortedDictionary5 = new SortedDictionary<string, int>();
            SortedDictionary<string, int> sortedDictionary6 = new SortedDictionary<string, int>();
            int num = 0;
            sortedDictionary5.Add("Labour Hours", num);
            int num2 = 0;
            sortedDictionary6.Add("Craft XP", num2);
            foreach (KeyValuePair<string, int> current in SD)
            {
                Craft_Recipe craft_Recipe = new Craft_Recipe();
                SD_Craft_Recipes_custom_sorted.TryGetValue(current.Key, out craft_Recipe);
                if (craft_Recipe != null)
                {
                    if (craft_Recipe.Flag == 0)
                    {
                        sortedDictionary2.Add(current.Key, current.Value);
                    }
                    if (craft_Recipe.Flag == 1)
                    {
                        sortedDictionary3.Add(current.Key, current.Value);
                    }
                    if (craft_Recipe.Flag == 2)
                    {
                        sortedDictionary4.Add(current.Key, current.Value);
                    }
                }
                else
                {
                    sortedDictionary.Add(current.Key, current.Value);
                }
            }
            dictionary.Add("SD_Res", sortedDictionary);
            dictionary.Add("SD_Mat_0", sortedDictionary2);
            dictionary.Add("SD_Mat_1", sortedDictionary3);
            dictionary.Add("SD_Mat_2", sortedDictionary4);
            dictionary.Add("Labour Hours", sortedDictionary5);
            dictionary.Add("Craft XP", sortedDictionary6);
            foreach (KeyValuePair<string, int> current2 in dictionary["SD_Mat_2"])
            {
                Craft_Recipe craft_Recipe2 = new Craft_Recipe();
                SD_Craft_Recipes_custom_sorted.TryGetValue(current2.Key, out craft_Recipe2);
                int num3 = (int)Math.Ceiling(Convert.ToDecimal(current2.Value / craft_Recipe2.CR_Result[0].Amount));
                int num4 = craft_Recipe2.CR_Result[0].Amount * num3;
                num = craft_Recipe2.LaborPrice * num3;
                int num5 = 0;
                dictionary["Labour Hours"].TryGetValue("Labour Hours", out num5);
                if (num5 > 0)
                {
                    dictionary["Labour Hours"].Remove("Labour Hours");
                    int value = num5 + num;
                    dictionary["Labour Hours"].Add("Labour Hours", value);
                }
                else
                {
                    dictionary["Labour Hours"].Remove("Labour Hours");
                    dictionary["Labour Hours"].Add("Labour Hours", num);
                }
                num2 = craft_Recipe2.GivesXP * num3;
                int num6 = 0;
                dictionary["Craft XP"].TryGetValue("Craft XP", out num6);
                if (num6 > 0)
                {
                    dictionary["Craft XP"].Remove("Craft XP");
                    int value2 = num6 + num2;
                    dictionary["Craft XP"].Add("Craft XP", value2);
                }
                else
                {
                    dictionary["Craft XP"].Remove("Craft XP");
                    dictionary["Craft XP"].Add("Craft XP", num2);
                }
                CR_Fullrequirement[] cR_Fullrequirement = craft_Recipe2.CR_Fullrequirement;
                for (int i = 0; i < cR_Fullrequirement.Length; i++)
                {
                    CR_Fullrequirement cR_Fullrequirement2 = cR_Fullrequirement[i];
                    string text = func_Get_Name_from_ID(cR_Fullrequirement2.Template);
                    Craft_Recipe craft_Recipe3 = new Craft_Recipe();
                    SD_Craft_Recipes_custom_sorted.TryGetValue(text, out craft_Recipe3);
                    if (craft_Recipe3 != null)
                    {
                        if (craft_Recipe3.Flag == 0)
                        {
                            if (dictionary["SD_Mat_0"].Keys.Contains(text))
                            {
                                int num7 = 0;
                                dictionary["SD_Mat_0"].TryGetValue(text, out num7);
                                dictionary["SD_Mat_0"].Remove(text);
                                int num8 = num4 * cR_Fullrequirement2.Amount / craft_Recipe2.CR_Result[0].Amount;
                                int value3 = num7 + num8;
                                dictionary["SD_Mat_0"].Add(text, value3);
                            }
                            else
                            {
                                int value4 = num4 * cR_Fullrequirement2.Amount / craft_Recipe2.CR_Result[0].Amount;
                                dictionary["SD_Mat_0"].Add(text, value4);
                            }
                        }
                        if (craft_Recipe3.Flag == 1)
                        {
                            if (dictionary["SD_Mat_1"].Keys.Contains(text))
                            {
                                int num9 = 0;
                                dictionary["SD_Mat_1"].TryGetValue(text, out num9);
                                dictionary["SD_Mat_1"].Remove(text);
                                int num10 = num4 * cR_Fullrequirement2.Amount / craft_Recipe2.CR_Result[0].Amount;
                                int value5 = num9 + num10;
                                dictionary["SD_Mat_1"].Add(text, value5);
                            }
                            else
                            {
                                int value6 = num4 * cR_Fullrequirement2.Amount / craft_Recipe2.CR_Result[0].Amount;
                                dictionary["SD_Mat_1"].Add(text, value6);
                            }
                        }
                    }
                    else if (dictionary["SD_Res"].Keys.Contains(text))
                    {
                        int num11 = 0;
                        dictionary["SD_Res"].TryGetValue(text, out num11);
                        dictionary["SD_Res"].Remove(text);
                        int num12 = num4 * cR_Fullrequirement2.Amount / craft_Recipe2.CR_Result[0].Amount;
                        int value7 = num11 + num12;
                        dictionary["SD_Res"].Add(text, value7);
                    }
                    else
                    {
                        int value8 = num4 * cR_Fullrequirement2.Amount / craft_Recipe2.CR_Result[0].Amount;
                        dictionary["SD_Res"].Add(text, value8);
                    }
                }
            }
            foreach (KeyValuePair<string, int> current3 in dictionary["SD_Mat_1"])
            {
                Craft_Recipe craft_Recipe4 = new Craft_Recipe();
                SD_Craft_Recipes_custom_sorted.TryGetValue(current3.Key, out craft_Recipe4);
                int num13 = (int)Math.Ceiling(Convert.ToDecimal(current3.Value / craft_Recipe4.CR_Result[0].Amount));
                int num14 = craft_Recipe4.CR_Result[0].Amount * num13;
                num = craft_Recipe4.LaborPrice * num13;
                int num15 = 0;
                dictionary["Labour Hours"].TryGetValue("Labour Hours", out num15);
                if (num15 > 0)
                {
                    dictionary["Labour Hours"].Remove("Labour Hours");
                    int value9 = num15 + num;
                    dictionary["Labour Hours"].Add("Labour Hours", value9);
                }
                else
                {
                    dictionary["Labour Hours"].Remove("Labour Hours");
                    dictionary["Labour Hours"].Add("Labour Hours", num);
                }
                num2 = craft_Recipe4.GivesXP * num13;
                int num16 = 0;
                dictionary["Craft XP"].TryGetValue("Craft XP", out num16);
                if (num16 > 0)
                {
                    dictionary["Craft XP"].Remove("Craft XP");
                    int value10 = num16 + num2;
                    dictionary["Craft XP"].Add("Craft XP", value10);
                }
                else
                {
                    dictionary["Craft XP"].Remove("Craft XP");
                    dictionary["Craft XP"].Add("Craft XP", num2);
                }
                CR_Fullrequirement[] cR_Fullrequirement = craft_Recipe4.CR_Fullrequirement;
                for (int i = 0; i < cR_Fullrequirement.Length; i++)
                {
                    CR_Fullrequirement cR_Fullrequirement3 = cR_Fullrequirement[i];
                    string text2 = func_Get_Name_from_ID(cR_Fullrequirement3.Template);
                    Craft_Recipe craft_Recipe5 = new Craft_Recipe();
                    SD_Craft_Recipes_custom_sorted.TryGetValue(text2, out craft_Recipe5);
                    if (craft_Recipe5 != null)
                    {
                        if (craft_Recipe5.Flag == 0)
                        {
                            if (dictionary["SD_Mat_0"].Keys.Contains(text2))
                            {
                                int num17 = 0;
                                dictionary["SD_Mat_0"].TryGetValue(text2, out num17);
                                dictionary["SD_Mat_0"].Remove(text2);
                                int num18 = num14 * cR_Fullrequirement3.Amount / craft_Recipe4.CR_Result[0].Amount;
                                int value11 = num17 + num18;
                                dictionary["SD_Mat_0"].Add(text2, value11);
                            }
                            else
                            {
                                int value12 = num14 * cR_Fullrequirement3.Amount / craft_Recipe4.CR_Result[0].Amount;
                                dictionary["SD_Mat_0"].Add(text2, value12);
                            }
                        }
                    }
                    else if (dictionary["SD_Res"].Keys.Contains(text2))
                    {
                        int num19 = 0;
                        dictionary["SD_Res"].TryGetValue(text2, out num19);
                        dictionary["SD_Res"].Remove(text2);
                        int num20 = num14 * cR_Fullrequirement3.Amount / craft_Recipe4.CR_Result[0].Amount;
                        int value13 = num19 + num20;
                        dictionary["SD_Res"].Add(text2, value13);
                    }
                    else
                    {
                        int value14 = num14 * cR_Fullrequirement3.Amount / craft_Recipe4.CR_Result[0].Amount;
                        dictionary["SD_Res"].Add(text2, value14);
                    }
                }
            }
            foreach (KeyValuePair<string, int> current4 in dictionary["SD_Mat_0"])
            {
                Craft_Recipe craft_Recipe6 = new Craft_Recipe();
                SD_Craft_Recipes_custom_sorted.TryGetValue(current4.Key, out craft_Recipe6);
                int num21 = (int)Math.Ceiling(Convert.ToDecimal(current4.Value / craft_Recipe6.CR_Result[0].Amount));
                int num22 = craft_Recipe6.CR_Result[0].Amount * num21;
                num = craft_Recipe6.LaborPrice * num21;
                int num23 = 0;
                dictionary["Labour Hours"].TryGetValue("Labour Hours", out num23);
                if (num23 > 0)
                {
                    dictionary["Labour Hours"].Remove("Labour Hours");
                    int value15 = num23 + num;
                    dictionary["Labour Hours"].Add("Labour Hours", value15);
                }
                else
                {
                    dictionary["Labour Hours"].Remove("Labour Hours");
                    dictionary["Labour Hours"].Add("Labour Hours", num);
                }
                num2 = craft_Recipe6.GivesXP * num21;
                int num24 = 0;
                dictionary["Craft XP"].TryGetValue("Craft XP", out num24);
                if (num24 > 0)
                {
                    dictionary["Craft XP"].Remove("Craft XP");
                    int value16 = num24 + num2;
                    dictionary["Craft XP"].Add("Craft XP", value16);
                }
                else
                {
                    dictionary["Craft XP"].Remove("Craft XP");
                    dictionary["Craft XP"].Add("Craft XP", num2);
                }
                CR_Fullrequirement[] cR_Fullrequirement = craft_Recipe6.CR_Fullrequirement;
                for (int i = 0; i < cR_Fullrequirement.Length; i++)
                {
                    CR_Fullrequirement cR_Fullrequirement4 = cR_Fullrequirement[i];
                    string text3 = func_Get_Name_from_ID(cR_Fullrequirement4.Template);
                    if (dictionary["SD_Res"].Keys.Contains(text3))
                    {
                        int num25 = 0;
                        dictionary["SD_Res"].TryGetValue(text3, out num25);
                        dictionary["SD_Res"].Remove(text3);
                        int num26 = num22 * cR_Fullrequirement4.Amount / craft_Recipe6.CR_Result[0].Amount;
                        int value17 = num25 + num26;
                        dictionary["SD_Res"].Add(text3, value17);
                    }
                    else
                    {
                        int value18 = num22 * cR_Fullrequirement4.Amount / craft_Recipe6.CR_Result[0].Amount;
                        dictionary["SD_Res"].Add(text3, value18);
                    }
                }
            }
            return dictionary;
        }

        private SortedDictionary<string, Craft_Recipe> func_SD_Craft_Recipes_custom_Population()
        {
            SortedDictionary<string, Craft_Recipe> sortedDictionary = new SortedDictionary<string, Craft_Recipe>();
            foreach (KeyValuePair<string, Recipe> current in SDictionary_Craft_Recipes)
            {
                Craft_Recipe craft_Recipe = new Craft_Recipe();
                Recipe recipe = new Recipe();
                List<CR_Fullrequirement> list = new List<CR_Fullrequirement>();
                List<CR_Result> list2 = new List<CR_Result>();
                recipe = current.Value;
                string arg_4A_0 = current.Key;
                craft_Recipe.Id = func_Get_ID_from_Name(recipe.Name.Remove(recipe.Name.IndexOf(" Blueprint")));
                craft_Recipe.Name = func_Get_Name_from_ID(craft_Recipe.Id);
                craft_Recipe.Flag = -1;
                craft_Recipe.LaborPrice = recipe.LaborPrice;
                craft_Recipe.GivesXP = recipe.GivesXP;
                craft_Recipe.RequiresLevel = recipe.RequiresLevel;
                Fullrequirement[] fullRequirements = recipe.FullRequirements;
                for (int i = 0; i < fullRequirements.Length; i++)
                {
                    Fullrequirement fullrequirement = fullRequirements[i];
                    list.Add(new CR_Fullrequirement
                    {
                        Amount = fullrequirement.Amount,
                        Chance = fullrequirement.Chance,
                        Template = fullrequirement.Template,
                        Name = func_Get_Name_from_ID(fullrequirement.Template)
                    });
                }
                craft_Recipe.CR_Fullrequirement = list.ToArray();
                Result[] results = recipe.Results;
                for (int i = 0; i < results.Length; i++)
                {
                    Result result = results[i];
                    list2.Add(new CR_Result
                    {
                        Amount = result.Amount,
                        Chance = result.Chance,
                        Template = result.Template,
                        Name = func_Get_Name_from_ID(result.Template)
                    });
                }
                craft_Recipe.CR_Result = list2.ToArray();
                sortedDictionary.Add(craft_Recipe.Name, craft_Recipe);
            }
            return sortedDictionary;
        }

        private SortedDictionary<string, Craft_Recipe> func_SD_Craft_Recipes_custom_FlagSort(SortedDictionary<string, Craft_Recipe> SD)
        {
            SortedDictionary<string, Craft_Recipe> sortedDictionary = new SortedDictionary<string, Craft_Recipe>();
            List<int> list = new List<int>();
            foreach (KeyValuePair<string, Craft_Recipe> current in SD)
            {
                list.Clear();
                CR_Fullrequirement[] cR_Fullrequirement = current.Value.CR_Fullrequirement;
                for (int i = 0; i < cR_Fullrequirement.Length; i++)
                {
                    CR_Fullrequirement cR_Fullrequirement2 = cR_Fullrequirement[i];
                    using (SortedDictionary<string, Storage_Resources>.ValueCollection.Enumerator enumerator2 = SDictionary_Storage_Resource.Values.GetEnumerator())
                    {
                        while (enumerator2.MoveNext())
                        {
                            if (enumerator2.Current.Id == cR_Fullrequirement2.Template)
                            {
                                list.Add(0);
                            }
                        }
                    }
                    using (SortedDictionary<string, Storage_Materials>.ValueCollection.Enumerator enumerator3 = SDictionary_Storage_Materials.Values.GetEnumerator())
                    {
                        while (enumerator3.MoveNext())
                        {
                            if (enumerator3.Current.Id == cR_Fullrequirement2.Template)
                            {
                                list.Add(-1);
                            }
                        }
                    }
                }
                current.Value.Flag = list.Min();
                if (current.Value.Flag >= 0)
                {
                    sortedDictionary.Add(current.Key, current.Value);
                }
            }
            do
            {
                foreach (KeyValuePair<string, Craft_Recipe> current2 in SD)
                {
                    list.Clear();
                    CR_Fullrequirement[] cR_Fullrequirement = current2.Value.CR_Fullrequirement;
                    for (int i = 0; i < cR_Fullrequirement.Length; i++)
                    {
                        CR_Fullrequirement cR_Fullrequirement3 = cR_Fullrequirement[i];
                        using (SortedDictionary<string, Storage_Materials>.ValueCollection.Enumerator enumerator3 = SDictionary_Storage_Materials.Values.GetEnumerator())
                        {
                            while (enumerator3.MoveNext())
                            {
                                if (enumerator3.Current.Id == cR_Fullrequirement3.Template && !sortedDictionary.Keys.Contains(cR_Fullrequirement3.Name))
                                {
                                    list.Add(-1);
                                }
                            }
                        }
                        using (SortedDictionary<string, Storage_Resources>.ValueCollection.Enumerator enumerator2 = SDictionary_Storage_Resource.Values.GetEnumerator())
                        {
                            while (enumerator2.MoveNext())
                            {
                                if (enumerator2.Current.Id == cR_Fullrequirement3.Template)
                                {
                                    list.Add(0);
                                }
                            }
                        }
                        foreach (KeyValuePair<string, Craft_Recipe> current3 in sortedDictionary)
                        {
                            if (current3.Value.Id == cR_Fullrequirement3.Template)
                            {
                                list.Add(current3.Value.Flag + 1);
                            }
                        }
                    }
                    int arg_28D_0 = list.Min();
                    int flag = list.Max();
                    if (arg_28D_0 > -1)
                    {
                        current2.Value.Flag = flag;
                    }
                    if (current2.Value.Flag > 0 && !sortedDictionary.Keys.Contains(current2.Key))
                    {
                        sortedDictionary.Add(current2.Key, current2.Value);
                    }
                }
            }
            while (sortedDictionary.Count < SD.Count);
            return sortedDictionary;
        }

        public string func_Get_Name_from_ID(int ID)
        {
            string result = "";
            foreach (KeyValuePair<int, string> current in SDictionary_Info_IDtoName)
            {
                if (ID == current.Key)
                {
                    result = current.Value;
                }
            }
            return result;
        }

        public int func_Get_ID_from_Name(string Name)
        {
            int result = 0;
            foreach (KeyValuePair<int, string> current in SDictionary_Info_IDtoName)
            {
                if (string.Compare(Name, current.Value, true) == 0)
                {
                    result = current.Key;
                }
            }
            return result;
        }

        private void comboBox_Craft_NewOrder_Quality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Craft_NewOrder_Quality.SelectedIndex == 0)
            {
                comboBox_Craft_NewOrder_Quality.BackColor = Color.LightGray;
            }
            if (comboBox_Craft_NewOrder_Quality.SelectedIndex == 1)
            {
                comboBox_Craft_NewOrder_Quality.BackColor = Color.DarkSeaGreen;
            }
            if (comboBox_Craft_NewOrder_Quality.SelectedIndex == 2)
            {
                comboBox_Craft_NewOrder_Quality.BackColor = Color.LightBlue;
            }
            if (comboBox_Craft_NewOrder_Quality.SelectedIndex == 3)
            {
                comboBox_Craft_NewOrder_Quality.BackColor = Color.PaleVioletRed;
            }
            if (comboBox_Craft_NewOrder_Quality.SelectedIndex == 4)
            {
                comboBox_Craft_NewOrder_Quality.BackColor = Color.Gold;
            }
        }

        private void button_Craft_Order_Clear_Click(object sender, EventArgs e)
        {
            groupBox_Craft_Order.Controls.Clear();
            groupBox_Craft_Order.Size = new Size(223, 41);
            SDictionary_Craft_Order.Clear();
            SD_Craft_Name_Amount.Clear();
            textBox_Craft_Uneed.Clear();
            textBox_Craft_CanBuild.Clear();
            i_Craft_Add = 0;
            label_Craft_Total_LH.Text = "Total Labour hours:";
            label_Craft_GainXP.Text = "Total Craft XP:";
            label_Craft_efficiency.Text = "Efficiency:";
            label_Craft_TotalCost.Text = "TotalCost:";
        }

        private void Button_Craft_Order_Delete_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string key = "label_Craft_Ordered_" + button.Name.Remove(0, "button_Craft_Order_Delete_".Length);
            Control[] array = groupBox_Craft_Order.Controls.Find(key, true);
            for (int i = 0; i < array.Length; i++)
            {
                Control value = array[i];
                groupBox_Craft_Order.Controls.Remove(value);
            }
            string key2 = "button_Craft_Order_Delete_" + button.Text + (i_Craft_Add - 1).ToString();
            array = groupBox_Craft_Order.Controls.Find(key2, true);
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Enabled = true;
            }
            groupBox_Craft_Order.Controls.Remove(button);
            groupBox_Craft_Order.Size = new Size(groupBox_Craft_Order.Size.Width, 5 + button.Location.Y);
            groupBox_Craft_Order.Refresh();
            i_Craft_Add--;
        }

        private void checkBox_Craft_StoredLH_CheckedChanged(object sender, EventArgs e)
        {
            if (SD_Craft_Name_Amount.Count > 0)
            {
                func_Craft_Text_Uneed();
            }
        }

        private void checkBox_Craft_StoredMats_CheckedChanged(object sender, EventArgs e)
        {
            if (SD_Craft_Name_Amount.Count > 0)
            {
                func_Craft_Text_Uneed();
            }
        }

        private void checkBox_Craft_StoredRes_CheckedChanged(object sender, EventArgs e)
        {
            if (SD_Craft_Name_Amount.Count > 0)
            {
                func_Craft_Text_Uneed();
            }
        }

        private void SpeedCurves_Graphics_Draw()
        {
            comboBox_SpeedCurves_YrShip.DataSource = SD_ShipsTempates.Keys.ToList<string>();
            comboBox_SpeedCurves_OpShip.DataSource = SD_ShipsTempates.Keys.ToList<string>();
            pictureBox_SpeedCurves_Base.Paint += new PaintEventHandler(DrawElipcesLines);
            pictureBox_SpeedCurves_Base.Refresh();
        }

        private void DrawElipcesLines(object sender, PaintEventArgs e)
        {
            Ship ship = new Ship();
            SD_ShipsTempates.TryGetValue(comboBox_SpeedCurves_YrShip.SelectedItem.ToString(), out ship);
            int num = ship.Specs.SpeedToWind.Count<float>() * 2 - 2;
            Font font = new Font("Arial", 8f);
            SolidBrush brush = new SolidBrush(Color.Black);
            new PointF(150f, 150f);
            PointF pt = new PointF(250f, 250f);
            PointF[] array = new PointF[num];
            Pen pen = new Pen(Color.Black, 1f);
            RectangleF rect = new RectangleF(50f, 50f, 400f, 400f);
            RectangleF rect2 = new RectangleF(100f, 100f, 300f, 300f);
            RectangleF rect3 = new RectangleF(150f, 150f, 200f, 200f);
            RectangleF rect4 = new RectangleF(200f, 200f, 100f, 100f);
            e.Graphics.DrawEllipse(pen, rect);
            e.Graphics.DrawEllipse(pen, rect2);
            e.Graphics.DrawEllipse(pen, rect3);
            e.Graphics.DrawEllipse(pen, rect4);
            string s = numericUpDown_SpeedCurves_MaxKn.Value.ToString() + "kn";
            e.Graphics.DrawString(s, font, brush, new PointF(450f, 235f));
            string s2 = (numericUpDown_SpeedCurves_MaxKn.Value * 3m / 4m).ToString() + "kn";
            e.Graphics.DrawString(s2, font, brush, new PointF(400f, 235f));
            string s3 = (numericUpDown_SpeedCurves_MaxKn.Value * 2m / 4m).ToString() + "kn";
            e.Graphics.DrawString(s3, font, brush, new PointF(350f, 235f));
            string s4 = (numericUpDown_SpeedCurves_MaxKn.Value * decimal.One / 4m).ToString() + "kn";
            e.Graphics.DrawString(s4, font, brush, new PointF(300f, 235f));
            for (int i = 0; i < num; i++)
            {
                double arg_2DE_0 = 225.0;
                double num2 = (double)(360 / num * i - 90);
                double expr_2CF = 3.1415926535897931 * num2 / 180.0;
                double num3 = Math.Sin(expr_2CF);
                double num4 = Math.Cos(expr_2CF);
                double num5 = arg_2DE_0 * num3;
                double num6 = arg_2DE_0 * num4;
                string s5 = (360 / num * i).ToString();
                array[i] = new PointF((float)num6 + pt.X, (float)num5 + pt.Y);
                e.Graphics.DrawLine(pen, pt, array[i]);
                e.Graphics.DrawString(s5, font, brush, array[i]);
            }
        }

        private void DrawClosedCurvePointF_YrShip(object sender, PaintEventArgs e)
        {
            Ship ship = new Ship();
            SD_ShipsTempates.TryGetValue(comboBox_SpeedCurves_YrShip.SelectedItem.ToString(), out ship);
            int num = ship.Specs.SpeedToWind.Count<float>() * 2 - 2;
            double num2 = 200.0 / (double)numericUpDown_SpeedCurves_MaxKn.Value / 10.0;
            PointF pointF = new PointF(250f, 250f);
            PointF[] array = new PointF[num];
            new Pen(Color.Red, 3f);
            Pen pen = new Pen(Color.Green, 3f);
            for (int i = 0; i < num; i++)
            {
                double num3 = (double)ship.Specs.MaxSpeed;
                if (i < ship.Specs.SpeedToWind.Count<float>())
                {
                    num3 = num2 * (double)ship.Specs.MaxSpeed * (double)ship.Specs.SpeedToWind[i];
                }
                else
                {
                    int num4 = ship.Specs.SpeedToWind.Count<float>() - (i - ship.Specs.SpeedToWind.Count<float>());
                    num3 = num2 * (double)ship.Specs.MaxSpeed * (double)ship.Specs.SpeedToWind[num4 - 2];
                }
                double num5 = (double)(360 / num * i - 90);
                double expr_153 = 3.1415926535897931 * num5 / 180.0;
                double num6 = Math.Sin(expr_153);
                double num7 = Math.Cos(expr_153);
                double num8 = num3 * num6;
                double num9 = num3 * num7;
                array[i] = new PointF((float)num9 + pointF.X, (float)num8 + pointF.Y);
            }
            e.Graphics.DrawClosedCurve(pen, array);
        }

        private void DrawClosedCurvePointF_OppShip(object sender, PaintEventArgs e)
        {
            Ship ship = new Ship();
            SD_ShipsTempates.TryGetValue(comboBox_SpeedCurves_OpShip.SelectedItem.ToString(), out ship);
            int num = ship.Specs.SpeedToWind.Count<float>() * 2 - 2;
            double num2 = 200.0 / (double)numericUpDown_SpeedCurves_MaxKn.Value / 10.0;
            PointF pointF = new PointF(250f, 250f);
            PointF[] array = new PointF[num];
            Pen pen = new Pen(Color.Red, 3f);
            new Pen(Color.Green, 3f);
            for (int i = 0; i < num; i++)
            {
                double num3 = (double)ship.Specs.MaxSpeed;
                if (i < ship.Specs.SpeedToWind.Count<float>())
                {
                    num3 = num2 * (double)ship.Specs.MaxSpeed * (double)ship.Specs.SpeedToWind[i];
                }
                else
                {
                    int num4 = ship.Specs.SpeedToWind.Count<float>() - (i - ship.Specs.SpeedToWind.Count<float>());
                    num3 = num2 * (double)ship.Specs.MaxSpeed * (double)ship.Specs.SpeedToWind[num4 - 2];
                }
                double num5 = (double)(360 / num * i - 90);
                double expr_153 = 3.1415926535897931 * num5 / 180.0;
                double num6 = Math.Sin(expr_153);
                double num7 = Math.Cos(expr_153);
                double num8 = num3 * num6;
                double num9 = num3 * num7;
                array[i] = new PointF((float)num9 + pointF.X, (float)num8 + pointF.Y);
            }
            e.Graphics.DrawClosedCurve(pen, array);
        }

        private void comboBox_SpeedCurves_YrShip_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox_SpeedCurves_Base.Paint += new PaintEventHandler(DrawClosedCurvePointF_YrShip);
            pictureBox_SpeedCurves_Base.Refresh();
        }

        private void comboBox_SpeedCurves_OpShip_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox_SpeedCurves_Base.Paint += new PaintEventHandler(DrawClosedCurvePointF_OppShip);
            pictureBox_SpeedCurves_Base.Refresh();
        }

        private void numericUpDown_SpeedCurves_MaxKn_ValueChanged(object sender, EventArgs e)
        {
            pictureBox_SpeedCurves_Base.Refresh();
        }

        private void radioButton_Storage_All_CheckedChanged(object sender, EventArgs e)
        {
            func_Tab_Storage_filling();
        }

        private void radioButton_Storage_Craft_CheckedChanged(object sender, EventArgs e)
        {
            func_Tab_Storage_filling();
        }

        private void radioButton_Storage_Trade_CheckedChanged(object sender, EventArgs e)
        {
            func_Tab_Storage_filling();
        }
    }
}
