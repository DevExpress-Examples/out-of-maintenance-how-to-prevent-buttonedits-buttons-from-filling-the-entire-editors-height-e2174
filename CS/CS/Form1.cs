using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WindowsApplication1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
    {
		private System.Data.DataSet dataSet1;
		private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
		private WindowsApplication1.MyButtonEdit myButtonEdit1;
        private MyButtonEdit myButtonEdit2;
        private MyButtonEdit myButtonEdit3;
        private MyButtonEdit myButtonEdit4;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.myButtonEdit4 = new WindowsApplication1.MyButtonEdit();
            this.myButtonEdit3 = new WindowsApplication1.MyButtonEdit();
            this.myButtonEdit2 = new WindowsApplication1.MyButtonEdit();
            this.myButtonEdit1 = new WindowsApplication1.MyButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Column1";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // myButtonEdit4
            // 
            this.myButtonEdit4.EditValue = "myButtonEdit4";
            this.myButtonEdit4.Location = new System.Drawing.Point(12, 198);
            this.myButtonEdit4.Name = "myButtonEdit4";
            this.myButtonEdit4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myButtonEdit4.Properties.Appearance.Options.UseFont = true;
            this.myButtonEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("myButtonEdit4.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.myButtonEdit4.Properties.ButtonsAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.myButtonEdit4.Properties.ButtonsHeight = 25;
            this.myButtonEdit4.Size = new System.Drawing.Size(375, 51);
            this.myButtonEdit4.TabIndex = 3;
            // 
            // myButtonEdit3
            // 
            this.myButtonEdit3.EditValue = "myButtonEdit3";
            this.myButtonEdit3.Location = new System.Drawing.Point(13, 141);
            this.myButtonEdit3.Name = "myButtonEdit3";
            this.myButtonEdit3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myButtonEdit3.Properties.Appearance.Options.UseFont = true;
            this.myButtonEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("myButtonEdit3.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.myButtonEdit3.Properties.ButtonsAlignment = DevExpress.Utils.VertAlignment.Center;
            this.myButtonEdit3.Properties.ButtonsHeight = 25;
            this.myButtonEdit3.Size = new System.Drawing.Size(375, 51);
            this.myButtonEdit3.TabIndex = 2;
            // 
            // myButtonEdit2
            // 
            this.myButtonEdit2.EditValue = "myButtonEdit2";
            this.myButtonEdit2.Location = new System.Drawing.Point(13, 84);
            this.myButtonEdit2.Name = "myButtonEdit2";
            this.myButtonEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myButtonEdit2.Properties.Appearance.Options.UseFont = true;
            this.myButtonEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("myButtonEdit2.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.myButtonEdit2.Properties.ButtonsAlignment = DevExpress.Utils.VertAlignment.Top;
            this.myButtonEdit2.Properties.ButtonsHeight = 25;
            this.myButtonEdit2.Size = new System.Drawing.Size(375, 51);
            this.myButtonEdit2.TabIndex = 1;
            // 
            // myButtonEdit1
            // 
            this.myButtonEdit1.EditValue = "myButtonEdit1";
            this.myButtonEdit1.Location = new System.Drawing.Point(13, 12);
            this.myButtonEdit1.Name = "myButtonEdit1";
            this.myButtonEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myButtonEdit1.Properties.Appearance.Options.UseFont = true;
            this.myButtonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("myButtonEdit1.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.myButtonEdit1.Properties.ButtonsAlignment = DevExpress.Utils.VertAlignment.Default;
            this.myButtonEdit1.Properties.ButtonsHeight = 0;
            this.myButtonEdit1.Size = new System.Drawing.Size(375, 51);
            this.myButtonEdit1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(400, 259);
            this.Controls.Add(this.myButtonEdit4);
            this.Controls.Add(this.myButtonEdit3);
            this.Controls.Add(this.myButtonEdit2);
            this.Controls.Add(this.myButtonEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());

		}

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

	}
}
