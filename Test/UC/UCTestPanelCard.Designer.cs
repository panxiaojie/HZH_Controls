
namespace Test.UC
{
    partial class UCTestPanelCard
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cardPanel1 = new HZH_Controls.Controls.CardPanel();
            this.textBoxEx1 = new HZH_Controls.Controls.TextBoxEx();
            this.cardPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardPanel1
            // 
            this.cardPanel1.BorderRadiusShow = true;
            this.cardPanel1.BorderUpDown = true;
            this.cardPanel1.Controls.Add(this.textBoxEx1);
            this.cardPanel1.LineCount = 0;
            this.cardPanel1.Location = new System.Drawing.Point(34, 30);
            this.cardPanel1.Name = "cardPanel1";
            this.cardPanel1.Size = new System.Drawing.Size(1117, 694);
            this.cardPanel1.TabIndex = 0;
            this.cardPanel1.Title = "sasas32";
            this.cardPanel1.TitleBackColor = System.Drawing.Color.LightBlue;
            this.cardPanel1.TitleFont = new System.Drawing.Font("黑体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cardPanel1.TitleFontColor = System.Drawing.Color.Gray;
            // 
            // textBoxEx1
            // 
            this.textBoxEx1.DecLength = 2;
            this.textBoxEx1.InputType = HZH_Controls.TextInputType.NotControl;
            this.textBoxEx1.Location = new System.Drawing.Point(435, 247);
            this.textBoxEx1.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.textBoxEx1.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.textBoxEx1.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBoxEx1.Name = "textBoxEx1";
            this.textBoxEx1.OldText = null;
            this.textBoxEx1.PromptColor = System.Drawing.Color.Gray;
            this.textBoxEx1.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxEx1.PromptText = "";
            this.textBoxEx1.RegexPattern = "";
            this.textBoxEx1.Size = new System.Drawing.Size(100, 28);
            this.textBoxEx1.TabIndex = 0;
            // 
            // UCTestPanelCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cardPanel1);
            this.Name = "UCTestPanelCard";
            this.Size = new System.Drawing.Size(1203, 760);
            this.cardPanel1.ResumeLayout(false);
            this.cardPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.CardPanel cardPanel1;
        private HZH_Controls.Controls.TextBoxEx textBoxEx1;
    }
}
