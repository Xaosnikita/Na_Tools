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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox_Info_Type = new System.Windows.Forms.ComboBox();
            this.label__Info_type = new System.Windows.Forms.Label();
            this.label_Info_Name = new System.Windows.Forms.Label();
            this.listBox_Info_Name = new System.Windows.Forms.ListBox();
            this.textBox_Info_Object = new System.Windows.Forms.TextBox();
            this.tabControl_NA_Tool = new System.Windows.Forms.TabControl();
            this.tabPage_Info = new System.Windows.Forms.TabPage();
            this.label_Info_ObjectDescription = new System.Windows.Forms.Label();
            this.label_Info_IdtoName = new System.Windows.Forms.Label();
            this.label_Info_Id = new System.Windows.Forms.Label();
            this.listBox_Info_IDtoName = new System.Windows.Forms.ListBox();
            this.tabPage_Storage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_Storage_Trade = new System.Windows.Forms.RadioButton();
            this.radioButton_Storage_Craft = new System.Windows.Forms.RadioButton();
            this.radioButton_Storage_All = new System.Windows.Forms.RadioButton();
            this.button_Storage_Save = new System.Windows.Forms.Button();
            this.button_Storage_Open = new System.Windows.Forms.Button();
            this.groupBox_Storage_ShipRecipes = new System.Windows.Forms.GroupBox();
            this.checkedListBox_Storage_ShipRecipes = new System.Windows.Forms.CheckedListBox();
            this.groupBox_Storage_Labour = new System.Windows.Forms.GroupBox();
            this.textBox_Storage_LH_LabourContracts_Price = new System.Windows.Forms.TextBox();
            this.label_Storage_LH_Price = new System.Windows.Forms.Label();
            this.label_Storage_LH_Quantity = new System.Windows.Forms.Label();
            this.textBox_Storage_LH_LabourHours_Price = new System.Windows.Forms.TextBox();
            this.textBox_Storage_LH_Labour_Contracts_Quantity = new System.Windows.Forms.TextBox();
            this.textBox_Storage_LH_Labour_Hours_Quantity = new System.Windows.Forms.TextBox();
            this.label_Storage_LH_Labour_Contracts = new System.Windows.Forms.Label();
            this.label_Storage_LH_Labour_Hours = new System.Windows.Forms.Label();
            this.groupBox_Storage_Resources = new System.Windows.Forms.GroupBox();
            this.label_Storage_Resources_AutoBuy = new System.Windows.Forms.Label();
            this.label_Storage_Resources_ItemWeight = new System.Windows.Forms.Label();
            this.label_Storage_Resources_BasePrice = new System.Windows.Forms.Label();
            this.label_Storage_Resources_Price = new System.Windows.Forms.Label();
            this.label_Storage_Resources_Quantity = new System.Windows.Forms.Label();
            this.label_Storage_Resources_Name = new System.Windows.Forms.Label();
            this.groupBox_Storage_Materials = new System.Windows.Forms.GroupBox();
            this.label_Storage_Materials_ItemWeight = new System.Windows.Forms.Label();
            this.label_Storage_Materials_BasePrice = new System.Windows.Forms.Label();
            this.label_Storage_Materials_Price = new System.Windows.Forms.Label();
            this.label_Storage_Materials_Quantity = new System.Windows.Forms.Label();
            this.label_Storage_Materials_Name = new System.Windows.Forms.Label();
            this.tabPage_Craft = new System.Windows.Forms.TabPage();
            this.button_Craft_Order_Clear = new System.Windows.Forms.Button();
            this.groupBox_Craft_NewOrder = new System.Windows.Forms.GroupBox();
            this.comboBox_Craft_NewOrder_Trim = new System.Windows.Forms.ComboBox();
            this.label_Craft_Trim = new System.Windows.Forms.Label();
            this.comboBox_Craft_NewOrder_Wood = new System.Windows.Forms.ComboBox();
            this.label_Craft_Wood = new System.Windows.Forms.Label();
            this.radioButton_Craft_Recipe = new System.Windows.Forms.RadioButton();
            this.button_Craft_Add = new System.Windows.Forms.Button();
            this.comboBox_Craft_NewOrder_Quality = new System.Windows.Forms.ComboBox();
            this.radioButton_Craft_Module = new System.Windows.Forms.RadioButton();
            this.radioButton_Craft_Ship = new System.Windows.Forms.RadioButton();
            this.label_Craft_Quality = new System.Windows.Forms.Label();
            this.comboBox_Craft_NewOrder_Name = new System.Windows.Forms.ComboBox();
            this.label_Craft_NewOrder_Name = new System.Windows.Forms.Label();
            this.groupBox_Craft_CanBuild = new System.Windows.Forms.GroupBox();
            this.textBox_Craft_CanBuild = new System.Windows.Forms.TextBox();
            this.groupBox_Craft_TotalNeeds = new System.Windows.Forms.GroupBox();
            this.textBox_Craft_Uneed = new System.Windows.Forms.TextBox();
            this.groupBox_Craft_Order = new System.Windows.Forms.GroupBox();
            this.groupBox_Craft_GeneralInfo = new System.Windows.Forms.GroupBox();
            this.label_Craft_efficiency = new System.Windows.Forms.Label();
            this.checkBox_Craft_StoredRes = new System.Windows.Forms.CheckBox();
            this.checkBox_Craft_StoredMats = new System.Windows.Forms.CheckBox();
            this.checkBox_Craft_StoredLH = new System.Windows.Forms.CheckBox();
            this.label_Craft_TotalCost = new System.Windows.Forms.Label();
            this.label_Craft_GainXP = new System.Windows.Forms.Label();
            this.label_Craft_Total_LH = new System.Windows.Forms.Label();
            this.label_Craft_ETA = new System.Windows.Forms.Label();
            this.tabPage_SPeedCurves = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_SpeedCurves_Scale = new System.Windows.Forms.Label();
            this.numericUpDown_SpeedCurves_MaxKn = new System.Windows.Forms.NumericUpDown();
            this.label_SpeedCurves_OpShip = new System.Windows.Forms.Label();
            this.comboBox_SpeedCurves_OpShip = new System.Windows.Forms.ComboBox();
            this.label_SpeedCurves_YrShip = new System.Windows.Forms.Label();
            this.comboBox_SpeedCurves_YrShip = new System.Windows.Forms.ComboBox();
            this.pictureBox_SpeedCurves_Base = new System.Windows.Forms.PictureBox();
            this.tabPage_Test = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog_Storage = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_Storage = new System.Windows.Forms.SaveFileDialog();
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SpeedCurves_MaxKn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SpeedCurves_Base)).BeginInit();
            this.tabPage_Test.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Info_Type
            // 
            this.comboBox_Info_Type.FormattingEnabled = true;
            this.comboBox_Info_Type.Location = new System.Drawing.Point(9, 19);
            this.comboBox_Info_Type.Name = "comboBox_Info_Type";
            this.comboBox_Info_Type.Size = new System.Drawing.Size(207, 21);
            this.comboBox_Info_Type.TabIndex = 0;
            // 
            // label__Info_type
            // 
            this.label__Info_type.AutoSize = true;
            this.label__Info_type.Location = new System.Drawing.Point(6, 3);
            this.label__Info_type.Name = "label__Info_type";
            this.label__Info_type.Size = new System.Drawing.Size(51, 13);
            this.label__Info_type.TabIndex = 1;
            this.label__Info_type.Text = "ItemType";
            // 
            // label_Info_Name
            // 
            this.label_Info_Name.Location = new System.Drawing.Point(6, 43);
            this.label_Info_Name.Name = "label_Info_Name";
            this.label_Info_Name.Size = new System.Drawing.Size(35, 13);
            this.label_Info_Name.TabIndex = 2;
            this.label_Info_Name.Text = "Name:";
            // 
            // listBox_Info_Name
            // 
            this.listBox_Info_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_Info_Name.Enabled = false;
            this.listBox_Info_Name.FormattingEnabled = true;
            this.listBox_Info_Name.Items.AddRange(new object[] {
            "Choose item type..."});
            this.listBox_Info_Name.Location = new System.Drawing.Point(6, 59);
            this.listBox_Info_Name.Name = "listBox_Info_Name";
            this.listBox_Info_Name.Size = new System.Drawing.Size(207, 771);
            this.listBox_Info_Name.Sorted = true;
            this.listBox_Info_Name.TabIndex = 5;
            // 
            // textBox_Info_Object
            // 
            this.textBox_Info_Object.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Info_Object.Location = new System.Drawing.Point(222, 19);
            this.textBox_Info_Object.Multiline = true;
            this.textBox_Info_Object.Name = "textBox_Info_Object";
            this.textBox_Info_Object.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Info_Object.Size = new System.Drawing.Size(550, 811);
            this.textBox_Info_Object.TabIndex = 7;
            // 
            // tabControl_NA_Tool
            // 
            this.tabControl_NA_Tool.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_NA_Tool.Controls.Add(this.tabPage_Info);
            this.tabControl_NA_Tool.Controls.Add(this.tabPage_Storage);
            this.tabControl_NA_Tool.Controls.Add(this.tabPage_Craft);
            this.tabControl_NA_Tool.Controls.Add(this.tabPage_SPeedCurves);
            this.tabControl_NA_Tool.Controls.Add(this.tabPage_Test);
            this.tabControl_NA_Tool.Location = new System.Drawing.Point(3, 12);
            this.tabControl_NA_Tool.Name = "tabControl_NA_Tool";
            this.tabControl_NA_Tool.SelectedIndex = 0;
            this.tabControl_NA_Tool.Size = new System.Drawing.Size(1057, 863);
            this.tabControl_NA_Tool.TabIndex = 8;
            // 
            // tabPage_Info
            // 
            this.tabPage_Info.Controls.Add(this.label_Info_ObjectDescription);
            this.tabPage_Info.Controls.Add(this.label_Info_IdtoName);
            this.tabPage_Info.Controls.Add(this.label_Info_Id);
            this.tabPage_Info.Controls.Add(this.listBox_Info_IDtoName);
            this.tabPage_Info.Controls.Add(this.label__Info_type);
            this.tabPage_Info.Controls.Add(this.textBox_Info_Object);
            this.tabPage_Info.Controls.Add(this.comboBox_Info_Type);
            this.tabPage_Info.Controls.Add(this.listBox_Info_Name);
            this.tabPage_Info.Controls.Add(this.label_Info_Name);
            this.tabPage_Info.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Info.Name = "tabPage_Info";
            this.tabPage_Info.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Info.Size = new System.Drawing.Size(1049, 837);
            this.tabPage_Info.TabIndex = 0;
            this.tabPage_Info.Text = "Info";
            this.tabPage_Info.UseVisualStyleBackColor = true;
            // 
            // label_Info_ObjectDescription
            // 
            this.label_Info_ObjectDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Info_ObjectDescription.AutoSize = true;
            this.label_Info_ObjectDescription.Location = new System.Drawing.Point(223, 4);
            this.label_Info_ObjectDescription.Name = "label_Info_ObjectDescription";
            this.label_Info_ObjectDescription.Size = new System.Drawing.Size(95, 13);
            this.label_Info_ObjectDescription.TabIndex = 11;
            this.label_Info_ObjectDescription.Text = "Object description:";
            // 
            // label_Info_IdtoName
            // 
            this.label_Info_IdtoName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Info_IdtoName.AutoSize = true;
            this.label_Info_IdtoName.Location = new System.Drawing.Point(825, 8);
            this.label_Info_IdtoName.Name = "label_Info_IdtoName";
            this.label_Info_IdtoName.Size = new System.Drawing.Size(38, 13);
            this.label_Info_IdtoName.TabIndex = 10;
            this.label_Info_IdtoName.Text = "Name:";
            // 
            // label_Info_Id
            // 
            this.label_Info_Id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Info_Id.AutoSize = true;
            this.label_Info_Id.Location = new System.Drawing.Point(778, 8);
            this.label_Info_Id.Name = "label_Info_Id";
            this.label_Info_Id.Size = new System.Drawing.Size(19, 13);
            this.label_Info_Id.TabIndex = 9;
            this.label_Info_Id.Text = "Id:";
            // 
            // listBox_Info_IDtoName
            // 
            this.listBox_Info_IDtoName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_Info_IDtoName.FormattingEnabled = true;
            this.listBox_Info_IDtoName.Location = new System.Drawing.Point(776, 21);
            this.listBox_Info_IDtoName.Name = "listBox_Info_IDtoName";
            this.listBox_Info_IDtoName.Size = new System.Drawing.Size(267, 810);
            this.listBox_Info_IDtoName.TabIndex = 8;
            // 
            // tabPage_Storage
            // 
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
            this.tabPage_Storage.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Storage.Name = "tabPage_Storage";
            this.tabPage_Storage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Storage.Size = new System.Drawing.Size(1049, 837);
            this.tabPage_Storage.TabIndex = 1;
            this.tabPage_Storage.Text = "Storage_WIP";
            this.tabPage_Storage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Show resources:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton_Storage_Trade
            // 
            this.radioButton_Storage_Trade.AutoSize = true;
            this.radioButton_Storage_Trade.Location = new System.Drawing.Point(199, 14);
            this.radioButton_Storage_Trade.Name = "radioButton_Storage_Trade";
            this.radioButton_Storage_Trade.Size = new System.Drawing.Size(53, 17);
            this.radioButton_Storage_Trade.TabIndex = 15;
            this.radioButton_Storage_Trade.Text = "Trade";
            this.radioButton_Storage_Trade.UseVisualStyleBackColor = true;
            this.radioButton_Storage_Trade.CheckedChanged += new System.EventHandler(this.radioButton_Storage_Trade_CheckedChanged);
            // 
            // radioButton_Storage_Craft
            // 
            this.radioButton_Storage_Craft.AutoSize = true;
            this.radioButton_Storage_Craft.Checked = true;
            this.radioButton_Storage_Craft.Location = new System.Drawing.Point(146, 14);
            this.radioButton_Storage_Craft.Name = "radioButton_Storage_Craft";
            this.radioButton_Storage_Craft.Size = new System.Drawing.Size(47, 17);
            this.radioButton_Storage_Craft.TabIndex = 14;
            this.radioButton_Storage_Craft.TabStop = true;
            this.radioButton_Storage_Craft.Text = "Craft";
            this.radioButton_Storage_Craft.UseVisualStyleBackColor = true;
            this.radioButton_Storage_Craft.CheckedChanged += new System.EventHandler(this.radioButton_Storage_Craft_CheckedChanged);
            // 
            // radioButton_Storage_All
            // 
            this.radioButton_Storage_All.AutoSize = true;
            this.radioButton_Storage_All.Location = new System.Drawing.Point(104, 14);
            this.radioButton_Storage_All.Name = "radioButton_Storage_All";
            this.radioButton_Storage_All.Size = new System.Drawing.Size(36, 17);
            this.radioButton_Storage_All.TabIndex = 13;
            this.radioButton_Storage_All.Text = "All";
            this.radioButton_Storage_All.UseVisualStyleBackColor = true;
            this.radioButton_Storage_All.CheckedChanged += new System.EventHandler(this.radioButton_Storage_All_CheckedChanged);
            // 
            // button_Storage_Save
            // 
            this.button_Storage_Save.Location = new System.Drawing.Point(801, 6);
            this.button_Storage_Save.Name = "button_Storage_Save";
            this.button_Storage_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Storage_Save.TabIndex = 12;
            this.button_Storage_Save.Text = "Save";
            this.button_Storage_Save.UseVisualStyleBackColor = true;
            this.button_Storage_Save.Click += new System.EventHandler(this.button_Storage_Save_Click);
            // 
            // button_Storage_Open
            // 
            this.button_Storage_Open.Location = new System.Drawing.Point(425, 6);
            this.button_Storage_Open.Name = "button_Storage_Open";
            this.button_Storage_Open.Size = new System.Drawing.Size(75, 23);
            this.button_Storage_Open.TabIndex = 11;
            this.button_Storage_Open.Text = "Open";
            this.button_Storage_Open.UseVisualStyleBackColor = true;
            this.button_Storage_Open.Click += new System.EventHandler(this.button_Storage_Open_Click);
            // 
            // groupBox_Storage_ShipRecipes
            // 
            this.groupBox_Storage_ShipRecipes.Controls.Add(this.checkedListBox_Storage_ShipRecipes);
            this.groupBox_Storage_ShipRecipes.Enabled = false;
            this.groupBox_Storage_ShipRecipes.Location = new System.Drawing.Point(801, 130);
            this.groupBox_Storage_ShipRecipes.Name = "groupBox_Storage_ShipRecipes";
            this.groupBox_Storage_ShipRecipes.Size = new System.Drawing.Size(241, 704);
            this.groupBox_Storage_ShipRecipes.TabIndex = 9;
            this.groupBox_Storage_ShipRecipes.TabStop = false;
            this.groupBox_Storage_ShipRecipes.Text = "Ship Recipes:";
            // 
            // checkedListBox_Storage_ShipRecipes
            // 
            this.checkedListBox_Storage_ShipRecipes.CheckOnClick = true;
            this.checkedListBox_Storage_ShipRecipes.Enabled = false;
            this.checkedListBox_Storage_ShipRecipes.FormattingEnabled = true;
            this.checkedListBox_Storage_ShipRecipes.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox_Storage_ShipRecipes.Name = "checkedListBox_Storage_ShipRecipes";
            this.checkedListBox_Storage_ShipRecipes.Size = new System.Drawing.Size(229, 679);
            this.checkedListBox_Storage_ShipRecipes.Sorted = true;
            this.checkedListBox_Storage_ShipRecipes.TabIndex = 0;
            // 
            // groupBox_Storage_Labour
            // 
            this.groupBox_Storage_Labour.Controls.Add(this.textBox_Storage_LH_LabourContracts_Price);
            this.groupBox_Storage_Labour.Controls.Add(this.label_Storage_LH_Price);
            this.groupBox_Storage_Labour.Controls.Add(this.label_Storage_LH_Quantity);
            this.groupBox_Storage_Labour.Controls.Add(this.textBox_Storage_LH_LabourHours_Price);
            this.groupBox_Storage_Labour.Controls.Add(this.textBox_Storage_LH_Labour_Contracts_Quantity);
            this.groupBox_Storage_Labour.Controls.Add(this.textBox_Storage_LH_Labour_Hours_Quantity);
            this.groupBox_Storage_Labour.Controls.Add(this.label_Storage_LH_Labour_Contracts);
            this.groupBox_Storage_Labour.Controls.Add(this.label_Storage_LH_Labour_Hours);
            this.groupBox_Storage_Labour.Location = new System.Drawing.Point(801, 35);
            this.groupBox_Storage_Labour.Name = "groupBox_Storage_Labour";
            this.groupBox_Storage_Labour.Size = new System.Drawing.Size(241, 89);
            this.groupBox_Storage_Labour.TabIndex = 8;
            this.groupBox_Storage_Labour.TabStop = false;
            this.groupBox_Storage_Labour.Text = "Labour Hours";
            // 
            // textBox_Storage_LH_LabourContracts_Price
            // 
            this.textBox_Storage_LH_LabourContracts_Price.Location = new System.Drawing.Point(167, 58);
            this.textBox_Storage_LH_LabourContracts_Price.Name = "textBox_Storage_LH_LabourContracts_Price";
            this.textBox_Storage_LH_LabourContracts_Price.Size = new System.Drawing.Size(60, 20);
            this.textBox_Storage_LH_LabourContracts_Price.TabIndex = 7;
            this.textBox_Storage_LH_LabourContracts_Price.Text = "0";
            // 
            // label_Storage_LH_Price
            // 
            this.label_Storage_LH_Price.AutoSize = true;
            this.label_Storage_LH_Price.Location = new System.Drawing.Point(170, 13);
            this.label_Storage_LH_Price.Name = "label_Storage_LH_Price";
            this.label_Storage_LH_Price.Size = new System.Drawing.Size(34, 13);
            this.label_Storage_LH_Price.TabIndex = 6;
            this.label_Storage_LH_Price.Text = "Price:";
            // 
            // label_Storage_LH_Quantity
            // 
            this.label_Storage_LH_Quantity.AutoSize = true;
            this.label_Storage_LH_Quantity.Location = new System.Drawing.Point(115, 13);
            this.label_Storage_LH_Quantity.Name = "label_Storage_LH_Quantity";
            this.label_Storage_LH_Quantity.Size = new System.Drawing.Size(49, 13);
            this.label_Storage_LH_Quantity.TabIndex = 5;
            this.label_Storage_LH_Quantity.Text = "Quantity:";
            // 
            // textBox_Storage_LH_LabourHours_Price
            // 
            this.textBox_Storage_LH_LabourHours_Price.Location = new System.Drawing.Point(167, 32);
            this.textBox_Storage_LH_LabourHours_Price.Name = "textBox_Storage_LH_LabourHours_Price";
            this.textBox_Storage_LH_LabourHours_Price.Size = new System.Drawing.Size(60, 20);
            this.textBox_Storage_LH_LabourHours_Price.TabIndex = 4;
            this.textBox_Storage_LH_LabourHours_Price.Text = "0";
            // 
            // textBox_Storage_LH_Labour_Contracts_Quantity
            // 
            this.textBox_Storage_LH_Labour_Contracts_Quantity.Location = new System.Drawing.Point(115, 58);
            this.textBox_Storage_LH_Labour_Contracts_Quantity.Name = "textBox_Storage_LH_Labour_Contracts_Quantity";
            this.textBox_Storage_LH_Labour_Contracts_Quantity.Size = new System.Drawing.Size(46, 20);
            this.textBox_Storage_LH_Labour_Contracts_Quantity.TabIndex = 3;
            this.textBox_Storage_LH_Labour_Contracts_Quantity.Text = "0";
            this.textBox_Storage_LH_Labour_Contracts_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Storage_LH_Labour_Hours_Quantity
            // 
            this.textBox_Storage_LH_Labour_Hours_Quantity.Location = new System.Drawing.Point(115, 32);
            this.textBox_Storage_LH_Labour_Hours_Quantity.Name = "textBox_Storage_LH_Labour_Hours_Quantity";
            this.textBox_Storage_LH_Labour_Hours_Quantity.Size = new System.Drawing.Size(46, 20);
            this.textBox_Storage_LH_Labour_Hours_Quantity.TabIndex = 2;
            this.textBox_Storage_LH_Labour_Hours_Quantity.Text = "0";
            this.textBox_Storage_LH_Labour_Hours_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Storage_LH_Labour_Contracts
            // 
            this.label_Storage_LH_Labour_Contracts.AutoSize = true;
            this.label_Storage_LH_Labour_Contracts.Location = new System.Drawing.Point(7, 61);
            this.label_Storage_LH_Labour_Contracts.Name = "label_Storage_LH_Labour_Contracts";
            this.label_Storage_LH_Labour_Contracts.Size = new System.Drawing.Size(91, 13);
            this.label_Storage_LH_Labour_Contracts.TabIndex = 1;
            this.label_Storage_LH_Labour_Contracts.Text = "Labour Contracts:";
            // 
            // label_Storage_LH_Labour_Hours
            // 
            this.label_Storage_LH_Labour_Hours.AutoSize = true;
            this.label_Storage_LH_Labour_Hours.Location = new System.Drawing.Point(7, 35);
            this.label_Storage_LH_Labour_Hours.Name = "label_Storage_LH_Labour_Hours";
            this.label_Storage_LH_Labour_Hours.Size = new System.Drawing.Size(74, 13);
            this.label_Storage_LH_Labour_Hours.TabIndex = 0;
            this.label_Storage_LH_Labour_Hours.Text = "Labour Hours:";
            // 
            // groupBox_Storage_Resources
            // 
            this.groupBox_Storage_Resources.Controls.Add(this.label_Storage_Resources_AutoBuy);
            this.groupBox_Storage_Resources.Controls.Add(this.label_Storage_Resources_ItemWeight);
            this.groupBox_Storage_Resources.Controls.Add(this.label_Storage_Resources_BasePrice);
            this.groupBox_Storage_Resources.Controls.Add(this.label_Storage_Resources_Price);
            this.groupBox_Storage_Resources.Controls.Add(this.label_Storage_Resources_Quantity);
            this.groupBox_Storage_Resources.Controls.Add(this.label_Storage_Resources_Name);
            this.groupBox_Storage_Resources.Location = new System.Drawing.Point(6, 35);
            this.groupBox_Storage_Resources.Name = "groupBox_Storage_Resources";
            this.groupBox_Storage_Resources.Size = new System.Drawing.Size(413, 40);
            this.groupBox_Storage_Resources.TabIndex = 7;
            this.groupBox_Storage_Resources.TabStop = false;
            this.groupBox_Storage_Resources.Text = "Resources";
            // 
            // label_Storage_Resources_AutoBuy
            // 
            this.label_Storage_Resources_AutoBuy.Location = new System.Drawing.Point(329, 20);
            this.label_Storage_Resources_AutoBuy.Name = "label_Storage_Resources_AutoBuy";
            this.label_Storage_Resources_AutoBuy.Size = new System.Drawing.Size(74, 13);
            this.label_Storage_Resources_AutoBuy.TabIndex = 5;
            this.label_Storage_Resources_AutoBuy.Text = "Auto Fill Price:";
            this.label_Storage_Resources_AutoBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Storage_Resources_ItemWeight
            // 
            this.label_Storage_Resources_ItemWeight.Location = new System.Drawing.Point(279, 20);
            this.label_Storage_Resources_ItemWeight.Name = "label_Storage_Resources_ItemWeight";
            this.label_Storage_Resources_ItemWeight.Size = new System.Drawing.Size(44, 13);
            this.label_Storage_Resources_ItemWeight.TabIndex = 4;
            this.label_Storage_Resources_ItemWeight.Text = "Weight:";
            this.label_Storage_Resources_ItemWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Storage_Resources_BasePrice
            // 
            this.label_Storage_Resources_BasePrice.Location = new System.Drawing.Point(212, 20);
            this.label_Storage_Resources_BasePrice.Name = "label_Storage_Resources_BasePrice";
            this.label_Storage_Resources_BasePrice.Size = new System.Drawing.Size(61, 13);
            this.label_Storage_Resources_BasePrice.TabIndex = 3;
            this.label_Storage_Resources_BasePrice.Text = "Base Price:";
            this.label_Storage_Resources_BasePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Storage_Resources_Price
            // 
            this.label_Storage_Resources_Price.AutoSize = true;
            this.label_Storage_Resources_Price.Location = new System.Drawing.Point(172, 20);
            this.label_Storage_Resources_Price.Name = "label_Storage_Resources_Price";
            this.label_Storage_Resources_Price.Size = new System.Drawing.Size(34, 13);
            this.label_Storage_Resources_Price.TabIndex = 2;
            this.label_Storage_Resources_Price.Text = "Price:";
            // 
            // label_Storage_Resources_Quantity
            // 
            this.label_Storage_Resources_Quantity.AutoSize = true;
            this.label_Storage_Resources_Quantity.Location = new System.Drawing.Point(117, 20);
            this.label_Storage_Resources_Quantity.Name = "label_Storage_Resources_Quantity";
            this.label_Storage_Resources_Quantity.Size = new System.Drawing.Size(49, 13);
            this.label_Storage_Resources_Quantity.TabIndex = 1;
            this.label_Storage_Resources_Quantity.Text = "Quantity:";
            // 
            // label_Storage_Resources_Name
            // 
            this.label_Storage_Resources_Name.Location = new System.Drawing.Point(6, 20);
            this.label_Storage_Resources_Name.Name = "label_Storage_Resources_Name";
            this.label_Storage_Resources_Name.Size = new System.Drawing.Size(105, 13);
            this.label_Storage_Resources_Name.TabIndex = 0;
            this.label_Storage_Resources_Name.Text = "Name:";
            this.label_Storage_Resources_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_Storage_Materials
            // 
            this.groupBox_Storage_Materials.Controls.Add(this.label_Storage_Materials_ItemWeight);
            this.groupBox_Storage_Materials.Controls.Add(this.label_Storage_Materials_BasePrice);
            this.groupBox_Storage_Materials.Controls.Add(this.label_Storage_Materials_Price);
            this.groupBox_Storage_Materials.Controls.Add(this.label_Storage_Materials_Quantity);
            this.groupBox_Storage_Materials.Controls.Add(this.label_Storage_Materials_Name);
            this.groupBox_Storage_Materials.Location = new System.Drawing.Point(425, 35);
            this.groupBox_Storage_Materials.Name = "groupBox_Storage_Materials";
            this.groupBox_Storage_Materials.Size = new System.Drawing.Size(370, 40);
            this.groupBox_Storage_Materials.TabIndex = 4;
            this.groupBox_Storage_Materials.TabStop = false;
            this.groupBox_Storage_Materials.Text = "Materials";
            // 
            // label_Storage_Materials_ItemWeight
            // 
            this.label_Storage_Materials_ItemWeight.AutoSize = true;
            this.label_Storage_Materials_ItemWeight.Location = new System.Drawing.Point(320, 20);
            this.label_Storage_Materials_ItemWeight.Name = "label_Storage_Materials_ItemWeight";
            this.label_Storage_Materials_ItemWeight.Size = new System.Drawing.Size(44, 13);
            this.label_Storage_Materials_ItemWeight.TabIndex = 4;
            this.label_Storage_Materials_ItemWeight.Text = "Weight:";
            // 
            // label_Storage_Materials_BasePrice
            // 
            this.label_Storage_Materials_BasePrice.AutoSize = true;
            this.label_Storage_Materials_BasePrice.Location = new System.Drawing.Point(253, 20);
            this.label_Storage_Materials_BasePrice.Name = "label_Storage_Materials_BasePrice";
            this.label_Storage_Materials_BasePrice.Size = new System.Drawing.Size(61, 13);
            this.label_Storage_Materials_BasePrice.TabIndex = 3;
            this.label_Storage_Materials_BasePrice.Text = "Base Price:";
            // 
            // label_Storage_Materials_Price
            // 
            this.label_Storage_Materials_Price.AutoSize = true;
            this.label_Storage_Materials_Price.Location = new System.Drawing.Point(213, 20);
            this.label_Storage_Materials_Price.Name = "label_Storage_Materials_Price";
            this.label_Storage_Materials_Price.Size = new System.Drawing.Size(34, 13);
            this.label_Storage_Materials_Price.TabIndex = 2;
            this.label_Storage_Materials_Price.Text = "Price:";
            // 
            // label_Storage_Materials_Quantity
            // 
            this.label_Storage_Materials_Quantity.AutoSize = true;
            this.label_Storage_Materials_Quantity.Location = new System.Drawing.Point(151, 20);
            this.label_Storage_Materials_Quantity.Name = "label_Storage_Materials_Quantity";
            this.label_Storage_Materials_Quantity.Size = new System.Drawing.Size(49, 13);
            this.label_Storage_Materials_Quantity.TabIndex = 1;
            this.label_Storage_Materials_Quantity.Text = "Quantity:";
            // 
            // label_Storage_Materials_Name
            // 
            this.label_Storage_Materials_Name.AutoSize = true;
            this.label_Storage_Materials_Name.Location = new System.Drawing.Point(6, 20);
            this.label_Storage_Materials_Name.Name = "label_Storage_Materials_Name";
            this.label_Storage_Materials_Name.Size = new System.Drawing.Size(38, 13);
            this.label_Storage_Materials_Name.TabIndex = 0;
            this.label_Storage_Materials_Name.Text = "Name:";
            // 
            // tabPage_Craft
            // 
            this.tabPage_Craft.Controls.Add(this.button_Craft_Order_Clear);
            this.tabPage_Craft.Controls.Add(this.groupBox_Craft_NewOrder);
            this.tabPage_Craft.Controls.Add(this.groupBox_Craft_CanBuild);
            this.tabPage_Craft.Controls.Add(this.groupBox_Craft_TotalNeeds);
            this.tabPage_Craft.Controls.Add(this.groupBox_Craft_Order);
            this.tabPage_Craft.Controls.Add(this.groupBox_Craft_GeneralInfo);
            this.tabPage_Craft.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Craft.Name = "tabPage_Craft";
            this.tabPage_Craft.Size = new System.Drawing.Size(1049, 837);
            this.tabPage_Craft.TabIndex = 2;
            this.tabPage_Craft.Text = "Craft_WIP";
            this.tabPage_Craft.UseVisualStyleBackColor = true;
            // 
            // button_Craft_Order_Clear
            // 
            this.button_Craft_Order_Clear.Location = new System.Drawing.Point(23, 463);
            this.button_Craft_Order_Clear.Name = "button_Craft_Order_Clear";
            this.button_Craft_Order_Clear.Size = new System.Drawing.Size(185, 37);
            this.button_Craft_Order_Clear.TabIndex = 20;
            this.button_Craft_Order_Clear.Text = "Clear";
            this.button_Craft_Order_Clear.UseVisualStyleBackColor = true;
            this.button_Craft_Order_Clear.Click += new System.EventHandler(this.button_Craft_Order_Clear_Click);
            // 
            // groupBox_Craft_NewOrder
            // 
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
            this.groupBox_Craft_NewOrder.Location = new System.Drawing.Point(5, 3);
            this.groupBox_Craft_NewOrder.Name = "groupBox_Craft_NewOrder";
            this.groupBox_Craft_NewOrder.Size = new System.Drawing.Size(223, 254);
            this.groupBox_Craft_NewOrder.TabIndex = 16;
            this.groupBox_Craft_NewOrder.TabStop = false;
            this.groupBox_Craft_NewOrder.Text = "Add new order";
            // 
            // comboBox_Craft_NewOrder_Trim
            // 
            this.comboBox_Craft_NewOrder_Trim.BackColor = System.Drawing.Color.White;
            this.comboBox_Craft_NewOrder_Trim.FormattingEnabled = true;
            this.comboBox_Craft_NewOrder_Trim.Items.AddRange(new object[] {
            "Random",
            "Build Strength",
            "Crew Space",
            "Planking",
            "Rigging Quality",
            "Speed",
            "Stiffness"});
            this.comboBox_Craft_NewOrder_Trim.Location = new System.Drawing.Point(58, 177);
            this.comboBox_Craft_NewOrder_Trim.Name = "comboBox_Craft_NewOrder_Trim";
            this.comboBox_Craft_NewOrder_Trim.Size = new System.Drawing.Size(159, 21);
            this.comboBox_Craft_NewOrder_Trim.TabIndex = 21;
            // 
            // label_Craft_Trim
            // 
            this.label_Craft_Trim.AutoSize = true;
            this.label_Craft_Trim.BackColor = System.Drawing.Color.Transparent;
            this.label_Craft_Trim.Location = new System.Drawing.Point(6, 180);
            this.label_Craft_Trim.Name = "label_Craft_Trim";
            this.label_Craft_Trim.Size = new System.Drawing.Size(30, 13);
            this.label_Craft_Trim.TabIndex = 20;
            this.label_Craft_Trim.Text = "Trim:";
            // 
            // comboBox_Craft_NewOrder_Wood
            // 
            this.comboBox_Craft_NewOrder_Wood.BackColor = System.Drawing.Color.White;
            this.comboBox_Craft_NewOrder_Wood.FormattingEnabled = true;
            this.comboBox_Craft_NewOrder_Wood.Items.AddRange(new object[] {
            "Fir",
            "Oak",
            "Teak",
            "Live Oak",
            "Mahogany",
            "Bermuda Cedar"});
            this.comboBox_Craft_NewOrder_Wood.Location = new System.Drawing.Point(58, 150);
            this.comboBox_Craft_NewOrder_Wood.Name = "comboBox_Craft_NewOrder_Wood";
            this.comboBox_Craft_NewOrder_Wood.Size = new System.Drawing.Size(159, 21);
            this.comboBox_Craft_NewOrder_Wood.TabIndex = 19;
            // 
            // label_Craft_Wood
            // 
            this.label_Craft_Wood.AutoSize = true;
            this.label_Craft_Wood.BackColor = System.Drawing.Color.Transparent;
            this.label_Craft_Wood.Location = new System.Drawing.Point(6, 153);
            this.label_Craft_Wood.Name = "label_Craft_Wood";
            this.label_Craft_Wood.Size = new System.Drawing.Size(36, 13);
            this.label_Craft_Wood.TabIndex = 18;
            this.label_Craft_Wood.Text = "Wood";
            // 
            // radioButton_Craft_Recipe
            // 
            this.radioButton_Craft_Recipe.AutoSize = true;
            this.radioButton_Craft_Recipe.Location = new System.Drawing.Point(6, 65);
            this.radioButton_Craft_Recipe.Name = "radioButton_Craft_Recipe";
            this.radioButton_Craft_Recipe.Size = new System.Drawing.Size(59, 17);
            this.radioButton_Craft_Recipe.TabIndex = 17;
            this.radioButton_Craft_Recipe.Text = "Recipe";
            this.radioButton_Craft_Recipe.UseVisualStyleBackColor = true;
            this.radioButton_Craft_Recipe.CheckedChanged += new System.EventHandler(this.radioButton_Craft_Recipe_CheckedChanged);
            // 
            // button_Craft_Add
            // 
            this.button_Craft_Add.Location = new System.Drawing.Point(18, 204);
            this.button_Craft_Add.Name = "button_Craft_Add";
            this.button_Craft_Add.Size = new System.Drawing.Size(185, 37);
            this.button_Craft_Add.TabIndex = 14;
            this.button_Craft_Add.Text = "Add";
            this.button_Craft_Add.UseVisualStyleBackColor = true;
            this.button_Craft_Add.Click += new System.EventHandler(this.button_Craft_Add_Click);
            // 
            // comboBox_Craft_NewOrder_Quality
            // 
            this.comboBox_Craft_NewOrder_Quality.BackColor = System.Drawing.Color.White;
            this.comboBox_Craft_NewOrder_Quality.FormattingEnabled = true;
            this.comboBox_Craft_NewOrder_Quality.Items.AddRange(new object[] {
            "Basic",
            "Common",
            "Fine",
            "Mastercraft",
            "Exceptional"});
            this.comboBox_Craft_NewOrder_Quality.Location = new System.Drawing.Point(58, 123);
            this.comboBox_Craft_NewOrder_Quality.Name = "comboBox_Craft_NewOrder_Quality";
            this.comboBox_Craft_NewOrder_Quality.Size = new System.Drawing.Size(159, 21);
            this.comboBox_Craft_NewOrder_Quality.TabIndex = 13;
            this.comboBox_Craft_NewOrder_Quality.SelectedIndexChanged += new System.EventHandler(this.comboBox_Craft_NewOrder_Quality_SelectedIndexChanged);
            // 
            // radioButton_Craft_Module
            // 
            this.radioButton_Craft_Module.AutoSize = true;
            this.radioButton_Craft_Module.Location = new System.Drawing.Point(6, 42);
            this.radioButton_Craft_Module.Name = "radioButton_Craft_Module";
            this.radioButton_Craft_Module.Size = new System.Drawing.Size(60, 17);
            this.radioButton_Craft_Module.TabIndex = 16;
            this.radioButton_Craft_Module.Text = "Module";
            this.radioButton_Craft_Module.UseVisualStyleBackColor = true;
            this.radioButton_Craft_Module.CheckedChanged += new System.EventHandler(this.radioButton_Craft_Module_CheckedChanged);
            // 
            // radioButton_Craft_Ship
            // 
            this.radioButton_Craft_Ship.AutoSize = true;
            this.radioButton_Craft_Ship.Location = new System.Drawing.Point(6, 19);
            this.radioButton_Craft_Ship.Name = "radioButton_Craft_Ship";
            this.radioButton_Craft_Ship.Size = new System.Drawing.Size(46, 17);
            this.radioButton_Craft_Ship.TabIndex = 15;
            this.radioButton_Craft_Ship.Text = "Ship";
            this.radioButton_Craft_Ship.UseVisualStyleBackColor = true;
            this.radioButton_Craft_Ship.CheckedChanged += new System.EventHandler(this.radioButton_Craft_Ship_CheckedChanged);
            // 
            // label_Craft_Quality
            // 
            this.label_Craft_Quality.AutoSize = true;
            this.label_Craft_Quality.BackColor = System.Drawing.Color.Transparent;
            this.label_Craft_Quality.Location = new System.Drawing.Point(6, 126);
            this.label_Craft_Quality.Name = "label_Craft_Quality";
            this.label_Craft_Quality.Size = new System.Drawing.Size(39, 13);
            this.label_Craft_Quality.TabIndex = 12;
            this.label_Craft_Quality.Text = "Quality";
            // 
            // comboBox_Craft_NewOrder_Name
            // 
            this.comboBox_Craft_NewOrder_Name.FormattingEnabled = true;
            this.comboBox_Craft_NewOrder_Name.Location = new System.Drawing.Point(58, 96);
            this.comboBox_Craft_NewOrder_Name.Name = "comboBox_Craft_NewOrder_Name";
            this.comboBox_Craft_NewOrder_Name.Size = new System.Drawing.Size(159, 21);
            this.comboBox_Craft_NewOrder_Name.TabIndex = 10;
            // 
            // label_Craft_NewOrder_Name
            // 
            this.label_Craft_NewOrder_Name.AutoSize = true;
            this.label_Craft_NewOrder_Name.Location = new System.Drawing.Point(6, 99);
            this.label_Craft_NewOrder_Name.Name = "label_Craft_NewOrder_Name";
            this.label_Craft_NewOrder_Name.Size = new System.Drawing.Size(38, 13);
            this.label_Craft_NewOrder_Name.TabIndex = 11;
            this.label_Craft_NewOrder_Name.Text = "Name:";
            // 
            // groupBox_Craft_CanBuild
            // 
            this.groupBox_Craft_CanBuild.Controls.Add(this.textBox_Craft_CanBuild);
            this.groupBox_Craft_CanBuild.Location = new System.Drawing.Point(234, 3);
            this.groupBox_Craft_CanBuild.Name = "groupBox_Craft_CanBuild";
            this.groupBox_Craft_CanBuild.Size = new System.Drawing.Size(290, 831);
            this.groupBox_Craft_CanBuild.TabIndex = 19;
            this.groupBox_Craft_CanBuild.TabStop = false;
            this.groupBox_Craft_CanBuild.Text = "Can build:";
            // 
            // textBox_Craft_CanBuild
            // 
            this.textBox_Craft_CanBuild.Location = new System.Drawing.Point(6, 19);
            this.textBox_Craft_CanBuild.Multiline = true;
            this.textBox_Craft_CanBuild.Name = "textBox_Craft_CanBuild";
            this.textBox_Craft_CanBuild.Size = new System.Drawing.Size(279, 806);
            this.textBox_Craft_CanBuild.TabIndex = 1;
            // 
            // groupBox_Craft_TotalNeeds
            // 
            this.groupBox_Craft_TotalNeeds.Controls.Add(this.textBox_Craft_Uneed);
            this.groupBox_Craft_TotalNeeds.Location = new System.Drawing.Point(530, 3);
            this.groupBox_Craft_TotalNeeds.Name = "groupBox_Craft_TotalNeeds";
            this.groupBox_Craft_TotalNeeds.Size = new System.Drawing.Size(291, 831);
            this.groupBox_Craft_TotalNeeds.TabIndex = 18;
            this.groupBox_Craft_TotalNeeds.TabStop = false;
            this.groupBox_Craft_TotalNeeds.Text = "You need:";
            // 
            // textBox_Craft_Uneed
            // 
            this.textBox_Craft_Uneed.Location = new System.Drawing.Point(6, 19);
            this.textBox_Craft_Uneed.Multiline = true;
            this.textBox_Craft_Uneed.Name = "textBox_Craft_Uneed";
            this.textBox_Craft_Uneed.Size = new System.Drawing.Size(279, 806);
            this.textBox_Craft_Uneed.TabIndex = 0;
            // 
            // groupBox_Craft_Order
            // 
            this.groupBox_Craft_Order.Location = new System.Drawing.Point(5, 506);
            this.groupBox_Craft_Order.Name = "groupBox_Craft_Order";
            this.groupBox_Craft_Order.Size = new System.Drawing.Size(223, 41);
            this.groupBox_Craft_Order.TabIndex = 17;
            this.groupBox_Craft_Order.TabStop = false;
            this.groupBox_Craft_Order.Text = "Your order:";
            // 
            // groupBox_Craft_GeneralInfo
            // 
            this.groupBox_Craft_GeneralInfo.Controls.Add(this.label_Craft_efficiency);
            this.groupBox_Craft_GeneralInfo.Controls.Add(this.checkBox_Craft_StoredRes);
            this.groupBox_Craft_GeneralInfo.Controls.Add(this.checkBox_Craft_StoredMats);
            this.groupBox_Craft_GeneralInfo.Controls.Add(this.checkBox_Craft_StoredLH);
            this.groupBox_Craft_GeneralInfo.Controls.Add(this.label_Craft_TotalCost);
            this.groupBox_Craft_GeneralInfo.Controls.Add(this.label_Craft_GainXP);
            this.groupBox_Craft_GeneralInfo.Controls.Add(this.label_Craft_Total_LH);
            this.groupBox_Craft_GeneralInfo.Controls.Add(this.label_Craft_ETA);
            this.groupBox_Craft_GeneralInfo.Location = new System.Drawing.Point(5, 263);
            this.groupBox_Craft_GeneralInfo.Name = "groupBox_Craft_GeneralInfo";
            this.groupBox_Craft_GeneralInfo.Size = new System.Drawing.Size(223, 194);
            this.groupBox_Craft_GeneralInfo.TabIndex = 16;
            this.groupBox_Craft_GeneralInfo.TabStop = false;
            this.groupBox_Craft_GeneralInfo.Text = "General info";
            // 
            // label_Craft_efficiency
            // 
            this.label_Craft_efficiency.AutoSize = true;
            this.label_Craft_efficiency.Location = new System.Drawing.Point(3, 150);
            this.label_Craft_efficiency.Name = "label_Craft_efficiency";
            this.label_Craft_efficiency.Size = new System.Drawing.Size(62, 13);
            this.label_Craft_efficiency.TabIndex = 22;
            this.label_Craft_efficiency.Text = "Efficiency:  ";
            // 
            // checkBox_Craft_StoredRes
            // 
            this.checkBox_Craft_StoredRes.AutoSize = true;
            this.checkBox_Craft_StoredRes.Location = new System.Drawing.Point(6, 18);
            this.checkBox_Craft_StoredRes.Name = "checkBox_Craft_StoredRes";
            this.checkBox_Craft_StoredRes.Size = new System.Drawing.Size(132, 17);
            this.checkBox_Craft_StoredRes.TabIndex = 6;
            this.checkBox_Craft_StoredRes.Text = "Use stored resources?";
            this.checkBox_Craft_StoredRes.UseVisualStyleBackColor = true;
            this.checkBox_Craft_StoredRes.CheckedChanged += new System.EventHandler(this.checkBox_Craft_StoredRes_CheckedChanged);
            // 
            // checkBox_Craft_StoredMats
            // 
            this.checkBox_Craft_StoredMats.AutoSize = true;
            this.checkBox_Craft_StoredMats.Location = new System.Drawing.Point(6, 41);
            this.checkBox_Craft_StoredMats.Name = "checkBox_Craft_StoredMats";
            this.checkBox_Craft_StoredMats.Size = new System.Drawing.Size(127, 17);
            this.checkBox_Craft_StoredMats.TabIndex = 2;
            this.checkBox_Craft_StoredMats.Text = "Use stored materials?";
            this.checkBox_Craft_StoredMats.UseVisualStyleBackColor = true;
            this.checkBox_Craft_StoredMats.CheckedChanged += new System.EventHandler(this.checkBox_Craft_StoredMats_CheckedChanged);
            // 
            // checkBox_Craft_StoredLH
            // 
            this.checkBox_Craft_StoredLH.AutoSize = true;
            this.checkBox_Craft_StoredLH.Location = new System.Drawing.Point(6, 64);
            this.checkBox_Craft_StoredLH.Name = "checkBox_Craft_StoredLH";
            this.checkBox_Craft_StoredLH.Size = new System.Drawing.Size(144, 17);
            this.checkBox_Craft_StoredLH.TabIndex = 3;
            this.checkBox_Craft_StoredLH.Text = "Use stored labour hours?";
            this.checkBox_Craft_StoredLH.UseVisualStyleBackColor = true;
            this.checkBox_Craft_StoredLH.CheckedChanged += new System.EventHandler(this.checkBox_Craft_StoredLH_CheckedChanged);
            // 
            // label_Craft_TotalCost
            // 
            this.label_Craft_TotalCost.AutoSize = true;
            this.label_Craft_TotalCost.Location = new System.Drawing.Point(3, 172);
            this.label_Craft_TotalCost.Name = "label_Craft_TotalCost";
            this.label_Craft_TotalCost.Size = new System.Drawing.Size(61, 13);
            this.label_Craft_TotalCost.TabIndex = 0;
            this.label_Craft_TotalCost.Text = "TotalCost:  ";
            // 
            // label_Craft_GainXP
            // 
            this.label_Craft_GainXP.AutoSize = true;
            this.label_Craft_GainXP.Location = new System.Drawing.Point(3, 106);
            this.label_Craft_GainXP.Name = "label_Craft_GainXP";
            this.label_Craft_GainXP.Size = new System.Drawing.Size(82, 13);
            this.label_Craft_GainXP.TabIndex = 21;
            this.label_Craft_GainXP.Text = "Total Craft XP:  ";
            // 
            // label_Craft_Total_LH
            // 
            this.label_Craft_Total_LH.AutoSize = true;
            this.label_Craft_Total_LH.Location = new System.Drawing.Point(3, 128);
            this.label_Craft_Total_LH.Name = "label_Craft_Total_LH";
            this.label_Craft_Total_LH.Size = new System.Drawing.Size(105, 13);
            this.label_Craft_Total_LH.TabIndex = 4;
            this.label_Craft_Total_LH.Text = "Total Labour hours:  ";
            // 
            // label_Craft_ETA
            // 
            this.label_Craft_ETA.AutoSize = true;
            this.label_Craft_ETA.Location = new System.Drawing.Point(3, 194);
            this.label_Craft_ETA.Name = "label_Craft_ETA";
            this.label_Craft_ETA.Size = new System.Drawing.Size(82, 13);
            this.label_Craft_ETA.TabIndex = 1;
            this.label_Craft_ETA.Text = "Estimated Time:";
            // 
            // tabPage_SPeedCurves
            // 
            this.tabPage_SPeedCurves.Controls.Add(this.textBox2);
            this.tabPage_SPeedCurves.Controls.Add(this.textBox1);
            this.tabPage_SPeedCurves.Controls.Add(this.label_SpeedCurves_Scale);
            this.tabPage_SPeedCurves.Controls.Add(this.numericUpDown_SpeedCurves_MaxKn);
            this.tabPage_SPeedCurves.Controls.Add(this.label_SpeedCurves_OpShip);
            this.tabPage_SPeedCurves.Controls.Add(this.comboBox_SpeedCurves_OpShip);
            this.tabPage_SPeedCurves.Controls.Add(this.label_SpeedCurves_YrShip);
            this.tabPage_SPeedCurves.Controls.Add(this.comboBox_SpeedCurves_YrShip);
            this.tabPage_SPeedCurves.Controls.Add(this.pictureBox_SpeedCurves_Base);
            this.tabPage_SPeedCurves.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage_SPeedCurves.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SPeedCurves.Name = "tabPage_SPeedCurves";
            this.tabPage_SPeedCurves.Size = new System.Drawing.Size(1049, 837);
            this.tabPage_SPeedCurves.TabIndex = 3;
            this.tabPage_SPeedCurves.Text = "Speed Curves_WIP";
            this.tabPage_SPeedCurves.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Red;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(638, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(19, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Green;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(638, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(19, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label_SpeedCurves_Scale
            // 
            this.label_SpeedCurves_Scale.AutoSize = true;
            this.label_SpeedCurves_Scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_SpeedCurves_Scale.Location = new System.Drawing.Point(663, 35);
            this.label_SpeedCurves_Scale.Name = "label_SpeedCurves_Scale";
            this.label_SpeedCurves_Scale.Size = new System.Drawing.Size(67, 13);
            this.label_SpeedCurves_Scale.TabIndex = 7;
            this.label_SpeedCurves_Scale.Text = "Scale to:(kn)";
            // 
            // numericUpDown_SpeedCurves_MaxKn
            // 
            this.numericUpDown_SpeedCurves_MaxKn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_SpeedCurves_MaxKn.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_SpeedCurves_MaxKn.Location = new System.Drawing.Point(736, 32);
            this.numericUpDown_SpeedCurves_MaxKn.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown_SpeedCurves_MaxKn.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_SpeedCurves_MaxKn.Name = "numericUpDown_SpeedCurves_MaxKn";
            this.numericUpDown_SpeedCurves_MaxKn.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown_SpeedCurves_MaxKn.TabIndex = 6;
            this.numericUpDown_SpeedCurves_MaxKn.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_SpeedCurves_MaxKn.ValueChanged += new System.EventHandler(this.numericUpDown_SpeedCurves_MaxKn_ValueChanged);
            // 
            // label_SpeedCurves_OpShip
            // 
            this.label_SpeedCurves_OpShip.AutoSize = true;
            this.label_SpeedCurves_OpShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_SpeedCurves_OpShip.Location = new System.Drawing.Point(511, 78);
            this.label_SpeedCurves_OpShip.Name = "label_SpeedCurves_OpShip";
            this.label_SpeedCurves_OpShip.Size = new System.Drawing.Size(117, 13);
            this.label_SpeedCurves_OpShip.TabIndex = 5;
            this.label_SpeedCurves_OpShip.Text = "Select opponent\'s ship:";
            // 
            // comboBox_SpeedCurves_OpShip
            // 
            this.comboBox_SpeedCurves_OpShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_SpeedCurves_OpShip.FormattingEnabled = true;
            this.comboBox_SpeedCurves_OpShip.Location = new System.Drawing.Point(511, 94);
            this.comboBox_SpeedCurves_OpShip.Name = "comboBox_SpeedCurves_OpShip";
            this.comboBox_SpeedCurves_OpShip.Size = new System.Drawing.Size(121, 21);
            this.comboBox_SpeedCurves_OpShip.TabIndex = 4;
            this.comboBox_SpeedCurves_OpShip.SelectedIndexChanged += new System.EventHandler(this.comboBox_SpeedCurves_OpShip_SelectedIndexChanged);
            // 
            // label_SpeedCurves_YrShip
            // 
            this.label_SpeedCurves_YrShip.AutoSize = true;
            this.label_SpeedCurves_YrShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_SpeedCurves_YrShip.Location = new System.Drawing.Point(511, 17);
            this.label_SpeedCurves_YrShip.Name = "label_SpeedCurves_YrShip";
            this.label_SpeedCurves_YrShip.Size = new System.Drawing.Size(85, 13);
            this.label_SpeedCurves_YrShip.TabIndex = 3;
            this.label_SpeedCurves_YrShip.Text = "Select your ship:";
            // 
            // comboBox_SpeedCurves_YrShip
            // 
            this.comboBox_SpeedCurves_YrShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_SpeedCurves_YrShip.FormattingEnabled = true;
            this.comboBox_SpeedCurves_YrShip.Location = new System.Drawing.Point(511, 33);
            this.comboBox_SpeedCurves_YrShip.Name = "comboBox_SpeedCurves_YrShip";
            this.comboBox_SpeedCurves_YrShip.Size = new System.Drawing.Size(121, 21);
            this.comboBox_SpeedCurves_YrShip.TabIndex = 2;
            this.comboBox_SpeedCurves_YrShip.SelectedIndexChanged += new System.EventHandler(this.comboBox_SpeedCurves_YrShip_SelectedIndexChanged);
            // 
            // pictureBox_SpeedCurves_Base
            // 
            this.pictureBox_SpeedCurves_Base.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_SpeedCurves_Base.Location = new System.Drawing.Point(5, 3);
            this.pictureBox_SpeedCurves_Base.Name = "pictureBox_SpeedCurves_Base";
            this.pictureBox_SpeedCurves_Base.Size = new System.Drawing.Size(500, 500);
            this.pictureBox_SpeedCurves_Base.TabIndex = 1;
            this.pictureBox_SpeedCurves_Base.TabStop = false;
            // 
            // tabPage_Test
            // 
            this.tabPage_Test.Controls.Add(this.numericUpDown1);
            this.tabPage_Test.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Test.Name = "tabPage_Test";
            this.tabPage_Test.Size = new System.Drawing.Size(1049, 837);
            this.tabPage_Test.TabIndex = 4;
            this.tabPage_Test.Text = "Test";
            this.tabPage_Test.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(298, 175);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // openFileDialog_Storage
            // 
            this.openFileDialog_Storage.FileName = "openFileDialog1";
            this.openFileDialog_Storage.Filter = "JSON files(*.json)|*.json|All files(*.*)|*.*";
            // 
            // saveFileDialog_Storage
            // 
            this.saveFileDialog_Storage.Filter = "JSON files(*.json)|*.json|All files(*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1081, 887);
            this.Controls.Add(this.tabControl_NA_Tool);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Nick Mickelson\'s Toolbox";
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SpeedCurves_MaxKn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SpeedCurves_Base)).EndInit();
            this.tabPage_Test.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
