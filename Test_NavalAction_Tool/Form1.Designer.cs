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
            this.numericUpDown_SpeedCurves_MaxKn.Location = new Point(736, 32);
            this.numericUpDown_SpeedCurves_MaxKn.Name = "numericUpDown_SpeedCurves_MaxKn";
            this.numericUpDown_SpeedCurves_MaxKn.Size = new Size(45, 20);
            this.numericUpDown_SpeedCurves_MaxKn.TabIndex = 6; 
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
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.AutoScroll = true;
            base.ClientSize = new Size(1081, 887);
            base.Controls.Add(this.tabControl_NA_Tool);
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
