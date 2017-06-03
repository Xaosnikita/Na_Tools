
namespace Test_NavalAction_Tool
{
    public class Form1 : Form
    {
        private int i_Craft_Add;

        private List<Dictionary<string, object>> ItemTemplates;

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

        private IContainer components;

        private ComboBox comboBox_Info_Type;

        private Label label__Info_type;

        private Label label_Info_Name;

        private ListBox listBox_Info_Name;

        private TextBox textBox_Info_Object;

        private TabPage tabPage_Info;

        private TabPage tabPage_Storage;

        private TabControl tabControl_NA_Tool;

        private GroupBox groupBox_Storage_Materials;

        private GroupBox groupBox_Storage_Resources;

        private Label label_Storage_Resources_Quantity;

        private Label label_Storage_Resources_Name;

        private Label label_Storage_Resources_ItemWeight;

        private Label label_Storage_Resources_BasePrice;

        private Label label_Storage_Resources_Price;

        private Label label_Storage_Resources_AutoBuy;

        private TabPage tabPage_Craft;

        private Label label_Storage_Materials_ItemWeight;

        private Label label_Storage_Materials_BasePrice;

        private Label label_Storage_Materials_Price;

        private Label label_Storage_Materials_Quantity;

        private Label label_Storage_Materials_Name;

        private GroupBox groupBox_Storage_Labour;

        private Label label_Storage_LH_Labour_Contracts;

        private Label label_Storage_LH_Labour_Hours;

        private TextBox textBox_Storage_LH_Labour_Contracts_Quantity;

        private TextBox textBox_Storage_LH_Labour_Hours_Quantity;

        private ListBox listBox_Info_IDtoName;

        private Label label_Info_IdtoName;

        private Label label_Info_Id;

        private Label label_Info_ObjectDescription;

        private GroupBox groupBox_Storage_ShipRecipes;

        private CheckedListBox checkedListBox_Storage_ShipRecipes;

        private TabPage tabPage_SPeedCurves;

        private TextBox textBox_Storage_LH_LabourContracts_Price;

        private Label label_Storage_LH_Price;

        private Label label_Storage_LH_Quantity;

        private TextBox textBox_Storage_LH_LabourHours_Price;

        private Label label_Craft_TotalCost;

        private Label label_Craft_Total_LH;

        private CheckBox checkBox_Craft_StoredLH;

        private CheckBox checkBox_Craft_StoredMats;

        private Label label_Craft_ETA;

        private ComboBox comboBox_Craft_NewOrder_Quality;

        private Label label_Craft_Quality;

        private Button button_Craft_Add;

        private GroupBox groupBox_Craft_GeneralInfo;

        private GroupBox groupBox_Craft_Order;

        private GroupBox groupBox_Craft_TotalNeeds;

        private GroupBox groupBox_Craft_CanBuild;

        private Button button_Storage_Save;

        private Button button_Storage_Open;

        private OpenFileDialog openFileDialog_Storage;

        private SaveFileDialog saveFileDialog_Storage;

        private CheckBox checkBox_Craft_StoredRes;

        private GroupBox groupBox_Craft_NewOrder;

        private RadioButton radioButton_Craft_Recipe;

        private RadioButton radioButton_Craft_Module;

        private RadioButton radioButton_Craft_Ship;

        private ComboBox comboBox_Craft_NewOrder_Name;

        private Label label_Craft_NewOrder_Name;

        private TextBox textBox_Craft_Uneed;

        private ComboBox comboBox_Craft_NewOrder_Wood;

        private Label label_Craft_Wood;

        private Button button_Craft_Order_Clear;

        private TextBox textBox_Craft_CanBuild;

        private Label label_Craft_GainXP;

        private Label label_Craft_efficiency;

        private ComboBox comboBox_Craft_NewOrder_Trim;

        private Label label_Craft_Trim;

        private PictureBox pictureBox_SpeedCurves_Base;

        private ComboBox comboBox_SpeedCurves_YrShip;

        private Label label_SpeedCurves_YrShip;

        private TabPage tabPage_Test;

        private Label label_SpeedCurves_OpShip;

        private ComboBox comboBox_SpeedCurves_OpShip;

        private NumericUpDown numericUpDown_SpeedCurves_MaxKn;

        private Label label_SpeedCurves_Scale;

        private TextBox textBox2;

        private TextBox textBox1;

        private Label label1;

        private RadioButton radioButton_Storage_Trade;

        private RadioButton radioButton_Storage_Craft;

        private RadioButton radioButton_Storage_All;

        private NumericUpDown numericUpDown1;

        private void textBox__Storage_Resource_Quantity_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Storage_Resources[] storage_Resources = this.Storage.Storage_Resources;
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
            Storage_Resources[] storage_Resources = this.Storage.Storage_Resources;
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
            Storage_Materials[] storage_Materials = this.Storage.Storage_Materials;
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
            this.Storage.Storage_LabourHours[0].Quantity = Convert.ToInt32(textBox.Text);
        }

