namespace OuterTrading
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ins = new System.Windows.Forms.TextBox();
            this.textBox_Shares = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_InsHandle = new System.Windows.Forms.TextBox();
            this.textBox_SharesHandle = new System.Windows.Forms.TextBox();
            this.textBox_PriceHandle = new System.Windows.Forms.TextBox();
            this.button_SendIns = new System.Windows.Forms.Button();
            this.button_SendShares = new System.Windows.Forms.Button();
            this.button_SendPrice = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_BuyHandle = new System.Windows.Forms.TextBox();
            this.textBox_SellHandle = new System.Windows.Forms.TextBox();
            this.button_SendBuy = new System.Windows.Forms.Button();
            this.button_SendSell = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "合约:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数量:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "价格:";
            // 
            // textBox_ins
            // 
            this.textBox_ins.Location = new System.Drawing.Point(54, 19);
            this.textBox_ins.Name = "textBox_ins";
            this.textBox_ins.Size = new System.Drawing.Size(100, 21);
            this.textBox_ins.TabIndex = 3;
            // 
            // textBox_Shares
            // 
            this.textBox_Shares.Location = new System.Drawing.Point(54, 48);
            this.textBox_Shares.Name = "textBox_Shares";
            this.textBox_Shares.Size = new System.Drawing.Size(100, 21);
            this.textBox_Shares.TabIndex = 4;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(54, 74);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(100, 21);
            this.textBox_price.TabIndex = 5;
            // 
            // textBox_InsHandle
            // 
            this.textBox_InsHandle.Location = new System.Drawing.Point(160, 19);
            this.textBox_InsHandle.Name = "textBox_InsHandle";
            this.textBox_InsHandle.Size = new System.Drawing.Size(100, 21);
            this.textBox_InsHandle.TabIndex = 6;
            // 
            // textBox_SharesHandle
            // 
            this.textBox_SharesHandle.Location = new System.Drawing.Point(160, 46);
            this.textBox_SharesHandle.Name = "textBox_SharesHandle";
            this.textBox_SharesHandle.Size = new System.Drawing.Size(100, 21);
            this.textBox_SharesHandle.TabIndex = 7;
            // 
            // textBox_PriceHandle
            // 
            this.textBox_PriceHandle.Location = new System.Drawing.Point(160, 73);
            this.textBox_PriceHandle.Name = "textBox_PriceHandle";
            this.textBox_PriceHandle.Size = new System.Drawing.Size(100, 21);
            this.textBox_PriceHandle.TabIndex = 8;
            // 
            // button_SendIns
            // 
            this.button_SendIns.Location = new System.Drawing.Point(267, 19);
            this.button_SendIns.Name = "button_SendIns";
            this.button_SendIns.Size = new System.Drawing.Size(75, 23);
            this.button_SendIns.TabIndex = 9;
            this.button_SendIns.Text = "发送合约";
            this.button_SendIns.UseVisualStyleBackColor = true;
            this.button_SendIns.Click += new System.EventHandler(this.Button_SendIns_Click);
            // 
            // button_SendShares
            // 
            this.button_SendShares.Location = new System.Drawing.Point(267, 48);
            this.button_SendShares.Name = "button_SendShares";
            this.button_SendShares.Size = new System.Drawing.Size(75, 23);
            this.button_SendShares.TabIndex = 10;
            this.button_SendShares.Text = "发送数量";
            this.button_SendShares.UseVisualStyleBackColor = true;
            this.button_SendShares.Click += new System.EventHandler(this.Button_SendShares_Click);
            // 
            // button_SendPrice
            // 
            this.button_SendPrice.Location = new System.Drawing.Point(267, 77);
            this.button_SendPrice.Name = "button_SendPrice";
            this.button_SendPrice.Size = new System.Drawing.Size(75, 23);
            this.button_SendPrice.TabIndex = 11;
            this.button_SendPrice.Text = "发送价格";
            this.button_SendPrice.UseVisualStyleBackColor = true;
            this.button_SendPrice.Click += new System.EventHandler(this.Button_SendPrice_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "买入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "卖空";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox_BuyHandle
            // 
            this.textBox_BuyHandle.Location = new System.Drawing.Point(160, 103);
            this.textBox_BuyHandle.Name = "textBox_BuyHandle";
            this.textBox_BuyHandle.Size = new System.Drawing.Size(100, 21);
            this.textBox_BuyHandle.TabIndex = 14;
            // 
            // textBox_SellHandle
            // 
            this.textBox_SellHandle.Location = new System.Drawing.Point(160, 132);
            this.textBox_SellHandle.Name = "textBox_SellHandle";
            this.textBox_SellHandle.Size = new System.Drawing.Size(100, 21);
            this.textBox_SellHandle.TabIndex = 15;
            // 
            // button_SendBuy
            // 
            this.button_SendBuy.Location = new System.Drawing.Point(267, 106);
            this.button_SendBuy.Name = "button_SendBuy";
            this.button_SendBuy.Size = new System.Drawing.Size(75, 23);
            this.button_SendBuy.TabIndex = 16;
            this.button_SendBuy.Text = "发送-买";
            this.button_SendBuy.UseVisualStyleBackColor = true;
            this.button_SendBuy.Click += new System.EventHandler(this.Button_SendBuy_Click);
            // 
            // button_SendSell
            // 
            this.button_SendSell.Location = new System.Drawing.Point(266, 135);
            this.button_SendSell.Name = "button_SendSell";
            this.button_SendSell.Size = new System.Drawing.Size(75, 23);
            this.button_SendSell.TabIndex = 17;
            this.button_SendSell.Text = "发送-卖";
            this.button_SendSell.UseVisualStyleBackColor = true;
            this.button_SendSell.Click += new System.EventHandler(this.Button_SendSell_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 163);
            this.Controls.Add(this.button_SendSell);
            this.Controls.Add(this.button_SendBuy);
            this.Controls.Add(this.textBox_SellHandle);
            this.Controls.Add(this.textBox_BuyHandle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_SendPrice);
            this.Controls.Add(this.button_SendShares);
            this.Controls.Add(this.button_SendIns);
            this.Controls.Add(this.textBox_PriceHandle);
            this.Controls.Add(this.textBox_SharesHandle);
            this.Controls.Add(this.textBox_InsHandle);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_Shares);
            this.Controls.Add(this.textBox_ins);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "外盘Hooker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ins;
        private System.Windows.Forms.TextBox textBox_Shares;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_InsHandle;
        private System.Windows.Forms.TextBox textBox_SharesHandle;
        private System.Windows.Forms.TextBox textBox_PriceHandle;
        private System.Windows.Forms.Button button_SendIns;
        private System.Windows.Forms.Button button_SendShares;
        private System.Windows.Forms.Button button_SendPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_BuyHandle;
        private System.Windows.Forms.TextBox textBox_SellHandle;
        private System.Windows.Forms.Button button_SendBuy;
        private System.Windows.Forms.Button button_SendSell;
        private System.Windows.Forms.Timer timer1;
    }
}