        private void textBox_Storage_LH_LabourHours_Price_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            this.Storage.Storage_LabourHours[0].Price = Convert.ToInt32(textBox.Text);
            this.Storage.Storage_LabourHours[1].Price = Convert.ToInt32(textBox.Text) * 500;
            this.textBox_Storage_LH_LabourContracts_Price.Text = this.Storage.Storage_LabourHours[1].Price.ToString();
        }

        private void textBox_Storage_LH_Labour_Contracts_Quantity_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            this.Storage.Storage_LabourHours[1].Quantity = Convert.ToInt32(textBox.Text);
        }

        private void textBox_Storage_LH_LabourContracts_Price_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            this.Storage.Storage_LabourHours[1].Price = Convert.ToInt32(textBox.Text);
            this.Storage.Storage_LabourHours[0].Price = Convert.ToInt32(textBox.Text) / 500;
            this.textBox_Storage_LH_LabourHours_Price.Text = this.Storage.Storage_LabourHours[0].Price.ToString();
        }

        private Storage func_Storage_population()
        {
            Storage storage = new Storage();
            int num = 0;
            int num2 = 0;
            foreach (Dictionary<string, object> current in this.ItemTemplates)
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
                    this.SDictionary_Storage_Resource.Add(storage_Resources.Name, storage_Resources);
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
                    this.SDictionary_Storage_Materials.Add(storage_Materials.Name, storage_Materials);
                    num2++;
                }
                if (current["ItemType"].ToString() == "RecipeShip")
                {
                    this.SDictionary_Storage_ShipRecipes.Add(current["Name"].ToString(), false);
                }
            }
            Storage_LabourHours storage_LabourHours = new Storage_LabourHours();
            Storage_LabourHours storage_LabourHours2 = new Storage_LabourHours();
            storage_LabourHours.Name = this.label_Storage_LH_Labour_Hours.Text;
            storage_LabourHours.Quantity = Convert.ToInt32(this.textBox_Storage_LH_Labour_Hours_Quantity.Text);
            this.SDictionary_Storage_LabourHours.Add("Labour Hours", storage_LabourHours);
            this.List_Storage_LabourHours.Add(storage_LabourHours);
            foreach (Dictionary<string, object> current2 in this.ItemTemplates)
            {
                if (current2["ItemType"].ToString() == "ExtraLaborHoursUsableItem")
                {
                    storage_LabourHours2.Name = current2["Name"].ToString();
                    storage_LabourHours2.Quantity = Convert.ToInt32(this.textBox_Storage_LH_Labour_Hours_Quantity.Text);
                    storage_LabourHours2.Price = Convert.ToInt32(current2["BasePrice"]);
                    storage_LabourHours.Price = storage_LabourHours2.Price / 500;
                    this.SDictionary_Storage_LabourHours.Add("Labour Contracts", storage_LabourHours2);
                    this.List_Storage_LabourHours.Add(storage_LabourHours2);
                }
            }
            foreach (string current3 in this.SDictionary_Storage_ShipRecipes.Keys)
            {
                Storage_Ship_Recipes storage_Ship_Recipes = new Storage_Ship_Recipes();
                bool @checked = false;
                @checked = this.SDictionary_Storage_ShipRecipes.TryGetValue(current3, out @checked);
                storage_Ship_Recipes.Checked = @checked;
                storage_Ship_Recipes.Name = current3;
                this.List_Storage_Ship_Recipes.Add(storage_Ship_Recipes);
            }
            this.SDictionary_Storage_Resource.Values.ToArray<Storage_Resources>();
            storage.Storage_Resources = this.SDictionary_Storage_Resource.Values.ToArray<Storage_Resources>();
            storage.Storage_Materials = this.SDictionary_Storage_Materials.Values.ToArray<Storage_Materials>();
            storage.Storage_LabourHours = this.List_Storage_LabourHours.ToArray();
            storage.Storage_Ship_Recipes = this.List_Storage_Ship_Recipes.ToArray();
            this.Storage = storage;
            return this.Storage;
        }

        private void func_Tab_Storage_filling()
        {
            this.groupBox_Storage_Resources.Controls.Clear();
            this.func_func_Storage_Tab_Resource_top_Controls_Drawings();
            int num = 1;
            Storage_Resources[] storage_Resources = this.Storage.Storage_Resources;
            for (int i = 0; i < storage_Resources.Length; i++)
            {
                Storage_Resources storage_Resources2 = storage_Resources[i];
                if (this.radioButton_Storage_All.Checked)
                {
                    this.func_Storage_Tab_Resource_Controls_Drawings(num, storage_Resources2);
                    num++;
                }
                if (this.radioButton_Storage_Craft.Checked && storage_Resources2.ProducedByNation == -1)
                {
                    this.func_Storage_Tab_Resource_Controls_Drawings(num, storage_Resources2);
                    num++;
                }
                if (this.radioButton_Storage_Trade.Checked && storage_Resources2.ProducedByNation != -1)
                {
                    this.func_Storage_Tab_Resource_Controls_Drawings(num, storage_Resources2);
                    num++;
                }
            }
            int num2 = 1;
            Storage_Materials[] storage_Materials = this.Storage.Storage_Materials;
            for (int i = 0; i < storage_Materials.Length; i++)
            {
                Storage_Materials storage_Materials2 = storage_Materials[i];
                Label label = new Label();
                label.Name = "label_Storage_Materials_" + storage_Materials2.Name;
                label.AutoSize = true;
                label.Location = new Point(this.label_Storage_Materials_Name.Location.X, this.label_Storage_Materials_Name.Location.Y + num2 * label.Height);
                label.Size = new Size(38, 13);
                label.TabIndex = 0;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Text = storage_Materials2.Name;
                this.groupBox_Storage_Materials.Controls.Add(label);
                TextBox textBox = new TextBox();
                textBox.Name = "textBox_Storage_Materials_Quantity_" + storage_Materials2.Name;
                textBox.Location = new Point(this.label_Storage_Materials_Quantity.Location.X, label.Location.Y - 3);
                textBox.Size = new Size(40, 20);
                textBox.TabIndex = 0;
                textBox.TextAlign = HorizontalAlignment.Center;
                textBox.Text = storage_Materials2.Quantity.ToString();
                textBox.TextChanged += new EventHandler(this.textBox__Storage_Materials_Quantity_TextChanged);
                this.groupBox_Storage_Materials.Controls.Add(textBox);
                Label label2 = new Label();
                label2.AutoSize = false;
                label2.Name = "label_Storage_Materials_Price_" + storage_Materials2.Name;
                label2.Location = new Point(this.label_Storage_Materials_Price.Location.X, label.Location.Y);
                label2.Size = new Size(this.label_Storage_Materials_Price.Size.Width, 13);
                label2.TabIndex = 0;
                label2.TextAlign = ContentAlignment.MiddleCenter;
                label2.Text = storage_Materials2.BasePrice.ToString();
                this.groupBox_Storage_Materials.Controls.Add(label2);
                Label label3 = new Label();
                label3.AutoSize = false;
                label3.Name = "label_Storage_Materials_BP_" + storage_Materials2.Name;
                label3.Location = new Point(this.label_Storage_Materials_BasePrice.Location.X, label.Location.Y);
                label3.Size = new Size(this.label_Storage_Materials_BasePrice.Size.Width, 13);
                label3.TabIndex = 0;
                label3.TextAlign = ContentAlignment.MiddleCenter;
                label3.Text = storage_Materials2.BasePrice.ToString();
                this.groupBox_Storage_Materials.Controls.Add(label3);
                Label label4 = new Label();
                label4.Name = "label_Storage_Materials_Weight_" + storage_Materials2.Name;
                label4.AutoSize = false;
                label4.Location = new Point(this.label_Storage_Materials_ItemWeight.Location.X, label.Location.Y);
                label4.Size = new Size(this.label_Storage_Materials_ItemWeight.Size.Width, 13);
                label4.TabIndex = 0;
                label4.TextAlign = ContentAlignment.MiddleCenter;
                label4.Text = storage_Materials2.ItemWeight.ToString();
                this.groupBox_Storage_Materials.Controls.Add(label4);
                this.groupBox_Storage_Materials.Size = new Size(this.groupBox_Storage_Materials.Size.Width, label.Location.Y + label.Height + 10);
                num2++;
            }
            this.textBox_Storage_LH_Labour_Hours_Quantity.Text = this.Storage.Storage_LabourHours[0].Quantity.ToString();
            this.textBox_Storage_LH_LabourHours_Price.Text = this.Storage.Storage_LabourHours[0].Price.ToString();
            this.textBox_Storage_LH_Labour_Contracts_Quantity.Text = this.Storage.Storage_LabourHours[1].Quantity.ToString();
            this.textBox_Storage_LH_LabourContracts_Price.Text = this.Storage.Storage_LabourHours[1].Price.ToString();
            this.checkedListBox_Storage_ShipRecipes.Items.Clear();
            Storage_Ship_Recipes[] storage_Ship_Recipes = this.Storage.Storage_Ship_Recipes;
            for (int i = 0; i < storage_Ship_Recipes.Length; i++)
            {
                Storage_Ship_Recipes storage_Ship_Recipes2 = storage_Ship_Recipes[i];
                int num3 = 0;
                bool value = false;
                value = this.SDictionary_Storage_ShipRecipes.TryGetValue(storage_Ship_Recipes2.Name, out value);
                this.checkedListBox_Storage_ShipRecipes.Items.Add(storage_Ship_Recipes2.Name);
                this.checkedListBox_Storage_ShipRecipes.SetItemChecked(num3, value);
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
            this.groupBox_Storage_Resources.Controls.Add(label);
            this.groupBox_Storage_Resources.Controls.Add(label2);
            this.groupBox_Storage_Resources.Controls.Add(label3);
            this.groupBox_Storage_Resources.Controls.Add(label4);
            this.groupBox_Storage_Resources.Controls.Add(label5);
            this.groupBox_Storage_Resources.Controls.Add(label6);
        }

        private void func_Storage_Tab_Resource_Controls_Drawings(int i_Storage_resource, Storage_Resources Item)
        {
            Label label = new Label();
            label.Name = "label_Storage_Resource_" + Item.Name;
            label.AutoSize = true;
            label.Location = new Point(this.groupBox_Storage_Resources.Location.X, this.label_Storage_Resources_Name.Location.Y + i_Storage_resource * label.Height);
            label.Size = new Size(38, 13);
            label.TabIndex = 0;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = Item.Name;
            this.groupBox_Storage_Resources.Controls.Add(label);
            TextBox textBox = new TextBox();
            textBox.Name = "textBox_Storage_Resource_Quantity_" + Item.Name;
            textBox.Location = new Point(this.label_Storage_Resources_Quantity.Location.X, label.Location.Y - 3);
            textBox.Size = new Size(40, 20);
            textBox.TabIndex = 0;
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.Text = Item.Quantity.ToString();
            textBox.TextChanged += new EventHandler(this.textBox__Storage_Resource_Quantity_TextChanged);
            this.groupBox_Storage_Resources.Controls.Add(textBox);
            TextBox textBox2 = new TextBox();
            textBox2.Name = "textBox_Storage_Resource_Price_" + Item.Name;
            textBox2.Location = new Point(this.label_Storage_Resources_Price.Location.X, label.Location.Y - 3);
            textBox2.Size = new Size(40, 20);
            textBox2.TabIndex = 0;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.Text = Item.Price.ToString();
            textBox2.TextChanged += new EventHandler(this.textBox__Storage_Resource_Price_TextChanged);
            this.groupBox_Storage_Resources.Controls.Add(textBox2);
            Label label2 = new Label();
            label2.AutoSize = false;
            label2.Name = "label_Storage_Resource_BP_" + Item.Name;
            label2.Location = new Point(this.label_Storage_Resources_BasePrice.Location.X, label.Location.Y);
            label2.Size = new Size(this.label_Storage_Resources_BasePrice.Size.Width, 13);
            label2.TabIndex = 0;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Text = Item.BasePrice.ToString();
            this.groupBox_Storage_Resources.Controls.Add(label2);
            Label label3 = new Label();
            label3.Name = "label_Storage_Resource_Weight_" + Item.Name;
            label3.AutoSize = false;
            label3.Location = new Point(this.label_Storage_Resources_ItemWeight.Location.X, label.Location.Y);
            label3.Size = new Size(this.label_Storage_Resources_ItemWeight.Size.Width, 13);
            label3.TabIndex = 0;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Text = Item.ItemWeight.ToString();
            this.groupBox_Storage_Resources.Controls.Add(label3);
            Label label4 = new Label();
            label4.Name = "label_Storage_Resource_AutoFillPrice_" + Item.Name;
            label4.AutoSize = false;
            label4.Location = new Point(this.label_Storage_Resources_AutoBuy.Location.X, label.Location.Y);
            label4.Size = new Size(this.label_Storage_Resources_AutoBuy.Size.Width, 13);
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
            this.groupBox_Storage_Resources.Controls.Add(label4);
            this.groupBox_Storage_Resources.Size = new Size(this.groupBox_Storage_Resources.Size.Width, label.Location.Y + label.Height + 10);
        }

        private void comboBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox_Info_Name.Enabled = true;
            this.comboBox_Info_Type.SelectedItem.ToString();
            this.listBox_Info_Name.Items.Clear();
            foreach (Dictionary<string, object> current in this.ItemTemplates)
            {
                if (current["ItemType"].ToString() == this.comboBox_Info_Type.SelectedItem.ToString() && !this.listBox_Info_Name.Items.Contains(current["Name"].ToString()))
                {
                    this.listBox_Info_Name.Items.Add(current["Name"].ToString());
                }
            }
        }

        private void listBox_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox_Info_Object.ResetText();
            foreach (Dictionary<string, object> current in this.ItemTemplates)
            {
                if (current["ItemType"].ToString() == this.comboBox_Info_Type.SelectedItem.ToString() && current["Name"].ToString() == this.listBox_Info_Name.SelectedItem.ToString())
                {
                    foreach (string current2 in current.Keys)
                    {
                        string text = current[current2].ToString();
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
                                string value = this.func_Get_Name_from_ID(iD) + ":";
                                text = arg_B9_0.Insert(num + text2.Count<char>() - 1, value);
                            }
                            while (text.Contains("\"Template\": "));
                        }
                        this.textBox_Info_Object.Text = string.Concat(new string[]
                        {
                            this.textBox_Info_Object.Text,
                            current2,
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
            if (this.openFileDialog_Storage.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            StreamReader expr_1F = File.OpenText(this.openFileDialog_Storage.FileName);
            Storage storage = JsonConvert.DeserializeObject<Storage>(expr_1F.ReadToEnd());
            expr_1F.Close();
            this.Storage = storage;
            Storage_Resources[] storage_Resources = this.Storage.Storage_Resources;
            for (int i = 0; i < storage_Resources.Length; i++)
            {
                Storage_Resources storage_Resources2 = storage_Resources[i];
                string key = "textBox_Storage_Resource_Quantity_" + storage_Resources2.Name;
                Control[] array = this.groupBox_Storage_Resources.Controls.Find(key, true);
                for (int j = 0; j < array.Length; j++)
                {
                    array[j].Text = storage_Resources2.Quantity.ToString();
                }
                string key2 = "textBox_Storage_Resource_Price_" + storage_Resources2.Name;
                array = this.groupBox_Storage_Resources.Controls.Find(key2, true);
                for (int j = 0; j < array.Length; j++)
                {
                    array[j].Text = storage_Resources2.Price.ToString();
                }
            }
            Storage_Materials[] storage_Materials = this.Storage.Storage_Materials;
            for (int i = 0; i < storage_Materials.Length; i++)
            {
                Storage_Materials storage_Materials2 = storage_Materials[i];
                string key3 = "textBox_Storage_Materials_Quantity_" + storage_Materials2.Name;
                Control[] array = this.groupBox_Storage_Materials.Controls.Find(key3, true);
                for (int j = 0; j < array.Length; j++)
                {
                    array[j].Text = storage_Materials2.Quantity.ToString();
                }
            }
            this.textBox_Storage_LH_Labour_Hours_Quantity.Text = this.Storage.Storage_LabourHours[0].Quantity.ToString();
            this.textBox_Storage_LH_LabourHours_Price.Text = this.Storage.Storage_LabourHours[0].Price.ToString();
            this.textBox_Storage_LH_Labour_Contracts_Quantity.Text = this.Storage.Storage_LabourHours[1].Quantity.ToString();
            this.textBox_Storage_LH_LabourContracts_Price.Text = this.Storage.Storage_LabourHours[1].Price.ToString();
            MessageBox.Show("Файл открыт");
        }

        private void button_Storage_Save_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog_Storage.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string arg_28_0 = this.saveFileDialog_Storage.FileName;
            string contents = JsonConvert.SerializeObject(this.Storage, Formatting.Indented);
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
                this.comboBox_Craft_NewOrder_Name.DataSource = this.SDictionary_Craft_ShipRecipes.Keys.ToList<string>();
                this.comboBox_Craft_NewOrder_Quality.Enabled = true;
                this.comboBox_Craft_NewOrder_Quality.SelectedIndex = 0;
                this.comboBox_Craft_NewOrder_Wood.Enabled = true;
                this.comboBox_Craft_NewOrder_Wood.SelectedIndex = 0;
                this.comboBox_Craft_NewOrder_Trim.Enabled = true;
                this.comboBox_Craft_NewOrder_Trim.SelectedIndex = 0;
                this.comboBox_Craft_NewOrder_Name.Refresh();
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
                this.comboBox_Craft_NewOrder_Name.DataSource = this.SDictionary_Craft_ModuleRecipes.Keys.ToList<string>();
                this.comboBox_Craft_NewOrder_Quality.Enabled = true;
                this.comboBox_Craft_NewOrder_Wood.Enabled = false;
                this.comboBox_Craft_NewOrder_Wood.SelectedIndex = -1;
                this.comboBox_Craft_NewOrder_Trim.Enabled = false;
                this.comboBox_Craft_NewOrder_Trim.SelectedIndex = -1;
                this.comboBox_Craft_NewOrder_Quality.SelectedIndex = 0;
                this.comboBox_Craft_NewOrder_Name.Refresh();
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
                this.comboBox_Craft_NewOrder_Name.DataSource = this.SDictionary_Craft_Recipes.Keys.ToList<string>();
                this.comboBox_Craft_NewOrder_Quality.Enabled = false;
                this.comboBox_Craft_NewOrder_Quality.SelectedIndex = -1;
                this.comboBox_Craft_NewOrder_Wood.Enabled = false;
                this.comboBox_Craft_NewOrder_Wood.SelectedIndex = -1;
                this.comboBox_Craft_NewOrder_Trim.Enabled = false;
                this.comboBox_Craft_NewOrder_Trim.SelectedIndex = -1;
                this.comboBox_Craft_NewOrder_Name.Refresh();
            }
        }

        private void button_Craft_Add_Click(object sender, EventArgs e)
        {
            Craft_Order craft_Order = new Craft_Order();
            craft_Order.Name = this.comboBox_Craft_NewOrder_Name.Text;
            if (this.radioButton_Craft_Ship.Checked)
            {
                craft_Order.Type = 0;
            }
            if (this.radioButton_Craft_Module.Checked)
            {
                craft_Order.Type = 1;
            }
            if (this.radioButton_Craft_Recipe.Checked)
            {
                craft_Order.Type = 2;
            }
            craft_Order.Woodtype = this.comboBox_Craft_NewOrder_Wood.SelectedIndex;
            craft_Order.Quality = this.comboBox_Craft_NewOrder_Quality.SelectedIndex;
            craft_Order.Trim = this.comboBox_Craft_NewOrder_Trim.SelectedIndex;
            this.SDictionary_Craft_Order.Add(this.i_Craft_Add, craft_Order);
            Label label = new Label();
            label.Name = "label_Craft_Ordered_" + this.comboBox_Craft_NewOrder_Name.Text + this.i_Craft_Add.ToString();
            label.AutoSize = true;
            label.Location = new Point(5, 24 + this.i_Craft_Add * label.Size.Height);
            label.Size = new Size(152, 13);
            label.TabIndex = 0;
            label.Text = this.comboBox_Craft_NewOrder_Name.Text + this.comboBox_Craft_NewOrder_Wood.Text + this.comboBox_Craft_NewOrder_Trim.Text;
            if (this.comboBox_Craft_NewOrder_Quality.SelectedIndex == 0)
            {
                this.comboBox_Craft_NewOrder_Quality.BackColor = Color.LightGray;
                label.BackColor = Color.LightGray;
            }
            if (this.comboBox_Craft_NewOrder_Quality.SelectedIndex == 1)
            {
                this.comboBox_Craft_NewOrder_Quality.BackColor = Color.DarkSeaGreen;
                label.BackColor = Color.DarkSeaGreen;
            }
            if (this.comboBox_Craft_NewOrder_Quality.SelectedIndex == 2)
            {
                this.comboBox_Craft_NewOrder_Quality.BackColor = Color.LightBlue;
                label.BackColor = Color.LightBlue;
            }
            if (this.comboBox_Craft_NewOrder_Quality.SelectedIndex == 3)
            {
                this.comboBox_Craft_NewOrder_Quality.BackColor = Color.PaleVioletRed;
                label.BackColor = Color.PaleVioletRed;
            }
            if (this.comboBox_Craft_NewOrder_Quality.SelectedIndex == 4)
            {
                this.comboBox_Craft_NewOrder_Quality.BackColor = Color.Gold;
                label.BackColor = Color.Gold;
            }
            this.groupBox_Craft_Order.Controls.Add(label);
            this.groupBox_Craft_Order.Size = new Size(this.groupBox_Craft_Order.Size.Width, 5 + label.Location.Y + label.Size.Height);
            this.i_Craft_Add++;
            this.func_Craft_Text_Uneed();
            this.func_Craft_Text_CanBuild();
        }

        private void func_Craft_Text_Uneed()
        {
            this.textBox_Craft_Uneed.Clear();
            this.SD_Craft_Name_Amount.Clear();
            string str = "Detailed:\r\n";
            string text = "\r\n-------------------\r\n";
            string text2 = "";
            string str2 = "Labour Hours:  ";
            string str3 = "Gives Craft XP:  ";
            string str4 = "Resources:  ";
            int num = 0;
            int num2 = 0;
            foreach (int current in this.SDictionary_Craft_Order.Keys)
            {
                Craft_Order craft_Order = new Craft_Order();
                this.SDictionary_Craft_Order.TryGetValue(current, out craft_Order);
                if (craft_Order.Type == 0)
                {
                    foreach (string current2 in this.SDictionary_Craft_ShipRecipes.Keys)
                    {
                        if (current2 == craft_Order.Name)
                        {
                            RecipeShip recipeShip = new RecipeShip();
                            Ship ship = new Ship();
                            this.SDictionary_Craft_ShipRecipes.TryGetValue(current2, out recipeShip);
                            this.SD_ShipsTempates.TryGetValue(current2, out ship);
                            num += recipeShip.LaborPrice;
                            num2 += recipeShip.GivesXP;
                            Fullrequirement[] fullRequirements = recipeShip.FullRequirements;
                            for (int i = 0; i < fullRequirements.Length; i++)
                            {
                                Fullrequirement obj = fullRequirements[i];
                                this.SD_Craft_Name_Amount = this.func_SDict_From_FullRequirement(obj);
                            }
                            Requirement[] requirements = recipeShip.WoodTypeDescs[craft_Order.Woodtype].Requirements;
                            for (int i = 0; i < requirements.Length; i++)
                            {
                                Requirement obj2 = requirements[i];
                                this.SD_Craft_Name_Amount = this.func_SDict_From_Requirement(obj2);
                            }
                            requirements = recipeShip.Qualities[craft_Order.Quality].Requirements;
                            for (int i = 0; i < requirements.Length; i++)
                            {
                                Requirement obj3 = requirements[i];
                                this.SD_Craft_Name_Amount = this.func_SDict_From_Requirement(obj3);
                            }
                            if (craft_Order.Quality > 0)
                            {
                                List<string> list = new List<string>();
                                decimal d = craft_Order.Quality + 1;
                                int num3 = (int)(ship.ShipMass / 50 * (d / 2m));
                                int num4 = 0;
                                this.Dict_Craft_Trim_Extra.TryGetValue(this.comboBox_Craft_NewOrder_Trim.Items[craft_Order.Trim].ToString(), out list);
                                foreach (string current3 in list)
                                {
                                    num4 = 0;
                                    this.SD_Craft_Name_Amount.TryGetValue(current3, out num4);
                                    if (num4 > 0)
                                    {
                                        this.SD_Craft_Name_Amount.Remove(current3);
                                        int value = num4 + num3;
                                        this.SD_Craft_Name_Amount.Add(current3, value);
                                    }
                                    else
                                    {
                                        this.SD_Craft_Name_Amount.Add(current3, num3);
                                    }
                                }
                            }
                        }
                    }
                }
                if (craft_Order.Type == 1)
                {
                    foreach (string current4 in this.SDictionary_Craft_ModuleRecipes.Keys)
                    {
                        if (current4 == craft_Order.Name)
                        {
                            RecipeModule recipeModule = new RecipeModule();
                            this.SDictionary_Craft_ModuleRecipes.TryGetValue(current4, out recipeModule);
                            num += recipeModule.LaborPrice;
                            num2 += recipeModule.GivesXP;
                            Fullrequirement[] fullRequirements = recipeModule.FullRequirements;
                            for (int i = 0; i < fullRequirements.Length; i++)
                            {
                                Fullrequirement obj4 = fullRequirements[i];
                                this.SD_Craft_Name_Amount = this.func_SDict_From_FullRequirement(obj4);
                            }
                            Requirement[] requirements = recipeModule.Qualities[craft_Order.Quality].Requirements;
                            for (int i = 0; i < requirements.Length; i++)
                            {
                                Requirement obj5 = requirements[i];
                                this.SD_Craft_Name_Amount = this.func_SDict_From_Requirement(obj5);
                            }
                        }
                    }
                }
                if (craft_Order.Type == 2)
                {
                    foreach (string current5 in this.SDictionary_Craft_Recipes.Keys)
                    {
                        if (current5 == craft_Order.Name)
                        {
                            Recipe recipe = new Recipe();
                            this.SDictionary_Craft_Recipes.TryGetValue(current5, out recipe);
                            num += recipe.LaborPrice;
                            num2 += recipe.GivesXP;
                            Fullrequirement[] fullRequirements = recipe.FullRequirements;
                            for (int i = 0; i < fullRequirements.Length; i++)
                            {
                                Fullrequirement obj6 = fullRequirements[i];
                                this.SD_Craft_Name_Amount = this.func_SDict_From_FullRequirement(obj6);
                            }
                        }
                    }
                }
            }
            if (this.checkBox_Craft_StoredMats.Checked)
            {
                for (int j = this.SD_Craft_Name_Amount.Count; j > 0; j--)
                {
                    int num5 = 0;
                    int num6 = 0;
                    string text3 = this.SD_Craft_Name_Amount.Keys.ToList<string>()[j - 1];
                    this.SD_Craft_Name_Amount.TryGetValue(text3, out num6);
                    Storage_Materials[] storage_Materials = this.Storage.Storage_Materials;
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
                        this.SD_Craft_Name_Amount.Remove(text3);
                    }
                    else
                    {
                        this.SD_Craft_Name_Amount.Remove(text3);
                        this.SD_Craft_Name_Amount.Add(text3, num7);
                    }
                }
            }
            this.Dict_sorted_by_flag_Name_amount = this.func_SD_sorted_Name_Amount(this.SD_Craft_Name_Amount);
            if (this.checkBox_Craft_StoredRes.Checked)
            {
                for (int k = this.Dict_sorted_by_flag_Name_amount["SD_Res"].Count; k > 0; k--)
                {
                    int num8 = 0;
                    int num9 = 0;
                    string text4 = this.Dict_sorted_by_flag_Name_amount["SD_Res"].Keys.ToList<string>()[k - 1];
                    this.Dict_sorted_by_flag_Name_amount["SD_Res"].TryGetValue(text4, out num9);
                    Storage_Resources[] storage_Resources = this.Storage.Storage_Resources;
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
                        this.Dict_sorted_by_flag_Name_amount["SD_Res"].Remove(text4);
                    }
                    else
                    {
                        this.Dict_sorted_by_flag_Name_amount["SD_Res"].Remove(text4);
                        this.Dict_sorted_by_flag_Name_amount["SD_Res"].Add(text4, num10);
                    }
                }
            }
            int num11 = 0;
            foreach (KeyValuePair<string, SortedDictionary<string, int>> current6 in this.Dict_sorted_by_flag_Name_amount)
            {
                if (current6.Key == "SD_Res")
                {
                    foreach (KeyValuePair<string, int> current7 in current6.Value)
                    {
                        string text5 = ".......................................................................................";
                        string text6 = " X ";
                        string text7 = " = ";
                        Storage_Resources[] storage_Resources = this.Storage.Storage_Resources;
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
            int num12 = (this.Dict_sorted_by_flag_Name_amount["Labour Hours"]["Labour Hours"] + num) * this.Storage.Storage_LabourHours[0].Price;
            int num13 = this.Dict_sorted_by_flag_Name_amount["Labour Hours"]["Labour Hours"] + num - this.Storage.Storage_LabourHours[0].Quantity - this.Storage.Storage_LabourHours[1].Quantity * 500;
            if (num13 < 0)
            {
                num13 = 0;
            }
            int num14 = num13 * this.Storage.Storage_LabourHours[0].Price;
            string str5 = (this.Dict_sorted_by_flag_Name_amount["Labour Hours"]["Labour Hours"] + num).ToString();
            string str6 = num13.ToString();
            if (this.checkBox_Craft_StoredLH.Checked)
            {
                this.label_Craft_Total_LH.Text = "Total Labour hours:  " + str6;
                this.label_Craft_TotalCost.Text = "TotalCost:  " + (num14 + num11).ToString() + "g";
            }
            else
            {
                this.label_Craft_Total_LH.Text = "Total Labour hours:  " + str5;
                this.label_Craft_TotalCost.Text = "TotalCost:  " + (num12 + num11).ToString() + "g";
            }
            string str7 = (this.Dict_sorted_by_flag_Name_amount["Craft XP"]["Craft XP"] + num2).ToString();
            this.label_Craft_GainXP.Text = "Total Craft XP:  " + str7;
            string text8 = ((this.Dict_sorted_by_flag_Name_amount["Craft XP"]["Craft XP"] + num2) / (this.Dict_sorted_by_flag_Name_amount["Labour Hours"]["Labour Hours"] + num)).ToString();
            if (text8.Length > 5)
            {
                text8 = text8.Remove(5);
            }
            this.label_Craft_efficiency.Text = "Efficiency:  " + text8;
            str += text;
            str3 = str3 + num2.ToString() + text;
            str2 = str2 + num.ToString() + text;
            str4 += text;
            this.textBox_Craft_Uneed.Text = str + text2;
        }

        private void func_Craft_Text_CanBuild()
        {
            this.textBox_Craft_CanBuild.Clear();
            this.SD_Craft_Name_Amount.Clear();
            string text = "To craft your order you will need:\r\n";
            string text2 = "\r\n-------------------\r\n";
            string text3 = "";
            string text4 = "You will gain:\r\n";
            string text5 = "Labour Hours:";
            string text6 = "Total weight:";
            int num = 0;
            double num2 = 0.0;
            foreach (int current in this.SDictionary_Craft_Order.Keys)
            {
                Craft_Order craft_Order = new Craft_Order();
                this.SDictionary_Craft_Order.TryGetValue(current, out craft_Order);
                if (craft_Order.Type == 0)
                {
                    foreach (string current2 in this.SDictionary_Craft_ShipRecipes.Keys)
                    {
                        if (current2 == craft_Order.Name)
                        {
                            RecipeShip recipeShip = new RecipeShip();
                            Ship ship = new Ship();
                            this.SDictionary_Craft_ShipRecipes.TryGetValue(current2, out recipeShip);
                            this.SD_ShipsTempates.TryGetValue(current2, out ship);
                            num += recipeShip.LaborPrice;
                            text4 = string.Concat(new object[]
                            {
                                text4,
                                this.comboBox_Craft_NewOrder_Quality.Items[craft_Order.Quality],
                                " ",
                                this.comboBox_Craft_NewOrder_Wood.Items[craft_Order.Woodtype],
                                " ",
                                craft_Order.Name,
                                " ",
                                this.comboBox_Craft_NewOrder_Trim.Items[craft_Order.Trim],
                                "\r\n"
                            });
                            Fullrequirement[] fullRequirements = recipeShip.FullRequirements;
                            for (int i = 0; i < fullRequirements.Length; i++)
                            {
                                Fullrequirement obj = fullRequirements[i];
                                this.SD_Craft_Name_Amount = this.func_SDict_From_FullRequirement(obj);
                            }
                            Requirement[] requirements = recipeShip.WoodTypeDescs[craft_Order.Woodtype].Requirements;
                            for (int i = 0; i < requirements.Length; i++)
                            {
                                Requirement obj2 = requirements[i];
                                this.SD_Craft_Name_Amount = this.func_SDict_From_Requirement(obj2);
                            }
                            requirements = recipeShip.Qualities[craft_Order.Quality].Requirements;
                            for (int i = 0; i < requirements.Length; i++)
                            {
                                Requirement obj3 = requirements[i];
                                this.SD_Craft_Name_Amount = this.func_SDict_From_Requirement(obj3);
                            }
                            if (craft_Order.Quality > 0)
                            {
                                List<string> list = new List<string>();
                                decimal d = craft_Order.Quality + 1;
                                int num3 = (int)(ship.ShipMass / 50 * (d / 2m));
                                int num4 = 0;
                                this.Dict_Craft_Trim_Extra.TryGetValue(this.comboBox_Craft_NewOrder_Trim.Items[craft_Order.Trim].ToString(), out list);
                                foreach (string current3 in list)
                                {
                                    num4 = 0;
                                    this.SD_Craft_Name_Amount.TryGetValue(current3, out num4);
                                    if (num4 > 0)
                                    {
                                        this.SD_Craft_Name_Amount.Remove(current3);
                                        int value = num4 + num3;
                                        this.SD_Craft_Name_Amount.Add(current3, value);
                                    }
                                    else
                                    {
                                        this.SD_Craft_Name_Amount.Add(current3, num3);
                                    }
                                }
                            }
                        }
                    }
                }
                if (craft_Order.Type == 1)
                {
                    foreach (string current4 in this.SDictionary_Craft_ModuleRecipes.Keys)
                    {
                        if (current4 == craft_Order.Name)
                        {
                            RecipeModule recipeModule = new RecipeModule();
                            this.SDictionary_Craft_ModuleRecipes.TryGetValue(current4, out recipeModule);
                            num += recipeModule.LaborPrice;
                            text4 = text4 + craft_Order.Name + "\r\n";
                            Fullrequirement[] fullRequirements = recipeModule.FullRequirements;
                            for (int i = 0; i < fullRequirements.Length; i++)
                            {
                                Fullrequirement obj4 = fullRequirements[i];
                                this.SD_Craft_Name_Amount = this.func_SDict_From_FullRequirement(obj4);
                            }
                            Requirement[] requirements = recipeModule.Qualities[craft_Order.Quality].Requirements;
                            for (int i = 0; i < requirements.Length; i++)
                            {
                                Requirement obj5 = requirements[i];
                                this.SD_Craft_Name_Amount = this.func_SDict_From_Requirement(obj5);
                            }
                        }
                    }
                }
                if (craft_Order.Type == 2)
                {
                    foreach (string current5 in this.SDictionary_Craft_Recipes.Keys)
                    {
                        if (current5 == craft_Order.Name)
                        {
                            Recipe recipe = new Recipe();
                            this.SDictionary_Craft_Recipes.TryGetValue(current5, out recipe);
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
                                this.SD_Craft_Name_Amount = this.func_SDict_From_FullRequirement(obj6);
                            }
                        }
                    }
                }
            }
            foreach (KeyValuePair<string, int> current6 in this.SD_Craft_Name_Amount)
            {
                Storage_Resources storage_Resources = new Storage_Resources();
                Storage_Materials storage_Materials = new Storage_Materials();
                if (this.SDictionary_Storage_Resource.Keys.Contains(current6.Key))
                {
                    this.SDictionary_Storage_Resource.TryGetValue(current6.Key, out storage_Resources);
                    num2 += (double)current6.Value * storage_Resources.ItemWeight;
                }
                if (this.SDictionary_Storage_Materials.Keys.Contains(current6.Key))
                {
                    this.SDictionary_Storage_Materials.TryGetValue(current6.Key, out storage_Materials);
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
            this.textBox_Craft_CanBuild.Text = string.Concat(new string[]
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
            this.textBox_Craft_Uneed.Clear();
            foreach (int current in this.SDictionary_Craft_Order.Keys)
            {
                Craft_Order craft_Order = new Craft_Order();
                this.SDictionary_Craft_Order.TryGetValue(current, out craft_Order);
                if (craft_Order.Type == 0)
                {
                    foreach (string current2 in this.SDictionary_Craft_ShipRecipes.Keys)
                    {
                        if (current2 == craft_Order.Name)
                        {
                            RecipeShip recipeShip = new RecipeShip();
                            this.SDictionary_Craft_ShipRecipes.TryGetValue(current2, out recipeShip);
                            string text = "--------\r\n" + recipeShip.Name + "\r\n--------";
                            Fullrequirement[] fullRequirements = recipeShip.FullRequirements;
                            for (int i = 0; i < fullRequirements.Length; i++)
                            {
                                Fullrequirement fullrequirement = fullRequirements[i];
                                string text2 = this.func_Get_Name_from_ID(fullrequirement.Template);
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
                                string text3 = this.func_Get_Name_from_ID(requirement.Template);
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
                                string text4 = this.func_Get_Name_from_ID(requirement2.Template);
                                text = string.Concat(new string[]
                                {
                                    text,
                                    "\r\n",
                                    text4,
                                    ":",
                                    requirement2.Amount.ToString()
                                });
                            }
                            this.textBox_Craft_Uneed.Text = this.textBox_Craft_Uneed.Text + text + "\r\n";
                        }
                    }
                }
                if (craft_Order.Type == 1)
                {
                    foreach (string current3 in this.SDictionary_Craft_ModuleRecipes.Keys)
                    {
                        if (current3 == craft_Order.Name)
                        {
                            RecipeModule recipeModule = new RecipeModule();
                            this.SDictionary_Craft_ModuleRecipes.TryGetValue(current3, out recipeModule);
                            string text5 = "--------\r\n" + recipeModule.Name + "\r\n--------";
                            Fullrequirement[] fullRequirements = recipeModule.FullRequirements;
                            for (int i = 0; i < fullRequirements.Length; i++)
                            {
                                Fullrequirement fullrequirement2 = fullRequirements[i];
                                string text6 = this.func_Get_Name_from_ID(fullrequirement2.Template);
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
                                string text7 = this.func_Get_Name_from_ID(requirement3.Template);
                                text5 = string.Concat(new string[]
                                {
                                    text5,
                                    "\r\n",
                                    text7,
                                    ":",
                                    requirement3.Amount.ToString()
                                });
                            }
                            this.textBox_Craft_Uneed.Text = this.textBox_Craft_Uneed.Text + text5 + "\r\n";
                        }
                    }
                }
                if (craft_Order.Type == 2)
                {
                    foreach (string current4 in this.SDictionary_Craft_Recipes.Keys)
                    {
                        if (current4 == craft_Order.Name)
                        {
                            Recipe recipe = new Recipe();
                            this.SDictionary_Craft_Recipes.TryGetValue(current4, out recipe);
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
                                string text9 = this.func_Get_Name_from_ID(fullrequirement3.Template);
                                text8 = string.Concat(new string[]
                                {
                                    text8,
                                    "\r\n",
                                    text9,
                                    ":",
                                    fullrequirement3.Amount.ToString()
                                });
                            }
                            this.textBox_Craft_Uneed.Text = this.textBox_Craft_Uneed.Text + text8 + "\r\n";
                        }
                    }
                }
            }
        }

        private SortedDictionary<string, int> func_SDict_From_Requirement(Requirement obj)
        {
            int num = 0;
            string key = this.func_Get_Name_from_ID(obj.Template);
            this.SD_Craft_Name_Amount.TryGetValue(key, out num);
            if (num > 0)
            {
                this.SD_Craft_Name_Amount.Remove(key);
                int value = num + obj.Amount;
                this.SD_Craft_Name_Amount.Add(key, value);
            }
            else
            {
                this.SD_Craft_Name_Amount.Add(key, obj.Amount);
            }
            return this.SD_Craft_Name_Amount;
        }

        private SortedDictionary<string, int> func_SDict_From_FullRequirement(Fullrequirement obj)
        {
            int num = 0;
            string key = this.func_Get_Name_from_ID(obj.Template);
            this.SD_Craft_Name_Amount.TryGetValue(key, out num);
            if (num > 0)
            {
                this.SD_Craft_Name_Amount.Remove(key);
                int value = num + obj.Amount;
                this.SD_Craft_Name_Amount.Add(key, value);
            }
            else
            {
                this.SD_Craft_Name_Amount.Add(key, obj.Amount);
            }
            return this.SD_Craft_Name_Amount;
        }

        private SortedDictionary<string, int> func_SDict_From_CR_FullRequirement(CR_Fullrequirement obj)
        {
            int num = 0;
            string key = this.func_Get_Name_from_ID(obj.Template);
            this.SD_Craft_Name_Amount.TryGetValue(key, out num);
            if (num > 0)
            {
                this.SD_Craft_Name_Amount.Remove(key);
                int value = num + obj.Amount;
                this.SD_Craft_Name_Amount.Add(key, value);
            }
            else
            {
                this.SD_Craft_Name_Amount.Add(key, obj.Amount);
            }
            return this.SD_Craft_Name_Amount;
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
                this.SD_Craft_Recipes_custom_sorted.TryGetValue(current.Key, out craft_Recipe);
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
                this.SD_Craft_Recipes_custom_sorted.TryGetValue(current2.Key, out craft_Recipe2);
                int num3 = (int)Math.Ceiling(current2.Value / craft_Recipe2.CR_Result[0].Amount);
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
                    string text = this.func_Get_Name_from_ID(cR_Fullrequirement2.Template);
                    Craft_Recipe craft_Recipe3 = new Craft_Recipe();
                    this.SD_Craft_Recipes_custom_sorted.TryGetValue(text, out craft_Recipe3);
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
                this.SD_Craft_Recipes_custom_sorted.TryGetValue(current3.Key, out craft_Recipe4);
                int num13 = (int)Math.Ceiling(current3.Value / craft_Recipe4.CR_Result[0].Amount);
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
                    string text2 = this.func_Get_Name_from_ID(cR_Fullrequirement3.Template);
                    Craft_Recipe craft_Recipe5 = new Craft_Recipe();
                    this.SD_Craft_Recipes_custom_sorted.TryGetValue(text2, out craft_Recipe5);
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
                this.SD_Craft_Recipes_custom_sorted.TryGetValue(current4.Key, out craft_Recipe6);
                int num21 = (int)Math.Ceiling(current4.Value / craft_Recipe6.CR_Result[0].Amount);
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
                    string text3 = this.func_Get_Name_from_ID(cR_Fullrequirement4.Template);
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
            foreach (KeyValuePair<string, Recipe> current in this.SDictionary_Craft_Recipes)
            {
                Craft_Recipe craft_Recipe = new Craft_Recipe();
                Recipe recipe = new Recipe();
                List<CR_Fullrequirement> list = new List<CR_Fullrequirement>();
                List<CR_Result> list2 = new List<CR_Result>();
                recipe = current.Value;
                string arg_4A_0 = current.Key;
                craft_Recipe.Id = this.func_Get_ID_from_Name(recipe.Name.Remove(recipe.Name.IndexOf(" Blueprint")));
                craft_Recipe.Name = this.func_Get_Name_from_ID(craft_Recipe.Id);
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
                        Name = this.func_Get_Name_from_ID(fullrequirement.Template)
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
                        Name = this.func_Get_Name_from_ID(result.Template)
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
                    using (SortedDictionary<string, Storage_Resources>.ValueCollection.Enumerator enumerator2 = this.SDictionary_Storage_Resource.Values.GetEnumerator())
                    {
                        while (enumerator2.MoveNext())
                        {
                            if (enumerator2.Current.Id == cR_Fullrequirement2.Template)
                            {
                                list.Add(0);
                            }
                        }
                    }
                    using (SortedDictionary<string, Storage_Materials>.ValueCollection.Enumerator enumerator3 = this.SDictionary_Storage_Materials.Values.GetEnumerator())
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
                        using (SortedDictionary<string, Storage_Materials>.ValueCollection.Enumerator enumerator3 = this.SDictionary_Storage_Materials.Values.GetEnumerator())
                        {
                            while (enumerator3.MoveNext())
                            {
                                if (enumerator3.Current.Id == cR_Fullrequirement3.Template && !sortedDictionary.Keys.Contains(cR_Fullrequirement3.Name))
                                {
                                    list.Add(-1);
                                }
                            }
                        }
                        using (SortedDictionary<string, Storage_Resources>.ValueCollection.Enumerator enumerator2 = this.SDictionary_Storage_Resource.Values.GetEnumerator())
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
            foreach (KeyValuePair<int, string> current in this.SDictionary_Info_IDtoName)
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
            foreach (KeyValuePair<int, string> current in this.SDictionary_Info_IDtoName)
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
            if (this.comboBox_Craft_NewOrder_Quality.SelectedIndex == 0)
            {
                this.comboBox_Craft_NewOrder_Quality.BackColor = Color.LightGray;
            }
            if (this.comboBox_Craft_NewOrder_Quality.SelectedIndex == 1)
            {
                this.comboBox_Craft_NewOrder_Quality.BackColor = Color.DarkSeaGreen;
            }
            if (this.comboBox_Craft_NewOrder_Quality.SelectedIndex == 2)
            {
                this.comboBox_Craft_NewOrder_Quality.BackColor = Color.LightBlue;
            }
            if (this.comboBox_Craft_NewOrder_Quality.SelectedIndex == 3)
            {
                this.comboBox_Craft_NewOrder_Quality.BackColor = Color.PaleVioletRed;
            }
            if (this.comboBox_Craft_NewOrder_Quality.SelectedIndex == 4)
            {
                this.comboBox_Craft_NewOrder_Quality.BackColor = Color.Gold;
            }
        }

        private void button_Craft_Order_Clear_Click(object sender, EventArgs e)
        {
            this.groupBox_Craft_Order.Controls.Clear();
            this.groupBox_Craft_Order.Size = new Size(223, 41);
            this.SDictionary_Craft_Order.Clear();
            this.SD_Craft_Name_Amount.Clear();
            this.textBox_Craft_Uneed.Clear();
            this.textBox_Craft_CanBuild.Clear();
            this.i_Craft_Add = 0;
            this.label_Craft_Total_LH.Text = "Total Labour hours:";
            this.label_Craft_GainXP.Text = "Total Craft XP:";
            this.label_Craft_efficiency.Text = "Efficiency:";
            this.label_Craft_TotalCost.Text = "TotalCost:";
        }

        private void Button_Craft_Order_Delete_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string key = "label_Craft_Ordered_" + button.Name.Remove(0, "button_Craft_Order_Delete_".Length);
            Control[] array = this.groupBox_Craft_Order.Controls.Find(key, true);
            for (int i = 0; i < array.Length; i++)
            {
                Control value = array[i];
                this.groupBox_Craft_Order.Controls.Remove(value);
            }
            string key2 = "button_Craft_Order_Delete_" + button.Text + (this.i_Craft_Add - 1).ToString();
            array = this.groupBox_Craft_Order.Controls.Find(key2, true);
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Enabled = true;
            }
            this.groupBox_Craft_Order.Controls.Remove(button);
            this.groupBox_Craft_Order.Size = new Size(this.groupBox_Craft_Order.Size.Width, 5 + button.Location.Y);
            this.groupBox_Craft_Order.Refresh();
            this.i_Craft_Add--;
        }

        private void checkBox_Craft_StoredLH_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SD_Craft_Name_Amount.Count > 0)
            {
                this.func_Craft_Text_Uneed();
            }
        }

        private void checkBox_Craft_StoredMats_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SD_Craft_Name_Amount.Count > 0)
            {
                this.func_Craft_Text_Uneed();
            }
        }

        private void checkBox_Craft_StoredRes_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SD_Craft_Name_Amount.Count > 0)
            {
                this.func_Craft_Text_Uneed();
            }
        }

        private void SpeedCurves_Graphics_Draw()
        {
            this.comboBox_SpeedCurves_YrShip.DataSource = this.SD_ShipsTempates.Keys.ToList<string>();
            this.comboBox_SpeedCurves_OpShip.DataSource = this.SD_ShipsTempates.Keys.ToList<string>();
            this.pictureBox_SpeedCurves_Base.Paint += new PaintEventHandler(this.DrawElipcesLines);
            this.pictureBox_SpeedCurves_Base.Refresh();
        }

        private void DrawElipcesLines(object sender, PaintEventArgs e)
        {
            Ship ship = new Ship();
            this.SD_ShipsTempates.TryGetValue(this.comboBox_SpeedCurves_YrShip.SelectedItem.ToString(), out ship);
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
            string s = this.numericUpDown_SpeedCurves_MaxKn.Value.ToString() + "kn";
            e.Graphics.DrawString(s, font, brush, new PointF(450f, 235f));
            string s2 = (this.numericUpDown_SpeedCurves_MaxKn.Value * 3m / 4m).ToString() + "kn";
            e.Graphics.DrawString(s2, font, brush, new PointF(400f, 235f));
            string s3 = (this.numericUpDown_SpeedCurves_MaxKn.Value * 2m / 4m).ToString() + "kn";
            e.Graphics.DrawString(s3, font, brush, new PointF(350f, 235f));
            string s4 = (this.numericUpDown_SpeedCurves_MaxKn.Value * decimal.One / 4m).ToString() + "kn";
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
            this.SD_ShipsTempates.TryGetValue(this.comboBox_SpeedCurves_YrShip.SelectedItem.ToString(), out ship);
            int num = ship.Specs.SpeedToWind.Count<float>() * 2 - 2;
            double num2 = 200.0 / (double)this.numericUpDown_SpeedCurves_MaxKn.Value / 10.0;
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
            this.SD_ShipsTempates.TryGetValue(this.comboBox_SpeedCurves_OpShip.SelectedItem.ToString(), out ship);
            int num = ship.Specs.SpeedToWind.Count<float>() * 2 - 2;
            double num2 = 200.0 / (double)this.numericUpDown_SpeedCurves_MaxKn.Value / 10.0;
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
            this.pictureBox_SpeedCurves_Base.Paint += new PaintEventHandler(this.DrawClosedCurvePointF_YrShip);
            this.pictureBox_SpeedCurves_Base.Refresh();
        }

        private void comboBox_SpeedCurves_OpShip_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pictureBox_SpeedCurves_Base.Paint += new PaintEventHandler(this.DrawClosedCurvePointF_OppShip);
            this.pictureBox_SpeedCurves_Base.Refresh();
        }

        private void numericUpDown_SpeedCurves_MaxKn_ValueChanged(object sender, EventArgs e)
        {
            this.pictureBox_SpeedCurves_Base.Refresh();
        }

        private void radioButton_Storage_All_CheckedChanged(object sender, EventArgs e)
        {
            this.func_Tab_Storage_filling();
        }

        private void radioButton_Storage_Craft_CheckedChanged(object sender, EventArgs e)
        {
            this.func_Tab_Storage_filling();
        }

        private void radioButton_Storage_Trade_CheckedChanged(object sender, EventArgs e)
        {
            this.func_Tab_Storage_filling();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
            this.comboBox_Info_Type = new ComboBox();
            this.label__Info_type = new Label();
            this.label_Info_Name = new Label();
            this.listBox_Info_Name = new ListBox();
            this.textBox_Info_Object = new TextBox();
            this.tabControl_NA_Tool = new TabControl();
            this.tabPage_Info = new TabPage();
            this.label_Info_ObjectDescription = new Label();
            this.label_Info_IdtoName = new Label();
            this.label_Info_Id = new Label();
            this.listBox_Info_IDtoName = new ListBox();
            this.tabPage_Storage = new TabPage();
            this.label1 = new Label();
            this.radioButton_Storage_Trade = new RadioButton();
            this.radioButton_Storage_Craft = new RadioButton();
            this.radioButton_Storage_All = new RadioButton();
            this.button_Storage_Save = new Button();
            this.button_Storage_Open = new Button();
            this.groupBox_Storage_ShipRecipes = new GroupBox();
            this.checkedListBox_Storage_ShipRecipes = new CheckedListBox();
            this.groupBox_Storage_Labour = new GroupBox();
            this.textBox_Storage_LH_LabourContracts_Price = new TextBox();
            this.label_Storage_LH_Price = new Label();
            this.label_Storage_LH_Quantity = new Label();
            this.textBox_Storage_LH_LabourHours_Price = new TextBox();
            this.textBox_Storage_LH_Labour_Contracts_Quantity = new TextBox();
            this.textBox_Storage_LH_Labour_Hours_Quantity = new TextBox();
            this.label_Storage_LH_Labour_Contracts = new Label();
            this.label_Storage_LH_Labour_Hours = new Label();
            this.groupBox_Storage_Resources = new GroupBox();
            this.label_Storage_Resources_AutoBuy = new Label();
            this.label_Storage_Resources_ItemWeight = new Label();
            this.label_Storage_Resources_BasePrice = new Label();
            this.label_Storage_Resources_Price = new Label();
            this.label_Storage_Resources_Quantity = new Label();
            this.label_Storage_Resources_Name = new Label();
            this.groupBox_Storage_Materials = new GroupBox();
            this.label_Storage_Materials_ItemWeight = new Label();
            this.label_Storage_Materials_BasePrice = new Label();
            this.label_Storage_Materials_Price = new Label();
            this.label_Storage_Materials_Quantity = new Label();
            this.label_Storage_Materials_Name = new Label();
            this.tabPage_Craft = new TabPage();
            this.button_Craft_Order_Clear = new Button();
            this.groupBox_Craft_NewOrder = new GroupBox();
            this.comboBox_Craft_NewOrder_Trim = new ComboBox();
            this.label_Craft_Trim = new Label();
            this.comboBox_Craft_NewOrder_Wood = new ComboBox();
            this.label_Craft_Wood = new Label();
            this.radioButton_Craft_Recipe = new RadioButton();
            this.button_Craft_Add = new Button();
            this.comboBox_Craft_NewOrder_Quality = new ComboBox();
            this.radioButton_Craft_Module = new RadioButton();
            this.radioButton_Craft_Ship = new RadioButton();
            this.label_Craft_Quality = new Label();
            this.comboBox_Craft_NewOrder_Name = new ComboBox();
            this.label_Craft_NewOrder_Name = new Label();
            this.groupBox_Craft_CanBuild = new GroupBox();
            this.textBox_Craft_CanBuild = new TextBox();
            this.groupBox_Craft_TotalNeeds = new GroupBox();
            this.textBox_Craft_Uneed = new TextBox();
            this.groupBox_Craft_Order = new GroupBox();
            this.groupBox_Craft_GeneralInfo = new GroupBox();
            this.label_Craft_efficiency = new Label();
            this.checkBox_Craft_StoredRes = new CheckBox();
            this.checkBox_Craft_StoredMats = new CheckBox();
            this.checkBox_Craft_StoredLH = new CheckBox();
            this.label_Craft_TotalCost = new Label();
            this.label_Craft_GainXP = new Label();
            this.label_Craft_Total_LH = new Label();
            this.label_Craft_ETA = new Label();
            this.tabPage_SPeedCurves = new TabPage();
            this.textBox2 = new TextBox();
            this.textBox1 = new TextBox();
            this.label_SpeedCurves_Scale = new Label();
            this.numericUpDown_SpeedCurves_MaxKn = new NumericUpDown();
            this.label_SpeedCurves_OpShip = new Label();
            this.comboBox_SpeedCurves_OpShip = new ComboBox();
            this.label_SpeedCurves_YrShip = new Label();
            this.comboBox_SpeedCurves_YrShip = new ComboBox();
            this.pictureBox_SpeedCurves_Base = new PictureBox();
            this.tabPage_Test = new TabPage();
            this.openFileDialog_Storage = new OpenFileDialog();
            this.saveFileDialog_Storage = new SaveFileDialog();
            this.numericUpDown1 = new NumericUpDown();
            this.tabControl_NA_Tool.SuspendLayout();
            this.tabPage_Info.SuspendLayout();
            this.tabPage_Storage.SuspendLayout();
            this.groupBox_Storage_ShipRecipes.SuspendLayout();
            this.groupBox_Storage_Labour.SuspendLayout();
            this.groupBox_Storage_Resources.SuspendLayout();
            this.groupBox_Storage_Materials.SuspendLayout();
            this.tabPage_Craft.SuspendLayout();
            this.groupBox_Craft_NewOrder.SuspendLayout();
            this.groupBox_Craft_CanBuild.SuspendLayout();
            this.groupBox_Craft_TotalNeeds.SuspendLayout();
            this.groupBox_Craft_GeneralInfo.SuspendLayout();
            this.tabPage_SPeedCurves.SuspendLayout();
            ((ISupportInitialize)this.numericUpDown_SpeedCurves_MaxKn).BeginInit();
            ((ISupportInitialize)this.pictureBox_SpeedCurves_Base).BeginInit();
            this.tabPage_Test.SuspendLayout();
            ((ISupportInitialize)this.numericUpDown1).BeginInit();
            base.SuspendLayout();
            this.comboBox_Info_Type.FormattingEnabled = true;
            this.comboBox_Info_Type.Location = new Point(9, 19);
            this.comboBox_Info_Type.Name = "comboBox_Info_Type";
            this.comboBox_Info_Type.Size = new Size(207, 21);
            this.comboBox_Info_Type.TabIndex = 0;
            this.label__Info_type.AutoSize = true;
            this.label__Info_type.Location = new Point(6, 3);
            this.label__Info_type.Name = "label__Info_type";
            this.label__Info_type.Size = new Size(51, 13);
            this.label__Info_type.TabIndex = 1;
            this.label__Info_type.Text = "ItemType";
            this.label_Info_Name.Location = new Point(6, 43);
            this.label_Info_Name.Name = "label_Info_Name";
            this.label_Info_Name.Size = new Size(35, 13);
            this.label_Info_Name.TabIndex = 2;
            this.label_Info_Name.Text = "Name:";
            this.listBox_Info_Name.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
            this.listBox_Info_Name.Enabled = false;
            this.listBox_Info_Name.FormattingEnabled = true;
            this.listBox_Info_Name.Items.AddRange(new object[]
            {
                "Choose item type..."
            });
            this.listBox_Info_Name.Location = new Point(6, 59);
            this.listBox_Info_Name.Name = "listBox_Info_Name";
            this.listBox_Info_Name.Size = new Size(207, 771);
            this.listBox_Info_Name.Sorted = true;
            this.listBox_Info_Name.TabIndex = 5;
            this.textBox_Info_Object.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.textBox_Info_Object.Location = new Point(222, 19);
            this.textBox_Info_Object.Multiline = true;
            this.textBox_Info_Object.Name = "textBox_Info_Object";
            this.textBox_Info_Object.ScrollBars = ScrollBars.Vertical;
            this.textBox_Info_Object.Size = new Size(550, 811);
            this.textBox_Info_Object.TabIndex = 7;
            this.tabControl_NA_Tool.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.tabControl_NA_Tool.Controls.Add(this.tabPage_Info);
            this.tabControl_NA_Tool.Controls.Add(this.tabPage_Storage);
            this.tabControl_NA_Tool.Controls.Add(this.tabPage_Craft);
            this.tabControl_NA_Tool.Controls.Add(this.tabPage_SPeedCurves);
            this.tabControl_NA_Tool.Controls.Add(this.tabPage_Test);
            this.tabControl_NA_Tool.Location = new Point(3, 12);
            this.tabControl_NA_Tool.Name = "tabControl_NA_Tool";
            this.tabControl_NA_Tool.SelectedIndex = 0;
            this.tabControl_NA_Tool.Size = new Size(1057, 863);
            this.tabControl_NA_Tool.TabIndex = 8;
            this.tabPage_Info.Controls.Add(this.label_Info_ObjectDescription);
            this.tabPage_Info.Controls.Add(this.label_Info_IdtoName);
            this.tabPage_Info.Controls.Add(this.label_Info_Id);
            this.tabPage_Info.Controls.Add(this.listBox_Info_IDtoName);
            this.tabPage_Info.Controls.Add(this.label__Info_type);
            this.tabPage_Info.Controls.Add(this.textBox_Info_Object);
            this.tabPage_Info.Controls.Add(this.comboBox_Info_Type);
            this.tabPage_Info.Controls.Add(this.listBox_Info_Name);
            this.tabPage_Info.Controls.Add(this.label_Info_Name);
            this.tabPage_Info.Location = new Point(4, 22);
            this.tabPage_Info.Name = "tabPage_Info";
            this.tabPage_Info.Padding = new Padding(3);
            this.tabPage_Info.Size = new Size(1049, 837);
            this.tabPage_Info.TabIndex = 0;
            this.tabPage_Info.Text = "Info";
            this.tabPage_Info.UseVisualStyleBackColor = true;
            this.label_Info_ObjectDescription.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
            this.label_Info_ObjectDescription.AutoSize = true;
            this.label_Info_ObjectDescription.Location = new Point(223, 4);
            this.label_Info_ObjectDescription.Name = "label_Info_ObjectDescription";
            this.label_Info_ObjectDescription.Size = new Size(95, 13);
            this.label_Info_ObjectDescription.TabIndex = 11;
            this.label_Info_ObjectDescription.Text = "Object description:";
            this.label_Info_IdtoName.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.label_Info_IdtoName.AutoSize = true;
            this.label_Info_IdtoName.Location = new Point(825, 8);
            this.label_Info_IdtoName.Name = "label_Info_IdtoName";
            this.label_Info_IdtoName.Size = new Size(38, 13);
            this.label_Info_IdtoName.TabIndex = 10;
            this.label_Info_IdtoName.Text = "Name:";
            this.label_Info_Id.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.label_Info_Id.AutoSize = true;
            this.label_Info_Id.Location = new Point(778, 8);
            this.label_Info_Id.Name = "label_Info_Id";
            this.label_Info_Id.Size = new Size(19, 13);
            this.label_Info_Id.TabIndex = 9;
            this.label_Info_Id.Text = "Id:";
            this.listBox_Info_IDtoName.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
            this.listBox_Info_IDtoName.FormattingEnabled = true;
            this.listBox_Info_IDtoName.Location = new Point(776, 21);
            this.listBox_Info_IDtoName.Name = "listBox_Info_IDtoName";
            this.listBox_Info_IDtoName.Size = new Size(267, 810);
            this.listBox_Info_IDtoName.TabIndex = 8;
            this.tabPage_Storage.AutoScroll = true;
            this.tabPage_Storage.Controls.Add(this.label1);
            this.tabPage_Storage.Controls.Add(this.radioButton_Storage_Trade);
            this.tabPage_Storage.Controls.Add(this.radioButton_Storage_Craft);
            this.tabPage_Storage.Controls.Add(this.radioButton_Storage_All);
            this.tabPage_Storage.Controls.Add(this.button_Storage_Save);
            this.tabPage_Storage.Controls.Add(this.button_Storage_Open);
            this.tabPage_Storage.Controls.Add(this.groupBox_Storage_ShipRecipes);
            this.tabPage_Storage.Controls.Add(this.groupBox_Storage_Labour);
            this.tabPage_Storage.Controls.Add(this.groupBox_Storage_Resources);
            this.tabPage_Storage.Controls.Add(this.groupBox_Storage_Materials);
            this.tabPage_Storage.Location = new Point(4, 22);
            this.tabPage_Storage.Name = "tabPage_Storage";
            this.tabPage_Storage.Padding = new Padding(3);
            this.tabPage_Storage.Size = new Size(1049, 837);
            this.tabPage_Storage.TabIndex = 1;
            this.tabPage_Storage.Text = "Storage_WIP";
            this.tabPage_Storage.UseVisualStyleBackColor = true;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Show resources:";
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            this.radioButton_Storage_Trade.AutoSize = true;
            this.radioButton_Storage_Trade.Location = new Point(199, 14);
            this.radioButton_Storage_Trade.Name = "radioButton_Storage_Trade";
            this.radioButton_Storage_Trade.Size = new Size(53, 17);
            this.radioButton_Storage_Trade.TabIndex = 15;
            this.radioButton_Storage_Trade.Text = "Trade";
            this.radioButton_Storage_Trade.UseVisualStyleBackColor = true;
            this.radioButton_Storage_Trade.CheckedChanged += new EventHandler(this.radioButton_Storage_Trade_CheckedChanged);
            this.radioButton_Storage_Craft.AutoSize = true;
            this.radioButton_Storage_Craft.Checked = true;
            this.radioButton_Storage_Craft.Location = new Point(146, 14);
            this.radioButton_Storage_Craft.Name = "radioButton_Storage_Craft";
            this.radioButton_Storage_Craft.Size = new Size(47, 17);
            this.radioButton_Storage_Craft.TabIndex = 14;
            this.radioButton_Storage_Craft.TabStop = true;
            this.radioButton_Storage_Craft.Text = "Craft";
            this.radioButton_Storage_Craft.UseVisualStyleBackColor = true;
            this.radioButton_Storage_Craft.CheckedChanged += new EventHandler(this.radioButton_Storage_Craft_CheckedChanged);
            this.radioButton_Storage_All.AutoSize = true;
            this.radioButton_Storage_All.Location = new Point(104, 14);
            this.radioButton_Storage_All.Name = "radioButton_Storage_All";
            this.radioButton_Storage_All.Size = new Size(36, 17);
            this.radioButton_Storage_All.TabIndex = 13;
            this.radioButton_Storage_All.Text = "All";
            this.radioButton_Storage_All.UseVisualStyleBackColor = true;
            this.radioButton_Storage_All.CheckedChanged += new EventHandler(this.radioButton_Storage_All_CheckedChanged);
            this.button_Storage_Save.Location = new Point(801, 6);
            this.button_Storage_Save.Name = "button_Storage_Save";
            this.button_Storage_Save.Size = new Size(75, 23);
            this.button_Storage_Save.TabIndex = 12;
            this.button_Storage_Save.Text = "Save";
            this.button_Storage_Save.UseVisualStyleBackColor = true;
            this.button_Storage_Save.Click += new EventHandler(this.button_Storage_Save_Click);
            this.button_Storage_Open.Location = new Point(425, 6);
            this.button_Storage_Open.Name = "button_Storage_Open";
            this.button_Storage_Open.Size = new Size(75, 23);
            this.button_Storage_Open.TabIndex = 11;
            this.button_Storage_Open.Text = "Open";
            this.button_Storage_Open.UseVisualStyleBackColor = true;
            this.button_Storage_Open.Click += new EventHandler(this.button_Storage_Open_Click);
            this.groupBox_Storage_ShipRecipes.Controls.Add(this.checkedListBox_Storage_ShipRecipes);
            this.groupBox_Storage_ShipRecipes.Enabled = false;
            this.groupBox_Storage_ShipRecipes.Location = new Point(801, 130);
            this.groupBox_Storage_ShipRecipes.Name = "groupBox_Storage_ShipRecipes";
            this.groupBox_Storage_ShipRecipes.Size = new Size(241, 704);
            this.groupBox_Storage_ShipRecipes.TabIndex = 9;
            this.groupBox_Storage_ShipRecipes.TabStop = false;
            this.groupBox_Storage_ShipRecipes.Text = "Ship Recipes:";
            this.checkedListBox_Storage_ShipRecipes.CheckOnClick = true;
            this.checkedListBox_Storage_ShipRecipes.Enabled = false;
            this.checkedListBox_Storage_ShipRecipes.FormattingEnabled = true;
            this.checkedListBox_Storage_ShipRecipes.Location = new Point(6, 19);
            this.checkedListBox_Storage_ShipRecipes.Name = "checkedListBox_Storage_ShipRecipes";
            this.checkedListBox_Storage_ShipRecipes.Size = new Size(229, 679);
            this.checkedListBox_Storage_ShipRecipes.Sorted = true;
            this.checkedListBox_Storage_ShipRecipes.TabIndex = 0;
            this.groupBox_Storage_Labour.Controls.Add(this.textBox_Storage_LH_LabourContracts_Price);
            this.groupBox_Storage_Labour.Controls.Add(this.label_Storage_LH_Price);
            this.groupBox_Storage_Labour.Controls.Add(this.label_Storage_LH_Quantity);
            this.groupBox_Storage_Labour.Controls.Add(this.textBox_Storage_LH_LabourHours_Price);
            this.groupBox_Storage_Labour.Controls.Add(this.textBox_Storage_LH_Labour_Contracts_Quantity);
            this.groupBox_Storage_Labour.Controls.Add(this.textBox_Storage_LH_Labour_Hours_Quantity);
            this.groupBox_Storage_Labour.Controls.Add(this.label_Storage_LH_Labour_Contracts);
            this.groupBox_Storage_Labour.Controls.Add(this.label_Storage_LH_Labour_Hours);
            this.groupBox_Storage_Labour.Location = new Point(801, 35);
            this.groupBox_Storage_Labour.Name = "groupBox_Storage_Labour";
            this.groupBox_Storage_Labour.Size = new Size(241, 89);
            this.groupBox_Storage_Labour.TabIndex = 8;
            this.groupBox_Storage_Labour.TabStop = false;
            this.groupBox_Storage_Labour.Text = "Labour Hours";
            this.textBox_Storage_LH_LabourContracts_Price.Location = new Point(167, 58);
            this.textBox_Storage_LH_LabourContracts_Price.Name = "textBox_Storage_LH_LabourContracts_Price";
            this.textBox_Storage_LH_LabourContracts_Price.Size = new Size(60, 20);
            this.textBox_Storage_LH_LabourContracts_Price.TabIndex = 7;
            this.textBox_Storage_LH_LabourContracts_Price.Text = "0";
            this.label_Storage_LH_Price.AutoSize = true;
            this.label_Storage_LH_Price.Location = new Point(170, 13);
            this.label_Storage_LH_Price.Name = "label_Storage_LH_Price";
            this.label_Storage_LH_Price.Size = new Size(34, 13);
            this.label_Storage_LH_Price.TabIndex = 6;
            this.label_Storage_LH_Price.Text = "Price:";
            this.label_Storage_LH_Quantity.AutoSize = true;
            this.label_Storage_LH_Quantity.Location = new Point(115, 13);
            this.label_Storage_LH_Quantity.Name = "label_Storage_LH_Quantity";
            this.label_Storage_LH_Quantity.Size = new Size(49, 13);
            this.label_Storage_LH_Quantity.TabIndex = 5;
            this.label_Storage_LH_Quantity.Text = "Quantity:";
            this.textBox_Storage_LH_LabourHours_Price.Location = new Point(167, 32);
            this.textBox_Storage_LH_LabourHours_Price.Name = "textBox_Storage_LH_LabourHours_Price";
            this.textBox_Storage_LH_LabourHours_Price.Size = new Size(60, 20);
            this.textBox_Storage_LH_LabourHours_Price.TabIndex = 4;
            this.textBox_Storage_LH_LabourHours_Price.Text = "0";
            this.textBox_Storage_LH_Labour_Contracts_Quantity.Location = new Point(115, 58);
            this.textBox_Storage_LH_Labour_Contracts_Quantity.Name = "textBox_Storage_LH_Labour_Contracts_Quantity";
            this.textBox_Storage_LH_Labour_Contracts_Quantity.Size = new Size(46, 20);
            this.textBox_Storage_LH_Labour_Contracts_Quantity.TabIndex = 3;
            this.textBox_Storage_LH_Labour_Contracts_Quantity.Text = "0";
            this.textBox_Storage_LH_Labour_Contracts_Quantity.TextAlign = HorizontalAlignment.Center;
            this.textBox_Storage_LH_Labour_Hours_Quantity.Location = new Point(115, 32);
            this.textBox_Storage_LH_Labour_Hours_Quantity.Name = "textBox_Storage_LH_Labour_Hours_Quantity";
            this.textBox_Storage_LH_Labour_Hours_Quantity.Size = new Size(46, 20);
            this.textBox_Storage_LH_Labour_Hours_Quantity.TabIndex = 2;
            this.textBox_Storage_LH_Labour_Hours_Quantity.Text = "0";
            this.textBox_Storage_LH_Labour_Hours_Quantity.TextAlign = HorizontalAlignment.Center;
            this.label_Storage_LH_Labour_Contracts.AutoSize = true;
            this.label_Storage_LH_Labour_Contracts.Location = new Point(7, 61);
            this.label_Storage_LH_Labour_Contracts.Name = "label_Storage_LH_Labour_Contracts";
            this.label_Storage_LH_Labour_Contracts.Size = new Size(91, 13);
            this.label_Storage_LH_Labour_Contracts.TabIndex = 1;
            this.label_Storage_LH_Labour_Contracts.Text = "Labour Contracts:";
            this.label_Storage_LH_Labour_Hours.AutoSize = true;
            this.label_Storage_LH_Labour_Hours.Location = new Point(7, 35);
            this.label_Storage_LH_Labour_Hours.Name = "label_Storage_LH_Labour_Hours";
            this.label_Storage_LH_Labour_Hours.Size = new Size(74, 13);
            this.label_Storage_LH_Labour_Hours.TabIndex = 0;
            this.label_Storage_LH_Labour_Hours.Text = "Labour Hours:";
            this.groupBox_Storage_Resources.Controls.Add(this.label_Storage_Resources_AutoBuy);
            this.groupBox_Storage_Resources.Controls.Add(this.label_Storage_Resources_ItemWeight);
            this.groupBox_Storage_Resources.Controls.Add(this.label_Storage_Resources_BasePrice);
            this.groupBox_Storage_Resources.Controls.Add(this.label_Storage_Resources_Price);
            this.groupBox_Storage_Resources.Controls.Add(this.label_Storage_Resources_Quantity);
            this.groupBox_Storage_Resources.Controls.Add(this.label_Storage_Resources_Name);
            this.groupBox_Storage_Resources.Location = new Point(6, 35);
            this.groupBox_Storage_Resources.Name = "groupBox_Storage_Resources";
            this.groupBox_Storage_Resources.Size = new Size(413, 40);
            this.groupBox_Storage_Resources.TabIndex = 7;
            this.groupBox_Storage_Resources.TabStop = false;
            this.groupBox_Storage_Resources.Text = "Resources";
            this.label_Storage_Resources_AutoBuy.Location = new Point(329, 20);
            this.label_Storage_Resources_AutoBuy.Name = "label_Storage_Resources_AutoBuy";
            this.label_Storage_Resources_AutoBuy.Size = new Size(74, 13);
            this.label_Storage_Resources_AutoBuy.TabIndex = 5;
            this.label_Storage_Resources_AutoBuy.Text = "Auto Fill Price:";
            this.label_Storage_Resources_AutoBuy.TextAlign = ContentAlignment.MiddleCenter;
            this.label_Storage_Resources_ItemWeight.Location = new Point(279, 20);
            this.label_Storage_Resources_ItemWeight.Name = "label_Storage_Resources_ItemWeight";
            this.label_Storage_Resources_ItemWeight.Size = new Size(44, 13);
            this.label_Storage_Resources_ItemWeight.TabIndex = 4;
            this.label_Storage_Resources_ItemWeight.Text = "Weight:";
            this.label_Storage_Resources_ItemWeight.TextAlign = ContentAlignment.MiddleCenter;
            this.label_Storage_Resources_BasePrice.Location = new Point(212, 20);
            this.label_Storage_Resources_BasePrice.Name = "label_Storage_Resources_BasePrice";
            this.label_Storage_Resources_BasePrice.Size = new Size(61, 13);
            this.label_Storage_Resources_BasePrice.TabIndex = 3;
            this.label_Storage_Resources_BasePrice.Text = "Base Price:";
            this.label_Storage_Resources_BasePrice.TextAlign = ContentAlignment.MiddleCenter;
            this.label_Storage_Resources_Price.AutoSize = true;
            this.label_Storage_Resources_Price.Location = new Point(172, 20);
            this.label_Storage_Resources_Price.Name = "label_Storage_Resources_Price";
            this.label_Storage_Resources_Price.Size = new Size(34, 13);
            this.label_Storage_Resources_Price.TabIndex = 2;
            this.label_Storage_Resources_Price.Text = "Price:";
            this.label_Storage_Resources_Quantity.AutoSize = true;
            this.label_Storage_Resources_Quantity.Location = new Point(117, 20);
            this.label_Storage_Resources_Quantity.Name = "label_Storage_Resources_Quantity";
            this.label_Storage_Resources_Quantity.Size = new Size(49, 13);
            this.label_Storage_Resources_Quantity.TabIndex = 1;
            this.label_Storage_Resources_Quantity.Text = "Quantity:";
            this.label_Storage_Resources_Name.Location = new Point(6, 20);
            this.label_Storage_Resources_Name.Name = "label_Storage_Resources_Name";
            this.label_Storage_Resources_Name.Size = new Size(105, 13);
            this.label_Storage_Resources_Name.TabIndex = 0;
            this.label_Storage_Resources_Name.Text = "Name:";
            this.label_Storage_Resources_Name.TextAlign = ContentAlignment.MiddleCenter;
            this.groupBox_Storage_Materials.Controls.Add(this.label_Storage_Materials_ItemWeight);
            this.groupBox_Storage_Materials.Controls.Add(this.label_Storage_Materials_BasePrice);
            this.groupBox_Storage_Materials.Controls.Add(this.label_Storage_Materials_Price);
            this.groupBox_Storage_Materials.Controls.Add(this.label_Storage_Materials_Quantity);
            this.groupBox_Storage_Materials.Controls.Add(this.label_Storage_Materials_Name);
            this.groupBox_Storage_Materials.Location = new Point(425, 35);
            this.groupBox_Storage_Materials.Name = "groupBox_Storage_Materials";
            this.groupBox_Storage_Materials.Size = new Size(370, 40);
            this.groupBox_Storage_Materials.TabIndex = 4;
            this.groupBox_Storage_Materials.TabStop = false;
            this.groupBox_Storage_Materials.Text = "Materials";
            this.label_Storage_Materials_ItemWeight.AutoSize = true;
            this.label_Storage_Materials_ItemWeight.Location = new Point(320, 20);
            this.label_Storage_Materials_ItemWeight.Name = "label_Storage_Materials_ItemWeight";
            this.label_Storage_Materials_ItemWeight.Size = new Size(44, 13);
            this.label_Storage_Materials_ItemWeight.TabIndex = 4;
            this.label_Storage_Materials_ItemWeight.Text = "Weight:";
            this.label_Storage_Materials_BasePrice.AutoSize = true;
            this.label_Storage_Materials_BasePrice.Location = new Point(253, 20);
            this.label_Storage_Materials_BasePrice.Name = "label_Storage_Materials_BasePrice";
            this.label_Storage_Materials_BasePrice.Size = new Size(61, 13);
            this.label_Storage_Materials_BasePrice.TabIndex = 3;
            this.label_Storage_Materials_BasePrice.Text = "Base Price:";
            this.label_Storage_Materials_Price.AutoSize = true;
            this.label_Storage_Materials_Price.Location = new Point(213, 20);
            this.label_Storage_Materials_Price.Name = "label_Storage_Materials_Price";
            this.label_Storage_Materials_Price.Size = new Size(34, 13);
            this.label_Storage_Materials_Price.TabIndex = 2;
            this.label_Storage_Materials_Price.Text = "Price:";
            this.label_Storage_Materials_Quantity.AutoSize = true;
            this.label_Storage_Materials_Quantity.Location = new Point(151, 20);
            this.label_Storage_Materials_Quantity.Name = "label_Storage_Materials_Quantity";
            this.label_Storage_Materials_Quantity.Size = new Size(49, 13);
            this.label_Storage_Materials_Quantity.TabIndex = 1;
            this.label_Storage_Materials_Quantity.Text = "Quantity:";
            this.label_Storage_Materials_Name.AutoSize = true;
            this.label_Storage_Materials_Name.Location = new Point(6, 20);
            this.label_Storage_Materials_Name.Name = "label_Storage_Materials_Name";
            this.label_Storage_Materials_Name.Size = new Size(38, 13);
            this.label_Storage_Materials_Name.TabIndex = 0;
            this.label_Storage_Materials_Name.Text = "Name:";
            this.tabPage_Craft.Controls.Add(this.button_Craft_Order_Clear);
            this.tabPage_Craft.Controls.Add(this.groupBox_Craft_NewOrder);
            this.tabPage_Craft.Controls.Add(this.groupBox_Craft_CanBuild);
            this.tabPage_Craft.Controls.Add(this.groupBox_Craft_TotalNeeds);
            this.tabPage_Craft.Controls.Add(this.groupBox_Craft_Order);
            this.tabPage_Craft.Controls.Add(this.groupBox_Craft_GeneralInfo);
            this.tabPage_Craft.Location = new Point(4, 22);
            this.tabPage_Craft.Name = "tabPage_Craft";
            this.tabPage_Craft.Size = new Size(1049, 837);
            this.tabPage_Craft.TabIndex = 2;
            this.tabPage_Craft.Text = "Craft_WIP";
            this.tabPage_Craft.UseVisualStyleBackColor = true;
            this.button_Craft_Order_Clear.Location = new Point(23, 463);
            this.button_Craft_Order_Clear.Name = "button_Craft_Order_Clear";
            this.button_Craft_Order_Clear.Size = new Size(185, 37);
            this.button_Craft_Order_Clear.TabIndex = 20;
            this.button_Craft_Order_Clear.Text = "Clear";
            this.button_Craft_Order_Clear.UseVisualStyleBackColor = true;
            this.button_Craft_Order_Clear.Click += new EventHandler(this.button_Craft_Order_Clear_Click);
            this.groupBox_Craft_NewOrder.Controls.Add(this.comboBox_Craft_NewOrder_Trim);
            this.groupBox_Craft_NewOrder.Controls.Add(this.label_Craft_Trim);
            this.groupBox_Craft_NewOrder.Controls.Add(this.comboBox_Craft_NewOrder_Wood);
            this.groupBox_Craft_NewOrder.Controls.Add(this.label_Craft_Wood);
            this.groupBox_Craft_NewOrder.Controls.Add(this.radioButton_Craft_Recipe);
            this.groupBox_Craft_NewOrder.Controls.Add(this.button_Craft_Add);
            this.groupBox_Craft_NewOrder.Controls.Add(this.comboBox_Craft_NewOrder_Quality);
            this.groupBox_Craft_NewOrder.Controls.Add(this.radioButton_Craft_Module);
            this.groupBox_Craft_NewOrder.Controls.Add(this.radioButton_Craft_Ship);
            this.groupBox_Craft_NewOrder.Controls.Add(this.label_Craft_Quality);
            this.groupBox_Craft_NewOrder.Controls.Add(this.comboBox_Craft_NewOrder_Name);
            this.groupBox_Craft_NewOrder.Controls.Add(this.label_Craft_NewOrder_Name);
            this.groupBox_Craft_NewOrder.Location = new Point(5, 3);
            this.groupBox_Craft_NewOrder.Name = "groupBox_Craft_NewOrder";
            this.groupBox_Craft_NewOrder.Size = new Size(223, 254);
            this.groupBox_Craft_NewOrder.TabIndex = 16;
            this.groupBox_Craft_NewOrder.TabStop = false;
            this.groupBox_Craft_NewOrder.Text = "Add new order";
            this.comboBox_Craft_NewOrder_Trim.BackColor = Color.White;
            this.comboBox_Craft_NewOrder_Trim.FormattingEnabled = true;
            this.comboBox_Craft_NewOrder_Trim.Items.AddRange(new object[]
            {
                "Random",
                "Build Strength",
                "Crew Space",
                "Planking",
                "Rigging Quality",
                "Speed",
                "Stiffness"
            });
            this.comboBox_Craft_NewOrder_Trim.Location = new Point(58, 177);
            this.comboBox_Craft_NewOrder_Trim.Name = "comboBox_Craft_NewOrder_Trim";
            this.comboBox_Craft_NewOrder_Trim.Size = new Size(159, 21);
            this.comboBox_Craft_NewOrder_Trim.TabIndex = 21;
            this.label_Craft_Trim.AutoSize = true;
            this.label_Craft_Trim.BackColor = Color.Transparent;
            this.label_Craft_Trim.Location = new Point(6, 180);
            this.label_Craft_Trim.Name = "label_Craft_Trim";
            this.label_Craft_Trim.Size = new Size(30, 13);
            this.label_Craft_Trim.TabIndex = 20;
            this.label_Craft_Trim.Text = "Trim:";
            this.comboBox_Craft_NewOrder_Wood.BackColor = Color.White;
            this.comboBox_Craft_NewOrder_Wood.FormattingEnabled = true;
            this.comboBox_Craft_NewOrder_Wood.Items.AddRange(new object[]
            {
                "Fir",
                "Oak",
                "Teak",
                "Live Oak",
                "Mahogany",
                "Bermuda Cedar"
            });
            this.comboBox_Craft_NewOrder_Wood.Location = new Point(58, 150);
            this.comboBox_Craft_NewOrder_Wood.Name = "comboBox_Craft_NewOrder_Wood";
            this.comboBox_Craft_NewOrder_Wood.Size = new Size(159, 21);
            this.comboBox_Craft_NewOrder_Wood.TabIndex = 19;
            this.label_Craft_Wood.AutoSize = true;
            this.label_Craft_Wood.BackColor = Color.Transparent;
            this.label_Craft_Wood.Location = new Point(6, 153);
            this.label_Craft_Wood.Name = "label_Craft_Wood";
            this.label_Craft_Wood.Size = new Size(36, 13);
            this.label_Craft_Wood.TabIndex = 18;
            this.label_Craft_Wood.Text = "Wood";
            this.radioButton_Craft_Recipe.AutoSize = true;
            this.radioButton_Craft_Recipe.Location = new Point(6, 65);
            this.radioButton_Craft_Recipe.Name = "radioButton_Craft_Recipe";
            this.radioButton_Craft_Recipe.Size = new Size(59, 17);
            this.radioButton_Craft_Recipe.TabIndex = 17;
            this.radioButton_Craft_Recipe.Text = "Recipe";
            this.radioButton_Craft_Recipe.UseVisualStyleBackColor = true;
            this.radioButton_Craft_Recipe.CheckedChanged += new EventHandler(this.radioButton_Craft_Recipe_CheckedChanged);
            this.button_Craft_Add.Location = new Point(18, 204);
            this.button_Craft_Add.Name = "button_Craft_Add";
            this.button_Craft_Add.Size = new Size(185, 37);
            this.button_Craft_Add.TabIndex = 14;
            this.button_Craft_Add.Text = "Add";
            this.button_Craft_Add.UseVisualStyleBackColor = true;
            this.button_Craft_Add.Click += new EventHandler(this.button_Craft_Add_Click);
            this.comboBox_Craft_NewOrder_Quality.BackColor = Color.White;
            this.comboBox_Craft_NewOrder_Quality.FormattingEnabled = true;
            this.comboBox_Craft_NewOrder_Quality.Items.AddRange(new object[]
            {
                "Basic",
                "Common",
                "Fine",
                "Mastercraft",
                "Exceptional"
            });
            this.comboBox_Craft_NewOrder_Quality.Location = new Point(58, 123);
            this.comboBox_Craft_NewOrder_Quality.Name = "comboBox_Craft_NewOrder_Quality";
            this.comboBox_Craft_NewOrder_Quality.Size = new Size(159, 21);
            this.comboBox_Craft_NewOrder_Quality.TabIndex = 13;
            this.comboBox_Craft_NewOrder_Quality.SelectedIndexChanged += new EventHandler(this.comboBox_Craft_NewOrder_Quality_SelectedIndexChanged);
            this.radioButton_Craft_Module.AutoSize = true;
            this.radioButton_Craft_Module.Location = new Point(6, 42);
            this.radioButton_Craft_Module.Name = "radioButton_Craft_Module";
            this.radioButton_Craft_Module.Size = new Size(60, 17);
            this.radioButton_Craft_Module.TabIndex = 16;
            this.radioButton_Craft_Module.Text = "Module";
            this.radioButton_Craft_Module.UseVisualStyleBackColor = true;
            this.radioButton_Craft_Module.CheckedChanged += new EventHandler(this.radioButton_Craft_Module_CheckedChanged);
            this.radioButton_Craft_Ship.AutoSize = true;
            this.radioButton_Craft_Ship.Location = new Point(6, 19);
            this.radioButton_Craft_Ship.Name = "radioButton_Craft_Ship";
            this.radioButton_Craft_Ship.Size = new Size(46, 17);
            this.radioButton_Craft_Ship.TabIndex = 15;
            this.radioButton_Craft_Ship.Text = "Ship";
            this.radioButton_Craft_Ship.UseVisualStyleBackColor = true;
            this.radioButton_Craft_Ship.CheckedChanged += new EventHandler(this.radioButton_Craft_Ship_CheckedChanged);
            this.label_Craft_Quality.AutoSize = true;
            this.label_Craft_Quality.BackColor = Color.Transparent;
            this.label_Craft_Quality.Location = new Point(6, 126);
            this.label_Craft_Quality.Name = "label_Craft_Quality";
            this.label_Craft_Quality.Size = new Size(39, 13);
            this.label_Craft_Quality.TabIndex = 12;
            this.label_Craft_Quality.Text = "Quality";
            this.comboBox_Craft_NewOrder_Name.FormattingEnabled = true;
            this.comboBox_Craft_NewOrder_Name.Location = new Point(58, 96);
            this.comboBox_Craft_NewOrder_Name.Name = "comboBox_Craft_NewOrder_Name";
            this.comboBox_Craft_NewOrder_Name.Size = new Size(159, 21);
            this.comboBox_Craft_NewOrder_Name.TabIndex = 10;
            this.label_Craft_NewOrder_Name.AutoSize = true;
            this.label_Craft_NewOrder_Name.Location = new Point(6, 99);
            this.label_Craft_NewOrder_Name.Name = "label_Craft_NewOrder_Name";
            this.label_Craft_NewOrder_Name.Size = new Size(38, 13);
            this.label_Craft_NewOrder_Name.TabIndex = 11;
            this.label_Craft_NewOrder_Name.Text = "Name:";
            this.groupBox_Craft_CanBuild.Controls.Add(this.textBox_Craft_CanBuild);
            this.groupBox_Craft_CanBuild.Location = new Point(234, 3);
            this.groupBox_Craft_CanBuild.Name = "groupBox_Craft_CanBuild";
            this.groupBox_Craft_CanBuild.Size = new Size(290, 831);
            this.groupBox_Craft_CanBuild.TabIndex = 19;
            this.groupBox_Craft_CanBuild.TabStop = false;
            this.groupBox_Craft_CanBuild.Text = "Can build:";
            this.textBox_Craft_CanBuild.Location = new Point(6, 19);
            this.textBox_Craft_CanBuild.Multiline = true;
            this.textBox_Craft_CanBuild.Name = "textBox_Craft_CanBuild";
            this.textBox_Craft_CanBuild.Size = new Size(279, 806);
            this.textBox_Craft_CanBuild.TabIndex = 1;
            this.groupBox_Craft_TotalNeeds.Controls.Add(this.textBox_Craft_Uneed);
            this.groupBox_Craft_TotalNeeds.Location = new Point(530, 3);
            this.groupBox_Craft_TotalNeeds.Name = "groupBox_Craft_TotalNeeds";
            this.groupBox_Craft_TotalNeeds.Size = new Size(291, 831);
            this.groupBox_Craft_TotalNeeds.TabIndex = 18;
            this.groupBox_Craft_TotalNeeds.TabStop = false;
            this.groupBox_Craft_TotalNeeds.Text = "You need:";
            this.textBox_Craft_Uneed.Location = new Point(6, 19);
            this.textBox_Craft_Uneed.Multiline = true;
            this.textBox_Craft_Uneed.Name = "textBox_Craft_Uneed";
            this.textBox_Craft_Uneed.Size = new Size(279, 806);
            this.textBox_Craft_Uneed.TabIndex = 0;
            this.groupBox_Craft_Order.Location = new Point(5, 506);
            this.groupBox_Craft_Order.Name = "groupBox_Craft_Order";
            this.groupBox_Craft_Order.Size = new Size(223, 41);
            this.groupBox_Craft_Order.TabIndex = 17;
            this.groupBox_Craft_Order.TabStop = false;
            this.groupBox_Craft_Order.Text = "Your order:";
            this.groupBox_Craft_GeneralInfo.Controls.Add(this.label_Craft_efficiency);
            this.groupBox_Craft_GeneralInfo.Controls.Add(this.checkBox_Craft_StoredRes);
            this.groupBox_Craft_GeneralInfo.Controls.Add(this.checkBox_Craft_StoredMats);
            this.groupBox_Craft_GeneralInfo.Controls.Add(this.checkBox_Craft_StoredLH);
            this.groupBox_Craft_GeneralInfo.Controls.Add(this.label_Craft_TotalCost);
            this.groupBox_Craft_GeneralInfo.Controls.Add(this.label_Craft_GainXP);
            this.groupBox_Craft_GeneralInfo.Controls.Add(this.label_Craft_Total_LH);
            this.groupBox_Craft_GeneralInfo.Controls.Add(this.label_Craft_ETA);
            this.groupBox_Craft_GeneralInfo.Location = new Point(5, 263);
            this.groupBox_Craft_GeneralInfo.Name = "groupBox_Craft_GeneralInfo";
            this.groupBox_Craft_GeneralInfo.Size = new Size(223, 194);
            this.groupBox_Craft_GeneralInfo.TabIndex = 16;
            this.groupBox_Craft_GeneralInfo.TabStop = false;
            this.groupBox_Craft_GeneralInfo.Text = "General info";
            this.label_Craft_efficiency.AutoSize = true;
            this.label_Craft_efficiency.Location = new Point(3, 150);
            this.label_Craft_efficiency.Name = "label_Craft_efficiency";
            this.label_Craft_efficiency.Size = new Size(62, 13);
            this.label_Craft_efficiency.TabIndex = 22;
            this.label_Craft_efficiency.Text = "Efficiency:  ";
            this.checkBox_Craft_StoredRes.AutoSize = true;
            this.checkBox_Craft_StoredRes.Location = new Point(6, 18);
            this.checkBox_Craft_StoredRes.Name = "checkBox_Craft_StoredRes";
            this.checkBox_Craft_StoredRes.Size = new Size(132, 17);
            this.checkBox_Craft_StoredRes.TabIndex = 6;
            this.checkBox_Craft_StoredRes.Text = "Use stored resources?";
            this.checkBox_Craft_StoredRes.UseVisualStyleBackColor = true;
            this.checkBox_Craft_StoredRes.CheckedChanged += new EventHandler(this.checkBox_Craft_StoredRes_CheckedChanged);
            this.checkBox_Craft_StoredMats.AutoSize = true;
            this.checkBox_Craft_StoredMats.Location = new Point(6, 41);
            this.checkBox_Craft_StoredMats.Name = "checkBox_Craft_StoredMats";
            this.checkBox_Craft_StoredMats.Size = new Size(127, 17);
            this.checkBox_Craft_StoredMats.TabIndex = 2;
            this.checkBox_Craft_StoredMats.Text = "Use stored materials?";
            this.checkBox_Craft_StoredMats.UseVisualStyleBackColor = true;
            this.checkBox_Craft_StoredMats.CheckedChanged += new EventHandler(this.checkBox_Craft_StoredMats_CheckedChanged);
            this.checkBox_Craft_StoredLH.AutoSize = true;
            this.checkBox_Craft_StoredLH.Location = new Point(6, 64);
            this.checkBox_Craft_StoredLH.Name = "checkBox_Craft_StoredLH";
            this.checkBox_Craft_StoredLH.Size = new Size(144, 17);
            this.checkBox_Craft_StoredLH.TabIndex = 3;
            this.checkBox_Craft_StoredLH.Text = "Use stored labour hours?";
            this.checkBox_Craft_StoredLH.UseVisualStyleBackColor = true;
            this.checkBox_Craft_StoredLH.CheckedChanged += new EventHandler(this.checkBox_Craft_StoredLH_CheckedChanged);
            this.label_Craft_TotalCost.AutoSize = true;
            this.label_Craft_TotalCost.Location = new Point(3, 172);
            this.label_Craft_TotalCost.Name = "label_Craft_TotalCost";
            this.label_Craft_TotalCost.Size = new Size(61, 13);
            this.label_Craft_TotalCost.TabIndex = 0;
            this.label_Craft_TotalCost.Text = "TotalCost:  ";
            this.label_Craft_GainXP.AutoSize = true;
            this.label_Craft_GainXP.Location = new Point(3, 106);
            this.label_Craft_GainXP.Name = "label_Craft_GainXP";
            this.label_Craft_GainXP.Size = new Size(82, 13);
            this.label_Craft_GainXP.TabIndex = 21;
            this.label_Craft_GainXP.Text = "Total Craft XP:  ";
            this.label_Craft_Total_LH.AutoSize = true;
            this.label_Craft_Total_LH.Location = new Point(3, 128);
            this.label_Craft_Total_LH.Name = "label_Craft_Total_LH";
            this.label_Craft_Total_LH.Size = new Size(105, 13);
            this.label_Craft_Total_LH.TabIndex = 4;
            this.label_Craft_Total_LH.Text = "Total Labour hours:  ";
            this.label_Craft_ETA.AutoSize = true;
            this.label_Craft_ETA.Location = new Point(3, 194);
            this.label_Craft_ETA.Name = "label_Craft_ETA";
            this.label_Craft_ETA.Size = new Size(82, 13);
            this.label_Craft_ETA.TabIndex = 1;
            this.label_Craft_ETA.Text = "Estimated Time:";
            this.tabPage_SPeedCurves.Controls.Add(this.textBox2);
            this.tabPage_SPeedCurves.Controls.Add(this.textBox1);
            this.tabPage_SPeedCurves.Controls.Add(this.label_SpeedCurves_Scale);
            this.tabPage_SPeedCurves.Controls.Add(this.numericUpDown_SpeedCurves_MaxKn);
            this.tabPage_SPeedCurves.Controls.Add(this.label_SpeedCurves_OpShip);
            this.tabPage_SPeedCurves.Controls.Add(this.comboBox_SpeedCurves_OpShip);
            this.tabPage_SPeedCurves.Controls.Add(this.label_SpeedCurves_YrShip);
            this.tabPage_SPeedCurves.Controls.Add(this.comboBox_SpeedCurves_YrShip);
            this.tabPage_SPeedCurves.Controls.Add(this.pictureBox_SpeedCurves_Base);
            this.tabPage_SPeedCurves.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Underline, GraphicsUnit.Point, 204);
            this.tabPage_SPeedCurves.Location = new Point(4, 22);
            this.tabPage_SPeedCurves.Name = "tabPage_SPeedCurves";
            this.tabPage_SPeedCurves.Size = new Size(1049, 837);
            this.tabPage_SPeedCurves.TabIndex = 3;
            this.tabPage_SPeedCurves.Text = "Speed Curves_WIP";
            this.tabPage_SPeedCurves.UseVisualStyleBackColor = true;
            this.textBox2.BackColor = Color.Red;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new Point(638, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(19, 20);
            this.textBox2.TabIndex = 9;
            this.textBox1.BackColor = Color.Green;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new Point(638, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(19, 20);
            this.textBox1.TabIndex = 8;
            this.label_SpeedCurves_Scale.AutoSize = true;
            this.label_SpeedCurves_Scale.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.label_SpeedCurves_Scale.Location = new Point(663, 35);
            this.label_SpeedCurves_Scale.Name = "label_SpeedCurves_Scale";
            this.label_SpeedCurves_Scale.Size = new Size(67, 13);
            this.label_SpeedCurves_Scale.TabIndex = 7;
            this.label_SpeedCurves_Scale.Text = "Scale to:(kn)";
            this.numericUpDown_SpeedCurves_MaxKn.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            NumericUpDown arg_2C1A_0 = this.numericUpDown_SpeedCurves_MaxKn;
            int[] expr_2C11 = new int[4];
            expr_2C11[0] = 4;
            arg_2C1A_0.Increment = new decimal(expr_2C11);
            this.numericUpDown_SpeedCurves_MaxKn.Location = new Point(736, 32);
            NumericUpDown arg_2C4C_0 = this.numericUpDown_SpeedCurves_MaxKn;
            int[] expr_2C42 = new int[4];
            expr_2C42[0] = 28;
            arg_2C4C_0.Maximum = new decimal(expr_2C42);
            this.numericUpDown_SpeedCurves_MaxKn.Name = "numericUpDown_SpeedCurves_MaxKn";
            this.numericUpDown_SpeedCurves_MaxKn.Size = new Size(45, 20);
            this.numericUpDown_SpeedCurves_MaxKn.TabIndex = 6;
            NumericUpDown arg_2C97_0 = this.numericUpDown_SpeedCurves_MaxKn;
            int[] expr_2C8D = new int[4];
            expr_2C8D[0] = 16;
            arg_2C97_0.Value = new decimal(expr_2C8D);
            this.numericUpDown_SpeedCurves_MaxKn.ValueChanged += new EventHandler(this.numericUpDown_SpeedCurves_MaxKn_ValueChanged);
            this.label_SpeedCurves_OpShip.AutoSize = true;
            this.label_SpeedCurves_OpShip.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.label_SpeedCurves_OpShip.Location = new Point(511, 78);
            this.label_SpeedCurves_OpShip.Name = "label_SpeedCurves_OpShip";
            this.label_SpeedCurves_OpShip.Size = new Size(117, 13);
            this.label_SpeedCurves_OpShip.TabIndex = 5;
            this.label_SpeedCurves_OpShip.Text = "Select opponent's ship:";
            this.comboBox_SpeedCurves_OpShip.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.comboBox_SpeedCurves_OpShip.FormattingEnabled = true;
            this.comboBox_SpeedCurves_OpShip.Location = new Point(511, 94);
            this.comboBox_SpeedCurves_OpShip.Name = "comboBox_SpeedCurves_OpShip";
            this.comboBox_SpeedCurves_OpShip.Size = new Size(121, 21);
            this.comboBox_SpeedCurves_OpShip.TabIndex = 4;
            this.comboBox_SpeedCurves_OpShip.SelectedIndexChanged += new EventHandler(this.comboBox_SpeedCurves_OpShip_SelectedIndexChanged);
            this.label_SpeedCurves_YrShip.AutoSize = true;
            this.label_SpeedCurves_YrShip.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.label_SpeedCurves_YrShip.Location = new Point(511, 17);
            this.label_SpeedCurves_YrShip.Name = "label_SpeedCurves_YrShip";
            this.label_SpeedCurves_YrShip.Size = new Size(85, 13);
            this.label_SpeedCurves_YrShip.TabIndex = 3;
            this.label_SpeedCurves_YrShip.Text = "Select your ship:";
            this.comboBox_SpeedCurves_YrShip.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.comboBox_SpeedCurves_YrShip.FormattingEnabled = true;
            this.comboBox_SpeedCurves_YrShip.Location = new Point(511, 33);
            this.comboBox_SpeedCurves_YrShip.Name = "comboBox_SpeedCurves_YrShip";
            this.comboBox_SpeedCurves_YrShip.Size = new Size(121, 21);
            this.comboBox_SpeedCurves_YrShip.TabIndex = 2;
            this.comboBox_SpeedCurves_YrShip.SelectedIndexChanged += new EventHandler(this.comboBox_SpeedCurves_YrShip_SelectedIndexChanged);
            this.pictureBox_SpeedCurves_Base.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBox_SpeedCurves_Base.Location = new Point(5, 3);
            this.pictureBox_SpeedCurves_Base.Name = "pictureBox_SpeedCurves_Base";
            this.pictureBox_SpeedCurves_Base.Size = new Size(500, 500);
            this.pictureBox_SpeedCurves_Base.TabIndex = 1;
            this.pictureBox_SpeedCurves_Base.TabStop = false;
            this.tabPage_Test.Controls.Add(this.numericUpDown1);
            this.tabPage_Test.Location = new Point(4, 22);
            this.tabPage_Test.Name = "tabPage_Test";
            this.tabPage_Test.Size = new Size(1049, 837);
            this.tabPage_Test.TabIndex = 4;
            this.tabPage_Test.Text = "Test";
            this.tabPage_Test.UseVisualStyleBackColor = true;
            this.openFileDialog_Storage.FileName = "openFileDialog1";
            this.openFileDialog_Storage.Filter = "JSON files(*.json)|*.json|All files(*.*)|*.*";
            this.saveFileDialog_Storage.Filter = "JSON files(*.json)|*.json|All files(*.*)|*.*";
            this.numericUpDown1.Location = new Point(298, 175);
            NumericUpDown arg_300F_0 = this.numericUpDown1;
            int[] expr_3002 = new int[4];
            expr_3002[0] = 100000000;
            arg_300F_0.Maximum = new decimal(expr_3002);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.AutoScroll = true;
            base.ClientSize = new Size(1081, 887);
            base.Controls.Add(this.tabControl_NA_Tool);
            base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            base.Name = "Form1";
            this.Text = "Nick Mickelson's Toolbox";
            this.tabControl_NA_Tool.ResumeLayout(false);
            this.tabPage_Info.ResumeLayout(false);
            this.tabPage_Info.PerformLayout();
            this.tabPage_Storage.ResumeLayout(false);
            this.tabPage_Storage.PerformLayout();
            this.groupBox_Storage_ShipRecipes.ResumeLayout(false);
            this.groupBox_Storage_Labour.ResumeLayout(false);
            this.groupBox_Storage_Labour.PerformLayout();
            this.groupBox_Storage_Resources.ResumeLayout(false);
            this.groupBox_Storage_Resources.PerformLayout();
            this.groupBox_Storage_Materials.ResumeLayout(false);
            this.groupBox_Storage_Materials.PerformLayout();
            this.tabPage_Craft.ResumeLayout(false);
            this.groupBox_Craft_NewOrder.ResumeLayout(false);
            this.groupBox_Craft_NewOrder.PerformLayout();
            this.groupBox_Craft_CanBuild.ResumeLayout(false);
            this.groupBox_Craft_CanBuild.PerformLayout();
            this.groupBox_Craft_TotalNeeds.ResumeLayout(false);
            this.groupBox_Craft_TotalNeeds.PerformLayout();
            this.groupBox_Craft_GeneralInfo.ResumeLayout(false);
            this.groupBox_Craft_GeneralInfo.PerformLayout();
            this.tabPage_SPeedCurves.ResumeLayout(false);
            this.tabPage_SPeedCurves.PerformLayout();
            ((ISupportInitialize)this.numericUpDown_SpeedCurves_MaxKn).EndInit();
            ((ISupportInitialize)this.pictureBox_SpeedCurves_Base).EndInit();
            this.tabPage_Test.ResumeLayout(false);
            ((ISupportInitialize)this.numericUpDown1).EndInit();
            base.ResumeLayout(false);
        }
    }
}
